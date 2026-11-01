using InventoryTools.Ui.Config.Layouts;

namespace InventoryTools.Ui.Config.WizardLayouts;

public class IntroWelcomeLayout : ContentLayout
{
    public override PageLayout Build()
    {
        return Page("intro/welcome", "功能概览",
            Paragraph("Allagan Tools 主要提供三类功能。接下来的页面会逐一简要介绍，约需一分钟；之后也可以在帮助窗口中查看详细说明。"),
            Section("追踪库存",
                Paragraph("集中查看并搜索所有角色、雇员、部队储物柜、陆行鸟鞍囊和投影台中的物品。")),
            Section("规划制作",
                Paragraph("拆解制作所需的全部中间材料，查看已有库存，并查找其余材料的购买或采集途径。")),
            Section("查询资料",
                Paragraph("查询物品、怪物、副本、NPC、飞艇等资料，了解它们的来源与用途。"))
        );
    }
}
