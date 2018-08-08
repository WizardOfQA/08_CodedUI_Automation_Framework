using CalculatorAutomationTest.Pages;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorAutomationTest.Base
{
    public enum PropertyType
    {
        Name,
        ClassName,
        Class,
        ControlName,
        ControlId,
        DisplayText
    }
    public class BasePage
    {     
        private static WinWindow _parentWindow;

        public BasePage()
        {
            
        }

        public void SetParent(string windowName)
        {
            _parentWindow = new WinWindow();
            _parentWindow.SearchProperties[WinWindow.PropertyNames.Name] = windowName;
        }
        public T SetProperty<T>(PropertyType property, string value) where T : WinControl
        {
            T control = (T)Activator.CreateInstance(typeof(T), new object[] { _parentWindow });

            if (property == PropertyType.Name)
                control.SearchProperties[WinControl.PropertyNames.Name] = value;
            else if (property == PropertyType.ControlName)
                control.SearchProperties[WinControl.PropertyNames.ControlName] = value;
            else if (property == PropertyType.ClassName)
                control.SearchProperties[WinControl.PropertyNames.ClassName] = value;
            else if (property == PropertyType.ControlId)
                control.SearchProperties[WinControl.PropertyNames.ControlId] = value;
            return control;
        }
    }
}
