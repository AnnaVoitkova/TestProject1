using System;

namespace TestProject1
{
    public class Tests
    {
        private IWebDriver driver;
        public IDictionary<string, object> vars { get; private set; }
        private IJavaScriptExecutor js;
        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            js = (IJavaScriptExecutor)driver;
            vars = new Dictionary<string, object>();
        }
        [TearDown]
        protected void TearDown()
        {
            driver.Quit();
        }
        [Test]
        public void auto()
        {
            driver.Navigate().GoToUrl("https://qauto2.forstudy.space/");
            driver.Manage().Window.Size = new System.Drawing.Size(1050, 708);
            driver.FindElement(By.CssSelector(".btn-outline-white")).Click();
            driver.FindElement(By.Id("signinEmail")).SendKeys("anna.styoba@gmail.com");
            driver.FindElement(By.Id("signinPassword")).SendKeys("123Qwerty");
            driver.FindElement(By.CssSelector(".btn-primary:nth-child(2)")).Click();
            driver.FindElement(By.CssSelector(".btn-primary")).Click();
            {
                var element = driver.FindElement(By.CssSelector(".btn-primary"));
                Actions builder = new Actions(driver);
                builder.MoveToElement(element).Perform();
            }
            {
                var element = driver.FindElement(By.tagName("body"));
                Actions builder = new Actions(driver);
                builder.MoveToElement(element, 0, 0).Perform();
            }
            driver.FindElement(By.Id("addCarBrand")).Click();
            {
                var dropdown = driver.FindElement(By.Id("addCarBrand"));
                dropdown.FindElement(By.XPath("//option[. = 'BMW']")).Click();
            }
            driver.FindElement(By.Id("addCarModel")).Click();
            {
                var dropdown = driver.FindElement(By.Id("addCarModel"));
                dropdown.FindElement(By.XPath("//option[. = 'X5']")).Click();
            }
            driver.FindElement(By.Id("addCarMileage")).Click();
            driver.FindElement(By.Id("addCarMileage")).Click();
            driver.FindElement(By.Id("addCarMileage")).Click();
            driver.FindElement(By.Id("addCarMileage")).SendKeys("21");
            driver.FindElement(By.CssSelector(".modal-footer > .btn-primary")).Click();
            driver.FindElement(By.CssSelector(".sidebar > .btn:nth-child(2)")).Click();
            driver.FindElement(By.CssSelector(".btn-primary")).Click();
            driver.FindElement(By.Id("addExpenseMileage")).Click();
            driver.FindElement(By.Id("addExpenseMileage")).SendKeys("23");
            driver.FindElement(By.Id("addExpenseLiters")).Click();
            driver.FindElement(By.Id("addExpenseLiters")).SendKeys("12");
            driver.FindElement(By.Id("addExpenseTotalCost")).Click();
            driver.FindElement(By.Id("addExpenseTotalCost")).Click();
            driver.FindElement(By.Id("addExpenseTotalCost")).Click();
            driver.FindElement(By.Id("addExpenseTotalCost")).SendKeys("13");
            driver.FindElement(By.CssSelector(".btn-primary:nth-child(2)")).Click();
            driver.FindElement(By.Id("userNavDropdown")).Click();
            driver.FindElement(By.CssSelector(".dropdown-item:nth-child(6)")).Click();
        }
    }
}