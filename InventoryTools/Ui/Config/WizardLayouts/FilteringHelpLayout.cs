using InventoryTools.Ui.Config.Layouts;

namespace InventoryTools.Ui.Config.WizardLayouts;

public class FilteringHelpLayout : ContentLayout
{
    public override PageLayout Build()
    {
        return Page("help/filtering", "筛选",
            Section("高级搜索语法",
                Paragraph("创建清单或搜索清单结果时，可以使用运算符缩小范围。可用运算符取决于当前搜索的内容。"),
                Bullet("!：排除包含输入内容的结果，适用于文本和数字。"),
                Bullet("<：筛选小于输入值的结果，适用于数字。"),
                Bullet(">：筛选大于输入值的结果，适用于数字。"),
                Bullet(">=：筛选大于或等于输入值的结果，适用于数字。"),
                Bullet("<=：筛选小于或等于输入值的结果，适用于数字。"),
                Bullet("=：筛选与输入内容完全相同的结果，适用于文本和数字。"),
                Bullet("&& 和 ||：分别表示“与”和“或”，可连接多个条件。"))
        );
    }
}
