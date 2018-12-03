using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebFormsLogin.Model
{
	public class ContentHandler
	{
		private List<NewsItem> news = new List<NewsItem>()
		{
			new NewsItem
			{
				Id = 2,
				Author = "Christofer",
				Date = DateTime.Now,
				Content = "This is another news item. This is a secret broadcast. Don't tell anyone!",
				Secret = true,
				Header = "Second News"
			},
			new NewsItem
			{
				Id = 1,
				Author = "Chris",
				Date = DateTime.Now,
				Content = "This is a news item. The first one ever reported!",
				Secret = false,
				Header = "First News"
			}
		};

		public List<NewsItem> GetTheNews()
		{
			return news;
		}
	}
}