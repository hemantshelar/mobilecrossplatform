using System.Collections;
using System.Collections.Generic;
using System.Web.Http;
using Microsoft.Azure.Mobile.Server.Config;
using xPlatAuction.Backend.DataObjects;
using xPlatAuction.Backend.Models;
using System.Linq;
namespace xPlatAuction.Backend.Controllers
{
    [MobileAppController]
    public class MyItemsController : ApiController
    {
        // GET api/MyItems
        public IEnumerable<MyAuctionItem> Get()
		{
			MobileServiceContext context = new MobileServiceContext();
			var result = from ai in context.AuctionItemDBEntities
						 select new MyAuctionItem
						 {
							 Id = ai.Id,
							 Name = ai.Name,
							 Description = ai.Description,
							 CurrentBid = ai.Bids.Count == 0 ? 0 : ai.Bids.Max( b => b.BidAmount),
							 MyHighestBid = 0//Will fix latter
						 };
			return result;
		}
    }
}
