using OpenQA.Selenium;

namespace QaseCSharp.test.pages
{
    public class ProjectsPage : BasePage
    {
        public static readonly By UserMenuImage = By.Id("user-menu");
        public static readonly By CreateNewProjectButton = By.Id("createButton");

        public ProjectsPage(IWebDriver driver) : base(driver)
        {
        }

        public override bool IsPageOpened()
        {
            return IsExist(UserMenuImage);
        }

        public void ClickButtonCreateNewProject()
        {
            Driver.FindElement(CreateNewProjectButton).Click();
        }
    }
}