<%@ Page Language="C#" AutoEventWireup="true" CodeFile="InfoPresa.aspx.cs" Inherits="InfoPresa" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Info</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p style="margin-left:10%">
            <asp:Label ID="Label1" runat="server" Font-Bold="true" ForeColor="Black" Font-Size="30px" Text=""></asp:Label>
            </p>
            <p style="margin-left:10%">
            <asp:Label ID="Label9" runat="server" Font-Bold="true" ForeColor="Black" Font-Size="30px" Text=""></asp:Label>
            </p>
            <p style="margin-left:10%">
            <asp:Label ID="Label12" runat="server" Font-Bold="true" ForeColor="Black" Font-Size="30px" Text=""></asp:Label>
            </p>
            <p style="margin-left:10%">
            <asp:Label ID="Label2" runat="server" Font-Bold="true" ForeColor="Black" Font-Size="30px" Text=""></asp:Label>
            </p>
            <p style="margin-left:10%">
            <asp:Label ID="Label3" runat="server" Font-Bold="true" ForeColor="Black" Font-Size="30px" Text=""></asp:Label>
            </p>
            <p style="margin-left:10%">
            <asp:Label ID="Label4" runat="server" Font-Bold="true" ForeColor="Black" Font-Size="30px" Text=""></asp:Label>
            </p>
            <p style="margin-left:10%">
            <asp:Label ID="Label5" runat="server" Font-Bold="true" ForeColor="Black" Font-Size="30px" Text=""></asp:Label>
            </p>
            <p style="margin-left:10%">
            <asp:Label ID="Label6" runat="server" Font-Bold="true" ForeColor="Black" Font-Size="30px" Text=""></asp:Label>
            </p>
             <p style="margin-left:10%">
            <asp:Label ID="Label7" runat="server" Font-Bold="true" ForeColor="Black" Font-Size="30px" Text=""></asp:Label>
            </p>
             <p style="margin-left:10%">
            <asp:Label ID="Label8" runat="server" Font-Bold="true" ForeColor="Black" Font-Size="30px" Text=""></asp:Label>
            </p>
            
           <p style="margin-left:10%"> 
              <asp:Label ID="Label10" Font-Size="25px" ForeColor ="Orange" Font-Bold="true" runat="server" Text="Detalii Operatiune:"></asp:Label>
            </p>
            <p style="margin-left:10%">
                <asp:TextBox ID="TextBox1" BorderColor="Orange" Font-Size="20px" Width="250px" Height="200px" BorderWidth="2px" TextMode="MultiLine" runat="server"></asp:TextBox>
            </p>
             <p style="margin-left:10%">
                <asp:Label ID="Label11" Font-Size="25px" ForeColor ="Orange" Font-Bold="true" runat="server" Text="Operatia a fost salvata cu success!"></asp:Label>
            </p>
            <p style="margin-left:10%"> 
                <asp:Button ID="Button1" Font-Size="20px" runat="server" Text="Salveaza Operatie" OnClick="OnClick" Width="200px"/>
            </p>
            <p style="margin-left:10%"> 
                <asp:Button ID="Button2" Font-Size="20px" runat="server" Text="Inchide Operatie" OnClientClick="window.close();return false" Width="200px"/>
            </p>
            
        </div>
    </form>
</body>
</html>
