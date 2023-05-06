using System.Collections.Generic;

namespace RealEstateUI.Services.Base
{
    public class Response<T> where T : class
    {
        public long Id { get; set; }
        public string Status { get; set; }
        public List<string> Errors { get; set; }
        public List<T> Tentities { get; set; }
        public T Tentity { get; set; }

    }

}
