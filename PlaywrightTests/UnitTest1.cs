using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using NUnit.Framework;
using PlaywrightTests.Page;

namespace PlaywrightTests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public async Task Test1()
    {
        //Starts Playwright
        using var playwright = await Playwright.CreateAsync();

        //Launches the Browser once Playwright is running
        await using var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions 
        {
            Headless = false
        });

        //Page
        var page = await browser.NewPageAsync();
        await page.GotoAsync("http://eaapp.somee.com/");
        
        LoginPage loginPage = new LoginPage(page);

        await loginPage.ClickLogin();
        await loginPage.Login("AdminTest", "AdminTest1!");
        var isVisible = await loginPage.IsEmployeeDetailsVisible();
        Assert.IsTrue(isVisible); 

    }
}