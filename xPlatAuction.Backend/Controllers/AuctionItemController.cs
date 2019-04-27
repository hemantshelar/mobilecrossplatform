﻿using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.OData;
using Microsoft.Azure.Mobile.Server;
using xPlatAuction.Backend.DataObjects;
using xPlatAuction.Backend.DomainManager;
using xPlatAuction.Backend.Models;

namespace xPlatAuction.Backend.Controllers
{
    public class AuctionItemController : TableController<AuctionItem>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            MobileServiceContext context = new MobileServiceContext();
			DomainManager = new AuctionItemDomainManager(context, Request);
		}

        // GET tables/AuctionItemDBEntity
        public IQueryable<AuctionItem> GetAllAuctionItemDBEntity()
        {
            return Query(); 
        }

        // GET tables/AuctionItemDBEntity/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<AuctionItem> GetAuctionItemDBEntity(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/AuctionItemDBEntity/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<AuctionItem> PatchAuctionItemDBEntity(string id, Delta<AuctionItem> patch)
        {
             return UpdateAsync(id, patch);
        }

        // POST tables/AuctionItemDBEntity
        public async Task<IHttpActionResult> PostAuctionItemDBEntity(AuctionItem item)
        {
			AuctionItem current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/AuctionItemDBEntity/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteAuctionItemDBEntity(string id)
        {
             return DeleteAsync(id);
        }
    }
}
