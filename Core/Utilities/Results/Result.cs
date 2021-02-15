using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        public Result(bool success, string message):this(success) //this demek classın kendisi demek 
        {
            Message = message;
        }
        public Result(bool success)
        {
            Success = success; //overloading(aşırı yükleme) 2 tane constructor
        }

        public bool Success { get; }

        public string Message { get; }//get readonlydir ve constructorda set edilebilir
    }
}