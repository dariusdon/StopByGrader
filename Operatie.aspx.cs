using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
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
        string stop = ConfigurationManager.ConnectionStrings["stop"].ConnectionString;
        using (SqlConnection con = new SqlConnection(stop))
        {
            using (SqlCommand cmd1 = new SqlCommand())
            {
                string sql1 = @"INSERT INTO [dbo].[StopByGrader]
           ([DataAparitiei]
           ,[CodCuloare]
           ,[Cavitate]
           ,[Defect]
           ,[CLS]
           ,[DataOperatie]
           ,[Descriere]
           ,[Operator]
           ,[Schimb])
     VALUES
           ('" + Session["Data1"] +@"'
           ,'" + Session["culoare"] + @"'
            ,'" + Session["name"] + @"'
            ,'" + Session["Defect"] + @"'
            ,'" + Session["CLS"] + @"'
            ,(convert(varchar, getdate(), 25))
            ,'" + TextBox1.Text + @"'
            ,'" + Session["Operator"] + @"'
            ,'" + Session["Schimb"] + @"')";
                cmd1.CommandText = sql1;
                cmd1.Connection = con;
                using (SqlDataAdapter sda = new SqlDataAdapter(cmd1))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                }

            }
        }
        Label2.Visible = true;
    }
}