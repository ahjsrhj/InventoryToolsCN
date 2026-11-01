using InventoryTools.Logic.Settings;
using InventoryTools.Ui.Config.Layouts;

namespace InventoryTools.Ui.Config.ConfigLayouts;

public class MarketBoardLayout : ConfigLayout
{
    public override PageLayout Build()
    {
        return Page("marketboard", "市场板",
            Paragraph("市场价格来自 Universalis，而非游戏本身，因此需要联网获取并缓存。"),
            Section("查询大区",
                Paragraph("下列大区会合并为查询范围。额外大区会添加到你的母大区和当前大区中，而不会替换它们。"),
                Setting<MarketBoardUseHomeWorldSetting>("母大区"),
                Setting<MarketBoardUseActiveWorldSetting>("当前大区"),
                Setting<MarketBoardExtraWorldsSetting>("其他大区")),
            Section("价格获取",
            Paragraph("是否自动下载价格数据？若未启用自动下载，请点击“刷新市场价格”按钮获取物品价格。"),
                Setting<AutomaticallyDownloadPricesSetting>("自动下载价格"),
                Setting<MarketRefreshTimeHoursSetting>("价格缓存时长（小时）"),
                Setting<MarketBoardSaleCountLimitSetting>("成交记录范围（天）"))
        );
    }
}
