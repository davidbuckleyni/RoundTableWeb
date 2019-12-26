using System;
using System.Collections.Generic;
using System.Text;

namespace RoundTableERPDal.Models
{
    public class Customer
    {
        public int ID { get; set; }
        public string AccountNumber { get; set; }
        public string CustomerName { get; set; }
        public int DefaultCollectionAddressID { get; set; }
        public int DefaultDeliveryAddressID { get; set; }
        public string Email { get; set; }
        public string Telephone1 { get; set; }
        public string Telephone2 { get; set; }
        public string Fax { get; set; }
        public bool OnHold { get; set; }
        public int SysTaxRateID { get; set; }
        public decimal CreditLimit { get; set; }
        public DateTime DateTimeLastModified { get; set; }
        public int Department { get; set; }
        public int DepartmentID { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public string AddressLine4 { get; set; }
        public string AddressLine5 { get; set; }
        public string MainEmail { get; set; }
        public string County { get; set; }
        public string PostCode { get; set; }
        public string DeliveryAddressLine1 { get; set; }
        public string DeliveryAddressLine2 { get; set; }
        public string DeliveryAddressLine3 { get; set; }
        public string DeliveryCounty { get; set; }
        public string DeliveryPostCode { get; set; }
        public string DeliveryEmail { get; set; }
        public bool IsDummy { get; set; }
        public string Website { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public bool isActive { get; set; }
        public bool isDeleted { get; set; }
    }
}
