using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RoundTableAPILib;
using RoundTableERPDal;
using RoundTableERPDal.Models;
using RoundTableERPDal.Models;
namespace RoundTableWeb.Api.Stock
{
    public class StockServices
    {
        public RoundTableERPContext db { get; set; }
       
        public HttpClient Client { get; }

     
        private void UpdateStock(RoundTableERPDal.Stock _stock)
        {
            db.UpdateStockItem(_stock);
        }

        private void DeleteStock(RoundTableERPDal.Stock _stock)
        {
            db.DeleteStockItem(_stock);
        }
    }
}
