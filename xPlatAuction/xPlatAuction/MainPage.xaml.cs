using Microsoft.WindowsAzure.MobileServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using xPlatAuction.Models;

namespace xPlatAuction
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

		private async void Button_Clicked(object sender, EventArgs e)
		{
			this.message.Text = "test!!";
			try
			{
				MobileServiceClient mobileServiceClient = new MobileServiceClient("https://xplatauctionhemant.azurewebsites.net");
				var items = await mobileServiceClient.GetTable<TodoItem>().ReadAsync(); ;
				var item = items.First();
				this.message.Text = item.Text;
			}
			catch (Exception ex)
			{
				throw ex;
			}
			
			//this.message.Text = 
		}
	}
}
