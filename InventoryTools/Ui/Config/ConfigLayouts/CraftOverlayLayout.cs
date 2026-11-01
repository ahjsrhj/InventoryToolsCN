using InventoryTools.Logic.Settings;
using InventoryTools.Ui.Config.Layouts;

namespace InventoryTools.Ui.Config.ConfigLayouts;

public class CraftOverlayLayout : ConfigLayout
{
    public override PageLayout Build()
    {
        return Page("craft-overlay", "制作浮窗",
            Paragraph("在游戏中显示当前制作清单的精简面板，无需打开窗口即可查看尚缺的物品。"),
            Section("显示",
                Setting<CraftOverlayMaxExpandedItemsSetting>("展开时显示的物品数"),
                Setting<CraftOverlayHideSetting>("在副本和过场动画中隐藏")),
            Section("行为",
                Setting<CraftOverlayRememberStateSetting>("重新加载后保持打开"))
        );
    }
}
