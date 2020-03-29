using System;
using System.Collections.Generic;
using System.Text;

namespace RoundTableDal.Models
{
    public class Locations
    {
        public int Id { get; set; } // int, not null
        public string Code { get; set; } // nvarchar(50), null
        public string Description { get; set; } // nvarchar(max), null
        public bool? IsActive { get; set; } // bit, null
        public bool? IsDeleted { get; set; } // bit, null
        public string CreatedBy { get; set; } // nvarchar(50), null
        public DateTime? CreatedDate { get; set; } // datetime, null
        public int? MainAddress { get; set; } // int, null
        public int? DeliveryAddress { get; set; } // int, null
    }

}
