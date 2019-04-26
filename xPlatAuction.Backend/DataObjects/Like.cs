using Microsoft.Azure.Mobile.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace xPlatAuction.Backend.DataObjects
{
	public class Like : EntityData
	{
		public int Reaction { get; set; }
		public Parent Parent { get; set; }
		public DateTime? Time { get; set; }
	}
}