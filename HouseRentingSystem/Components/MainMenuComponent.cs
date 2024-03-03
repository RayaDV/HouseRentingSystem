using Microsoft.AspNetCore.Mvc;

namespace HouseRentingSystem.Components
{
    public class MainMenuComponent : ViewComponent // to become ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return await Task.FromResult<IViewComponentResult>(View());
        }
    }
}
