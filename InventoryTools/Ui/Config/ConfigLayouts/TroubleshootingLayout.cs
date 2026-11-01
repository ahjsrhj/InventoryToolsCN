using InventoryTools.Logic.Settings;
using InventoryTools.Ui.Config.Layouts;

namespace InventoryTools.Ui.Config.ConfigLayouts;

public class TroubleshootingLayout : ConfigLayout
{
    public override PageLayout Build()
    {
        return Page("troubleshooting", "故障排查",
            Paragraph("仅在遇到特定问题时才需要调整这些时间。默认值适用于大多数情况。"),
            Section("获取追踪器",
                Paragraph("获取追踪器会监视制作、采集和战利品获取情况，并据此更新制作清单的完成状态。数值单位均为秒；增大数值可提升网络较慢或设备繁忙时的稳定性，但响应会稍慢。"),
                Setting<AcquisitionTrackerLoginDelaySetting>("登录后等待多久再开始扫描"),
                Setting<AcquisitionTrackerPersistStateSetting>("停止操作后继续追踪多久"))
        );
    }
}
