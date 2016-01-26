<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="WebFormsSampleApp.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
	<div class="jumbotron">
		<div class="well text-center">
			<h1>First ASP .NET WebForms Homework</h1>
			<asp:Label runat="server" id="httpSubTitleLabel"></asp:Label>
		</div>
    </div>
	<div class="well">
		<div class="row">
			<div>
				<asp:TextBox runat="server" ID="MyTextBox"></asp:TextBox>
				<asp:Button runat="server" OnClick="httpButton_Click" Text="Change text"/>
				<asp:Image runat="server" ID="MyTextImage" />
			</div>
		</div>
	</div>
</asp:Content>
