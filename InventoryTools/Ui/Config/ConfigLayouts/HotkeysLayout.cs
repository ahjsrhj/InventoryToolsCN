using InventoryTools.Logic.Settings;
using InventoryTools.Ui.Config.Layouts;

namespace InventoryTools.Ui.Config.ConfigLayouts;

public class HotkeysLayout : ConfigLayout
{
    public override PageLayout Build()
    {
        return Page("hotkeys", "快捷键",
            Section("切换窗口",
                Paragraph("无论鼠标当前是否指向物品，均可使用这些快捷键。"),
                Setting<HotKeyListsWindowSetting>("清单"),
                Setting<HotkeyCraftWindowSetting>("制作"),
                Setting<HotkeyConfigWindowSetting>("设置"),
                Setting<HotkeyMobWindowSetting>("怪物"),
                Setting<HotkeyDutiesWindowSetting>("副本"),
                Setting<HotkeyAirshipWindowSetting>("飞艇"),
                Setting<HotkeySubmarinesWindowSetting>("潜水艇"),
                Setting<HotkeyRetainerTasksWindowSetting>("雇员探险")),
            Section("指向物品时",
                Paragraph("这些快捷键作用于鼠标指向的物品，仅在指向物品时生效。"),
                Setting<HotkeyMoreInfoSetting>("查看详情"),
                Setting<HotkeyOpenItemLogSetting>("打开对应日志"),
                Setting<HotkeyOpenCraftingLogSetting>("制作笔记"),
                Setting<HotkeyOpenGatheringLogSetting>("采集笔记"),
                Setting<HotkeyOpenFishingLogSetting>("钓鱼笔记"))
        );
    }
}
