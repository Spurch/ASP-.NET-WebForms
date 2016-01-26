<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="WebControlsHomeWork.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
	<div class="row">
		<div class="col-md-4">
			<h2>Add Student</h2>
			<label for="firstName">First name:</label>
			<asp:TextBox ID="firstName" CssClass="form-control" runat="server"></asp:TextBox>
			<br />
			<label for="lastName">Last name:</label>
			<asp:TextBox ID="lastName" CssClass="form-control" runat="server"></asp:TextBox>
			<br />
			<label for="facultyNumber">Faculty number::</label>
			<asp:TextBox ID="facultyNumber" CssClass="form-control" runat="server"></asp:TextBox>
			<br />
			<label for="universityList">University:</label>
			<asp:DropDownList ID="universityList" CssClass="form-control" runat="server"></asp:DropDownList>
			<br />
			<label for="specialtyList">Specialty:</label>
			<asp:DropDownList ID="specialtyList" CssClass="form-control" runat="server"></asp:DropDownList>
			<br />
			<p>Hold Ctrl button when selecting courses!</p>
			<label for="coursesList">Courses:</label>
			<asp:ListBox ID="coursesList" CssClass="form-control" runat="server" AutoPostBack="true" SelectionMode="Multiple"></asp:ListBox>
			<br />
			<asp:Button ID="submitStudentButton" CssClass="btn btn-submit" runat="server" Text="Submit!" OnClick="OnStudentSubmit"/>
		</div>

		<div class="col-md-offset-6">
			<asp:Panel ID="result" runat="server">

			</asp:Panel>
		</div>
	</div>
</asp:Content>
