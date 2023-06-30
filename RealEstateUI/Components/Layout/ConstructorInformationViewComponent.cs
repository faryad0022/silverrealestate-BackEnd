using Microsoft.AspNetCore.Mvc;
using RealEstateUI.Contract;
using System.Threading.Tasks;

namespace RealEstateUI.Components.Layout
{
    [ViewComponent(Name = "ConstructorInformation")]
    public class ConstructorInformationViewComponent : ViewComponent
    {
        private readonly IConstructorInformationService _constructorInformationService;

        public ConstructorInformationViewComponent(IConstructorInformationService constructorInformationService)
        {
            _constructorInformationService = constructorInformationService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(await _constructorInformationService.GetAllConstructorAsync());
        }
    }
}
