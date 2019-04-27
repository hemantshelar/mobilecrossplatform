using Microsoft.Azure.Mobile.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace xPlatAuction.Backend.DataObjects
{
	public class Comment : StorageData
	{
		public string CommentText { get; set; }
	}
}