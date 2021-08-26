using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using QaseCSharp.test.pages;

namespace QaseCSharp
{
    public class BaseTest
    {
        protected IWebDriver Driver;
        protected string Email;
        protected string Password;
        protected string BaseUrl;
        protected LoginPage LoginPage;
        protected ProjectsPage ProjectsPage;
        protected ProjectModalPage ProjectModalPage;
        protected ProjectDetailsPage ProjectDetailsPage;
        protected ProjectSettingsPage ProjectSettingsPage;

        [SetUp]
        public void StartBrowser()
        {
            DotNetEnv.Env.TraversePath().Load();
            Email = DotNetEnv.Env.GetString("QASE_EMAIL", "Email not found");
            Password = DotNetEnv.Env.GetString("QASE_PASSWORD", "Password not found");
            BaseUrl = DotNetEnv.Env.GetString("QASE_BASE_URL", "Url not found");
            var options = new ChromeOptions();
            options.AddArguments("--start-maximized");
            // options.AddArguments("--headless");
            options.AddArguments("--disable-notifications");
            Driver = new ChromeDriver(options);
            LoginPage = new LoginPage(Driver);
            ProjectsPage = new ProjectsPage(Driver);
            ProjectModalPage = new ProjectModalPage(Driver);
            ProjectDetailsPage = new ProjectDetailsPage(Driver);
            ProjectSettingsPage = new ProjectSettingsPage(Driver);
        }

        [TearDown]
        public void CloseBrowser()
        {
            Driver.Close();
        }
    }
}