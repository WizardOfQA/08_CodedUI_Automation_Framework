using CalculatorAutomationTest.Base;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorAutomationTest
{
    public static class Helper
    {
        // Click
        public static void Click(this WinControl control)
        {
            Mouse.Click(control);
        }        
    }
}
