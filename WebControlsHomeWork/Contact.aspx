<%@ Page Title="Tic-Tac-Toe" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="WebControlsHomeWork.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Tic-Tac-Toe</h2>
	<p>You play with the X sign!</p>
	<p>Input 'X' in some of the fields and change focus!</p>
	<div class="row">
		<div class="col-md-4">
			<asp:Panel ID="TicTacToePanel" runat="server">
				<asp:Table ID="TicTacToeField" runat="server" CssClass="table">
					<asp:TableRow>
						<asp:TableCell><asp:TextBox ID="zeroZero" runat="server" CssClass=" form-control" AutoPostBack="true"></asp:TextBox></asp:TableCell>
						<asp:TableCell><asp:TextBox ID="zeroOne" runat="server" CssClass=" form-control" AutoPostBack="true"></asp:TextBox></asp:TableCell>
						<asp:TableCell><asp:TextBox ID="zeroTwo" runat="server" CssClass=" form-control" AutoPostBack="true"></asp:TextBox></asp:TableCell>
					</asp:TableRow>
					<asp:TableRow>
						<asp:TableCell><asp:TextBox ID="oneZero" runat="server" CssClass=" form-control" AutoPostBack="true"></asp:TextBox></asp:TableCell>
						<asp:TableCell><asp:TextBox ID="oneOne" runat="server" CssClass=" form-control" AutoPostBack="true"></asp:TextBox></asp:TableCell>
						<asp:TableCell><asp:TextBox ID="oneTwo" runat="server" CssClass=" form-control" AutoPostBack="true"></asp:TextBox></asp:TableCell>
					</asp:TableRow>
					<asp:TableRow>
						<asp:TableCell><asp:TextBox ID="twoZero" runat="server" CssClass=" form-control" AutoPostBack="true"></asp:TextBox></asp:TableCell>
						<asp:TableCell><asp:TextBox ID="twoOne" runat="server" CssClass=" form-control" AutoPostBack="true"></asp:TextBox></asp:TableCell>
						<asp:TableCell><asp:TextBox ID="twoTwo" runat="server" CssClass=" form-control" AutoPostBack="true"></asp:TextBox></asp:TableCell>
					</asp:TableRow>
				</asp:Table>
			</asp:Panel>
		</div>
	</div>
</asp:Content>
