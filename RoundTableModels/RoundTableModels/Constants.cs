using System;
using System.Collections.Generic;
using System.Text;

namespace RoundTableCore
{
    public static class Constants
    {
        public const string ApiKey = "ApiKey";

        public const string ClientSecret = "ClientSecret";

        public const string andriodAPi = "http://192.168.1.6:88/";

        public const string isoApi = "http://192.168.1.6:88/";

        public const string deskTopApiUrl = "http://192.168.1.6:63980/";


        public const string GetALlStock = "stock/";

        public const string FindKeys = "ApiKeys/Get";



        public const string UpdateStock = "Stock/UdpdateStock/";


        public const string GetAllWorksOrders = "Works/";

        public static string BuildUrl()
        {
            return "http://192.168.1.6:88/";


        }


    }
}
