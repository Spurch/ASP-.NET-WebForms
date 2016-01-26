<%@ Page Title="BasicInfo" Language="C#" MasterPageFile="~/Profile.Master" AutoEventWireup="true" CodeBehind="BasicInfo.aspx.cs" Inherits="MasterPagesHomework.BasicInfo" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="ProfileChildContent" runat="server">
    <h2 class="text-center">Profile Basic details</h2>
	<div class="container well col-md-12">
			<div class="col-md-8">
				<label for="userName" id="userNameLabel">Username:</label>
				<asp:TextBox ID="userName" runat="server" CssClass="form-control">Username...</asp:TextBox>
				<br />
				<label for="firstName" id="firstNameLabel">First name:</label>
				<asp:TextBox ID="firstName" runat="server" CssClass="form-control">First name...</asp:TextBox>
				<br />
				<label for="lastName" id="lastNameLabel">Last name:</label>
				<asp:TextBox ID="lastName" runat="server" CssClass="form-control">Last name...</asp:TextBox>
				<br />
				<label for="email" id="emailLabel">E-mail:</label>
				<asp:TextBox ID="email" runat="server" CssClass="form-control">E-mail...</asp:TextBox>
				<br />
			</div>
		<div class="col-md-4">
			<p>This is how I feel when looking at Web Forms</p>
			<asp:Image ID="userAvatar" class="img-thumbnail" runat="server"/>
		</div>
	</div>
</asp:Content>
