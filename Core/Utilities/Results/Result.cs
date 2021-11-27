using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        public Result(bool success, string message):this(success)//bu isimdeki construcotr tek parametreli olan çalışacak
        {
            Message = message;
           // Success = success;//burada kenidni tekrar etmemek için alttaki contructorı kullanıcam
        }
        //overloading aşırı yükleme her ikisinden birini seçebilir imza farklı
        public Result(bool success)//construcotr mesaj yollamak istemiyorum
        {           
            Success = success;
        }
        public bool Success { get; }

        public string Message { get; }
    }
}
