using Faker;
using NUnit.Framework;
using QaseCSharp.test.elements;

namespace QaseCSharp
{
    public class ProjectTest : BaseTest
    {
        [Test]
        public void ProjectShouldBeCreated()
        {
            string random = StringFaker.Alpha(6).ToUpper();
            var project = new Project(random, random, "There is a test", "Public");
            LoginPage.OpenLoginPage(BaseUrl);
            LoginPage.IsPageOpened();
            LoginPage.Login(Email, Password);
            ProjectsPage.IsPageOpened();
            ProjectsPage.ClickButtonCreateNewProject();
            ProjectModalPage.IsPageOpened();
            ProjectModalPage.CreateNewProject(project);
            ProjectDetailsPage.OpenSettings();
            ProjectSettingsPage.IsPageOpened();
            ProjectSettingsPage.ValidateProject(project);
        }
    }
}