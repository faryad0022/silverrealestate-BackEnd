using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace RealEstateUI.Controllers.Home.Components
{
    [ViewComponent(Name = "SpectacularLocation")]
    public class SpectacularLocationViewComponent:ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
