<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Operatie.aspx.cs" Inherits="Operatie" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Operatie</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p style="margin-left:10%">
                <asp:Label ID="Label1" Font-Size="35px" ForeColor ="Orange" Font-Bold="true" runat="server" Text="Operatie"></asp:Label>
                <br />
            </p>
             
            <p style="margin-left:10%">
                <asp:Label ID="Label3" Font-Size="25px" ForeColor ="Orange" Font-Bold="true" runat="server" Text="Selecteaza Defect:"></asp:Label>
                <br />
            </p>
            <p style="margin-left:10%"> 
                <asp:DropDownList ID="DropDownList1" Font-Bold="true" Font-Size="20px" runat="server">
                    <asp:ListItem Value="Default">Default</asp:ListItem>
                </asp:DropDownList>
            </p>
             <p style="margin-left:10%"> 
              <asp:Label ID="Label4" Font-Size="25px" ForeColor ="Orange" Font-Bold="true" runat="server" Text="Detalii Operatiune:"></asp:Label>
            </p>
            <p style="margin-left:10%">
                <asp:TextBox ID="TextBox1" BorderColor="Orange" Font-Size="20px" Width="250px" Height="200px" BorderWidth="2px" TextMode="MultiLine" runat="server"></asp:TextBox>
            </p>
             <p style="margin-left:10%">
                <asp:Label ID="Label2" Font-Size="25px" ForeColor ="Orange" Font-Bold="true" runat="server" Text="Operatia a fost salvata cu success!"></asp:Label>
            </p>
            <p style="margin-left:10%"> 
                <asp:Button ID="Button2" Font-Size="20px" runat="server" Text="Salveaza Operatie" OnClick="OnClick" Width="200px"/>
            </p>
            <p style="margin-left:10%"> 
                <asp:Button ID="Button1" Font-Size="20px" runat="server" Text="Inchide Operatie" OnClientClick="window.close();return false" Width="200px"/>
            </p>
        </div>
    </form>
</body>
</html>
