using Microsoft.Azure.Mobile.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace xPlatAuction.Backend.DataObjects
{
	public class Parent : EntityData
	{
		public string Name { get; set; }
		public string ContactNumber { get; set; }
		public Student Sudent { get; set; }
	}
}