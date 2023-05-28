﻿using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace RealEstateUI.Controllers.Home.Components
{
    [ViewComponent(Name = "LatestProperty")]
    public class LatestPropertyViewComponent:ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
