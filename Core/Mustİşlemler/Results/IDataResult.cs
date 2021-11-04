using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Mustİşlemler.Results
{
    public interface IDataResult<T>:IResult
    {

        T Data { get; }


    }
}
