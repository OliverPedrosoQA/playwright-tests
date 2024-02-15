using System.Threading.Tasks;
using Microsoft.Playwright.NUnit;
using NUnit.Framework;

namespace NUnitPlaywrightTests;

public class NUnitPlaywright : PageTest
{
    [SetUp]
    public async Task Setup()
    {
        await Page.GotoAsync("http://eaapp.somee.com/");
    }

    [Test]
    public async Task TestWithUNitTest()
    {
        //Page
        await Page.ClickAsync("text=Login");
        await Page.FillAsync("#UserName", "AdminTest");
        await Page.FillAsync("#Password", "AdminTest1!");
        await Page.ClickAsync("text=Log in");
        await Expect(Page.Locator("text=Employee List")).ToBeVisibleAsync();
        
    }
}