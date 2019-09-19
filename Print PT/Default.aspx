<%@ Page Title="Print Orders" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="Print_PT._Default" %>
<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
<link rel="Anu Logo" href="Anu Logo.ico" type="image/ico"/>
    <style type="text/css">
        
         .grid-sltrow
        {
            background: #ddd;
            font-weight: bold;
        }
        .SubTotalRowStyle
        {
           
            background-color:#ffffff;
            font-weight: bold;
        }
        .GrandTotalRowStyle
        {
            
            background-color: #ffffff;
            color: #000000;
            font-weight: bold;
        }
        .GroupHeaderStyle
        {
            
            background-color: #ffffff;
            color: #000000;
            font-weight: bold;
        }
        .serh-grid
        {
            width: 85%;
            border: 1px solid #6AB5FF;
            background: #fff;
            line-height: 14px;
            font-size: 11px;
            font-family: Verdana;
        }
        .hidden-field
 {
     display:none;
 }
 
 div.container {
    width: 100%;
   min-height: 1285px;
}

header, footer {
    padding: .5em;
    color: black;
    background-color: white;
    clear: left;
    text-align: center;
    border: 1px solid gray;
    margin-left:20px;
}

nav {
    float: left;
    max-width: 160px;
    margin: 0;
    padding: 1em;
}

nav ul {
    list-style-type: none;
    padding: 0;
}
   
nav ul a {
    text-decoration: none;
}

article {
    margin-left: 170px;
    border-left: 1px solid gray;
    padding: 1em;
    overflow: hidden;
}

        .style1
        {
            text-decoration: underline;
        }
        .style2
        {
            text-align: center;
            width:250px;
            height:45px;
            margin-left:350px;
        }

        .style3
        {
            color: #000000;
            font-size: medium;
        }

        .style4
        {
            width: 29%;
            height: 103px;
            margin-top:-100px;
        }

        .style5
        {
            height: 21px;
        }

        .style6
        {
            width: 214px;
        }

        .auto-style1 {
            color: #000000;
        }

    </style>
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
&nbsp;
&nbsp;&nbsp;&nbsp;
<div class="container">
<header>
   <h1>
       <asp:Label ID="Label9" runat="server" CssClass="style3" 
           style="font-weight: 700; font-size: x-large;" Text="PT"></asp:Label>
       <b>-
       <asp:Label ID="Label8" runat="server" Text="NUMBER" CssClass="style3" 
           style="font-weight: 700; font-size: x-large;"></asp:Label>
    </b></h1>
</header>
&nbsp;<br />
    <br />
&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
    <br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    &nbsp; 
    &nbsp; 
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    &nbsp;
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    &nbsp;
    <br />
    <table class="style4" align="left">
    <tr>
    <td class="style6">
    <asp:TextBox ID="TextBox1" runat="server" Text="14390"
        style="text-align: center; color: #000000;" ForeColor="#999999" Width="100px"></asp:TextBox>
        &nbsp;<asp:Button ID="Button1" runat="server" 
    Text="Submit" onclick="Button1_Click" ForeColor="#999999" Height="21px" 
        style="color: #000000" />
            &nbsp;<asp:Button ID="Button2" runat="server" Height="21px" 
        onclick="Button2_Click" style="color: #000000" Text="Print" />
    
    </td>
    </tr>
    <tr>
    <td class="style6">
        <asp:TextBox ID="TextBox8" runat="server" Text="Form No. AWS/TSC/F-01,Rev No-00" 
            style="text-align: center" Width="230px" Enabled="False"></asp:TextBox>
    </td>
    </tr>
        <tr>
            <td>
                <strong>
            <asp:Label ID="Label16" runat="server" Text="" CssClass="auto-style1"></asp:Label>
                </strong>
        </td>
        </tr>
    </table>
    <table class="style4" align="right">
        <tr>
            <td>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label4" runat="server" Text="Order No." ForeColor="#333333" 
        style="color: #000000"></asp:Label>
            </td>
            <td>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label5" runat="server" Text="Date" ForeColor="#333333" 
        style="color: #000000"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
    <asp:TextBox ID="TextBox2" runat="server" 
        style="text-align:center; font-weight: 700;" Enabled="False"></asp:TextBox>
            </td>
            <td>
    <asp:TextBox ID="TextBox3" runat="server" 
        style="text-align:center; font-weight: 700;" Enabled="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label6" runat="server" Text="Customer" ForeColor="#333333" 
        style="color: #000000"></asp:Label>
            </td>
            <td>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label 
        ID="Label7" runat="server" Text="Customer PO" ForeColor="#333333" 
        style="color: #000000"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
    <asp:TextBox ID="TextBox4" runat="server" 
        style="text-align:center; font-weight: 700;" Enabled="False"></asp:TextBox>
            </td>
            <td>
    <asp:TextBox ID="TextBox5" runat="server" 
        style="text-align:center; font-weight: 700;" Enabled="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style5">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label12" runat="server" style="color: #000000" 
                    Text="Customer Name"></asp:Label>
            </td>
            <td class="style5"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label14" runat="server" style="color: #000000" Text="Worles_PO"></asp:Label>
            </td>
        </tr>
        <tr>
      <td>
          &nbsp;<asp:TextBox ID="TextBox6" runat="server" 
              style="font-weight: 700; margin-left: 0px; text-align:center;" 
              Width="164px" Enabled="False"></asp:TextBox>
            </td>
            <td> 
                <asp:TextBox ID="TextBox7" runat="server" 
                    style="font-weight: 700; text-align: center" Enabled="False"></asp:TextBox>
            </td>
        </tr>
    </table>
    <br />
    <br />
    <br />
        <center><asp:GridView ID="GridView3" runat="server" BackColor="White" ShowFooter="True"
            BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" 
            AutoGenerateColumns="False" onrowdatabound="GridView3_RowDataBound">
            <FooterStyle BackColor="White" ForeColor="Black" HorizontalAlign="Center" Font-Bold="True" />
            <HeaderStyle BackColor="White" Font-Bold="True" ForeColor="Black" />
            <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
            <RowStyle ForeColor="Black" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#007DBB" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#00547E" />
            <Columns>
                <asp:TemplateField HeaderText="Sr No.">
                        <ItemTemplate>
                            <%#Container.DataItemIndex+1 %>
                        </ItemTemplate>
                    </asp:TemplateField>
                        <asp:BoundField DataField="NumOrd" HeaderText="... U.I.D ..." ReadOnly="True" />
                        <asp:BoundField DataField="ArtOrd" HeaderText="......... Item ........" ReadOnly="True" />
                        <asp:BoundField DataField="NomArt" HeaderText="....... Description ......." ReadOnly="True" />
                        <asp:BoundField DataField="PlaOrd" HeaderText="Customer Reference" ReadOnly="True" />
                        <asp:BoundField DataField="PieOrd" HeaderText="Qty" ReadOnly="True" />
                        <asp:BoundField DataField="PreOrd" HeaderText="Unit Rate" ReadOnly="True" />
                        <asp:BoundField DataField="DtoOrd" HeaderText="Disc%" ReadOnly="True" FooterText="Total W/O_Disc"/>
                        <asp:TemplateField HeaderText="Amount">        
				<ItemTemplate>
                      <asp:Label ID="Label1" runat="server"/>
                  </ItemTemplate>
			 <FooterTemplate>
				<asp:Label ID="total" runat="server" />
                <asp:Label ID="Label15" runat="server" />
			 </FooterTemplate>
       </asp:TemplateField>
                        <asp:TemplateField HeaderText="Qty Amt">
				<ItemTemplate>
                      <asp:Label ID="Label3" runat="server"/>
                  </ItemTemplate>
			 <FooterTemplate>
				<asp:Label ID="total2" runat="server" />
			 </FooterTemplate>
       </asp:TemplateField>
                        <asp:BoundField DataField="EntOrd" HeaderText="Delivery" DataFormatString = "{0:d}" ReadOnly="True" />
                        <asp:TemplateField HeaderText="In Wks" >
				        <ItemTemplate>
                        <asp:Label ID="Label2" runat="server"/>
                        </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="FecPed" HeaderText="Remarks" DataFormatString = "{0:d}" ReadOnly="True" >
                        <ItemStyle CssClass="hidden-field"/>
                        </asp:BoundField>
                        <asp:TemplateField>
                            <EditItemTemplate>
                                <asp:Label ID="Label1" runat="server" Text='<%# Eval("Datos") %>'></asp:Label>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label4" runat="server" Text='<%# Bind("Datos") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField> 
                        </Columns>
        </asp:GridView>
             <asp:Label ID="Label13" runat="server" 
                style="font-weight: 700; margin: 1000px auto auto 330px; color: #000000; font-size: medium;" 
                Text="Total : "></asp:Label>
            <asp:Label ID="Label10" runat="server" 
                style="font-weight: 700; margin: 1000px auto auto 2px; color: #000000; font-size: medium;" 
                Text="Label"></asp:Label>
    </center>
    <div class="style2">
    <br />
    &nbsp;<asp:Label ID="Label11" runat="server" 
            style="font-weight: 700; color: #000000" Text="CARBIDE DETAILS"></asp:Label>
        <span class="style1"><strong><br />
        </strong></span>
    <br />
    </div>
    <center>
        <asp:GridView ID="GridView2" runat="server" BackColor="White" AutoGenerateColumns="False"
            BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" 
            onrowdatabound="GridView2_RowDataBound">
            <FooterStyle BackColor="White" ForeColor="#000066" />
            <HeaderStyle BackColor="White" Font-Bold="True" ForeColor="Black" />
            <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
            <RowStyle ForeColor="Black" HorizontalAlign="Left" VerticalAlign="Top" Height="50px" Width="80px"/>
            <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#007DBB" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#00547E" />
            <Columns>
                        <asp:BoundField DataField="NumOrd" HeaderText="NEW UID" ReadOnly="True" />
                        <asp:BoundField DataField="PieOrd" HeaderText="NEW QTY" ReadOnly="True" />
                        <asp:BoundField DataField="F2" HeaderText="OLD UID" ReadOnly="True" />
                        <asp:BoundField DataField="Required T#C# Size" HeaderText=".......... OD ..........." ReadOnly="True" />
                        <asp:BoundField DataField="F4" HeaderText="...... L ......" ReadOnly="True" />
                        <asp:BoundField DataField="F5" HeaderText="...... ID ......" ReadOnly="True" />
                        <asp:BoundField DataField="F6" HeaderText="GRADE" ReadOnly="True" />
                        <asp:BoundField DataField="F7" HeaderText="OLD QTY" ReadOnly="True" />
                        </Columns>
        </asp:GridView>
        <br />
       
        </div>
</asp:Content>
