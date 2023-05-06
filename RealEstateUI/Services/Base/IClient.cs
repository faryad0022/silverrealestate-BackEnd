using System.Net.Http;

namespace RealEstateUI.Services.Base
{
    public partial interface IClient
    {
        public HttpClient HttpClient { get; }   
    }
}
