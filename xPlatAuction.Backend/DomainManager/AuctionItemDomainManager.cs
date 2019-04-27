using Microsoft.Azure.Mobile.Server;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Http.OData;
using xPlatAuction.Backend.DataObjects;
using xPlatAuction.Backend.Models;

namespace xPlatAuction.Backend.DomainManager
{
	public class AuctionItemDomainManager : MappedEntityDomainManager<AuctionItem, AuctionItemDBEntity> 
	{
		public AuctionItemDomainManager(DbContext context , HttpRequestMessage request) : base(context,request)
		{

		}

		public override IQueryable<Models.AuctionItem> Query()
		{
			return base.Query();
		}
		public override Task<bool> DeleteAsync(string id)
		{
			throw new NotImplementedException();
		}

		public override SingleResult<Models.AuctionItem> Lookup(string id)
		{
			return base.LookupEntity(a => a.Id == id);
		}

		public override Task<Models.AuctionItem> UpdateAsync(string id, Delta<Models.AuctionItem> patch)
		{
			return base.UpdateEntityAsync(patch, id);
		}
	}
}