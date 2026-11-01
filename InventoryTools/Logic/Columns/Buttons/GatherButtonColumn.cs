using System.Collections.Generic;
using CriticalCommonLib.Services;
using CriticalCommonLib.Services.Mediator;
using DalaMock.Host.Mediator;
using Dalamud.Bindings.ImGui;
using InventoryTools.Logic.Columns.Abstract;

namespace InventoryTools.Logic.Columns.Buttons;

public class GatherButtonColumn : ButtonColumn
{
    private readonly IGameInterface _gameInterface;

    public GatherButtonColumn(IGameInterface gameInterface)
    {
        _gameInterface = gameInterface;
    }
    public override string Name { get; set; } = "采集笔记按钮";
    public override float Width { get; set; } = 80;
    public override string HelpText { get; set; } = "显示一个按钮，用于打开此物品对应的采集笔记或捕鱼笔记条目。";

    public override List<MessageBase>? Draw(FilterConfiguration configuration, ColumnConfiguration columnConfiguration,
        SearchResult searchResult, int rowIndex, int columnIndex)
    {
        ImGui.TableNextColumn();
        if (!ImGui.TableGetColumnFlags().HasFlag(ImGuiTableColumnFlags.IsEnabled)) return null;

        if (ImGui.Button("日志##" + rowIndex + "_" + columnIndex))
        {
            if (searchResult.Item.ObtainedFishing)
            {
                _gameInterface.OpenFishingLog(searchResult.Item.RowId, searchResult.Item.ObtainedSpearFishing);
            }
            else
            {
                _gameInterface.OpenGatheringLog(searchResult.Item.RowId);
            }
        }

        return null;
    }
}
