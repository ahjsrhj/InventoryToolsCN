using InventoryTools.Logic.Columns.Abstract;
using InventoryTools.Services;
using Microsoft.Extensions.Logging;

namespace InventoryTools.Logic.Columns
{
    public class IsArmoireItem : CheckboxColumn
    {
        public IsArmoireItem(ILogger<IsArmoireItem> logger, ImGuiService imGuiService) : base(logger, imGuiService)
        {
        }
        public override ColumnCategory ColumnCategory => ColumnCategory.Basic;
        public override bool? CurrentValue(ColumnConfiguration columnConfiguration, SearchResult searchResult)
        {
            return searchResult.Item.CabinetCategory != null;
        }
        public override string Name { get; set; } = "可存入投影梳妆台？";
        public override string RenderName => "投影梳妆台？";
        public override float Width { get; set; } = 100;
        public override string HelpText { get; set; } = "显示此物品能否存入投影梳妆台。";
        public override bool HasFilter { get; set; } = true;
        public override ColumnFilterType FilterType { get; set; } = ColumnFilterType.Boolean;
    }
}
