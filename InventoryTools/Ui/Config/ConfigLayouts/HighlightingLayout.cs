using InventoryTools.Logic.Settings;
using InventoryTools.Ui.Config.Layouts;

namespace InventoryTools.Ui.Config.ConfigLayouts;

public class HighlightingLayout : ConfigLayout
{
    public override PageLayout Build()
    {
        return Page("highlighting", "高亮显示",
            Paragraph("清单与库存中的物品匹配时，可为对应格子和背包标签着色。以下为默认设置，大多数选项也可在单个清单中单独调整。"),
            Section("当前清单",
                Paragraph("通常可通过各窗口中的“高亮”按钮或聊天指令控制高亮，也可以在此启用或关闭。"),
                Setting<WindowFilterSetting>(),
                Setting<BackgroundFilterSetting>(),
                Setting<SaveBackgroundFilterSetting>("在不同游戏会话间记住此设置")
            ),
            Section("高亮时机",
                Setting<HighlightWhenSetting>(),
                Setting<InvertHighlightingSetting>(),
                Setting<InvertTabHighlightingSetting>()),
            Section("颜色",
                Setting<HighlightColourSetting>("匹配物品颜色"),
                Setting<TabHighlightColourSetting>("匹配标签颜色")),
            Section("目标位置",
                Paragraph("整理清单会标记物品的目标背包。可以同时高亮来源与目标位置，方便查看转移前后的状态。"),
                Setting<HighlightDestinationSetting>(),
                EnabledBy<HighlightDestinationSetting>(
                    Setting<HighlightDestinationEmptySetting>(),
                    Setting<InvertDestinationHighlightingSetting>(),
                    Setting<HighlightDestinationColourSetting>("目标位置颜色"))),
            Section("雇员列表",
                Paragraph("雇员持有清单关注的物品时，可在召唤铃列表中标记对应雇员，省去逐个查看。"),
                Setting<ColourRetainerListSetting>("为雇员名称着色"),
                EnabledBy<ColourRetainerListSetting>(
                    Setting<RetainerListColourSetting>("名称颜色")),
                Setting<ShowItemNumberRetainerListSetting>("显示物品数量")),
            Section("商店高亮",
                Paragraph("打开商店时，可高亮与清单匹配的商品，并在游戏场景中标记出售这些商品的 NPC。"),
                Setting<ShopHighlightingDisableItemsSetting>("淡化不匹配的商品"),
                Setting<ShopHighlightingNpcSetting>("在场景中高亮商人 NPC"),
                EnabledBy<ShopHighlightingNpcSetting>(
                    Setting<ShopHighlightingNpcColorSetting>("高亮颜色"),
                    Setting<ShopHighlightingNpcNameplateIconSetting>("在名字牌上显示图标")))
        );
    }
}
