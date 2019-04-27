using Microsoft.Azure.Mobile.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace xPlatAuction.Backend.DataObjects
{
	public class Bid : EntityData
	{
		public double BidAmount { get; set; }
		public string Bidder { get; set; }

		[Column("AuctionItem_Id")]
		public string AuctionItemId { get; set; }

		[ForeignKey("AuctionItemId")]
		public virtual AuctionItemDBEntity AuctionItem { get; set; }
	}
}