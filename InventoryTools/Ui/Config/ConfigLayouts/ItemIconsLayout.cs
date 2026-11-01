using InventoryTools.Logic.Settings;
using InventoryTools.Ui.Config.Layouts;

namespace InventoryTools.Ui.Config.ConfigLayouts;

public class ItemIconsLayout : ConfigLayout
{
    public override PageLayout Build()
    {
        return Page("item-icons", "物品图标",
            Paragraph("当物品有多种相似的获取或用途途径时，可将对应图标合并显示。下方可分别调整各类来源和用途的默认分组方式。"),
            Section("获取途径",
                Scrollable("sourceIconGrouping", 320,
                    Setting<SourceIconGroupingSetting>())),
            Section("用途",
                Scrollable("useIconGrouping", 200,
                    Setting<UseIconGroupingSetting>()))
        );
    }
}
