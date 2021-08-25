using OpenQA.Selenium;

namespace QaseCSharp.test.pages
{
    public class LoginPage : BasePage
    {
        public static readonly By LoginButton = By.Id("btnLogin");
        public static readonly By EmailInput = By.Id("inputEmail");
        public static readonly By PasswordInput = By.Id("inputPassword");


        public LoginPage(IWebDriver driver) : base(driver)
        {
        }

        public override bool IsPageOpened()
        {
            return IsExist(LoginButton);
        }

        public void OpenLoginPage(string baseUrl)
        {
            Driver.Navigate().GoToUrl(baseUrl);
        }

        public void Login(string email, string password)
        {
            Driver.FindElement(EmailInput).SendKeys(email);
            Driver.FindElement(PasswordInput).SendKeys(password);
            Driver.FindElement(LoginButton).Click();
        }
    }
}