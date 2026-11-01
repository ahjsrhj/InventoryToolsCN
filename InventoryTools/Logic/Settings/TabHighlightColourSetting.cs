using System.Numerics;
using InventoryTools.Logic.Settings.Abstract;
using InventoryTools.Services;
using Microsoft.Extensions.Logging;

namespace InventoryTools.Logic.Settings
{
    public class TabHighlightColourSetting : ColorSetting
    {
        public override Vector4 DefaultValue { get; set; } = new(0.007f, 0.008f,
            0.007f, 0.2f);

        public override Vector4 CurrentValue(InventoryToolsConfiguration configuration)
        {
            return configuration.TabHighlightColor;
        }

        public override void UpdateFilterConfiguration(InventoryToolsConfiguration configuration, Vector4 newValue)
        {
            configuration.TabHighlightColor = newValue;
        }

        public override string Key { get; set; } = "TabHighlightColour";
        public override string Name { get; set; } = "标签高亮颜色";
        public override string HelpText { get; set; } = "设置包含符合筛选条件物品的标签颜色。";
        public override string Version => "1.7.0.0";

        public TabHighlightColourSetting(ILogger<TabHighlightColourSetting> logger, ImGuiService imGuiService) : base(logger, imGuiService)
        {
        }
    }
}
