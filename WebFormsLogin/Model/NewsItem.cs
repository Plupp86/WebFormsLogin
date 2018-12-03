using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebFormsLogin.Model
{
	public class NewsItem
	{
		public int Id { get; set; }
		public string Author { get; set; }
		public DateTime Date { get; set; }
		public string Content { get; set; }
		public bool Secret { get; set; }
		public string Header { get; set; }
	}
}