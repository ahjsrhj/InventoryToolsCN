using System.Linq;
using System.Numerics;
using CriticalCommonLib.Services;
using CriticalCommonLib.Services.Mediator;
using DalaMock.Host.Mediator;
using DalaMock.Shared.Interfaces;
using Dalamud.Bindings.ImGui;
using InventoryTools.Logic;
using InventoryTools.Services;
using Microsoft.Extensions.Logging;

namespace InventoryTools.Ui
{
    public class SupportDumpWindow : GenericWindow
    {
        private readonly SupportDumpService _supportDumpService;
        private readonly IFileDialogManager _fileDialogManager;
        private readonly IChatUtilities _chatUtilities;

        public SupportDumpWindow(ILogger<SupportDumpWindow> logger, MediatorService mediator, ImGuiService imGuiService, InventoryToolsConfiguration configuration, SupportDumpService supportDumpService, IFileDialogManager fileDialogManager, IChatUtilities chatUtilities, string name = "Generate Support Dump") : base(logger, mediator, imGuiService, configuration, name)
        {
            _supportDumpService = supportDumpService;
            _fileDialogManager = fileDialogManager;
            _chatUtilities = chatUtilities;
        }

        public override void Initialize()
        {
            WindowName = "生成支持诊断信息";
            Key = "supportdump";
        }

        public override bool SaveState => false;
        public override Vector2? DefaultSize { get; } = new Vector2(500, 200);
        public override Vector2? MaxSize { get; } = new Vector2(800, 400);
        public override Vector2? MinSize { get; } = new Vector2(300, 150);
        public override string GenericKey { get; } = "supportdump";
        public override string GenericName { get; } = "Generate Support Dump";
        public override bool DestroyOnClose => true;

        public override void DrawWindow()
        {
            ImGui.PushTextWrapPos();
            ImGui.TextWrapped(
                "仅在收到明确指示时使用此功能。它会生成包含库存、Allagan Tools 配置和日志的 ZIP 文件。若要协助排查问题，请先在“文件”菜单中启用详细日志，重现问题后再生成诊断文件。是否继续？");
            ImGui.PopTextWrapPos();
            ImGui.NewLine();

            if (ImGui.Button("继续"))
            {
                _fileDialogManager.SaveFileDialog("保存支持诊断文件", "*.zip", "support_dump.zip", ".zip",
                    (success, path) =>
                    {
                        if (success)
                        {
                            GenerateDump(path);
                        }
                    }, null, true);
            }

            ImGui.SameLine();

            if (ImGui.Button("取消"))
            {
                this.IsOpen = false;
            }
        }

        private void GenerateDump(string path)
        {
            var result = _supportDumpService.GenerateDump(path);
            if (result.Success)
            {
                var included = result.IncludedFiles.Any() ? string.Join(", ", result.IncludedFiles) : "无文件";
                _chatUtilities.Print($"支持诊断文件已保存到 {result.ZipPath}（包含：{included}）。");
                if (result.MissingFiles.Any())
                {
                    _chatUtilities.PrintError($"以下文件无法加入支持诊断文件：{string.Join(", ", result.MissingFiles)}。");
                }
            }
            else
            {
                _chatUtilities.PrintError("生成支持诊断文件失败，请查看 Dalamud 日志了解详情。");
            }

            this.IsOpen = false;
        }

        public override FilterConfiguration? SelectedConfiguration => null;

        public override void Invalidate()
        {

        }
    }
}
