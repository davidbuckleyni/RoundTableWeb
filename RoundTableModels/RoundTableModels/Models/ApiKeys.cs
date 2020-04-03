using System;
using System.Collections.Generic;
using System.Text;

namespace RoundTableAPIStandard.Models
{
	public class ApiKeys
	{
		public int Id { get; set; }
		public Guid ClientId { get; set; }
		public Guid ApiKey { get; set; }
		public int CustomerId { get; set; }
		public int LimitOfRequests { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }
		public bool isActive { get; set; }
		public bool isDeleted { get; set; }
		public DateTime CreatedBy { get; set; }
		public DateTime CreatedDate { get; set; }
	}
}
