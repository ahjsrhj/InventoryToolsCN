using InventoryTools.Ui.Config.Layouts;

namespace InventoryTools.Ui.Config.WizardLayouts;

public class IntroCraftingLayout : ContentLayout
{
    public override PageLayout Build()
    {
        return Page("intro/crafting", "制作",
            Paragraph("制作清单会将目标配方拆解为所有中间产物与原材料，并与现有库存进行核对。"),
            Section("清单内容",
                Bullet("完整的材料树，包含所有中间配方。"),
                Bullet("查看已有材料，以及持有它们的角色或雇员。"),
                Bullet("查找缺少材料的购买或采集途径。"),
                Bullet("获取材料后自动更新制作进度。")),
            Section("打开看看",
                OpenWindow<CraftsWindow>("打开制作窗口"))
        );
    }
}
