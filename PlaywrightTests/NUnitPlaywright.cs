// using System.Threading.Tasks;
// using Microsoft.Playwright;
// using Microsoft.Playwright.NUnit;
// using Microsoft.Playwright.Transport.Protocol;
// using NUnit.Framework;
// using PlaywrightTests.Page;

// namespace NUnitPlaywrightTests;

// public class NUnitPlaywright : PageTest
// {
//     [SetUp]
//     public async Task Setup()
//     {
//         await Page.GotoAsync("http://eaapp.somee.com/");
//     }

//     [Test]
//     public async Task TestWithUNitTest()
//     {

//         var loginPage = new LoginPage(Page);
        
//         Page.SetDefaultTimeout(1000); it's possible to set the default timeout for the whole test
//         using Locators
//         var loginLink = Page.Locator("text=Login");
//         await loginLink.ClickAsync();
//         await Page.FillAsync("#UserName", "AdminTest");
//         await Page.FillAsync("#Password", "AdminTest1!");

//         //Using Locator with Page Locator Options
//         var logInButton = Page.Locator("Input", new PageLocatorOptions { HasTextString = "Log in" });
//         await logInButton.ClickAsync();  //await logInButton.ClickAsync("text=Log in");
      
//         await Expect(Page.Locator("text=Employee List")).ToBeVisibleAsync();
        
//     }
// }