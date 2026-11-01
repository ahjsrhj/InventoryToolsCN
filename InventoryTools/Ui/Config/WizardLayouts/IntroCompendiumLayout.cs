using InventoryTools.Compendium.Windows;
using InventoryTools.Ui.Config.Layouts;

namespace InventoryTools.Ui.Config.WizardLayouts;

public class IntroCompendiumLayout : ContentLayout
{
    public override PageLayout Build()
    {
        return Page("intro/compendium", "图鉴",
            Paragraph("图鉴是可浏览的游戏资料库，使用与插件其他功能相同的数据。想了解某项内容、它的来源或掉落途径，都可以在这里查询。"),
            Section("收录内容",
                Bullet("物品、任务和成就。"),
                Bullet("坐骑、宠物和幻化套装。"),
                Bullet("副本、理符、蛮族和友好部族、收藏品交纳。"),
                Bullet("古代武器与工具、秘传书、传承录和魂晶。"),
                Bullet("NPC、区域，以及飞艇和潜水艇航线。"),
                Bullet("职业、套装、陆行鸟物品等。")),
            Section("打开看看",
                Paragraph("各条目之间会相互关联，你可以从物品一路查看掉落该物品的副本，以及出售其他相关物品的 NPC。"),
                OpenWindow<CompendiumTypesWindow>("打开图鉴"),
                Paragraph("也可以通过物品和制作窗口中的“图鉴”菜单，或使用 /compendium 指令打开。"))
        );
    }
}
