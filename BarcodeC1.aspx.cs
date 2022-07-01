using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class BarcodeC1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        LabelT.Text = Session["Reference"].ToString() + ":Barcodes";
        int contor = 0;
        string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
        using (SqlConnection con = new SqlConnection(constr))
        {
            using (SqlCommand cmd1 = new SqlCommand())
            {
                string sql1 = @"
                           SELECT mGDD.barcode,
                           mGDD.AnomalyCode,
	                       mGDD.PressCavityName

                            FROM [TITM15C02DB02\TI_MCAT_HIST].[HistorianAndReports].[dbo].mcat_GradingDetailData mGDD WITH (NOLOCK)
                            WHERE shiftDateTime >= DATEADD(HOUR,-8,GETDATE()) and mGDD.Overallgrade = 'X'
                            AND (mGDD.AnomalyCode = '9' OR mGDD.AnomalyCode = '12'
                            OR mGDD.AnomalyCode = '02B' or mGDD.AnomalyCode = '22' OR mGDD.AnomalyCode = '11' or mGDD.AnomalyCode = '46'
                            OR mGDD.AnomalyCode = '14' or mGDD.AnomalyCode = '21' or mGDD.AnomalyCode = '47' or mGDD.AnomalyCode = '31' or mGDD.AnomalyCode = '31A' or mGDD.AnomalyCode = '31B'
                            OR mGDD.AnomalyCode = '60' or mGDD.AnomalyCode = '62' or mGDD.AnomalyCode = '41A' or mGDD.AnomalyCode = '41B' or mGDD.AnomalyCode = '42A' or mGDD.AnomalyCode = '45A'
                            or mGDD.AnomalyCode = '63' or mGDD.AnomalyCode = '64' or mGDD.AnomalyCode = '02AC' or mGDD.AnomalyCode = '54A' or mGDD.AnomalyCode = '56' or mGDD.AnomalyCode = '02C' 
                            or mGDD.AnomalyCode = '32A' or mGDD.AnomalyCode = '32B' or mGDD.AnomalyCode = '51A' or mGDD.AnomalyCode = '61A' or mGDD.AnomalyCode = '61B' or mGDD.AnomalyCode = '61C'
                            or mGDD.AnomalyCode = '65A' or mGDD.AnomalyCode = '65B' or mGDD.AnomalyCode = '65C' or mGDD.AnomalyCode = '65D' or mGDD.AnomalyCode = '66A' or mGDD.AnomalyCode = '66BA'
                            or mGDD.AnomalyCode = '66BB' or mGDD.AnomalyCode = '66BD' or mGDD.AnomalyCode = '66BE' or mGDD.AnomalyCode = '66D' or mGDD.AnomalyCode = '66C' or mGDD.AnomalyCode = '66P'
                            or mGDD.AnomalyCode = '66R' or mGDD.AnomalyCode = '66S' or mGDD.AnomalyCode = '67' or mGDD.AnomalyCode = '68A' or mGDD.AnomalyCode = '68B' or mGDD.AnomalyCode = '68C' 
                            or mGDD.AnomalyCode = '68D' or mGDD.AnomalyCode = '68E' or mGDD.AnomalyCode = '68F' or mGDD.AnomalyCode = '68G' or mGDD.AnomalyCode = '68H' or mGDD.AnomalyCode = '68J' 
                            or mGDD.AnomalyCode = '68K' or mGDD.AnomalyCode = '68L' or mGDD.AnomalyCode = '6A' or mGDD.AnomalyCode = '6C' or mGDD.AnomalyCode = '6D' or mGDD.AnomalyCode = '6I')
                            and mGDD.PressCavityName = '" + Session["Reference"] +"' " +
                            "order by mGDD.barcode desc";

                cmd1.CommandText = sql1;
                cmd1.Connection = con;
                using (SqlDataAdapter sda = new SqlDataAdapter(cmd1))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    contor = dt.Rows.Count;
                    for (int i = 0; i < contor; i++)
                    {
                        var button = new Button
                        {
                            ID = Convert.ToString(dt.Rows[i]["barcode"]),
                            CommandArgument = Convert.ToString(dt.Rows[i]["barcode"]),
                            Text = Convert.ToString(dt.Rows[i]["barcode"])
                        };
                        button.Attributes.Add("style", "margin-right:100%; margin-top:20px;display: inline-block;border-radius:10px");
                        button.ForeColor = System.Drawing.Color.Black;
                        button.Font.Size = 20;
                        button.Width = 250;
                        button.Height = 75;
                        button.Font.Bold = true;
                        button.BackColor = System.Drawing.Color.White;
                        button.BorderWidth = 3;
                        button.Command += Load_Items;
                        color(button);
                        check(button);
                        PlaceHolder1.Controls.Add(button);
                    }
                }
            }
        }            
    }


    protected void color(Button button)
    {
        int contor = 0;
      
        string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
        using (SqlConnection con = new SqlConnection(constr))
        {
            using (SqlCommand cmd1 = new SqlCommand())
            {
                string sql1 = @"
                           SELECT mGDD.barcode,
                           mGDD.AnomalyCode,
	                       mGDD.PressCavityName

                            FROM [TITM15C02DB02\TI_MCAT_HIST].[HistorianAndReports].[dbo].mcat_GradingDetailData mGDD WITH (NOLOCK)
                            WHERE shiftDateTime >= DATEADD(HOUR,-8,GETDATE()) and mGDD.Overallgrade = 'X'
                            AND (mGDD.AnomalyCode = '9' OR mGDD.AnomalyCode = '12'
                            OR mGDD.AnomalyCode = '02B' or mGDD.AnomalyCode = '22' OR mGDD.AnomalyCode = '11' or mGDD.AnomalyCode = '46'
                            OR mGDD.AnomalyCode = '14' or mGDD.AnomalyCode = '21' or mGDD.AnomalyCode = '47' or mGDD.AnomalyCode = '31' or mGDD.AnomalyCode = '31A' or mGDD.AnomalyCode = '31B'
                            OR mGDD.AnomalyCode = '60' or mGDD.AnomalyCode = '62' or mGDD.AnomalyCode = '41A' or mGDD.AnomalyCode = '41B' or mGDD.AnomalyCode = '42A' or mGDD.AnomalyCode = '45A'
                            or mGDD.AnomalyCode = '63' or mGDD.AnomalyCode = '64' or mGDD.AnomalyCode = '02AC' or mGDD.AnomalyCode = '54A' or mGDD.AnomalyCode = '56' or mGDD.AnomalyCode = '02C' 
                            or mGDD.AnomalyCode = '32A' or mGDD.AnomalyCode = '32B' or mGDD.AnomalyCode = '51A' or mGDD.AnomalyCode = '61A' or mGDD.AnomalyCode = '61B' or mGDD.AnomalyCode = '61C'
                            or mGDD.AnomalyCode = '65A' or mGDD.AnomalyCode = '65B' or mGDD.AnomalyCode = '65C' or mGDD.AnomalyCode = '65D' or mGDD.AnomalyCode = '66A' or mGDD.AnomalyCode = '66BA'
                            or mGDD.AnomalyCode = '66BB' or mGDD.AnomalyCode = '66BD' or mGDD.AnomalyCode = '66BE' or mGDD.AnomalyCode = '66D' or mGDD.AnomalyCode = '66C' or mGDD.AnomalyCode = '66P'
                            or mGDD.AnomalyCode = '66R' or mGDD.AnomalyCode = '66S' or mGDD.AnomalyCode = '67' or mGDD.AnomalyCode = '68A' or mGDD.AnomalyCode = '68B' or mGDD.AnomalyCode = '68C' 
                            or mGDD.AnomalyCode = '68D' or mGDD.AnomalyCode = '68E' or mGDD.AnomalyCode = '68F' or mGDD.AnomalyCode = '68G' or mGDD.AnomalyCode = '68H' or mGDD.AnomalyCode = '68J' 
                            or mGDD.AnomalyCode = '68K' or mGDD.AnomalyCode = '68L' or mGDD.AnomalyCode = '6A' or mGDD.AnomalyCode = '6C' or mGDD.AnomalyCode = '6D' or mGDD.AnomalyCode = '6I')
                            and mGDD.PressCavityName = '" + Session["Reference"] + "' " +
                            "order by mGDD.barcode desc";

                cmd1.CommandText = sql1;
                cmd1.Connection = con;
                using (SqlDataAdapter sda = new SqlDataAdapter(cmd1))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    contor = dt.Rows.Count;
                    for (int i = 0; i < contor; i++)
                    {
                        string test = (string)dt.Rows[i]["barcode"];
                        string compare = (string)dt.Rows[i]["AnomalyCode"];
                        if ((compare == "9" || compare == "12" || compare == "22" || compare == "46" || compare == "47" || compare == "60" || compare == "62" || compare == "63" || compare == "64"
                            || compare == "02AC" || compare == "02C" || compare == "32A" || compare == "32B" || compare == "51A" || compare == "61A" || compare == "61C" || compare == "65A" || compare == "65B"
                            || compare == "65C" || compare == "65D" || compare == "66A" || compare == "66B" || compare == "66BA" || compare == "66BB" || compare == "66BD" || compare == "66BE" || compare == "66C"
                            || compare == "66P" || compare == "66R" || compare == "66S" || compare == "66D"
                            || compare == "67" || compare == "68A" || compare == "68B" || compare == "68C" || compare == "68D" || compare == "68E" || compare == "68F" || compare == "68G" || compare == "68H"
                            || compare == "68J" || compare == "68K" || compare == "68L" || compare == "6A" || compare == "6C" || compare == "6D" || compare == "6I") && button.Text == test)
                        {
                            button.BackColor = System.Drawing.Color.Red;
                            button.ForeColor = System.Drawing.Color.Black;
                            button.BorderColor = System.Drawing.Color.Black;
                            button.Font.Bold = true;
                            button.BorderWidth = 0;
                        }
                        if ((compare == "56" || compare == "54A" || compare == "45A" || compare == "42A" || compare == "41B" || compare == "41A" || compare == "31B" || compare == "31A" || compare == "31" || compare == "21"
                            || compare == "14" || compare == "11" || compare == "02B") && button.Text == test)
                        {
                            button.BackColor = System.Drawing.Color.Yellow;
                            button.ForeColor = System.Drawing.Color.Black;
                            button.Font.Bold = true;
                            button.BorderColor = System.Drawing.Color.Black;
                            button.BorderWidth = 0;
                        }

                    }
                }
            }
        }
    }

    protected void check(Button button)
    {
        string barcode = button.Text;
        string stop = ConfigurationManager.ConnectionStrings["stop"].ConnectionString;
        using (SqlConnection con = new SqlConnection(stop))
        {
            using (SqlCommand cmd1 = new SqlCommand())
            {
                string sql1 = @"SELECT TOP (1000) [DataAparitiei]
                              ,[CodCuloare]
                              ,[Cavitate]
                              ,[Defect]
                              ,[CLS]
                              ,[DataOperatie]
                              ,[Descriere]
                              ,[Operator]
                              ,[Schimb]
                              ,[Barcode]
                          FROM [APPS].[dbo].[StopByGrader]
                          where Barcode = '" + barcode + @"'
                          order by DataOperatie desc";

                cmd1.CommandText = sql1;
                cmd1.Connection = con;
                using (SqlDataAdapter sda = new SqlDataAdapter(cmd1))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        button.BackColor = System.Drawing.Color.LawnGreen;
                    }
                }
            }
        }
    }
    
    private void Load_Items(object sender, CommandEventArgs e)
    {

        string name = Convert.ToString(e.CommandArgument);
        Session["Barcode"] = name;
        Response.Redirect("InfoPresa.aspx");
    }
  
}