using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void OnClick(object sender, EventArgs args)
    {
        Session["Operator"] = TextBox1.Text;
        string password = TextBox2.Text;
        if ((string)Session["Operator"] == "antonescu" && password == "5177")
        {
            Response.Redirect("Curing1.aspx");
        }
        if ((string)Session["Operator"] == "bunceanu" && password == "4561")
        {
            Response.Redirect("Curing1.aspx");
        }
        if ((string)Session["Operator"] == "fandel" && password == "4856")
        {
            Response.Redirect("Curing1.aspx");
        }
        if ((string)Session["Operator"] == "giurgi" && password == "4437")
        {
            Response.Redirect("Curing1.aspx");
        }
        if ((string)Session["Operator"] == "lasc" && password == "811")
        {
            Response.Redirect("Curing1.aspx");
        }
        if ((string)Session["Operator"] == "iordache" && password == "4509")
        {
            Response.Redirect("Curing1.aspx");
        }
        if ((string)Session["Operator"] == "irodia" && password == "2026")
        {
            Response.Redirect("Curing1.aspx");
        }
        if ((string)Session["Operator"] == "rosu" && password == "6143")
        {
            Response.Redirect("Curing1.aspx");
        }

        if ((string)Session["Operator"] == "sanda" && password == "4560")
        {
            Response.Redirect("Curing2.aspx");
        }
        if ((string)Session["Operator"] == "frunza" && password == "2205")
        {
            Response.Redirect("Curing2.aspx");
        }
        if ((string)Session["Operator"] == "enache" && password == "4856")
        {
            Response.Redirect("Curing2.aspx");
        }
        if ((string)Session["Operator"] == "dinu" && password == "2143")
        {
            Response.Redirect("Curing2.aspx");
        }

        if ((string)Session["Operator"] == "tamas" && password == "3877")
        {
            Response.Redirect("Admin.aspx");
        }
        if ((string)Session["Operator"] == "dobromirescu" && password == "2976")
        {
            Response.Redirect("Admin.aspx");
        }
        if ((string)Session["Operator"] == "ionascu" && password == "3794")
        {
            Response.Redirect("Admin.aspx");
        }
        if ((string)Session["Operator"] == "homaniuc" && password == "0000")
        {
            Response.Redirect("Admin.aspx");
        }
        if ((string)Session["Operator"] == "artin" && password == "4013")
        {
            Response.Redirect("Admin.aspx");
        }
        if ((string)Session["Operator"] == "balaban" && password == "4567")
        {
            Response.Redirect("Admin.aspx");
        }
        if ((string)Session["Operator"] == "hariton" && password == "460")
        {
            Response.Redirect("Admin.aspx");
        }
        if ((string)Session["Operator"] == "manzur" && password == "2433")
        {
            Response.Redirect("Admin.aspx");
        }
    }
}
