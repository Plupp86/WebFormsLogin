using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebFormsLogin.Model
{
	public class Repository
	{
		Entities entities = new Entities();


		public int GetUser(string userName)
		{

			var user = entities.Users
				.Where(u => u.UserName == userName)
				.FirstOrDefault();
			if (user == null)
			{
				return 0;
			}
			else
			{
				return user.Id;
			}

		}

		public bool CheckPassword(int id, string password)
		{
			var user = entities.Users
				.Where(u => u.Id == id)
				.FirstOrDefault();

			return user.Password == password;

		}
	}
}