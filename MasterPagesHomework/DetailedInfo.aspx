<%@ Page Title="DetailedInfo" Language="C#" MasterPageFile="~/Profile.Master" AutoEventWireup="true" CodeBehind="DetailedInfo.aspx.cs" Inherits="MasterPagesHomework.DetailedInfo" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="ProfileChildContent" runat="server">
	<h2 class="text-center">Detailed profile</h2>
	<div class="container well col-md-12">
		<div class="col-md-8">
			<label for="phone" id="phoneLabel">Phone:</label>
			<asp:TextBox ID="phone" runat="server" CssClass="form-control">phone...</asp:TextBox>
			<br />
			<label for="userCity" id="cityLabel">City:</label>
			<asp:TextBox ID="userCity" runat="server" CssClass="form-control">City...</asp:TextBox>
			<br />
			<label for="userAddress" id="addressLabel">Address:</label>
			<asp:TextBox ID="userAddress" runat="server" CssClass="form-control">Address...</asp:TextBox>
			<br />
			<label for="birthDate" id="birthDateLabel">Birth date:</label>
			<asp:TextBox ID="birthDate" runat="server" CssClass="form-control">Date...</asp:TextBox>
			<br />
			<label for="userSex" id="userSexLabel">Sex:</label>
			<asp:TextBox ID="userSex" runat="server" CssClass="form-control">Sex...</asp:TextBox>
			<br />
		</div>
		<div class="col-md-4">
			<label for="userFlavourText" id="userFlavourTextLabel">Flavour text:</label>
			<asp:TextBox ID="userFlavourText" runat="server" CssClass="form-control">Text...</asp:TextBox>
			<br />
		</div>
	</div>
</asp:Content>
