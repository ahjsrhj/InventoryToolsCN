using InventoryTools.Ui.Config.Layouts;

namespace InventoryTools.Ui.Config.WizardLayouts;

public class IntroDefaultsLayout : ContentLayout
{
    public override PageLayout Build()
    {
        return Page("intro/defaults", "默认设置",
            Paragraph("插件已默认启用一组常用功能。"),
            Paragraph("接下来的页面会介绍常用功能的设置。"),
            Paragraph("将鼠标悬停在“？”图标上，可查看各项设置的说明。")
        );
    }
}
