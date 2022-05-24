using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class InfoPresa : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Text = "Cavitate:" + Session["name"];
        Label2.Text = "Data Aparitiei:" + Session["Data1"];
        Label3.Text = "Cod Culoare:" + Session["culoare"];
        Label4.Text = "Defect:" + Session["Defect"];
        Label5.Text = "CLS:" + Session["CLS"];
        Label6.Text = "Operator:" + Session["Operator"];
        Label7.Text = "Schimb:" + Session["Schimb"];
        Label8.Text = "Data Operatiei:" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
    }
    protected void OnClick(object sender, EventArgs e)
    {
        Response.Redirect("Operatie.aspx");
    }
}