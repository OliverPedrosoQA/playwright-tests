// using System.Text.RegularExpressions;
// using System.Threading.Tasks;
// using Microsoft.Playwright;
// using Microsoft.Playwright.NUnit;
// using NUnit.Framework;

// namespace PlaywrightTests;

// public class Tests
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
//         await page.ClickAsync("text=Login");
//         await page.ScreenshotAsync(new PageScreenshotOptions
//         {
//             Path = "EAApp.jpg"
//         });

//         await page.FillAsync("#UserName", "AdminTest");
//         await page.FillAsync("#Password", "AdminTest1!");
//         await page.ClickAsync("text=Log in");
//         var isExist = await page.Locator("text=Employee List").IsVisibleAsync();
//         Assert.IsTrue(isExist);
//     }
// }