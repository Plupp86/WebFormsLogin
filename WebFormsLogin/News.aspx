<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="News.aspx.cs" Inherits="WebFormsLogin.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
	<div class="sn-main">
		<div class="sn-news">
			<h2>The latest news</h2>
			<p>To see the really secret news you need to log in.</p>
			<div class="sn-news-list">


				<div class="sn-news-item">
					<span class="sn-news-header">News Title
					</span>
					<span class="sn-news-date">2018-12-03
					</span>
					<div class="sn-news-content">
						<p>
							Here be the secret news in all its glory!
						</p>
					</div>
				</div>

				<div class="sn-secret">
					<div class="sn-news-item">

						<span class="sn-news-header">News Title
						</span>
						<span class="sn-news-date">2018-12-03
						</span>
						<div class="sn-news-content">
							<p>
								Here be the secret news in all its glory!
							</p>
						</div>

					</div>
				</div>

			</div>
		</div>
	</div>
</asp:Content>
