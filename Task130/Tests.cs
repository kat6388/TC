using NUnit.Framework;

namespace Task130
{
    [TestFixture]
    public class Tests
    {
        public const string url = "https://www.tut.by/";
        public const string username = "seleniumtests@tut.by";
        public const string password = "123456789zxcvbn";

        [Test]
        public void Login()
        {
            Methods methods = new Methods();
            var driver = methods.NavigateTo(url);
            methods.LoginUser(driver, username, password);
            Assert.IsTrue(methods.IsUserLogin(driver));
        }

        [Test]
        public void Logout()
        {
            Methods methods = new Methods();
            var driver = methods.NavigateTo(url);
            methods.LogoutUser(driver, username, password);
            Assert.IsTrue(methods.IsUserLogout(driver));
        }
    }
}
