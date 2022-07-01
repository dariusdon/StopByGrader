using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Details();
    }
    public void Details()
    {
        string stop = ConfigurationManager.ConnectionStrings["stop"].ConnectionString;
        using (SqlConnection con = new SqlConnection(stop))
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                string sql = @"Select [Barcode]
           ,[DataAparitiei]
           ,[AnomalyCode]
           ,[CodCuloare]
           ,[Cavitate]
           ,[Defect]
           ,[CLS]
           ,[DataOperatie]
           ,[Descriere]
           ,[Operator]
           ,[Schimb]
           
from dbo.StopByGrader order by DataOperatie desc";

                cmd.CommandText = sql;
                cmd.Connection = con;
                using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    GridView1.AllowPaging = true;
                    GridView1.DataSource = dt;
                    GridView1.DataBind();
                }
            }
        }
    }
    protected void GrdEmp_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        GridView1.DataBind();
    }
    public static void ToCSV(DataTable dtDataTable, string strFilePath)
    {
        StreamWriter sw = new StreamWriter(strFilePath, false);
        //headers    
        for (int i = 0; i < dtDataTable.Columns.Count; i++)
        {
            sw.Write(dtDataTable.Columns[i]);
            if (i < dtDataTable.Columns.Count - 1)
            {
                sw.Write(",");
            }
        }
        sw.Write(sw.NewLine);
        foreach (DataRow dr in dtDataTable.Rows)
        {
            for (int i = 0; i < dtDataTable.Columns.Count; i++)
            {
                if (!Convert.IsDBNull(dr[i]))
                {
                    string value = dr[i].ToString();
                    if (value.Contains(','))
                    {
                        value = String.Format("\"{0}\"", value);
                        sw.Write(value);
                    }
                    else
                    {
                        sw.Write(dr[i].ToString());
                    }
                }
                if (i < dtDataTable.Columns.Count - 1)
                {
                    sw.Write(",");
                }
            }
            sw.Write(sw.NewLine);
        }
        sw.Close();

    }
    protected void Logout(object sender,EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }

    protected void generateCSV(object sender,EventArgs e)
    {
            string date1 = Convert.ToDateTime(TextBox5.Text).ToString("yyyy-MM-dd");
            string date2 = Convert.ToDateTime(TextBox7.Text).ToString("yyyy-MM-dd");
            string time1 = Convert.ToDateTime(TextBox6.Text).ToString("h:mm:ss tt");
            string time2 = Convert.ToDateTime(TextBox8.Text).ToString("h:mm:ss tt");

            string finaldate1 = date1 + " " + time1;
            string finaldate2 = date2 + " " + time2;
            string stop = ConfigurationManager.ConnectionStrings["stop"].ConnectionString;
            using (SqlConnection con = new SqlConnection(stop))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
               string sql = @"Select [Barcode]
               ,[DataAparitiei]
               ,[AnomalyCode]
               ,[CodCuloare]
               ,[Cavitate]
               ,[Defect]
               ,[CLS]
               ,[DataOperatie]
               ,[Descriere]
               ,[Operator]
               ,[Schimb]
           
                from dbo.StopByGrader
                where DataOperatie between '"+finaldate1+"' and '"+finaldate2+"' order by DataOperatie desc";



                cmd.CommandText = sql;
                    cmd.Connection = con;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        GridView1.AllowPaging = true;
                        GridView1.DataSource = dt;
                        GridView1.DataBind();
                        ToCSV(dt, "D:\\ShiftLeaderReaction\\1.csv");
                        Response.Redirect("http://10.202.80.13/ShiftLeaderReaction/File/1.csv");

                    }
                }
            }
        }
    }
