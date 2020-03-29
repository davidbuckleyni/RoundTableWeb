using System;
using System.Collections.Generic;
using System.Text;

namespace RoundTableDal.Models
{
	public class WorksOrder
    {
        public int id { get; set; }
        public string CustomerAccountNumber { get; set; }
        public string WorksOrderNumber { get; set; }
        public DateTime DateDue { get; set; }
        public string Description { get; set; }
        public int WorksOrderLines { get; set; }
        public int Staffid { get; set; }
        public int Route { get; set; }
        public DateTime DateActionedFor { get; set; }
        public DateTime ActualActionedDate { get; set; }
        public string Signuature { get; set; }
        public string AccountNumber { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int AuthorizedBy { get; set; }
        public int CompeltedBy { get; set; }
        public bool isActive { get; set; }
        public bool isDeleted { get; set; }
    }
}