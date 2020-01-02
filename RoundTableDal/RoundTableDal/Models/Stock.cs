using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;

namespace RoundTableERPDal
{
   

    public class Stock
    {
         public int ID { get; set; } // int, not null
            public string StockCode { get; set; } // nvarchar(150), null
            public string Name { get; set; } // nvarchar(350), not null
            public string Description { get; set; } // nvarchar(max), null
            public DateTime? StartDate { get; set; } // datetime, null
            public DateTime? EndDate { get; set; } // datetime, null
            public int? WarehouseId { get; set; } // int, null
            public int? IsFreeText { get; set; } // int, null
            public decimal? QuanityInStock { get; set; } // decimal(18,5), null
            public decimal? RecordedQuantity { get; set; } // decimal(18,5), null
            public bool? UseDescription { get; set; } // bit, null
            public string Barcode { get; set; } // nvarchar(50), null
            public int? ProductGroup { get; set; } // int, null
            public int? TaxCode { get; set; } // int, null
              public decimal? PhysicalStock { get; set; } // decimal(18,5), null
            public decimal? ActualStock { get; set; } // decimal(18,5), null
            public bool? isActive { get; set; } // bit, null
            public bool? isDeleted { get; set; } // bit, null
            public DateTime? CreatedDate { get; set; } // datetime, null
            public string CreatedBy { get; set; } // varchar(100), null
            public string UOM { get; set; } // nvarchar(50), null
        }
     
}
