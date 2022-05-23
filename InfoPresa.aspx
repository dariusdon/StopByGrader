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
            <asp:Label ID="Label1" runat="server" Font-Bold="true" ForeColor="Orange" Font-Size="30px" Text="CU001"></asp:Label>
            </p>
            <p style="margin-left:10%">
            <asp:Label ID="Label2" runat="server" Font-Bold="true" ForeColor="Orange" Font-Size="30px" Text="Adauga:"></asp:Label>
            </p>
            <p style="margin-left:10%">
                <asp:Button ID="Button1" Font-Bold="true" Font-Size="20px"  runat="server" Text="Operatie" OnClick="OnClick" />
            </p>
            
        </div>
    </form>
</body>
</html>
