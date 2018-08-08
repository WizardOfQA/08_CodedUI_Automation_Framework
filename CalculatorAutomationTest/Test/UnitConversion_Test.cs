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
using System.Configuration;
using CalculatorAutomationTest.Base;

namespace CalculatorAutomationTest.Test
{
    /// <summary>
    /// Summary description for CodedUITest2
    /// </summary>
    [CodedUITest]
    public class UnitConversion_Test : BasePage
    {
        public UnitConversion_Test()
        {
        }
        [TestInitialize]
        public void LaunchApplication()
        {
            ApplicationUnderTest.Launch(AUT);
        }

        [TestMethod]
        public void Length_Conversion_Km_Mile()
        {
            // 1. Navigate to View page
            ViewPage vp = new ViewPage();

            // 2. Navigate to UnitConversion page
            UnitConversionPage ucp = vp.ClickUnitConversion();

            // 3. Set Unit type, From, To comboboxes
            ucp.SetComboBox(ucp.comboBoxUnitType, "Length");
            ucp.SetComboBox(ucp.comboBoxFrom, "Kilometers");
            ucp.SetComboBox(ucp.comboBoxTo, "Mile");

            // 4. Input the value on From Edit
            ucp.EnterText(ucp.editFrom, "1");

            // 5. Verify the result in To Edit
            Assert.AreEqual("0.621371192237334", ucp.editTo.Text);
            Playback.Wait(2000);
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
