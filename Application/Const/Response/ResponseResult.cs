using System.Collections.Generic;

namespace Application.Const.Response
{

    public class ResponseResult
    {
        public string Status { get; set; }
        public List<string> Errors { get; set; }
        public object Response { get; set; }
        public static ResponseResult SetResult(object response, string status, List<string> errors)
        {
            return new ResponseResult
            {
                Status = status,
                Errors = errors,
                Response = response
            };
        }
    }
}
