using Microsoft.Azure.Mobile.Server;
using Microsoft.Azure.Mobile.Server.Swagger;
using Swashbuckle.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Description;

namespace xPlatAuction.Backend
{
	public partial class Startup
	{
		public static void ConfigureSwagger(HttpConfiguration config)
		{
			config.Services.Replace(typeof(IApiExplorer),new MobileAppApiExplorer(config));
			config.EnableSwagger(c =>
			{
				c.SingleApiVersion("v1", "v1.1 APIs");

				//Tells the Swagger doc that any MobileAppController needs a 
				//ZUMO-API-VERSION header with default 2.0.0
				c.OperationFilter<MobileAppHeaderFilter>();

				//Looks at attributes on properties to decide weather they are re
				//Right now, this only applies to the DatabaseGeneratedAttribute.
				c.SchemaFilter<MobileAppSchemaFilter>();
			}).EnableSwaggerUi();

		}

	}
}