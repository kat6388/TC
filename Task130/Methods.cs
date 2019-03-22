using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace Task130
{
    public class Methods
    {
        public IWebDriver NavigateTo(string url)
        {
            var chromeDriver = new ChromeDriver(@"D:\Automation");
            chromeDriver.Navigate().GoToUrl(url);
            return chromeDriver;
        }

        public void LoginUser(IWebDriver chromeDriver, string username, string password)
        {
            Actions builder = new Actions(chromeDriver);
            chromeDriver.FindElement(By.LinkText("Войти")).Click();
            chromeDriver.FindElement(By.Name("login")).SendKeys(username);
            builder.SendKeys(Keys.Tab).Perform();
            chromeDriver.FindElement(By.Name("password")).SendKeys(password);
            chromeDriver.FindElement(By.ClassName("auth__enter")).Click();
        }

        public bool IsUserLogin(IWebDriver chromeDriver)
        {
            return chromeDriver.FindElement(By.ClassName("uname")).Displayed;
        }

        public void LogoutUser(IWebDriver chromeDriver, string username, string password)
        {
            LoginUser(chromeDriver,username,password);
            chromeDriver.FindElement(By.ClassName("uname")).Click();
            chromeDriver.FindElement(By.LinkText("Выйти")).Click();
        }

        public bool IsUserLogout(IWebDriver chromeDriver)
        {
            return chromeDriver.FindElement(By.LinkText("Войти")).Displayed;
        }
    }
}
