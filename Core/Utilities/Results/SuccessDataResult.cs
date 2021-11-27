using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessDataResult<T> : DataResult<T>
    {
        //versiyonlar
        public SuccessDataResult(T data, string message) : base(data, true, message)
        {

        }
        public SuccessDataResult(T data) : base(data, true)
        {

        }
        public SuccessDataResult(string message) : base(default, true, message)//birşey döndürmek istemiyor default sadece mesaj vermek istersek
        {

        }
        public SuccessDataResult() : base(default, true)
        {

        }
    }
}
