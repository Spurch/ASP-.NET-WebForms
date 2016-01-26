<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebFormsSampleApp._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
		<div class="well text-center">
			<h1>First ASP .NET WebForms Homework</h1>
			<asp:Label runat="server" id="operationSubTitleLabel"></asp:Label>
		</div>
    </div>
	<div class="well">
		<div class="row">
			<div class="col-md-3">
				<asp:Label for="firstInputTextBox" runat="server" id="firstLabel"></asp:Label>
				<asp:TextBox class="form-control" runat="server" id="firstInputTextBox" />
				</br>
				<asp:Label for="secondInputTextBox" runat="server" id="secondLabel"></asp:Label>
				<asp:TextBox class="form-control" runat="server" id="secondInputTextBox" />
				<br />
				<asp:Label for="secondInputTextBox" runat="server" id="resultLabel"></asp:Label>
				<asp:TextBox class="form-control" runat="server" id="resultTextBox" disabled/>
				<br />
				<asp:Button class="form-control btn btn-success" runat="server" id="calculateBtn" Text="Calculate!" OnClick="calculateBtn_Click" />
			</div>
			<div class="col-md-3">
				<asp:Label for="mathOperationSelector" runat="server" id="operationSelectLabel"></asp:Label>
				<asp:DropDownList runat="server" class="form-control" id="mathOperationSelector" autopostback="true">
					<asp:ListItem value="sum" Selected>Sum</asp:ListItem>
					<asp:ListItem value="prod">Prod</asp:ListItem>
				</asp:DropDownList>
			</div>
			<div class="col-md-6">
				<div class="well text-center">
					<asp:Label runat="server" ID="responseLabel" style="visibility: hidden;"></asp:Label>
				</div>
			</div>
		</div>
	</div>
</asp:Content>
