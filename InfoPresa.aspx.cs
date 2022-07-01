using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class InfoPresa : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label11.Visible = false;
        string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
        using (SqlConnection con = new SqlConnection(constr))
        {
            using (SqlCommand cmd1 = new SqlCommand())
            {
                string sql1 = @"SELECT mGDD.barcode,
                               mGDD.AnomalyCode,
                               mGDD.PressCavityName,
                               ShiftDateTime,
                               mGDD.OverallGrade,
                               mGDD.ColorSignature,
                               mAC.descLocal
                               FROM [TITM15C02DB02\TI_MCAT_HIST].[HistorianAndReports].[dbo].mcat_GradingDetailData mGDD WITH (NOLOCK)
                               LEFT JOIN [TITM15C02DB02\TI_MCAT_HIST].[HistorianAndReports].[dbo].mcat_AnomalyCodes mAC WITH (NOLOCK) ON mAC.globalCode = mGDD.AnomalyCode
                               WHERE mGDD.barcode = '" + Session["Barcode"] +"'";
                cmd1.CommandText = sql1;
                cmd1.Connection = con;
                using (SqlDataAdapter sda = new SqlDataAdapter(cmd1))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    Session["Cod"] = dt.Rows[0]["ColorSignature"];
                    Session["Defect"] = dt.Rows[0]["descLocal"];
                    Session["Cls"] = dt.Rows[0]["OverallGrade"];
                    Session["DateShift"] = dt.Rows[0]["ShiftDateTime"];
                    Session["AnomalyCode"] = dt.Rows[0]["AnomalyCode"];
                }
            }
        }

        Label1.Text = "Cavitate:" + Session["Reference"];
        Label9.Text = "Barcode:" + Session["Barcode"];
        Label2.Text = "Data Aparitiei:" + Session["DateShift"];
        Label12.Text = "Cod Anomalie:" + Session["AnomalyCode"];
        Label3.Text = "Cod Culoare:" + Session["Cod"];
        Label4.Text = "Defect:" + Session["Defect"];
        Label5.Text = "CLS:" + Session["Cls"];
        Label6.Text = "Operator:" + Session["Operator"];
        Label7.Text = "Schimb:" + Session["Schimb"];
        Label8.Text = "Data Operatiei:" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
    }
    protected void OnClick(object sender, EventArgs e)
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
               ,[Schimb]
               ,[Barcode]
               ,[AnomalyCode])
            VALUES
           ('" + Session["DateShift"] + @"'
           ,'" + Session["Cod"] + @"'
            ,'" + Session["Reference"] + @"'
            ,'" + Session["Defect"] + @"'
            ,'" + Session["Cls"] + @"'
            ,(convert(varchar, getdate(), 25))
            ,'" + TextBox1.Text + @"'
            ,'" + Session["Operator"] + @"'
            ,'" + Session["Schimb"] + @"'
            ,'" + Session["Barcode"] +@"'
            ,'" + Session["AnomalyCode"] +"')";
                cmd1.CommandText = sql1;
                cmd1.Connection = con;
                using (SqlDataAdapter sda = new SqlDataAdapter(cmd1))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                }
            }
        }
        Label11.Visible = true;
    }
}