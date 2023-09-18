using Hanssens.Net;
using System;
using System.Collections.Generic;
using System.Net.Http.Headers;

namespace RealEstateUI.Services.Base
{
    public class BaseHttpService
    {
        protected readonly IClient _client;
        protected readonly ILocalStorage _localStorage;

        public BaseHttpService(IClient client, ILocalStorage localStorage)
        {
            _client = client;
            _localStorage = localStorage;
        }
        protected ApiResponse ConvertApiExceptions<T>(ApiException ex)
        {
            if (ex.StatusCode == 400)
            {
                return new ApiResponse() { Errors = new List<string>() { "Validation error occured" }, Status = "Error" };
            }
            if (ex.StatusCode == 404)
            {
                return new ApiResponse() { Errors = new List<string>() { "NotFound" }, Status = "Error" };
            }
            else
            {
                return new ApiResponse() {Errors = new List<string>() { "Something went wrong" }, Status = "Error" };
            }
        }
        protected void AddBeared()
        {
            if(_localStorage.Exists("local"))
            {
                _client.HttpClient.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue("Bearer", _localStorage.Get<string>("local"));
            }
        }
    }
}
