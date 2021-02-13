using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        // Get'ler contructor içinde set edilebilir
        public Result(bool success, string message):this(success)
        {
            Message = message;
        }

        public Result(bool success)
        {
             Success = success;
        }

        public bool Success { get; }

        public string Message { get; }
    }
}
