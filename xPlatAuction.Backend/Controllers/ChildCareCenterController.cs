using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.OData;
using Microsoft.Azure.Mobile.Server;
using xPlatAuction.Backend.DataObjects;
using xPlatAuction.Backend.Models;

namespace xPlatAuction.Backend.Controllers
{
    public class ChildCareCenterController : TableController<ChildCareCenter>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            MobileServiceContext context = new MobileServiceContext();
            DomainManager = new EntityDomainManager<ChildCareCenter>(context, Request);
        }

        // GET tables/ChildCareCenter
        public IQueryable<ChildCareCenter> GetAllChildCareCenter()
        {
            return Query(); 
        }

        // GET tables/ChildCareCenter/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<ChildCareCenter> GetChildCareCenter(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/ChildCareCenter/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<ChildCareCenter> PatchChildCareCenter(string id, Delta<ChildCareCenter> patch)
        {
             return UpdateAsync(id, patch);
        }

        // POST tables/ChildCareCenter
        public async Task<IHttpActionResult> PostChildCareCenter(ChildCareCenter item)
        {
            ChildCareCenter current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/ChildCareCenter/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteChildCareCenter(string id)
        {
             return DeleteAsync(id);
        }
    }
}
