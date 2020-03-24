using System;
using System.Collections.Generic;
using System.Security.AccessControl;
using System.Text;

namespace RoundTableDal.Models
{
    public class Documents
    {
        public int Id { get; set; }

        
        public string DoucmentNumber { get; set; }
        public string AccountNumber { get; set; }
        public string Number { get; set; }

        public int Notes { get; set; }
        public string Description { get; set; }
        public int Type { get; set; }
        public DateTime? Date { get; set; }
        public int Printed { get; set; }
        public int Status { get; set; }
        public int CustomerId { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public DateTime? PromisedDeliveryDate { get; set; }
        public int WarehouseId { get; set; }
        public int CurrencyIdi { get; set; }
        public decimal ExchangeRate { get; set; }
        public decimal TotalNet { get; set; }
        public decimal TotoalGross { get; set; }
        public bool UseInvoiceAddress { get; set; }
        public bool PaymentWithOrder { get; set; }
        public string PaymentReference { get; set; }
        public int SettlmentDaysAllowed { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int Priority { get; set; }
        public string ExternalReference { get; set; }
        public bool DespatchReady { get; set; }
        public bool AllocationReady { get; set; }
        public int AllocationStatus { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }

       
    }
}
