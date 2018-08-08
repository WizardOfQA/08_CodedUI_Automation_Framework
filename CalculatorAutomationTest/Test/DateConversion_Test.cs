using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
using CalculatorAutomationTest.Pages;
using System.Diagnostics;

namespace CalculatorAutomationTest.Test
{
    /// <summary>
    /// Summary description for DateConversion_Test
    /// </summary>
    [CodedUITest]
    public class DateConversion_Test
    {
        public DateConversion_Test()
        {
        }
        [TestInitialize]
        public void LaunchApplication()
        {
            ApplicationUnderTest.Launch(@"C:\Windows\System32\calc1.exe");
        }

        [TestMethod]
        public void Can_Calculate_Date_Differences()
        {
            // 1. Navigate to View page
            ViewPage vp = new ViewPage();

            // 2. Navigate to DateConversion page
            DateConversionPage dcp = vp.ClickDateConversion();
            
            // 3. Add dates
            dcp.SetDate("1-July-2018", "7-Aug-2018");

            // 4. Click Calculate button
            dcp.ClickCalculate();

            // 5. Verify the results
            Assert.AreEqual("1 month, 6 days", dcp.editDifference.Text);
            Assert.AreEqual("37 days", dcp.editDifferenceDays.Text);

        }

        [TestCleanup]
        public void BackToOriginalStatus()
        {
            ViewPage vp = new ViewPage();
            vp.ClickBasic();
        }

        #region Additional test attributes

        // You can use the following additional attributes as you write your tests:

        ////Use TestInitialize to run code before running each test 
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

        ////Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

        #endregion

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        private TestContext testContextInstance;

       
    }
}
