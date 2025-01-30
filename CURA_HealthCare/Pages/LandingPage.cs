using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURA_HealthCare.Pages
{
    public class LandingPage
    {
        protected IWebDriver driver;

        public LandingPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        
        IWebElement appointment => driver.FindElement(By.Id("btn-make-appointment"));

        public void Clickappointbtn() => appointment.Click();
    }
}
