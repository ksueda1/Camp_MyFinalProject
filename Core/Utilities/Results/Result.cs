using System;
namespace Core.Utilities.Results
{
    public class Result:IResult
    {


        /*public Result(bool success, string message)
        {
            Message = message;
            Success = success;
        }

        public Result(bool success)
        {            
            Success = success;
        }
        //üstteki overloading ama dry ilkesine uymuyor.
        */

        public Result(bool success, string message):this(success)
        {
            Message = message;
        }
        //tek parametreli constructor'a success'i yolla demek.
        //iki parametreli olursa ikisi de çalışır.

        public Result(bool success)
        {
            Success = success;
        }


        public bool Success { get; }

        public string Message { get; }
    }
}
