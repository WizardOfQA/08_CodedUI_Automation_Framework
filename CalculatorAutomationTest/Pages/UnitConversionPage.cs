using CalculatorAutomationTest.Base;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorAutomationTest.Pages
{
    public class UnitConversionPage : BasePage
    {
        public UnitConversionPage()
        {
            SetParent("Calculator");
        }

        //ComboBox for UnitType
        public WinComboBox comboBoxUnitType
        {
            get
            {
                return SetProperty<WinComboBox>(PropertyType.Name, "Unit Type");
            }
        }

        //ComboBox for From
        public WinComboBox comboBoxFrom
        {
            get
            {
                return SetProperty<WinComboBox>(PropertyType.Name, "From Unit");
            }
        }

        //ComboBox for From
        public WinComboBox comboBoxTo
        {
            get
            {
                return SetProperty<WinComboBox>(PropertyType.Name, "To Unit");
            }
        }

        //Edit for From value
        public WinEdit editFrom
        {
            get
            {
                return SetProperty<WinEdit>(PropertyType.Name, "From Value");
            }
        }

        //Edit for To value
        public WinEdit editTo
        {
            get
            {
                return SetProperty<WinEdit>(PropertyType.Name, "To Value");
            }
        }

        public void SetComboBox(WinComboBox comboBox, string unitType)
        {
            comboBox.SelectedItem = unitType;
        }

        public void EnterText(WinEdit edit, string text)
        {
            Keyboard.SendKeys(edit, text);
        }
    }
}
