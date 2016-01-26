<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebControlsHomeWork._Default" ValidateRequest="false"%>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>ASP.NET Web Controls Homework</h1>
    </div>

    <div class="row">
        <div class="col-md-4">
			<label for="rangeStart">From: </label>
			<asp:TextBox ID="rangeStart" runat="server" CssClass="form-control"></asp:TextBox>
			<br />
			<label for="rangeEnd">To: </label>
			<asp:TextBox ID="rangeEnd" runat="server" CssClass="form-control"></asp:TextBox>
			<br />
			<asp:Button ID="generateRandomNumber" runat="server" CssClass="btn btn-submit" Text="Generate!" OnClick="GenerateNumber"/>
			<br />
			<label for="resultBox">Generated: </label>
			<asp:TextBox ID="resultBox" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="col-md-4">
			<label for="htmlEscapedField">Input HTML: </label>
			<asp:TextBox ID="htmlEscapedField" runat="server" CssClass="form-control"></asp:TextBox>
			<br />
			<asp:Button ID="htmlEscapedButton" runat="server" CssClass="btn btn-success" Text="Submit HTML!" OnClick="OnHtmlSubmit" />
			<br />
			<asp:Label ID="submitedLabel" for="submitedText" runat="server">Initial Label:</asp:Label>
			<br />
			<asp:TextBox ID="submitedText" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="col-md-4">
 
        </div>
    </div>

</asp:Content>
