<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AspIntroHomework._Default" %>
<%@ Import Namespace="System.Reflection"  %>
<script runat="server">
	protected void OnClick(object sender, EventArgs e)
	{
		resultField.Text = "Hello " + nameInputField.Text.ToString();
	}

	protected String GetAssembly()
	{
		return Assembly.GetExecutingAssembly().Location;
	}
</script>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron text-center">
        <h1>ASP.NET WebForms Intro Homework</h1>
    </div>

    <div class="row">
        <div class="col-md-4">
			<asp:Label for="nameInputField" runat="server" id="nameLabel">Input string: </asp:Label>
			<asp:TextBox ID="nameInputField" runat="server" class="form-control"/>
			<br />
			<asp:Button ID="submitBtn" runat="server" class="btn btn-primary" OnClick="OnClick" Text="Submit!"/>
			<br />
			<br />
			<div class="well">
				<asp:Label ID="resultField" runat="server"></asp:Label>
			</div>
        </div>
        <div class="col-md-4">
			<div class="well">
				<% ="Hello World from the aspx page! :)"%>
			</div>
			<div class="well">
				<% =hello %>
			</div>
        </div>
        <div class="col-md-4">
			Current running Assembly is:
			<div class="well">
				<% =GetAssembly()%>.
			</div>
        </div>
    </div>

</asp:Content>
