﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RoundTableDal.Models;
using Dapper;
using DapperExtensions;
using Microsoft.Extensions.Options;
using System.Configuration;
using System.Data.SqlClient;

namespace RoundTableDal
{
    /// <summary>
    /// Defines the <see cref="OMSContext" />
    /// </summary>
    public class RoundTableERPContext
    {
        AppConfiguration appconfig = new AppConfiguration();
        public string constr { get; set; }

        private readonly ConnectionStringConfig config;

        private string schemaDefination = "dbo";

        public RoundTableERPContext()
        {
            constr = appconfig.ConnectionString;
        }

        /// <summary>
        /// Gets or sets the constr
        /// </summary>
        /// <summary>
        /// Initializes a new instance of the <see cref="OMSContext"/> class.
        /// </summary>
        /// <summary>
        /// Defines the DocumentType
        /// </summary>
        public enum DocumentType
        {
            /// <summary>
            /// Defines the Orders
            /// </summary>
            Orders = 0,

            /// <summary>
            /// Defines the Quotes
            /// </summary>
            Quotes = 1,

            Jobs = 2
        }

        public void UpdateWorkOrder(WorksOrder workOrder)
        {
            using (var connection = new SqlConnection(constr))
            {
                connection.Open();
                connection.UpdateAsync(workOrder);
            }
        }
        
        public List<WorksOrder> GetWorksOrderNumberByAccountNumber(string customerAccountNumber)
        {
            using (var connection = new SqlConnection(constr))
            {
                return connection.Query<WorksOrder>($"SELECT * FROM {schemaDefination}.[WorksOrder] where WorksOrderNumber=@customerAccountNumber",
                    new { WorksOrderNumber = customerAccountNumber }).ToList();
            }
        }
        public WorksOrder GetWorksOrderByWorkOrderNumber(string worksOrderNumber)
        {
            using (var connection = new SqlConnection(constr))
            {
                return connection.Query<WorksOrder>($"SELECT * FROM {schemaDefination}.[WorksOrder] where WorksOrderNumber=@WorksOrderNumber",
                    new { WorksOrderNumber = worksOrderNumber }).FirstOrDefault();
            }
        }

        public Stock GetSingleItemByBarCode(string barCode)
        {
            using (var connection = new SqlConnection(constr))
            {
                return connection.Query<Stock>($"SELECT * FROM {schemaDefination}.[STOCK] where BarCode=@BarCode",
                    new {BarCode = barCode}).FirstOrDefault();
            }
        }


        public Stock GetSingleItemByStockCode(string stockCode)
        {
            using (var connection = new SqlConnection(constr))
            {
                return connection.Query<Stock>($"SELECT * FROM {schemaDefination}.[STOCK] where StockCode=@StockCode",
                    new {StockCode = stockCode}).FirstOrDefault();
            }
        }

        public List<Locations> GetAllLocations()
        {
            List<Locations> results = new List<Locations>();
            using (var connection = new SqlConnection(constr))
            {
                return connection.Query<Locations>($"SELECT * FROM {schemaDefination}.[Locations]").ToList();
            }
        }

        public List<Customer> GetSingleCustomerById(int CustomerId)
        {
            List<Customer> results = new List<Customer>();
            using (var connection = new SqlConnection(constr))
            {
                return connection.Query<Customer>($"SELECT * FROM {schemaDefination}.[Customer] where ID={CustomerId}")
                    .ToList();
            }
        }

        public List<Customer> GetAllCustomers()
        {
            using (var connection = new SqlConnection(constr))
            {
                return connection.Query<Customer>("SELECT * FROM {schemaDefination}.[Customer]").ToList();
            }
        }

        public Customer GetSingleCustomerByCustomerId(int CustomerId)
        {
            using (var connection = new SqlConnection(constr))
            {
                return connection.QuerySingle<Customer>(
                    $"SELECT * FROM {schemaDefination}.[Customer] where ID={CustomerId}");
            }
        }

        public LocationsItem FindLocationItem(string StockCode)
        {
            using (var connection = new SqlConnection(constr))
            {
                return connection
                    .Query<LocationsItem>(
                        $"SELECT * FROM {schemaDefination}.[LocationsItem] where StockCode={StockCode}")
                    .FirstOrDefault();
            }
        }

        public List<PickLists> GetAllPickingListItems(string PickListName)
        {
            using (var connection = new SqlConnection(constr))
            {
                return connection.Query<PickLists>($"SELECT * FROM {schemaDefination}.[LocationsItem]").ToList();
            }
        }

        public List<Stock> GetAlLStock()
        {
            List<Stock> results = new List<Stock>();
            using (var connection = new SqlConnection(constr))
            {
                return connection.Query<Stock>("SELECT * FROM {schemaDefination}.[STOCK]").ToList();
            }
        }

        /// <summary>
        /// The GetNextOrderNumber
        /// </summary>
        /// <param name="orderType">The orderType<see cref="DocumentType"/></param>
        /// <returns>The <see cref="string"/></returns>
        public string GetNextOrderNumber(DocumentType orderType)
        {
            int result = 0;
            using (var connection = new SqlConnection(constr))
            {
                result = connection.ExecuteScalar<int>(
                    $"select [OderNumber] from {schemaDefination}.[OrderNumber] where [Type]=" + (int) orderType);
            }

            return string.Format("O-{000000}", result);
        }

        /// <summary>
        /// The UpdateSalesOrder
        /// </summary>
        /// <param name="Order">The Order<see cref="Documents"/></param>
        public void UpdateSalesOrder(Documents Order)
        {
            using (var connection = new SqlConnection(constr))
            {
                connection.UpdateAsync(Order);
            }
        }

        public void UpdateLocationItem(LocationsItem itemLocation)
        {
            using (var connection = new SqlConnection(constr))
            {
                connection.Open();
                connection.UpdateAsync(itemLocation);
            }
        }

        public void AddLocationItem(LocationsItem itemLocation)
        {
            using (var connection = new SqlConnection(constr))
            {
                connection.Open();
                connection.InsertAsync(itemLocation);
            }
        }

        /// <summary>
        /// The AddSalesOrder
        /// </summary>
        /// <param name="Order">The Order<see cref="Documents"/></param>
        public void AddSalesOrder(Documents Order)
        {
            using (var connection = new SqlConnection(constr))
            {
                connection.Open();
                connection.Insert(Order);
            }
        }

        public void AddLocationItem(Customer customer)
        {
            using (var connection = new SqlConnection(constr))
            {
                connection.Open();
                connection.Insert(customer);
            }
        }

        /// <summary>
        /// The AddCustomer
        /// </summary>
        /// <param name="customer">The customer<see cref="CustomerModel"/></param>
        public void AddCustomer(Customer customer)
        {
            using (var connection = new SqlConnection(constr))
            {
                connection.Open();
                connection.Insert(customer);
            }
        }

        /// <summary>
        /// The UpdateStockItem
        /// </summary>
        /// <param name="item">The item<see cref="Stock"/></param>
        public async Task<int> UpdateStockItem(Stock item)
        {
            using (var connection = new SqlConnection(constr))
            {
                connection.UpdateAsync(item);
                return 200;
            }
        }

        public bool DeleteStockItem(Stock item)
        {
            using (var connection = new SqlConnection(constr))
            {
                Task<bool> isDeleted = connection.DeleteAsync(item);

                return isDeleted.Result;
            }
        }

        /// <summary>
        /// The AddStockItem
        /// </summary>
        /// <param name="item">The item<see cref="Stock"/></param>
        public bool AddStockItem(Stock item)
        {
            using (var connection = new SqlConnection(constr))
            {
                connection.InsertAsync(item);
                return true;
            }
        }

        /// <summary>
        /// The AddDocumentLines
        /// </summary>
        /// <param name="lines">The lines<see cref="DocumentLines"/></param>
        public void AddDocumentLines(DocumentLines lines)
        {
            using (var connection = new SqlConnection(constr))
            {
                connection.InsertAsync(lines);
            }
        }
    }
}