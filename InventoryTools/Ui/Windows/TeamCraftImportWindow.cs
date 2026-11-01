using System.Collections.Generic;
using System.Numerics;
using CriticalCommonLib.Services.Mediator;
using DalaMock.Host.Mediator;
using Dalamud.Bindings.ImGui;
using InventoryTools.Lists;
using InventoryTools.Logic;
using InventoryTools.Mediator;
using InventoryTools.Services;
using Microsoft.Extensions.Logging;

namespace InventoryTools.Ui;

public class TeamCraftImportWindow : GenericWindow
{
    private readonly ListImportExportService _importExportService;
    private string _importListItems = "";
    private bool _hasError;
    private List<(uint, uint)>? _parseResult;

    public TeamCraftImportWindow(ILogger<TeamCraftImportWindow> logger, MediatorService mediator, ImGuiService imGuiService, InventoryToolsConfiguration configuration, ListImportExportService importExportService, string name = "Teamcraft Import") : base(logger, mediator, imGuiService, configuration, name)
    {
        _importExportService = importExportService;
        Flags = ImGuiWindowFlags.NoCollapse;
    }

    public List<(uint, uint)>? ParseResult => _parseResult;


    public override string GenericKey { get; } = "tcimport";
    public override string GenericName { get; } = "Teamcraft Import";
    public override bool DestroyOnClose { get; }
    public override bool SaveState { get; } = false;
    public override Vector2? DefaultSize { get; } = new Vector2(300, 300);
    public override Vector2? MaxSize { get; }
    public override Vector2? MinSize { get; }
    public override void Initialize()
    {
    }

    public override void DrawWindow()
    {
        ImGui.Text("导入到制作清单：");
        ImGui.SameLine();
        ImGuiService.HelpMarker("Guide to importing lists.\r\n\r\n" +
                                "第 1 步：在 Teamcraft 中打开包含目标制作物品的清单。\r\n\r\n" +
                                "第 2 步：找到“物品”中的“复制为文本”按钮，只需复制成品。\r\n\r\n" +
                                "第 3 步：将文本粘贴到此窗口下方的文本框。\r\n\r\n" +
                                "第 4 步：点击“导入”。");
        ImGui.Text("在此粘贴文本");
        ImGui.InputTextMultiline("###FinalItems", ref _importListItems, 10000000, new Vector2(ImGui.GetContentRegionAvail().X, 100));


        if (ImGui.Button("导入"))
        {
            var importedList = _importExportService.FromTCString(_importListItems ?? "");
            if (importedList is not null)
            {
                Close();
                MediatorService.Publish(new TeamCraftDataImported(importedList));
            }

        }
        ImGui.SameLine();
        if (ImGui.Button("取消"))
        {
            Close();
        }
    }

    public override void Invalidate()
    {
        
    }

    public override FilterConfiguration? SelectedConfiguration { get; }
}
