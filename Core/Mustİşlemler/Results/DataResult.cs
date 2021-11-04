﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Mustİşlemler.Results
{
    public class DataResult<T> : Result, IDataResult<T>
    {
        public DataResult(T data,bool success,string message):base(success,message)
        {

        }



        public T Data { get; }
    }
}
