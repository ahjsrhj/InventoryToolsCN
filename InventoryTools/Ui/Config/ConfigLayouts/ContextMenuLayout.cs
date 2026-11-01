using InventoryTools.Logic.Settings;
using InventoryTools.Ui.Config.Layouts;

namespace InventoryTools.Ui.Config.ConfigLayouts;

public class ContextMenuLayout : ConfigLayout
{
    public override PageLayout Build()
    {
        return Page("context-menu", "右键菜单",
            Paragraph("在游戏的右键菜单中添加 Allagan Tools 功能。每项都会占用一行，可按需单独启用或关闭。"),
            Section("清单",
                Setting<ContextMenuAddToCraftListSetting>("添加到制作清单"),
                Setting<ContextMenuAddToActiveCraftListSetting>("添加到当前制作清单"),
                Setting<ContextMenuAddToCuratedListSetting>("添加到精选清单"),
                Setting<ContextMenuAddToFavouritesSetting>("添加或移出收藏")),
            Section("查看详情",
                Paragraph("打开右键目标对应的 Allagan Tools 详情窗口。"),
                Setting<ContextMenuMoreInformationSetting>("物品"),
                Setting<ContextMenuMoreInformationNpcsSetting>("NPC"),
                Setting<ContextMenuMoreInformationMonstersSetting>("怪物")),
            Section("打开游戏界面",
                Paragraph("快速打开游戏中的各类日志。"),
                Setting<ContextMenuOpenCraftingLogSetting>("制作笔记"),
                Setting<ContextMenuOpenGatheringLogSetting>("采集笔记"),
                Setting<ContextMenuOpenFishingLogSetting>("钓鱼笔记")),
            Section("搜索",
                Paragraph("搜索范围同样适用于从 Allagan Tools 自身菜单发起的搜索。"),
                Paragraph("搜索范围比游戏自带功能更广，会检索插件已记录的所有角色。"),
                Setting<ContextMenuItemSearchSetting>("搜索此物品"),
                Paragraph("如需限制搜索位置，请在下方设置搜索范围。"),
                Setting<ContextMenuItemSearchScopeSetting>("搜索这些位置")),
            Section("其他",
                Setting<ContextMenuCopyNameSetting>("复制物品名称"))
        );
    }
}
