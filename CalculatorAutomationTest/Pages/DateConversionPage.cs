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
    public class DateConversionPage : BasePage
    {
        public DateConversionPage()
        {
            SetParent("Calculator");
        }

        //DateTimePicker for From
        public WinDateTimePicker dateTimePickerFrom
        {
            get
            {
                return SetProperty<WinDateTimePicker>(PropertyType.Name, "From Date Time Pick");
            }
        }
       
        //DateTimePicker for To
        public WinDateTimePicker dateTimePickerTo
        {
            get
            {
                return SetProperty<WinDateTimePicker>(PropertyType.Name, "To Date Time Pick");
            }
        }

        //Edit for Difference(years, months, weeks, days)
        public WinEdit editDifference
        {
            get
            {
                return SetProperty<WinEdit>(PropertyType.Name, "Difference (Years, Months, Weeks, Days)");
            }
        }

        //Edit for Difference(days)
        public WinEdit editDifferenceDays
        {
            get
            {
                return SetProperty<WinEdit>(PropertyType.Name, "Difference (Days)");
            }
        }

        // btnCalculate
        public WinButton btnCalculate
        {
            get
            {
                return SetProperty<WinButton>(PropertyType.Name, "Calculate");
            }
        }

        // dd-MonthName-yyyy
        public void SetDate(string from, string to)
        {
            dateTimePickerFrom.DateTimeAsString = from;
            dateTimePickerTo.DateTimeAsString = to;
        }

        public void ClickCalculate()
        {
            btnCalculate.Click();
            Playback.Wait(1000);
        }
    }
}
