using SeleniumTraining.src.code.page;

namespace SeleniumTraining.src.code.test;
[TestClass]
public class TestFedex : TestBase
{   MainPage mainPage = new MainPage();
    LoginSection loginSection = new LoginSection();
    LeftSite leftSite = new LeftSite(); 
    
    [TestMethod]
    public void VerifyTheLoginIsSuccessfuly2()
    {
        mainPage.loginButton.Click();
        loginSection.emailTxtBox.SetText("asfdsa");
    }
}