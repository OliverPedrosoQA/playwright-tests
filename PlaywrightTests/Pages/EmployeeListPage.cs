using System.Drawing;
using Microsoft.Playwright;

namespace PlaywrightTests.Page;
public class EmployeeListPage
{
    private IPage _page;
    //Constructor 
    public EmployeeListPage(IPage page) => _page = page;

    //Getters
    private ILocator EmployeeListLink => _page.Locator("text=Employee List");
    private ILocator EmployeeListSearchButton => _page.GetByRole(AriaRole.Button, new() { Name = "Search" });
//GetByRole(AriaRole.Button, new() { Name = "Search" })
    public async Task clickEmployeeListLink() => await EmployeeListLink.ClickAsync();
    public async Task<bool> IsSearchButtonVisible() => await EmployeeListSearchButton.IsVisibleAsync();

}