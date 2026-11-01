using InventoryTools.Logic.Settings.Abstract;
using InventoryTools.Services;
using Microsoft.Extensions.Logging;

namespace InventoryTools.Logic.Settings
{
    public class ColourRetainerListSetting : BooleanSetting
    {
        public override bool DefaultValue { get; set; } = true;
        public override bool CurrentValue(InventoryToolsConfiguration configuration)
        {
            return configuration.ColorRetainerList;
        }

        public override void UpdateFilterConfiguration(InventoryToolsConfiguration configuration, bool newValue)
        {
            configuration.ColorRetainerList = newValue;
        }

        public override string Key { get; set; } = "ColourRetainerList";
        public override string Name { get; set; } = "在雇员列表中标记颜色？";
        public override string HelpText { get; set; } = "若雇员持有相关物品或有待整理物品，是否在召唤铃列表中为其名称着色？";
        public override string Version => "1.7.0.0";

        public ColourRetainerListSetting(ILogger<ColourRetainerListSetting> logger, ImGuiService imGuiService) : base(logger, imGuiService)
        {
        }
    }
}
