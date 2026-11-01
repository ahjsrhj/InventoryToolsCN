using InventoryTools.Ui.Config.Layouts;

namespace InventoryTools.Ui.Config.WizardLayouts;

public class ListBasicsHelpLayout : ContentLayout
{
    public override PageLayout Build()
    {
        return Page("help/list-basics", "清单基础",
            Paragraph("清单是插件查看目标物品或整理库存的主要方式。目前可以创建三种清单。"),
            Section("搜索清单",
                Paragraph("搜索所有库存中的指定物品。只想寻找物品、不需要规划整理方式时，请使用此清单。"),
                Paragraph("例如："),
                Bullet("查找制作所需的材料。"),
                Bullet("找回放置在某处的房屋家具。"),
                Bullet("查看刚获得物品的价值。"),
                Bullet("确认某件物品是否已放入投影台或军械库。"),
                Bullet("无需前往召唤铃，即可查看雇员装备。"),
                Bullet("检查持有物品是否可以存入军械库。")),
            Section("整理清单",
                Paragraph("在搜索清单的基础上，还可指定物品的目标位置，并规划如何将物品存入所选库存。"),
                Paragraph("例如："),
                Bullet("制作后收纳材料，避免重复堆放。"),
                Bullet("将高于指定物品等级的物品暂存到陆行鸟鞍囊。"),
                Bullet("找出仅适合存入部队储物柜的物品并进行整理。")),
            Section("游戏物品清单",
                Paragraph("搜索游戏物品目录中的全部物品。"),
                Paragraph("例如："),
                Bullet("搜索幻化装备。"),
                Bullet("查看尚未获得的坐骑和宠物。"),
                Bullet("追踪游戏内各类物品的价格。"))
        );
    }
}
