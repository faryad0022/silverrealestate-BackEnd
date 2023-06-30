using System.Collections.Generic;

namespace Application.Const.Response
{

    public class ResponseResultDTO
    {
        public string Status { get; set; }
        public List<string> Errors { get; set; }
        public object Data { get; set; }
        public static ResponseResultDTO SetResult(object response, string status, List<string> errors)
        {
            return new ResponseResultDTO
            {
                Status = status,
                Errors = errors,
                Data = response
            };
        }
    }
}
