using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
namespace TestProject1
{
    public class Tests
    {
        IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            //Given I open Chrome browser
            driver = new ChromeDriver("C:\\Users\\user\\source\\repos\\TestProject1\\TestProject1");
            driver.Manage().Window.Maximize();
          }

        [Test]
        public void To_Verify_LogIn_With_Valid_Credential()
        {
            // When I enter url as http://www.amazon.in
            driver.Navigate().GoToUrl("http://www.amazon.in");
            //Then I can able to see Amazon home page
            IWebElement imglogo = driver.FindElement(By.Id("nav-logo-sprites"));
            Assert.IsTrue(imglogo.Displayed);
            //When I click Signin button
            IWebElement signbutton = driver.FindElement(By.Id("nav-link-accountList-nav-line-1"));
            signbutton.Click();
            //And I enter username as '7008942373'
            IWebElement txtname=driver.FindElement(By.XPath("//*[@id=\"ap_email\"]"));
            txtname.SendKeys("7008942373");
            //And I click coninue button
            IWebElement contbutton = driver.FindElement(By.XPath("//*[@id=\"continue\"]"));
            contbutton.Click();
            
            //And I enter valid password'8093900336'
            IWebElement txtpassword = driver.FindElement(By.XPath("//*[@id=\"ap_password\"]"));
            txtpassword.SendKeys("8093900336");
            IWebElement login = driver.FindElement(By.XPath("//*[@id=\"signInSubmit\"]"));
            login.Click();
        }
           public void To_Verify_LogIn_With_In_valid_Credential()
        {

        }
        [TearDown]
        public void CleanUp()
        {
           driver.Close();
        }
    }
}