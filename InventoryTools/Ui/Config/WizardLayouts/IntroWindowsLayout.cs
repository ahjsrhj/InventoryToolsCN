using InventoryTools.EquipmentSuggest;
using InventoryTools.Ui.Config.Layouts;

namespace InventoryTools.Ui.Config.WizardLayouts;

public class IntroWindowsLayout : ContentLayout
{
    public override PageLayout Build()
    {
        return Page("intro/windows", "其他工具",
            Paragraph("此外还有几个独立于清单、制作和图鉴的工具，可从任意 Allagan Tools 窗口底部的菜单按钮打开。"),
            Section("陸行鳥配色計算器",
                Paragraph("選擇目標陸行鳥顏色，計算器會列出餵食所需的果實與順序。鎖定方案後即可追蹤進度，逐項記錄已餵食的果實。"),
                OpenWindow<ChocoboColourWindow>("打開陸行鳥配色計算器")),
            Section("裝備推薦",
                Paragraph("選擇職業後，工具會檢查所有角色與雇員持有的裝備，依物品等級和該職業重視的屬性，找出優於當前裝備的選項。"),
                OpenWindow<EquipmentSuggestWindow>("打開裝備推薦")),
            Section("兩個實用提示",
                Paragraph("右鍵點擊物品或表格行通常能找到更多操作；在插件任意位置點擊物品圖標，都可打開完整詳情。"))
        );
    }
}
