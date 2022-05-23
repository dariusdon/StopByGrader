using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Operatie : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
        Label2.Visible = false;
    }
    protected void OnClick(object sender,EventArgs e)
    {
        Label2.Visible = true;
    }
}