using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        public Result(bool success, string message):this(success)
        {
            // Getter' lar ReadOnly'dir. Ve ReadOnly'ler constructor'larda set edilebilir!!
            Massage = message;
        }

        public Result(bool success)
        {
            Success = success;
        }

        public bool Success { get; }

        public string Massage { get; }
    }
}
