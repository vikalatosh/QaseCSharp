using OpenQA.Selenium;

namespace QaseCSharp.test.pages
{
    public class ProjectDetailsPage : BasePage
    {
        public static readonly By ProjectTitle = By.CssSelector(".avatar-xxs");
        public static readonly By SettingsTitle = By.XPath("//*[text()='Settings']");

        public ProjectDetailsPage(IWebDriver driver) : base(driver)
        {
        }

        public override bool IsPageOpened()
        {
            return IsExist(ProjectTitle);
        }

        public void OpenSettings()
        {
            Driver.FindElement(SettingsTitle).Click();
        }
    }
}