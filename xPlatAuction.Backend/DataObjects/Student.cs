using Microsoft.Azure.Mobile.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace xPlatAuction.Backend.DataObjects
{
	public class Student : EntityData
	{
		public string Name { get; set; }
		public DateTime? DOB { get; set; }

		[Column("Center_Id")]
		public string CenterId { get; set; }
		[ForeignKey("CenterId")]
		public ChildCareCenter Center { get; set; }
	}
}