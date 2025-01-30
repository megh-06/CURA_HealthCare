using CURA_HealthCare.Pages;
using CURA_HealthCare.Utilities;

namespace CURA_HealthCare.Test
{
    public class Tests : Base
    {
        private LandingPage landingpage;
        private LoginPage loginpage;

        [SetUp]
        public void BeforeEachTest()
        {
            landingpage = new LandingPage(driver);
            loginpage = new LoginPage(driver);
        }

        [Test]
        [TestCase("XYZ", "ABC")]      //One of the Data Driven Approach
        public void test(string name,string pass)
        {
            landingpage.appointbtn();
            loginpage.Login(name, pass);
        }
    }
}