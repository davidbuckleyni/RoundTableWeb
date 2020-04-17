using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace RoundTableWeb.Api.Classes {
    public class Singleton {
        private HttpClient httpclient;
        public Singleton() {
            httpclient = new HttpClient();
        }
    }
}
