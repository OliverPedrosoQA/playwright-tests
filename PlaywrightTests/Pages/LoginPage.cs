using Microsoft.Playwright;

namespace PlaywrightTests.Page;
public class LoginPage
{
    private IPage _page;
    //Constructor 
    public LoginPage(IPage page) => _page = page;

    //Getters
    private ILocator LoginLink => _page.Locator("text=Login");
    private ILocator UserName => _page.Locator("#UserName");
    private ILocator Password => _page.Locator("#Password");
    private ILocator LoginButton => _page.Locator("text=Log in");
    private ILocator EmployeeListLink => _page.Locator("text=Employee List");

    public async Task ClickLogin() => await LoginLink.ClickAsync();

    public async Task Login(string userName, string password)
    {
        await UserName.FillAsync(userName);
        await Password.FillAsync(password);
        await LoginButton.ClickAsync();

    }

    public async Task<bool> IsEmployeeDetailsVisible() => await EmployeeListLink.IsVisibleAsync();

}