using System;
using NUnit.Framework;
using OpenQA.Selenium;
using QaseCSharp.test.elements;
using static System.String;

namespace QaseCSharp.test.pages
{
    public class ProjectSettingsPage : BasePage
    {
        public static readonly By GeneralSettingsTitle = By.XPath("//*[@class='project-settings-tab']" +
                                                                  "//*[text()='Settings']");
        public string InputAndTextAreaLocator = "//*[contains(text(),'{0}')]//ancestor::*[@class='form-group']" +
                                     "//*[@class='form-control']";
        public string RadioButtonLocator = "//*[contains(text(),'{0}')]//ancestor::*[@class='row']" +
                                                "//*[contains(text(),'{1}')]";
        public ProjectSettingsPage(IWebDriver driver) : base(driver)
        {
        }

        public override bool IsPageOpened()
        {
            return IsExist(GeneralSettingsTitle);
        }

        public void ValidateProject(Project project)
        {
            ValidateInput("Project name", project.ProjectName);
            ValidateInput("Project Code", project.ProjectCode);
            ValidateTextarea("Description", project.Description);
            ValidateRadioButton("Project access type", project.AccessType);
        }
        
        private void ValidateInput(string label, string expected) {
            var str = Driver.FindElement(By.XPath(Format(InputAndTextAreaLocator, label))).GetAttribute("value");
            Assert.AreEqual(expected, str, 
                "Element " + label + " text is not correct");
        }
        
        private void ValidateTextarea(string label, string expected) {
            var str = Driver.FindElement(By.XPath(Format(InputAndTextAreaLocator, label))).Text;
            Assert.AreEqual(expected, str, 
                "Element " + label + " text is not correct");
        }
        
        private void ValidateRadioButton(string label, string expected) {
            var isSelected = Driver.FindElement(By.XPath(Format(RadioButtonLocator, label, expected))).Enabled;
            Assert.True(isSelected, "Element " + label + " text is not correct");
        }
    }
}