using AllaganLib.GameSheets.Sheets.Rows;
using AllaganLib.Shared.Extensions;
using CriticalCommonLib.MarketBoard;
using CriticalCommonLib.Models;
using CriticalCommonLib.Services;

using InventoryTools.Extensions;
using InventoryTools.Services;
using Microsoft.Extensions.Logging;

namespace InventoryTools.Logic.Filters
{
    public class MarketBoardMinTotalPriceFilter : MarketBoardTotalPriceFilter
    {
        public MarketBoardMinTotalPriceFilter(ILogger<MarketBoardMinTotalPriceFilter> logger, ImGuiService imGuiService, ICharacterMonitor characterMonitor, IMarketCache marketCache) : base(logger, imGuiService, characterMonitor, marketCache)
        {
            ShowOperatorTooltip = true;
        }
        public override string Key { get; set; } = "MBMinTotalPrice";
        public override string Name { get; set; } = "市场最低总价";
        public override string HelpText { get; set; } = "物品按最低单价乘以数量计算的市场总价。需先启用自动获取价格。后台价格更新会在库存刷新时生效，而库存刷新通常会频繁发生。";
        public override FilterCategory FilterCategory { get; set; } = FilterCategory.Market;

        public override bool? FilterItem(FilterConfiguration configuration,InventoryItem item)
        {
            var currentValue = CurrentValue(configuration);
            if (!string.IsNullOrEmpty(currentValue))
            {
                if (!item.CanBeTraded)
                {
                    return false;
                }
                var activeCharacter = CharacterMonitor.ActiveCharacter;
                if (activeCharacter != null)
                {
                    var marketBoardData = MarketCache.GetPricing(item.ItemId, activeCharacter.WorldId, false);
                    if (marketBoardData != null)
                    {
                        float price;
                        if (item.IsHQ)
                        {
                            price = marketBoardData.MinPriceHq;
                        }
                        else
                        {
                            price = marketBoardData.MinPriceNq;
                        }

                        price *= item.Quantity;
                        return price.PassesFilter(currentValue.ToLower());
                    }
                }

                return false;
            }

            return true;
        }

        public override bool? FilterItem(FilterConfiguration configuration, ItemRow item)
        {
            return true;
        }
    }
}
