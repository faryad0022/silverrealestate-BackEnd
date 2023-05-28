using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace RealEstateUI.Controllers.Home.Components
{
    [ViewComponent(Name = "LatestBlogs")]
    public class LatestBlogsViewComponent:ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
