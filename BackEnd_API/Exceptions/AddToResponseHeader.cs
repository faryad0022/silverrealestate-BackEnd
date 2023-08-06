using Microsoft.AspNetCore.Http;

namespace BackEnd_API.Exceptions
{
    public static class AddToResponseHeader
    {
        public static void AddAppError(this HttpResponse response, string message)
        {
            response.Headers.Add("App-Error",message);
            response.Headers.Add("Access-Control-Expose-Header", "App-Error"); 
            response.Headers.Add("Access-Control-Allow-Origin", "*");
        }
    }
}
