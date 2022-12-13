namespace Entities.Tests;

public class Tests
{
    AppUser appUser = new AppUser();
    [SetUp]
    public void Setup()
    {
        appUser.Id = 1;
        appUser.UserName = "Jerry";
    }

    [Test]
    public void AppUser_Is_Id_Valid()
    {
        if(appUser.Id == 1)
        {
            Assert.Pass("Id is Valid");
        }
    }
    [Test]
    public void AppUser_Is_UserName_Valid()
    {
        if(appUser.UserName == "Jerry")
        {
            Assert.Pass("Username is Valid");
        }
    }
}