using System;
using OpenQA.Selenium;
using QaseCSharp.test.elements;

namespace QaseCSharp.test.pages
{
    public class ProjectModalPage : BasePage
    {
        public static readonly By NewProjectTitle = By.XPath("//*[text()='New Project']");
        public static readonly By ProjectNameInput = By.Id("inputTitle");
        public static readonly By ProjectCodeInput = By.Id("inputCode");
        public static readonly By DescriptionTextarea = By.Id("inputDescription");
        public const string AccessLabel = "//*[@class='form-check']//*[contains(text(),'{0}')]";

        public ProjectModalPage(IWebDriver driver) : base(driver)
        {
        }

        public override bool IsPageOpened()
        {
            return IsExist(NewProjectTitle);
        }

        public void CreateNewProject(Project project)
        {
            Driver.FindElement(ProjectNameInput).SendKeys(project.ProjectName);
            Driver.FindElement(ProjectCodeInput).Clear();
            Driver.FindElement(ProjectCodeInput).SendKeys(project.ProjectCode);
            Driver.FindElement(DescriptionTextarea).SendKeys(project.Description);
            Driver.FindElement(By.XPath(string.Format(AccessLabel, project.AccessType))).Click();
            Driver.FindElement(ProjectNameInput).Submit();
        }
    }
}