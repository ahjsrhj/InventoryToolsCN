using InventoryTools.Logic.Settings.Abstract;
using InventoryTools.Services;
using Microsoft.Extensions.Logging;

namespace InventoryTools.Logic.Settings
{
    public class HighlightDestinationEmptySetting : BooleanSetting
    {
        public override bool DefaultValue { get; set; } = false;
        public override bool CurrentValue(InventoryToolsConfiguration configuration)
        {
            return configuration.HighlightDestinationEmpty;
        }

        public override void UpdateFilterConfiguration(InventoryToolsConfiguration configuration, bool newValue)
        {
            configuration.HighlightDestinationEmpty = newValue;
        }

        public override string Key { get; set; } = "HighlightEmptyDestination";
        public override string Name { get; set; } = "高亮空目标位置？";

        public override string HelpText { get; set; } =
            "高亮目标位置时，是否同时高亮空位，还是仅高亮目标位置中已有的物品？";
        
        public override string Version => "1.7.0.0";

        public HighlightDestinationEmptySetting(ILogger<HighlightDestinationEmptySetting> logger, ImGuiService imGuiService) : base(logger, imGuiService)
        {
        }
    }
}
