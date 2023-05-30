using System.Collections.Generic;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace Application.Reaspose
{

    public class ReturnData< T> where T : class
    {
        public string Status { get; set; }
        public List<string> Errors { get; set; }
        public List<T> Tentities { get; set; }
        [MaybeNull]
        public  T Tentity { get; set; }

    }


    public static class FillRetuenData<T> where T : class
    {
        public static ReturnData<T> FillByListEntity(List<T> data, string status, List<string> errors)
        {
            return new ReturnData<T>
            {
                Tentity = null,
                Tentities = data,
                Status = status,
                Errors = errors
            };

        }
        public static ReturnData<T> FillByEntity(T data, string status, List<string> errors)
        {

            return new ReturnData<T>
            {
                Tentities = null,
                Tentity = data,
                Status = status,
                Errors = errors
            };
        }
    }
}
