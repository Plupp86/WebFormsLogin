using System;
using System.Data.Entity;
using System.Web.Security;

using System.Web.UI;

using WebFormsLogin.Model;

namespace WebFormsLogin
{
	public partial class SiteMaster : MasterPage
	{
		UserHandler _userHandler = new UserHandler();


		protected void Page_Load(object sender, EventArgs e)
		{
			userNameError.Style.Value = "display:none";
			passwordError.Style.Value = "display:none";

			if (Request.IsAuthenticated)
			{
				loggedIn.Visible = true;
				loggedOut.Visible = false;
			}
			else
			{
				loggedIn.Visible = false;
				loggedOut.Visible = true;
			}
		}


		protected void submit_Click(object sender, EventArgs e)
		{
			LoginResponse loginResponse = _userHandler.Login(userName.Value, password.Value);
			if (!loginResponse.UserNameExists)
			{
				userNameError.Style.Value = "display:block; color: red;";
				snlogin.Style.Value = "display: block;";

			}
			else if (!loginResponse.PasswordMatch)
			{
				passwordError.Style.Value = "display:block; color: red;";
				snlogin.Style.Value = "display: block;";
			}
			else
			{
				FormsAuthentication.RedirectFromLoginPage(userName.Value, true);
			}
		}
	}
}