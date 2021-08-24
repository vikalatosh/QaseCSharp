
using NUnit.Framework;
using OpenQA.Selenium;

namespace QaseCSharp
{
    public class LoginTest : BaseTest
    {

        [Test]
        public void LoginShouldBeSuccessful()
        {
            Driver.Navigate().GoToUrl(BaseUrl);
            Driver.FindElement(By.Id("inputEmail")).SendKeys(Email);
            Driver.FindElement(By.Id("inputPassword")).SendKeys(Password);
            Driver.FindElement(By.Id("btnLogin")).Click();
            var isOpened = Driver.FindElement(By.Id("user-menu")).Displayed;
            Assert.True(isOpened, "Products page is not opened");
        }
    }
}