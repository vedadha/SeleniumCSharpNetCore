using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumCSharpNetCore
{
    public class CustomControl : DriverHelper //This way you extend Driver
    {
        public static void ComboBox(string controlName, string value)
        {

            IWebElement comboControl = Driver.FindElement(By.XPath($"//input[@id='{controlName}-awed']"));

            comboControl.Clear();
            comboControl.SendKeys("Almond");

            IWebElement comboBox = Driver.FindElement(By.XPath($"//div[@id='{controlName}-dropmenu']//li[text()='{value}']"));
            comboBox.Click();
        }
    }
}
