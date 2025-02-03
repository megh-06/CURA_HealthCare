using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace CURA_HealthCare.Utilities
{
    public class Base
    {
        protected IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            //driver = new ChromeDriver();

            string browserName = ConfigurationManager.AppSettings["browser"] ?? "Chrome";
            InitBrowser(browserName);

            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Url = "https://katalon-demo-cura.herokuapp.com/";
        }

        public void InitBrowser(string browserName)
        {
            switch (browserName.ToLower())
            {
                case "edge":
                    new DriverManager().SetUpDriver(new EdgeConfig());
                    break;

                case "chrome":
                    new DriverManager().SetUpDriver(new ChromeConfig());
                    driver = new ChromeDriver();
                    break;

                default:
                    throw new ArgumentException($"Invalid browser: {browserName}");
            }
        }

        [TearDown]
        public void TearDown()
        {
            driver.Dispose();
        }
    }
}
