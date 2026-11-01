using InventoryTools.EquipmentSuggest;
using InventoryTools.Ui.Config.Layouts;

namespace InventoryTools.Ui.Config.ConfigLayouts;

public class EquipmentRecommendationLayout : ConfigLayout
{
    public override PageLayout Build()
    {
        return Page("equipment-recommendation", "装备推荐",
            Paragraph("对比当前装备与可用装备，并推荐更合适的搭配。以下为打开推荐界面时使用的默认选项。"),
            Section("默认选项",
                Setting<EquipmentSuggestModeSetting>("推荐模式"),
                Setting<EquipmentSuggestViewModeSetting>("布局"))
        );
    }
}
