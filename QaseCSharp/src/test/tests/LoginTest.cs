using NUnit.Framework;

namespace QaseCSharp
{
    public class LoginTest : BaseTest
    {

        [Test]
        public void LoginShouldBeSuccessful()
        {
            LoginPage.OpenLoginPage(BaseUrl);
            LoginPage.IsPageOpened();
            LoginPage.Login(Email, Password);
            ProjectsPage.IsPageOpened();
        }
    }
}