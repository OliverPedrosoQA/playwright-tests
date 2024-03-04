
using Microsoft.Playwright;
using PlaywrightTests.Page;

namespace PlaywrightTests.Tests;

public class EmployeeList
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public async Task ValidatingEmployeeList1()
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
        EmployeeListPage employeePage = new EmployeeListPage(page);

        await loginPage.ClickLoginLink();
        await loginPage.Login("AdminTest", "AdminTest1!");
        
        //Way 1 for Network Event - Response and Request validations
        var employeeListPageResponse = page.WaitForResponseAsync("**/Employee"); //this method validates the response        //Way 1 for Network Event - Request validation
        var employeeListPageRequest = page.WaitForRequestAsync("**/Employee"); 
        await employeePage.clickEmployeeListLink();
        var getRequest = await employeeListPageRequest;
        var getResponse = await employeeListPageResponse;

        //Validate if the Search button is visible
        var IsSearchButtonVisible = await employeePage.IsSearchButtonVisible();
        Assert.IsTrue(IsSearchButtonVisible);

    }

    [Test]
    public async Task ValidatingEmployeeList2()
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
        EmployeeListPage employeePage = new EmployeeListPage(page);

        await loginPage.ClickLoginLink();
        await loginPage.Login("AdminTest", "AdminTest1!");

        //Way 2 for Network Event - Response and Request validations
        var request = await page.RunAndWaitForRequestAsync(async () =>
        {
            await employeePage.clickEmployeeListLink();
        }, x => x.Url.Contains("/Employee"));

        var response = await page.RunAndWaitForResponseAsync(async () => 
        {
            await employeePage.clickEmployeeListLink();
        }, x => x.Url.Contains("/Employee") && x.Status == 200);     
        
        var IsSearchButtonVisible = await employeePage.IsSearchButtonVisible();
        Assert.IsTrue(IsSearchButtonVisible);
    }
 
}