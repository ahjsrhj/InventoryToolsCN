using InventoryTools.Ui.Config.Layouts;

namespace InventoryTools.Ui.Config.WizardLayouts;

public class AboutHelpLayout : ContentLayout
{
    public override PageLayout Build()
    {
        return Page("help/about", "关于",
            Paragraph("本插件由作者利用空闲时间开发维护，源于热爱。未来也会继续积极更新。"),
            Paragraph("如遇到问题，请通过插件安装器中的反馈按钮提交。"),
            Section("相关链接",
                Link("打开 Wiki", "https://github.com/Critical-Impact/InventoryTools/wiki/1.-Overview"),
                Link("报告问题", "https://github.com/Critical-Impact/InventoryTools/issues"))
        );
    }
}
