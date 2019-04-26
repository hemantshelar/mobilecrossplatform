using Microsoft.Azure.Mobile.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace xPlatAuction.Backend.DataObjects
{
	public class Post : EntityData
	{
		public string Description { get; set; }
		public Student Student { get; set; }
		public ChildCareCenter Center { get; set; }
		public List<Like> Likes { get; set; }
	}
}