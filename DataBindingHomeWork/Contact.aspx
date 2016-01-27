<%@ Page Title="EmployeeForm" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="DataBindingHomeWork.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
	<style type="text/css">  
      div#container {
        width: 580px;
        margin: 100px auto 0 auto;
        padding: 20px;
        background: #000;
        border: 1px solid #1a1a1a;
      }
      
      /* HOVER STYLES */
      div#pop-up {
        display: none;
        position: absolute;
        width: 280px;
        padding: 10px;
        background: #eeeeee;
        color: #000000;
        border: 1px solid #1a1a1a;
        font-size: 90%;
      }
    </style>

	<script type="text/javascript" src="https://ajax.googleapis.com/ajax/libs/jquery/1.5.0/jquery.min.js"></script>
	<script type="text/javascript">
		$(document).ready(function () {
			var moveLeft = 20;
			var moveDown = 10;
			$('.trigger').hover(function (e) {
				var target = $(e.target);
				var id = (target.text());
				$('div#pop-up').load("HiddenDetails.ashx?ID=" + id);
				$('div#pop-up').show()
				  .css('top', e.pageY + moveDown)
				  .css('left', e.pageX + moveLeft)
				  .appendTo('body');
			}, function () {
				setTimeout(function () { $('div#pop-up').hide(); }, 5);
			});

		});
	</script>

	<h2>Northwind Employees Form</h2>
	<p>Hover on EmployeeID to see it working... sorry for not working for the whole row :(</p>
	<div class="well">
		<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" ClientIDMode="Static">
			<Columns>
				<asp:TemplateField HeaderText="EmployeeID" SortExpression="EmployeeID" Visible="true">
                <ItemTemplate>
                    <asp:Label class="trigger" ID="lbl" runat="server" Text='<%# Bind("EmployeeID") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
				<asp:BoundField DataField="Employee" HeaderText="Employee">
					<ItemStyle CssClass="trigger" />
				</asp:BoundField>
				<asp:BoundField DataField="Country" HeaderText="Country">
					<ItemStyle CssClass="trigger" />
				</asp:BoundField>
				<asp:BoundField DataField="City" HeaderText="City">
					<ItemStyle CssClass="trigger" />
				</asp:BoundField>
			</Columns>
		</asp:GridView>
	</div>


	<div id="pop-up">
		<h3>Pop-up div Successfully Displayed</h3>
	</div>
</asp:Content>
