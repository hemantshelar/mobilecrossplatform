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
    public class LikeController : TableController<Like>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            MobileServiceContext context = new MobileServiceContext();
            DomainManager = new EntityDomainManager<Like>(context, Request);
        }

        // GET tables/Like
        public IQueryable<Like> GetAllLike()
        {
            return Query(); 
        }

        // GET tables/Like/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<Like> GetLike(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/Like/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<Like> PatchLike(string id, Delta<Like> patch)
        {
             return UpdateAsync(id, patch);
        }

        // POST tables/Like
        public async Task<IHttpActionResult> PostLike(Like item)
        {
            Like current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/Like/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteLike(string id)
        {
             return DeleteAsync(id);
        }
    }
}
