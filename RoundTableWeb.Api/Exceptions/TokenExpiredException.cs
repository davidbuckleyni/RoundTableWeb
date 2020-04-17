using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoundTableWeb.Api.Exceptions {
    public class TokenExpiredException : Exception {
        public TokenExpiredException()
            : base("The token has expired") {
        }
    }
}
