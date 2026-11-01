using InventoryTools.Logic.Settings;
using InventoryTools.Ui.Config.Layouts;

namespace InventoryTools.Ui.Config.ConfigLayouts;

public class WindowsAndListsLayout : ConfigLayout
{
    public override PageLayout Build()
    {
        return Page("windows-lists", "窗口与清单",
            Section("布局",
                Paragraph("调整各个窗口的布局方式。"),
                Setting<CraftWindowLayoutSetting>("制作窗口"),
                Setting<FiltersWindowLayoutSetting>("物品窗口"),
                Setting<ShowFiltersTabSetting>("显示筛选器标签页"),
                Setting<CompendiumRowHeightSetting>("图鉴行高")),
            Section("自动切换",
                Paragraph("在界面中切换清单时，若已启用高亮，是否自动切换为当前清单的高亮设置？"),
                Setting<SwitchFiltersAutomaticallySetting>(),
                Setting<SwitchCraftListsAutomaticallySetting>()),
            Section("忽略 Esc 键",
                Paragraph("按下 Esc 键时仍保持打开的窗口。"),
                Setting<CraftWindowIgnoreEscapeSetting>("制作窗口"),
                Setting<FiltersWindowIgnoreEscapeSetting>("物品窗口"),
                Setting<ItemWindowIgnoreEscapeSetting>("物品详情窗口"),
                Setting<FilterWindowIgnoreEscapeSetting>("清单窗口"))
        );
    }
}
