using System;
using System.Collections.Generic;
using System.Text;

namespace RoundTableERPDal.Models
{
    public class DocumentLines
    {
        public int Id { get; set; }

        public string DocumentNumber { get; set; }
        public int DocumentId { get; set; }
        public int WarehouseLocation { get; set; }
        public string StockCode { get; set; }
        public string Description { get; set; }
        public bool UseDescription { get; set; }
        public decimal Quantity { get; set; }
        public decimal TotalValue { get; set; }
        public decimal SellingPrice { get; set; }
        public bool OveridePrice { get; set; }
        public decimal DiscountPrice { get; set; }
        public decimal CostPrice { get; set; }
        public decimal DiscountPercent { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public DateTime? DeliveyDateRequested { get; set; }
        public bool ShowOnReports { get; set; }
        public decimal AllocatedQuantity { get; set; }
        public decimal DespatchedQuantity { get; set; }
        public int AllocatedStatus { get; set; }
        public string PricingDescription { get; set; }
        public string FreeTextDescription { get; set; }
        public string Reference { get; set; }
        public string SecondReference { get; set; }
        public Guid TraceAbilityId { get; set; }
        public bool IsFreeTextItem { get; set; }
        public int Status { get; set; }
        public bool isActive { get; set; }
        public bool isDeleted { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
