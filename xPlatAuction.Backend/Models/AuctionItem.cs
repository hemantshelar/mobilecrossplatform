﻿using Microsoft.Azure.Mobile.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace xPlatAuction.Backend.Models
{
	public class AuctionItem : EntityData
	{
		public string Name { get; set; }
		public string  Description { get; set; }

		public double StartingBid { get; set; }
		public double CurrentBid { get; set; }
		public string AuctionId { get; set; }

	}
}