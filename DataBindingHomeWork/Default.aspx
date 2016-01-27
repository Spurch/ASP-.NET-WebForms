<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DataBindingHomeWork._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
	<h2 class="text-center">Car search/selection form</h2>
	<div class="container well">
		<div class="col-md-6">
			<label for="ProducerSelect" id="producerLabel">Producer:</label>
			<asp:DropDownList runat="server" ID="ProducerSelect" AutoPostBack="true" CssClass="form-control"></asp:DropDownList>
			<br />
			<label for="ModelSelect" id="modelLabel">Model:</label>
			<asp:DropDownList runat="server" ID="ModelSelect" CssClass="form-control"></asp:DropDownList>
			<br />
			<label for="ExtraSelect" id="extraLabel">Extras:</label>
			<asp:CheckBoxList runat="server" ID="ExtraSelect" class="checkbox"></asp:CheckBoxList>
			<br />
			<label for="EngineSelect" id="engineLabel">Engine type:</label>
			<asp:RadioButtonList runat="server" ID="EngineSelect" class="radiobutton" RepeatDirection="Horizontal">
				<asp:ListItem Value="Gas">Gas</asp:ListItem>
				<asp:ListItem Value="Diesel">Diesel</asp:ListItem>
				<asp:ListItem Value="LPG">LPG</asp:ListItem>
			</asp:RadioButtonList>
			<asp:Button class="btn btn-success" Text ="Search" runat="server" ID="submitButton" OnClick="SearchCars" />
		</div>
		<div class="col-md-6">
			<asp:Label runat="server" for="resultProducer" ID="resultProducerLabel"></asp:Label>
			<asp:Literal runat="server" ID="resultProducer"></asp:Literal>
			<br />
			<asp:Label runat="server" for="resultModel" ID="resultModelLabel"></asp:Label>
			<asp:Literal runat="server" ID="resultModel"></asp:Literal>
			<br />
			<asp:Label runat="server" for="resultExtras" ID="resultExtrasLabel"></asp:Label>
			<asp:Literal runat="server" ID="resultExtras"></asp:Literal>
			<br />
			<asp:Label runat="server" for="resultEngineType" ID="resultEngineTypeLabel"></asp:Label>
			<asp:Literal runat="server" ID="resultEngineType"></asp:Literal>
		</div>
	</div>
	<div class="row">
	</div>
</asp:Content>
