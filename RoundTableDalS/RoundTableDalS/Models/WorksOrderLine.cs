using System;
using System.Collections.Generic;
using System.Text;

namespace RoundTableDal.Models
{
	public class WorksOrderLine
    {
        public int id { get; set; }
        public string WorksOrderNumber { get; set; }
        public string SalesOrderNumber { get; set; }
        public string Item { get; set; }
        public int Qty { get; set; }
        public int ComponenetRequired { get; set; }
        public int CompletedBy { get; set; }
        public DateTime CompletedDate { get; set; }
        public bool CustomerApproved { get; set; }
        public string CustomerNotes { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
