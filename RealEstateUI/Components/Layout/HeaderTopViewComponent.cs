using Microsoft.AspNetCore.Mvc;
using RealEstateUI.Contract;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstateUI.Components.Layout
{
    [ViewComponent(Name ="HeaderTop")]
    public class HeaderTopViewComponent:ViewComponent
    {
        private readonly IAddressService _addressService;

        public HeaderTopViewComponent(IAddressService addressService)
        {
            _addressService = addressService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var addresses = await _addressService.GetAllAsync();
            
            return View(addresses.Where(a => a.Id == 1).FirstOrDefault());
        }
    }
}
