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
			
		}

	

		public List<NewsItem> GetTheNews()
		{
			return _contentHandler.GetTheNews().OrderByDescending(n => n.Id).ToList();
		}

		//public IQueryable<NewsItem> GetNews([QueryString("Id")] int? categoryId)
		//{
		//	PopulateList();
		//	return news.AsQueryable<NewsItem>();
		//}
	}
}