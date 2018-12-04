using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebFormsLogin.Model;

namespace WebFormsLogin
{
	public partial class News : Page
	{
		ContentHandler _contentHandler = new ContentHandler();

		protected void Page_Load(object sender, EventArgs e)
		{
			if (Request.IsAuthenticated)
			{
				AuthenticatedMessagePanel.Visible = true;
				AnonymousMessagePanel.Visible = false;
				NewsMessage.Text = "<h3>You are logged in as " + User.Identity.Name + "!</h3>";
			}
			else
			{
				AuthenticatedMessagePanel.Visible = false;
				AnonymousMessagePanel.Visible = true;
				NewsMessage.Text = "<h3>You need to log in to see the top secret news!</h3>";
			}
		}



		public List<NewsItem> GetTheNews()
		{
			return _contentHandler.GetTheNews().OrderByDescending(n => n.Id).ToList();
		}

		public List<NewsItem> GetPublicNews()
		{
			return _contentHandler.GetPublicNews().OrderByDescending(n => n.Id).ToList();
		}

		//public IQueryable<NewsItem> GetNews([QueryString("Id")] int? categoryId)
		//{
		//	PopulateList();
		//	return news.AsQueryable<NewsItem>();
		//}
	}
}