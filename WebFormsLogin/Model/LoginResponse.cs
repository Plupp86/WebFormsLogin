using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebFormsLogin.Model
{
	public class LoginResponse
	{
		public bool UserNameExists { get; set; }
		public bool PasswordMatch { get; set; }
	}
}