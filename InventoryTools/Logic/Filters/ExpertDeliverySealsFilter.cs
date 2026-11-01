using System.Linq;
using AllaganLib.GameSheets.Caches;
using AllaganLib.GameSheets.ItemSources;
using AllaganLib.GameSheets.Sheets.Rows;
using AllaganLib.Shared.Extensions;
using CriticalCommonLib.Models;
using InventoryTools.Logic.Filters.Abstract;
using InventoryTools.Services;
using Microsoft.Extensions.Logging;

namespace InventoryTools.Logic.Filters;

public class ExpertDeliverySealsFilter : StringFilter
{
    public ExpertDeliverySealsFilter(ILogger<ExpertDeliverySealsFilter> logger, ImGuiService imGuiService) : base(logger, imGuiService)
    {
    }

    public override string Key { get; set; } = "ExpertDeliverySeals";
    public override string Name { get; set; } = "军票交纳奖励";
    public override string HelpText { get; set; } = "以稀有品交纳此物品可获得的军票数量。";
    public override FilterCategory FilterCategory { get; set; } = FilterCategory.Basic;
    public override bool? FilterItem(FilterConfiguration configuration, InventoryItem item)
    {
        return FilterItem(configuration, item.Item);
    }

    public override bool? FilterItem(FilterConfiguration configuration, ItemRow item)
    {
        if (!item.IsExpertDelivery)
        {
            return null;
        }

        var sealsRewarded = item.GetUsesByType<ItemGCExpertDeliverySource>(ItemInfoType.GCExpertDelivery)
            .FirstOrDefault()?.SealsRewarded ?? null;
        if (sealsRewarded == null)
        {
            return null;
        }

        var currentValue = CurrentValue(configuration);
        if (!string.IsNullOrEmpty(currentValue))
        {
            if (sealsRewarded.Value.PassesFilter(currentValue.ToLower()))
            {
                return true;
            }

            return false;
        }
        return null;
    }
}
