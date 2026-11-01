using InventoryTools.Logic.Settings.Abstract;
using InventoryTools.Services;
using Microsoft.Extensions.Logging;

namespace InventoryTools.Logic.Settings
{
    public class AutoSaveSetting : BooleanSetting
    {
        private readonly PluginLogic _pluginLogic;

        public AutoSaveSetting(ILogger<AutoSaveSetting> logger, ImGuiService imGuiService, PluginLogic pluginLogic) : base(logger, imGuiService)
        {
            _pluginLogic = pluginLogic;
        }
        public override bool DefaultValue { get; set; } = true;
        public override bool CurrentValue(InventoryToolsConfiguration configuration)
        {
            return configuration.AutoSave;
        }

        public override void UpdateFilterConfiguration(InventoryToolsConfiguration configuration, bool newValue)
        {
            configuration.AutoSave = newValue;
            _pluginLogic.ClearAutoSave();
        }

        public override string Key { get; set; } = "AutoSave";
        public override string Name { get; set; } = "自动保存库存和配置？";

        public override string WizardName { get; } = "自动保存库存？";

        public override string HelpText { get; set; } =
            "是否按指定间隔自动保存库存与配置？插件会在游戏关闭或配置变更时保存，但崩溃时可能来不及保存，启用此项可降低数据丢失风险。";
        
        public override string Version => "1.7.0.0";
    }
}
