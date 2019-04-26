using Microsoft.Azure.Mobile.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace xPlatAuction.Backend.DataObjects
{
	public class Parent : EntityData
	{
		public string Name { get; set; }
		public string ContactNumber { get; set; }

		[Column("Center_Id")]
		public string CenterId { get; set; }
		[ForeignKey("CenterId")]
		public Student Sudent { get; set; }
	}
}