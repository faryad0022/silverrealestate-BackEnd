using System.Collections.Generic;

namespace RealEstateUI.Services.Base
{
    public class ApiResponse<T> where T : class
    {
        public string Status { get; set; }
        public List<string> Errors { get; set; }
        public List<T> Tentities { get; set; }
        public T Tentity { get; set; }

    }

}
