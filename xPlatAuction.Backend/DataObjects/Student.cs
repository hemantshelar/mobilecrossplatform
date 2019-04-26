using Microsoft.Azure.Mobile.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace xPlatAuction.Backend.DataObjects
{
	public class Student : EntityData
	{
		public string Name { get; set; }
		public DateTime? DOB { get; set; }

		public ChildCareCenter Center { get; set; }
	}
}