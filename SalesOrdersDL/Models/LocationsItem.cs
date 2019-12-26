using System;
using System.Collections.Generic;
using System.Text;

namespace RoundTableERPDal.Models
{
    public class LocationsItem
    {
        public int Id { get; set; } // int, not null
        public int? LocationId { get; set; } // int, null
        public string StockCode { get; set; } // nvarchar(100), null
        public decimal? QtyInStock { get; set; } // decimal(18,5), null
        public DateTime? LastSale { get; set; } // datetime, null
        public decimal? MinStockLevel { get; set; } // decimal(18,5), null
        public decimal? MaxStockLeval { get; set; } // decimal(18,5), null
        public DateTime? LastStockCount { get; set; } // datetime, null
        public string CreatedBy { get; set; } // nvarchar(50), null
        public DateTime? CreatedDate { get; set; } // datetime, null
        public bool? IsDeleted { get; set; } // bit, null
        public bool? IsActive { get; set; } // bit, null
    }

}