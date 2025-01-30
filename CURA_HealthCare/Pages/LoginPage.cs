using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURA_HealthCare.Pages
{
    public class LoginPage
    {
        protected IWebDriver driver;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        IWebElement user => driver.FindElement(By.CssSelector("input[id='txt-username']"));

        IWebElement pass => driver.FindElement(By.CssSelector("input[id='txt-password']"));

        IWebElement btn => driver.FindElement(By.XPath("//button[text()='Login']"));

        public void Login(string Username, string Password)
        {
            user.SendKeys(Username);
            pass.SendKeys(Password);
            btn.Click();
        }
    }
}
