<%@ Page Title="Friends list" Language="C#" MasterPageFile="~/Details.Master" AutoEventWireup="true" CodeBehind="FriendList.aspx.cs" Inherits="MasterPagesHomework.FriendList" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="DetailsChildContent" runat="server">
    <h2 class="text-center">Your Friend List</h2>
	<div class="container well col-md-12">
			<div class="col-md-8">
				<asp:Table ID="listAllFriends" runat="server">
					<asp:TableHeaderRow>
						<asp:TableHeaderCell>
							<p class="text-center">Friend</p>
						</asp:TableHeaderCell>
						<asp:TableHeaderCell>
							<p class="text-center">Known behavioral problems</p>
						</asp:TableHeaderCell>
					</asp:TableHeaderRow>
					<asp:TableRow>
						<asp:TableCell><a href="https://telerikacademy.com/Users/Nikolay.IT">Nikolay Kostov</a></asp:TableCell>
						<asp:TableCell>Runs a .NET Asylum</asp:TableCell>
					</asp:TableRow>
					<asp:TableRow>
						<asp:TableCell><a href="https://telerikacademy.com/Users/DonchoMinkov">Doncho Minkov</a></asp:TableCell>
						<asp:TableCell>Likes JavaScript</asp:TableCell>
					</asp:TableRow>
					<asp:TableRow>
						<asp:TableCell><a href="https://telerikacademy.com/Users/ivaylo.kenov">Ivaylo Kenov</a></asp:TableCell>
						<asp:TableCell>Cqlata vi rabota takava...</asp:TableCell>
					</asp:TableRow>
				</asp:Table>
			</div>
		<div class="col-md-4">
			<table>
				<tr>
					<th>Recently Friend(omized):</th>
				</tr>
				<tr>
					<td><a href="http://basementrejects.com/wp-content/uploads/2012/08/doctor-who-season-1-10-the-doctor-dances-are-you-my-mummy.jpg">MockUpLink</a></td>
				</tr>
				<tr>
					<td><a href="http://i.dailymail.co.uk/i/pix/2011/04/15/article-1377089-0B9544D200000578-772_634x724.jpg">SecondMockUpLink</a></td>
				</tr>
			</table>
		</div>
	</div>
</asp:Content>
