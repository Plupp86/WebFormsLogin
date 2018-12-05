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
				Id = 5,
				Author = "Christofer",
				Date = DateTime.Now,
				Content = "Yet another supersecret is revealed. Stay logged in to be sure not to miss any more news.",
				Secret = true,
				Header = "Super Secret"
			},
			new NewsItem
			{
				Id = 4,
				Author = "Christofer",
				Date = DateTime.Now,
				Content = "Another top secret news post!",
				Secret = true,
				Header = "More secrets"
			},
			new NewsItem
			{
				Id = 3,
				Author = "Christofer",
				Date = DateTime.Now,
				Content = "The Secret News Page is now ready to go live!",
				Secret = false,
				Header = "Going live"
			},
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

		public List<NewsItem> GetPublicNews()
		{
			return news
				.Where(n => n.Secret == false)
				.ToList();
		}
	}
}