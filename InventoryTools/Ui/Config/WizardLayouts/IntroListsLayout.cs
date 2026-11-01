using InventoryTools.Ui.Config.Layouts;

namespace InventoryTools.Ui.Config.WizardLayouts;

public class IntroListsLayout : ContentLayout
{
    public override PageLayout Build()
    {
        return Page("intro/lists", "清单",
            Paragraph("插件的大多数功能都围绕清单展开。清单会保存物品搜索条件，可用于在游戏中高亮结果、整理物品或追踪库存变化。"),
            Section("三种清单",
                Bullet("搜索清单：查找各个库存中的物品。"),
                Bullet("整理清单：查找物品并规划转移位置。"),
                Bullet("游戏物品清单：搜索游戏中的所有物品，包括尚未持有的物品。")),
            Section("打开看看",
                Paragraph("物品窗口用于管理清单，也提供可直接添加的示例清单。"),
                OpenWindow<FiltersWindow>("打开物品窗口"))
        );
    }
}
