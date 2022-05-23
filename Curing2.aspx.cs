using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Curing2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void OpenWindow(object sender, EventArgs e)
    {
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=800,left=700,top=100,resizable=no');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void Refresh(object sender,EventArgs e)
    {
        Response.Redirect("Curing2.aspx");
    }
}