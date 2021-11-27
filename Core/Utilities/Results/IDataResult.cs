using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public interface IDataResult<T> : IResult//mesaj ve işlem sonucu içerdiği için IResult impelent ettik
    {
        T Data { get; }
    }
}
