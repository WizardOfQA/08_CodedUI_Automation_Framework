using CalculatorAutomationTest.Base;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorAutomationTest.Pages
{
    public class ViewPage : BasePage
    {
        public ViewPage()
        {
            SetParent("Calculator");
        }

        //MenuItem for View
        //public WinMenuBar menuBar
        //{
        //    get
        //    {
        //        return SetProperty<WinMenuBar>(PropertyType.ControlId, "0");
        //    }
        //}

        //MenuItem for View
        public WinMenuItem menuView
        {
            get
            {
                return SetProperty<WinMenuItem>(PropertyType.Name, "View");
            }
        }

        //MenuItem for DateConversion
        private WinMenuItem menuDateConversion
        {
            get
            {
                return SetProperty<WinMenuItem>(PropertyType.Name, "Date calculation\tCtrl+E");
            }
        }

        //MenuItem for UnitConversion
        private WinMenuItem menuUnitConversion
        {
            get
            {
                return SetProperty<WinMenuItem>(PropertyType.Name, "Unit conversion\tCtrl+U");
            }
        }

        //MenuItem for Basic
        private WinMenuItem menuBasic
        {
            get
            {
                return SetProperty<WinMenuItem>(PropertyType.Name, "Basic\tCtrl+F4");
            }
        }

        // Navigate to DateConversion Page
        public DateConversionPage ClickDateConversion()
        {
            menuView.Click();
            menuDateConversion.Click();
            return new DateConversionPage();
        }

        // Navigate to UnitConversion Page
        public UnitConversionPage ClickUnitConversion()
        {
            menuView.Click();
            menuUnitConversion.Click();
            return new UnitConversionPage();
        }

        // Navigate to UnitConversion Page
        public BasicPage ClickBasic()
        {
            menuView.Click();
            menuBasic.Click();
            return new BasicPage();
        }
    }
}
