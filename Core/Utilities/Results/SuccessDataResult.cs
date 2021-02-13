using System;
namespace Core.Utilities.Results
{
    public class SuccessDataResult<T>:DataResult<T>
    {
        public SuccessDataResult(T data, string message):base(data,true,message)
        {

        }

        public SuccessDataResult(T data):base(data, true)
        {

        }

        public SuccessDataResult(string message):base(default,true,message)
        {

        }
        //yukarıdaki default T'nin default türü.

        public SuccessDataResult():base(default,true)
        {

        }
        //son ikisi fazla kullanılmıyor ama altyapı için bulunsun.
    }
}
