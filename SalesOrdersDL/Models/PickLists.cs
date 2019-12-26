using System;
using System.Collections.Generic;
using System.Text;

namespace RoundTableERPDal.Models
{
    public class PickLists
    {
        public int Id { get; set; } // int, not null
        public string Description { get; set; } // nchar(10), null
        public int? StockItemId { get; set; } // int, null
        public int? LocaitonId { get; set; } // int, null
        public int? UOM { get; set; } // int, null
        public bool? isActive { get; set; } // bit, null
        public bool? isDeleted { get; set; } // bit, null
        public DateTime? CreatedDate { get; set; } // date, null
        public string CreatedBy { get; set; } // nvarchar(150), null
    }

}
