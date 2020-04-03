using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;
using RoundTableAPILib.Models;
using RoundTableCore;
using RoundTableDal.Models;

namespace RoundTableAPILib
{
    public class RoundTableAPIClient
    {



        private readonly HttpClient _httpClient;
        private readonly string _remoteServiceBaseUrl;
        public string ApiUrl { get; set; }

        public device DeveiceType { get; set; }
        public enum device 
        {
            Desktop = 1,
            Phone =2            

        }


        List<ErrorObject> errors = new List<ErrorObject>();


        public RoundTableAPIClient()
        {
            _httpClient = new HttpClient();

            if (DeveiceType == device.Desktop)
                ApiUrl = Constants.deskTopApiUrl;
            else
                ApiUrl = Constants.BuildUrl();

        }

        public void Token()
        {



        }


     
        /// <summary>
        /// Posts the update settings.
        /// </summary>
        /// <param name="transfer">The transfer.</param>
        /// <returns>Task&lt;System.Int32&gt;.</returns>
        public async Task<int> PostUpdateStock(Stock _stock)
        {

            var uri = new Uri(string.Format(ApiUrl + Constants.UpdateStock, string.Empty));


            var json = JsonConvert.SerializeObject(_stock);
            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");

            // Do the actual request and await the response
            var httpResponse = await _httpClient.PostAsync(Constants.UpdateStock, httpContent);

            return 1;



        }

        public async Task<List<WorksOrderModel>> GetAllWorksOrder(string ApiUrl)
        {
            List<WorksOrderModel> _result = new List<WorksOrderModel>();
            var test = Constants.GetAllWorksOrders;
            var uri = new Uri(string.Format(ApiUrl + Constants.GetAllWorksOrders, string.Empty));

            var response = await _httpClient.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                var byteArray = await response.Content.ReadAsByteArrayAsync();

                var content = Encoding.UTF8.GetString(byteArray, 0, byteArray.Length);
                _result = JsonConvert.DeserializeObject<List<WorksOrderModel>>(content);
            }

            return _result.ToList();
        }

        /// <summary>
        /// Gets the stock take names.
        /// </summary>
        /// <returns>Task&lt;List&lt;StockTakeNames&gt;&gt;.</returns>
        public async Task<List<Stock>> GetStockFromApi(){
            List<Stock> _result = new List<Stock>();

            var uri = new Uri(string.Format(ApiUrl +  Constants.GetALlStock, string.Empty));

            var response = await _httpClient.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                var byteArray = await response.Content.ReadAsByteArrayAsync(); 

                var content = Encoding.UTF8.GetString(byteArray, 0, byteArray.Length);
                _result = JsonConvert.DeserializeObject<List<Stock>>(content);
            }

            return _result.ToList();
        }


        // Handle Error

    }
}
