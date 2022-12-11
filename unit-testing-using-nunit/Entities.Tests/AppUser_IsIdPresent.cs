namespace API.Entities;

public class Tests
{
    [TestFixture]
    public class AppUser_IsIdPresent
    {
        AppUser _appUser = new AppUser();

        [Test]
        public void IsAppUser_InputId_ReturnTrue()
        {
            var result = _appUser.setId(1);

            Assert.IsTrue(result, "ID is present for user");
        }
    }
}