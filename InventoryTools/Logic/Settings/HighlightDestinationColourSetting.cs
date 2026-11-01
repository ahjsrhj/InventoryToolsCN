using System.Numerics;
using InventoryTools.Logic.Settings.Abstract;
using InventoryTools.Services;
using Microsoft.Extensions.Logging;

namespace InventoryTools.Logic.Settings
{
    public class HighlightDestinationColourSetting : ColorSetting
    {
        public override Vector4 DefaultValue { get; set; } = new Vector4(0.321f, 0.239f, 0.03f, 1f);
        public override Vector4 CurrentValue(InventoryToolsConfiguration configuration)
        {
            return configuration.DestinationHighlightColor;
        }

        public override void UpdateFilterConfiguration(InventoryToolsConfiguration configuration, Vector4 newValue)
        {
            configuration.DestinationHighlightColor = newValue;
        }

        public override string Key { get; set; } = "DestinationHighlightColour";
        public override string Name { get; set; } = "目标高亮颜色";
        public override string HelpText { get; set; } = "设置目标位置中符合来源筛选的物品颜色（需启用目标重复物品高亮）。";
        public override string Version => "1.7.0.0";

        public HighlightDestinationColourSetting(ILogger<HighlightDestinationColourSetting> logger, ImGuiService imGuiService) : base(logger, imGuiService)
        {
        }
    }
}
