using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebFormsLogin.Model
{
	public class UserHandler
	{
		Repository rep = new Repository();

		internal LoginResponse Login(string userName, string password)
		{
			var answer = new LoginResponse()
			{
				UserNameExists = false,
				PasswordMatch = false
			};

			int userId = rep.GetUser(userName);

			if (userId == 0)
			{
				return answer;
			}
			else
			{
				answer.UserNameExists = true;
				if (rep.CheckPassword(userId, password))
				{
					answer.PasswordMatch = true;
				}
				return answer;
			}
		}
	}
}