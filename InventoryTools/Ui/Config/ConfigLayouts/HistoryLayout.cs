using InventoryTools.Logic.Settings;
using InventoryTools.Ui.Config.Layouts;

namespace InventoryTools.Ui.Config.ConfigLayouts;

public class HistoryLayout : ConfigLayout
{
    public override PageLayout Build()
    {
        return Page("history", "库存历史",
            Paragraph("记录物品在各个库存之间的存入、取出与转移，方便回顾库存变化。历史清单会读取这些记录。"),
            Paragraph("关闭此功能后，历史类型的清单将无法使用。"),
            Section("记录设置",
                Setting<HistoryEnabledSetting>("记录库存变动"),
                EnabledBy<HistoryEnabledSetting>(
                    Setting<HistoryTrackEventsSetting>("要记录的事件")))
        );
    }
}
