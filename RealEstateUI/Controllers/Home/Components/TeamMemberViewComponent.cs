using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace RealEstateUI.Controllers.Home.Components
{
    [ViewComponent(Name ="TeamMember")]
    public class TeamMemberViewComponent:ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
