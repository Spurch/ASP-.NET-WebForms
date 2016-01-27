<%@ Page Title="Profile" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="DataBindingHomeWork.Profile" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
	<div class="container well">
		<asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateColumns="true">
		</asp:DetailsView>
	</div>
	<div>
		<a class="btn btn-success" id="returnButton" href="/About">Go Back</a>
	</div>
</asp:Content>
