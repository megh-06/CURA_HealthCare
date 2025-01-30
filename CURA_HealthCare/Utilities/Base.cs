using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURA_HealthCare.Utilities
{
    public class Base
    {
        protected IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://katalon-demo-cura.herokuapp.com/";
        }

        [TearDown]
        public void TearDown()
        {
            driver.Dispose();
        }
    }
}
