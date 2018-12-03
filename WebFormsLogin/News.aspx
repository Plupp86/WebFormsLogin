<%@ Page Title="News" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="News.aspx.cs" Inherits="WebFormsLogin.News" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
	<div class="sn-main">
		<div class="sn-news">
			<h2>The latest news</h2>


			<p>To see the really secret news you need to log in.</p>



			<div class="sn-news-list">

				<%
					var news_list = GetTheNews();

					foreach (var item in news_list)
					{
						if (item.Secret)
						{
							Response.Write("<div class='sn-secret'>");
						}
						Response.Write("<div class='sn-news-item'>" +
							"<span class='sn-news-header'>" +item.Header + "</span>" +
							"<span class='sn-news-date'>" +item.Date.ToShortDateString() +"</span>" +
							"<div class='sn-news-content'>" +
							"<p>" +item.Content +"</p>" +
							"</div></div>");
						if (item.Secret)
						{
							Response.Write("</div>");
						}
					}

				%>

			</div>
		</div>
	</div>
</asp:Content>
