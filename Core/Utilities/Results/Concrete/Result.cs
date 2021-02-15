using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results.Abstract;

namespace Core.Utilities.Results.Concrete
{
    public class Result : IResult
    {

        public Result(bool success)
        {
            Success = success;
        }
        // this(success) deyince success isteyen consructor da çalışır.
        public Result(bool success, string message) :this(success)
        {
            Message = Message;
        }
        public bool  Success { get; }
        public string Message { get; }
    }
}
