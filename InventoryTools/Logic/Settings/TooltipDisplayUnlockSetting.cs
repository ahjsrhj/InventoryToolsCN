using InventoryTools.Logic.Settings.Abstract;
using InventoryTools.Services;
using Microsoft.Extensions.Logging;

namespace InventoryTools.Logic.Settings;

public class TooltipDisplayUnlockSetting : BooleanSetting
{
    public TooltipDisplayUnlockSetting(ILogger<TooltipDisplayUnlockSetting> logger, ImGuiService imGuiService) : base(logger, imGuiService)
    {
    }

    public override bool DefaultValue { get; set; } = false;
    public override bool CurrentValue(InventoryToolsConfiguration configuration)
    {
        return configuration.TooltipDisplayUnlock;
    }

    public override void UpdateFilterConfiguration(InventoryToolsConfiguration configuration, bool newValue)
    {
        configuration.TooltipDisplayUnlock = newValue;
    }

    public override string Key { get; set; } = "TooltipDisplayUnlockSetting";
    public override string Name { get; set; } = "显示物品解锁状态";
    public override string HelpText { get; set; } = "若物品可解锁或获取，则显示角色是否已解锁或获得。可在配置窗口中指定角色。";
    public override string Version { get; } = "1.11.0.4";
}
