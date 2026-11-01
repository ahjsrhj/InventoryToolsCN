using InventoryTools.Ui.Config.Layouts;

namespace InventoryTools.Ui.Config.WizardLayouts;

public class IntroInventoriesLayout : ContentLayout
{
    public override PageLayout Build()
    {
        return Page("intro/inventories", "你的物品",
            Paragraph("游戏至少显示过一次的库存，插件才能读取。这是游戏发送数据方式的限制，无法通过设置绕过。"),
            Section("如果缺少库存",
                Paragraph("在游戏中打开一次，之后插件便会记住。常见的库存包括："),
                Bullet("雇员：与召唤铃互动，并打开每位雇员的库存。"),
                Bullet("部队储物柜：打开需要查看的各个分页。"),
                Bullet("投影台和军械库。"),
                Bullet("陆行鸟鞍囊。")),
            Section("完成后",
                Paragraph("插件会保存一份独立记录。之后无论身在何处，都能搜索雇员库存，无需返回召唤铃。"))
        );
    }
}
