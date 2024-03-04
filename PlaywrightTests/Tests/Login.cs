
// using Microsoft.Playwright;
// using PlaywrightTests.Page;

// namespace PlaywrightTests.Tests;

// public class Login
// {
//     [SetUp]
//     public void Setup()
//     {
//     }

//     [Test]
//     public async Task Test1()
//     {
//         //Starts Playwright
//         using var playwright = await Playwright.CreateAsync();

//         //Launches the Browser once Playwright is running
//         await using var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions 
//         {
//             Headless = false
//         });

//         //Page
//         var page = await browser.NewPageAsync();
//         await page.GotoAsync("http://eaapp.somee.com/");
        
//         LoginPage loginPage = new LoginPage(page);

//         await loginPage.ClickLoginLink();
//         await loginPage.Login("AdminTest", "AdminTest1!");
//         var isVisible = await loginPage.IsEmployeeDetailsVisible();
//         Assert.IsTrue(isVisible); 

//     }

// }