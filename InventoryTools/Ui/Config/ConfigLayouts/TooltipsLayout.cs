using InventoryTools.Logic.Settings;
using InventoryTools.Ui.Config.Layouts;

namespace InventoryTools.Ui.Config.ConfigLayouts;

public class TooltipsLayout : ConfigLayout
{
    public override PageLayout Build()
    {
        return PageGroup("tooltips", "提示信息",
            Page("tooltips/general", "常规",
                Paragraph("Allagan Tools 可以在游戏物品提示中添加信息。启用提示增强后，本节中的功能才会生效。"),
                Setting<ShowTooltipsSetting>("启用提示信息增强"),
                EnabledBy<ShowTooltipsSetting>(
                    Setting<ImGuiTooltipModeSetting>("在 Allagan Tools 窗口中显示"),
                    Setting<TooltipDisplayHeaderSetting>("为新增内容标注插件名称"),
                    Setting<TooltipCategoryWhitelistSetting>("仅显示这些物品分类"),
                    Setting<TooltipCategoryBlacklistSetting>("将以上列表作为排除项"))),
            Page("tooltips/appearance", "外观",
                Paragraph("设置 Allagan Tools 新增提示行的默认样式，各项功能也可单独设置颜色。"),
                Setting<TooltipColorSetting>("默认文字颜色"),
                Setting<TooltipHeaderLinesSetting>("上方空行数"),
                Setting<TooltipFooterLinesSetting>("下方空行数")),
            Page("tooltips/locations", "物品所在位置",
                Paragraph("显示你持有该物品的位置和数量。"),
                Setting<TooltipDisplayAmountOwnedSetting>("显示持有位置"),
                EnabledBy<TooltipDisplayAmountOwnedSetting>(
                    Setting<TooltipLocationScopeLimitSetting>("搜索这些位置"),
                    Setting<TooltipLocationDisplayModeSetting>("显示方式"),
                    Setting<TooltipAmountOwnedSortSetting>("排序方式"),
                    Setting<ToolTipLocationLimitSetting>("最多显示条数"),
                    Setting<TooltipCurrentCharacterSetting>("仅当前角色"),
                    Setting<TooltipAddCharacterNameSetting>("附带角色名称"),
                    Setting<TooltipAmountOwnedColorSetting>("文字颜色"))),
            Page("tooltips/retrieve", "待取回数量",
                Paragraph("显示当前清单（整理清单或制作清单）中仍需取回的物品数量。"),
                Setting<TooltipDisplayRetrieveAmountSetting>("显示待取回数量"),
                EnabledBy<TooltipDisplayRetrieveAmountSetting>(
                    Setting<TooltipAmountToRetrieveColorSetting>("文字颜色"))),
            Page("tooltips/market", "市场价格",
                Paragraph("显示该物品在 Universalis 上的价格，可分别显示以下任一价格。"),
                Setting<TooltipAverageMarketPriceSetting>("显示普通品质／高品质均价"),
                Setting<TooltipMinimumMarketPriceSetting>("显示普通品质／高品质最低价"),
                Setting<TooltipMarketPricingColorSetting>("文字颜色")),
            Page("tooltips/unlock", "物品解锁状态",
                Paragraph("显示该物品是否已解锁，以及哪些角色已解锁。"),
                Setting<TooltipDisplayUnlockSetting>("显示解锁状态"),
                EnabledBy<TooltipDisplayUnlockSetting>(
                    Setting<TooltipDisplayUnlockCharacterSetting>("检查角色"),
                    Setting<TooltipDisplayUnlockDisplayModeSetting>("显示方式"),
                    Setting<TooltipDisplayUnlockHideUnlockedSetting>("隐藏已解锁的角色"),
                    Setting<TooltipItemUnlockStatusColorSetting>("文字颜色"))),
            Page("tooltips/coffer", "宝箱内容",
                Paragraph("显示宝箱或容器中可能包含的物品。"),
                Setting<TooltipDisplayCofferLootSetting>("显示宝箱内容"),
                EnabledBy<TooltipDisplayCofferLootSetting>(
                    Setting<TooltipCofferLootScopeSetting>("搜索这些位置"),
                    Setting<TooltipCofferLootColorSetting>("文字颜色"))),
            Page("tooltips/curated", "精选清单",
                Paragraph("显示哪些精选清单已包含该物品。"),
                Setting<TooltipDisplayCuratedListsSetting>("显示精选清单"),
                EnabledBy<TooltipDisplayCuratedListsSetting>(
                    Setting<TooltipCuratedListsSetting>("仅限这些清单"),
                    Setting<TooltipCuratedListsMatchQualitySetting>("匹配物品品质"),
                    Setting<TooltipCuratedListsColorSetting>("文字颜色"))),
            Page("tooltips/glamour", "幻化套装",
                Paragraph("显示该物品是否能补齐你正在收集的套装。"),
                Setting<TooltipDisplayGlamourReadySetSetting>("显示幻化套装信息"),
                EnabledBy<TooltipDisplayGlamourReadySetSetting>(
                    Setting<TooltipGlamourReadySetScopeSetting>("搜索这些位置"),
                    Setting<TooltipGlamourReadySetDisplayModeSetting>("显示方式"),
                    Setting<TooltipGlamourReadySetColorSetting>("文字颜色"),
                    Setting<TooltipGlamourReadySetAcquiredColorSetting>("已获得物品颜色"),
                    Setting<TooltipGlamourReadySetNotAcquiredColorSetting>("未获得物品颜色"))),
            Page("tooltips/patch", "素材版本",
                Paragraph("显示制作素材首次加入游戏的版本。"),
                Setting<TooltipDisplayIngredientPatchSetting>("显示素材加入版本"),
                EnabledBy<TooltipDisplayIngredientPatchSetting>(
                    Setting<TooltipIngredientPatchTooltipColorSetting>("文字颜色"))),
            Page("tooltips/sources", "获取途径",
                Paragraph("显示物品的获取途径。"),
                Setting<TooltipSourceInformationEnabledSetting>("显示获取途径"),
                EnabledBy<TooltipSourceInformationEnabledSetting>(
                    Setting<TooltipSourceInformationModifierSetting>("按住此键时显示"),
                    Setting<TooltipSourceInformationColorSetting>("文字颜色"),
                    Scrollable("sourceInformation", 260,
                        Setting<TooltipSourceInformationSetting>()))),
            Page("tooltips/uses", "用途信息",
                Paragraph("显示该物品可用于制作或兑换的内容。"),
                Setting<TooltipUseInformationEnabledSetting>("显示用途信息"),
                EnabledBy<TooltipUseInformationEnabledSetting>(
                    Setting<TooltipUseInformationModifierSetting>("按住此键时显示"),
                    Setting<TooltipUseInformationColorSetting>("文字颜色"),
                    Scrollable("useInformation", 260,
                        Setting<TooltipUseInformationSetting>())))
        );
    }
}
