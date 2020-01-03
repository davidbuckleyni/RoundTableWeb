using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RoundTableAPILib;
using RoundTableDal;
using RoundTableERPDal;

namespace RoundTableWeb.Api.Stock
{
    public class StockServices
    {
        public RoundTableERPContext db { get; set; }
       
        public HttpClient Client { get; }

     
        private void UpdateStock(RoundTableDal.Models.Stock _stock)
        {
            db.UpdateStockItem(_stock);
        }

        private void DeleteStock(RoundTableDal.Models.Stock _stock)
        {
            db.DeleteStockItem(_stock);
        }
    }
}
