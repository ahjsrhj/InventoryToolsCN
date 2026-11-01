using InventoryTools.Ui.Config.Layouts;

namespace InventoryTools.Ui.Config.WizardLayouts;

public class GeneralHelpLayout : ContentLayout
{
    public override PageLayout Build()
    {
        return Page("help/general", "常规",
            Paragraph("Allagan Tools 是一款多功能插件，主要用于追踪和查看库存、规划制作，以及查询物品信息。"),
            Paragraph("如果你使用过 Teamcraft 或 Garland Tools，会发现本插件也借鉴了其中的一些设计。"),
            Section("库存追踪",
                Paragraph("插件会尽力记录你的库存。有些库存只有在首次打开后才能缓存。如果看不到雇员、部队储物柜或投影台等内容，请先在游戏中打开对应库存。"),
                Paragraph("插件记录物品后，你可以创建清单来搜索特定物品、整理物品或使用其他功能。")),
            Section("制作规划",
                Paragraph("制作窗口可创建目标物品清单，并将每项配方拆解为所需材料。你可以查看缺少什么、物品存放在哪里，以及如何采集或购买缺少的材料。"),
                Paragraph("如果使用过 Teamcraft，上手会很轻松。")),
            Section("物品信息",
                Paragraph("插件内置了较完整的物品资料库。点击插件中任意物品图标，即可打开物品详情窗口。")),
            Section("高亮显示",
                Paragraph("使用物品清单或制作清单时，可以启用高亮，在游戏中快速定位对应物品。插件窗口处于活动状态时，勾选“高亮”即可启用。若要通过宏控制，请参阅帮助中的指令章节，并使用“背景”高亮选项。")),
            Section("更多信息",
                Paragraph("本指南仅介绍基础功能，更多信息请参阅 Wiki。"),
                Link("打开 Wiki", "https://github.com/Critical-Impact/InventoryTools/wiki/1.-Overview"))
        );
    }
}
