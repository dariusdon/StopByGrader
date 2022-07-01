using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
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
        string shiftcolor;
        string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
        using (SqlConnection con = new SqlConnection(constr))
        {
            using (SqlCommand cmd1 = new SqlCommand())
            {
                string sql1 = @"SELECT [ShiftDate]
                      ,[ShiftID]
                      ,[ShiftColor]
                      FROM[tias067a].[NewERT].[dbo].[ShiftCalendar]
                      where convert(varchar, ShiftDate,23) = convert(varchar, getdate(), 23)
                      and ShiftID = (case when convert(varchar, getdate(),24) between '07:00:00' and '15:00:00' then '1'
                      when convert(varchar, getdate(),24) between '15:00:00' and '23:00:00' then '2'
                      when convert(varchar, getdate(),24) between '23:00:00' and '23:59:59' then '3'
                      when convert(varchar, getdate(),24) between '00:00:00' and '07:00:00' then '3' end)";
                cmd1.CommandText = sql1;
                cmd1.Connection = con;
                using (SqlDataAdapter sda = new SqlDataAdapter(cmd1))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    shiftcolor = Convert.ToString(dt.Rows[0]["ShiftColor"]);
                }

            }
            Session["Operator"] = TextBox1.Text;
            Session["Schimb"] = shiftcolor;
            string password = TextBox2.Text;
            if ((string)Session["Operator"] == "antonescu" && password == "5177")
            {
                Session["test"] = "<=";
                Response.Redirect("Curing1EXP.aspx");
            }
            if ((string)Session["Operator"] == "bunceanu" && password == "4561")
            {
                Session["test"] = "<=";
                Response.Redirect("Curing1EXP.aspx");
            }
            if ((string)Session["Operator"] == "fandel" && password == "4856")
            {
                Session["test"] = "<=";
                Response.Redirect("Curing1EXP.aspx");
            }
            if ((string)Session["Operator"] == "giurgi" && password == "4437")
            {
                Session["test"] = "<=";
                Response.Redirect("Curing1EXP.aspx");
            }
            if ((string)Session["Operator"] == "lasc" && password == "811")
            {
                Session["test"] = "<=";
                Response.Redirect("Curing1EXP.aspx");
            }
            if ((string)Session["Operator"] == "iordache" && password == "4509")
            {
                Session["test"] = "<=";
                Response.Redirect("Curing1EXP.aspx");
            }
            if ((string)Session["Operator"] == "irodia" && password == "2026")
            {
                Session["test"] = "<=";
                Response.Redirect("Curing1EXP.aspx");
            }
            if ((string)Session["Operator"] == "rosu" && password == "6143")
            {
                Session["test"] = "<=";
                Response.Redirect("Curing1EXP.aspx");
            }

            if ((string)Session["Operator"] == "sanda" && password == "4560")
            {
                Session["test"] = ">";
                Response.Redirect("Curing2EXP.aspx");
            }
            if ((string)Session["Operator"] == "frunza" && password == "2205")
            {
                Session["test"] = ">";
                Response.Redirect("Curing2EXP.aspx");
            }
            if ((string)Session["Operator"] == "enache" && password == "4856")
            {
                Session["test"] = ">";
                Response.Redirect("Curing2EXP.aspx");
            }
            if ((string)Session["Operator"] == "dinu" && password == "2143")
            {
                Session["test"] = ">";
                Response.Redirect("Curing2EXP.aspx");
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
            if ((string) Session["Operator"] == "user" && password == "user"){
                Session["test"] = ">";
                Response.Redirect("Curing1EXP.aspx");
            }
        }
    }
}