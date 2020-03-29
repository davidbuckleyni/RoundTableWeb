using System;
using System.Collections.Generic;
using System.Text;

namespace RoundTableAPILib.Models
{
    public class ErrorObject : Exception
    {
        public int StatusCode { get; set; }

        public string Content { get; set; }

    }
}
