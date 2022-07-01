<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Curing1EXP.aspx.cs" Inherits="Curing1EXP" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
            <p style="margin-left:46%">
               <asp:Label ID="LabelT" Font-Size="38px" Font-Bold="true" ForeColor="Orange" runat="server" Text="Curing1"></asp:Label>
             </p>
           
            <asp:PlaceHolder runat="server" EnableTheming="true" ID="PlaceHolder1"></asp:PlaceHolder>
          
            <br />
            <br />
            <asp:Button style="margin-left:42%" ID="Refresh" runat="server" Text="Refresh" ForeColor="Green" Font-Size="25px" OnClick="Refresh1"/>
            
            <asp:Button ID="Home" runat="server" Text="Deconectare" ForeColor="Red" Font-Size="25px" OnClick="Logout"/>
            <br />
          
            
            </div>
 
  
    </form>
    <script runat="server"> 
 public override void VerifyRenderingInServerForm(Control control) 
 { 
 } 
</script> 
</body>
</html>
