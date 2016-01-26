<%@ Page Title="Calculator" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Calculator.aspx.cs" Inherits="WebControlsHomeWork.Calculator" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
	<h2>Calculator</h2>
	<div class="col-md-3 well">
		<asp:Panel ID="CalculatorPanel" runat="server">
			<div class="row">
				<div class="col-md-8">
					<asp:TextBox ID="CalculatorDisplay" class="form-control" runat="server" Style="text-align: right" Enabled="false"></asp:TextBox>
				</div>
				<div class="col-md-4">
					<asp:Button class="btn btn-default" ID="clearAll" Text="CE" runat="server" OnClick="clearAll_Click" />
				</div>
			</div>
			<br />
			<div class="col-md-8">
				<div class="row">
					<div class="col-md-4">
						<asp:Button class="btn btn-default" ID="seven" Text="7" runat="server" OnClick="number_Click" />
					</div>
					<div class="col-md-4">
						<asp:Button class="btn btn-default" ID="eight" Text="8" runat="server" OnClick="number_Click"/>
					</div>
					<div class="col-md-4">
						<asp:Button class="btn btn-default" ID="nine" Text="9" runat="server" OnClick="number_Click"/>
					</div>
				</div>
				<br />
				<div class="row">
					<div class="col-md-4">
						<asp:Button class="btn btn-default" ID="four" Text="4" runat="server" OnClick="number_Click"/>
					</div>
					<div class="col-md-4">
						<asp:Button class="btn btn-default" ID="five" Text="5" runat="server" OnClick="number_Click"/>
					</div>
					<div class="col-md-4">
						<asp:Button class="btn btn-default" ID="six" Text="6" runat="server" OnClick="number_Click"/>
					</div>
				</div>
				<br />
				<div class="row">
					<div class="col-md-4">
						<asp:Button class="btn btn-default" ID="one" Text="1" runat="server" OnClick="number_Click"/>
					</div>
					<div class="col-md-4">
						<asp:Button class="btn btn-default" ID="two" Text="2" runat="server" OnClick="number_Click"/>
					</div>
					<div class="col-md-4">
						<asp:Button class="btn btn-default" ID="three" Text="3" runat="server" OnClick="number_Click"/>
					</div>
				</div>
				<br />
				<div class="row">
					<div class="col-md-4">
						<asp:Button class="btn btn-default" ID="decimalDot" Text="." runat="server" />
					</div>
					<div class="col-md-4">
						<asp:Button class="btn btn-default" ID="zero" Text="0" runat="server" OnClick="number_Click"/>
					</div>
					<div class="col-md-4">
						<asp:Button class="btn btn-default" ID="equals" Text="=" runat="server" Width="39px" OnClick="result_Click"/>
					</div>
				</div>
			</div>
			<div class="col-md-4">
				<div class="row">
					<div class="col-md-6">
						<asp:Button class="btn btn-default" ID="division" Text="/" runat="server" OnClick="operation_Click" />
					</div>
					<div class="col-md-6">
						<asp:Button class="btn btn-default" ID="sqrt" Text="&radic;" runat="server" Width="40px" OnClick="operation_Click"/>
					</div>
				</div>
				<br />
				<div class="row">
					<div class="col-md-6">
						<asp:Button class="btn btn-default" ID="diff" Text="-" runat="server" OnClick="operation_Click"/>
					</div>
					<div class="col-md-6">
						<asp:Button class="btn btn-default" ID="prod" Text="*" runat="server" OnClick="operation_Click"/>
					</div>
				</div>
				<br />
				<div class="row">
					<div class="col-md-6">
						<asp:Button class="btn btn-default" ID="sum" Text="+" runat="server" Height="90px" OnClick="operation_Click" Width="77px" />
					</div>
				</div>
			</div>
		</asp:Panel>
	</div>
	<div class="row">
	</div>
</asp:Content>
