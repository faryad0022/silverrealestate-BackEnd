using System.Collections.Generic;

namespace RealEstateUI.Services.Base
{
    public class ApiResponse
    {
        public List<string> Errors { get; set; }
        public string Status { get; set; }
        public object Data { get; set; }

    }

}
