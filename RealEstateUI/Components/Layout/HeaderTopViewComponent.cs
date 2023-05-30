using Microsoft.AspNetCore.Mvc;
using RealEstateUI.Contract;
using System.Threading.Tasks;

namespace RealEstateUI.Components.Layout
{
    [ViewComponent(Name = "HeaderTop")]
    public class HeaderTopViewComponent : ViewComponent
    {
        private readonly IAddressService _addressService;

        public HeaderTopViewComponent(IAddressService addressService)
        {
            _addressService = addressService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
            => View(await _addressService.GetAddressEntityAsync(1));
    }
}
