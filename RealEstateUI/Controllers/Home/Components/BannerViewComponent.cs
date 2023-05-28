using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace RealEstateUI.Controllers.Home.Components
{
    [ViewComponent(Name = "Banner")]
    public class BannerViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
