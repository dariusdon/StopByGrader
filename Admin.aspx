<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Admin.aspx.cs" Inherits="Admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <p style="margin-left:48%">
                <asp:Label ID="Label1" Font-Size="38px" Font-Bold="true" ForeColor="Orange" runat="server" Text="Admin"></asp:Label>
            </p>
            <asp:Label style="margin-left:100px" ID="Label2" Font-Size="25px" Font-Bold="true" ForeColor="Orange" runat="server" Text="Raport Operatii:"></asp:Label>
            <br />
             <asp:GridView style="margin-left:100px" ID="GridView1" Width="1750px" AllowPaging="true" Font-size="22px"  runat="server" HeaderStyle-BackColor="#ffa500" HeaderStyle-ForeColor="Black" PageSize="20"  onpageindexchanging="GrdEmp_PageIndexChanging">
         
         <PagerSettings mode="Numeric"
          position="Bottom"           
          pagebuttoncount="10" />
         <PagerStyle backcolor="#ffa500"
          height="30px"
          verticalalign="Bottom"
          horizontalalign="Right"/>
          </asp:GridView>
            <br />
            <br />
            <asp:Button style="margin-left:47%" ID="Button1" Width="150px" Font-Size="23px" ForeColor="Red" runat="server" Text="Delogare" OnClick="Logout" />
        </div>
    </form>
</body>
</html>
