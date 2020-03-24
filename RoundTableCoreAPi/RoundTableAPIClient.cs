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

        List<ErrorObject> errors = new List<ErrorObject>();

        public RoundTableAPIClient()
        {
            _httpClient = new HttpClient();

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

            var uri = new Uri(string.Format(  Constants.UpdateStock, string.Empty));


            var json = JsonConvert.SerializeObject(_stock);
            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");

            // Do the actual request and await the response
            var httpResponse = await _httpClient.PostAsync(Constants.UpdateStock, httpContent);

            return 1;



        }

        public async Task<List<WorksOrder>> GetWorksOrder()
        {
            List<WorksOrder> _result = new List<WorksOrder>();

            var uri = new Uri(string.Format(Constants.GetALlStock, string.Empty));

            var response = await _httpClient.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                var byteArray = await response.Content.ReadAsByteArrayAsync();

                var content = Encoding.UTF8.GetString(byteArray, 0, byteArray.Length);
                _result = JsonConvert.DeserializeObject<List<WorksOrder>>(content);
            }

            return _result.ToList();
        }

        /// <summary>
        /// Gets the stock take names.
        /// </summary>
        /// <returns>Task&lt;List&lt;StockTakeNames&gt;&gt;.</returns>
        public async Task<List<Stock>> GetStockFromApi(){
            List<Stock> _result = new List<Stock>();

            var uri = new Uri(string.Format(Constants.GetALlStock, string.Empty));

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
