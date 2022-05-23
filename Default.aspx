<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p style="margin-top:50px;margin-left:46%">
            <asp:Label ID="Label1" runat="server" Text="StopByGrader" Font-Size="40px" ForeColor="Orange"></asp:Label>
            </p>

            <p style="margin-left:46%;margin-top:200px">
                <asp:Label ID="Label2" runat="server" Font-Size="35px" ForeColor="Orange" Text="Nume Utilizator"></asp:Label>
             </p>
            <p style="margin-left:46%;margin-top:15px">
                <asp:TextBox ID="TextBox1" Font-Bold="true" Font-Size="24px" runat="server" Width="224px"></asp:TextBox>
             </p>
           
            <p style="margin-left:49%;margin-top:15px">
                &nbsp;&nbsp; <asp:Label ID="Label3" runat="server" Font-Size="35px" ForeColor="Orange" Text="Parola"></asp:Label>
             </p>
            <p style="margin-left:46%;margin-top:15px">
                <asp:TextBox ID="TextBox2" Font-Bold="true" TextMode="Password" Font-Size="24px" runat="server" Width="224px"></asp:TextBox>
             </p>
            <p style="margin-left:47%;margin-top:20px">
                <asp:Button ID="Button1" runat="server" Font-Bold="True" Font-Size="24px" Text="Login" Height="37px" Width="197px" OnClick="OnClick"/>
             </p>
        </div>
    </form>
</body>
</html>
