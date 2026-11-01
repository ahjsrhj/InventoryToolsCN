using System.Collections.Generic;
using InventoryTools.Logic.Filters;
using InventoryTools.Logic.Settings.Abstract;
using InventoryTools.Services;
using Microsoft.Extensions.Logging;

namespace InventoryTools.Logic.Settings
{
    public class HighlightWhenSetting : ChoiceSetting<HighlightWhen>
    {
        private readonly Dictionary<HighlightWhen, string> _staticChoices = new()
        {
            {HighlightWhen.Always, "Always"}, {HighlightWhen.WhenSearching, "When Searching"}
        };

        public override HighlightWhen DefaultValue { get; set; } = HighlightWhen.WhenSearching;

        public override HighlightWhen CurrentValue(InventoryToolsConfiguration configuration)
        {
            return configuration.HighlightWhenEnum;
        }

        public override void UpdateFilterConfiguration(InventoryToolsConfiguration configuration, HighlightWhen newValue)
        {
            configuration.HighlightWhenEnum = newValue;
        }

        public override string Key { get; set; } = "HighlightWhen";
        public override string Name { get; set; } = "高亮时机";
        public override string HelpText { get; set; } = "启用清单高亮后，选择始终高亮还是仅在搜索列时高亮。";
        
        public override Dictionary<HighlightWhen, string> Choices => _staticChoices;
        public override string Version => "1.7.0.0";

        public HighlightWhenSetting(ILogger<HighlightWhenSetting> logger, ImGuiService imGuiService) : base(logger, imGuiService)
        {
        }
    }
}
