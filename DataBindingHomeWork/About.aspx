<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="DataBindingHomeWork.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
	<h2>Northwind Employees</h2>
	<div class="container well">
		<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false">
			<Columns>
				<asp:HyperLinkField
					DataNavigateUrlFields="EmployeeID"
					DataNavigateUrlFormatString="Profile.aspx?ID={0}"
					DataTextField="Employee"
					HeaderText="Employee"
					SortExpression="Employee" />
			</Columns>
		</asp:GridView>
	</div>
</asp:Content>
