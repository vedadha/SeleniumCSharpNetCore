using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumCSharpNetCore
{
    public class Tests : DriverHelper //This way you extend Driver
    {

        [SetUp]
        public void Setup()
        {
            ChromeOptions option = new ChromeOptions();
            option.AddArgument("--headless");
            System.Console.WriteLine("Setup");
            Driver = new ChromeDriver() ;   
        }

        [Test]
        public void Test1()
        {
            Driver.Navigate().GoToUrl("https://demowf.aspnetawesome.com/");
            System.Console.WriteLine("Setup");

            Driver.FindElement(By.Id("ContentPlaceHolder1_Meal")).SendKeys("Tomato");
            //Narednom komandom trazimo element sa custom xpath selectorom i klikamo na zeljeno dugme
            Driver.FindElement(By.XPath("//input[@Name='itemContentPlaceHolder1_ParentCat']/following-sibling::div[text()='Nuts']")).Click();
            //Narednom komandom trazimo element sa custom xpath selectorom i klikamo na zeljeno dugme
            Driver.FindElement(By.XPath("//input[@Name='ctl00$ContentPlaceHolder1$ChildMeal1']/following-sibling::div[text()='Hazelnuts']")).Click();


            //The first command needs to be implamented before second one, because second element is only visible after first element value is set.
            //We Debug this program by entering red dots at point where commands need to be executed to track they behavior.
            //We can drag yellow arrow from red dot to some other line and by pressing 'Step over' see changes without compiling code again.

            CustomControl.ComboBox("ContentPlaceHolder1_AllMealsCombo", "Almond");

        }
    }
}