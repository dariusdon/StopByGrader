
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Web.UI.WebControls;


public partial class Curing1EXP : System.Web.UI.Page
{
    public EventHandler Click;

    protected void Page_Load(object sender, EventArgs e)
    {
        if ((string)Session["test"] == ">")
        {
            LabelT.Text = "Curing2";
        }
        int contor = 0;
        string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
        using (SqlConnection con = new SqlConnection(constr))
        {
            using (SqlCommand cmd1 = new SqlCommand())
            {
                string sql1 = @"
                            SELECT distinct
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
                            AND mGDD.PressCavityName " + Session["test"] + " 'CU385' order by mGDD.PressCavityName asc";



                cmd1.CommandText = sql1;
                cmd1.Connection = con;
                using (SqlDataAdapter sda = new SqlDataAdapter(cmd1))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    contor = dt.Rows.Count;
                    for (int i = 0; i < contor; i++)
                    {
                        Console.Write(Environment.NewLine);
                        var button = new Button
                        {
                            ID = Convert.ToString(dt.Rows[i]["PressCavityName"]),
                            CommandArgument = Convert.ToString(dt.Rows[i]["PressCavityName"]),
                            Text = Convert.ToString(dt.Rows[i]["PressCavityName"])
                        };

                        button.Command += Load_Items;
                        button.Attributes.Add("style", "margin-right:10px; margin-top:10px;");

                        button.Width = 198;
                        button.Height = 75;

                        button.Font.Bold = true;
                        button.Font.Size = 20;
                        checkyellow(button);
                        checkred(button);
                        checkvisible(button);
                        PlaceHolder1.Controls.Add(button);

                    }

                }
            }

        }
    }


    private void Load_Items(object sender, CommandEventArgs e)
    {

        string name = Convert.ToString(e.CommandArgument);
        Session["Reference"] = name;
        string url = "BarcodeC1.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=600,height=1000,left=700,top=0,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
        //Response.Redirect("Default.aspx");
    }




    public void Logout(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }
    public void Refresh1(object sender, EventArgs e)
    {
        Response.Redirect("Curing1EXP.aspx");
    }
    protected void checkred(Button button)
    {
        string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
        using (SqlConnection con = new SqlConnection(constr))
        {
            using (SqlCommand cmd1 = new SqlCommand())
            {
                string sql1 = @"
                           SELECT
	                               mGDD.PressCavityName,
								   mGDD.AnomalyCode
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
                            AND mGDD.PressCavityName " + Session["test"] + " 'CU385' and PressCavityName = '" + button.Text + "' order by mGDD.PressCavityName asc";



                cmd1.CommandText = sql1;
                cmd1.Connection = con;
                using (SqlDataAdapter sda = new SqlDataAdapter(cmd1))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    int contor = dt.Rows.Count;
                    Parallel.For(0, contor, (i, state) =>
                    {
                        string anomaly = Convert.ToString(dt.Rows[i]["AnomalyCode"]);
                        if (anomaly == "9" || anomaly == "12" || anomaly == "22" || anomaly == "46" || anomaly == "47" || anomaly == "60" || anomaly == "62" || anomaly == "63" ||
                        anomaly == "64" || anomaly == "02AC" || anomaly == "02C" || anomaly == "32A" || anomaly == "32B" || anomaly == "51A" || anomaly == "61A" || anomaly == "61B" ||
                        anomaly == "61C" || anomaly == "65A" || anomaly == "65B" || anomaly == "65C" || anomaly == "65D" || anomaly == "66A" || anomaly == "66B" || anomaly == "66BA" ||
                        anomaly == "66BB" || anomaly == "66BD" || anomaly == "66BE" || anomaly == "66C" || anomaly == "66D" || anomaly == "66P" || anomaly == "66R" || anomaly == "66S" ||
                        anomaly == "67" || anomaly == "68A" || anomaly == "68C" || anomaly == "68D" || anomaly == "68E" || anomaly == "68F" || anomaly == "68G" || anomaly == "68H" ||
                        anomaly == "68H" || anomaly == "68J" || anomaly == "68K" || anomaly == "68L" || anomaly == "6A" || anomaly == "6C" || anomaly == "6D" || anomaly == "6I")
                        {
                            button.BackColor = System.Drawing.Color.Red;
                        }
                    });
                }
            }
        }
    }

    protected void checkyellow(Button button)
    {

        string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
        using (SqlConnection con = new SqlConnection(constr))
        {
            using (SqlCommand cmd1 = new SqlCommand())
            {
                string sql1 = @"
                           SELECT
	                               mGDD.PressCavityName,
								   mGDD.AnomalyCode
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
                            AND mGDD.PressCavityName " + Session["test"] + " 'CU385' and PressCavityName = '" + button.Text + "' order by mGDD.PressCavityName asc";



                cmd1.CommandText = sql1;
                cmd1.Connection = con;
                using (SqlDataAdapter sda = new SqlDataAdapter(cmd1))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    int contor = dt.Rows.Count;
                    Parallel.For(0, contor, (i, state) =>
                    {
                        string compare = Convert.ToString(dt.Rows[i]["AnomalyCode"]);
                        if (compare == "56" || compare == "54A" || compare == "45A" || compare == "42A" || compare == "41B" || compare == "41A" || compare == "31B" || compare == "31A" || compare == "31" || compare == "21"
                            || compare == "14" || compare == "11" || compare == "02B")
                        {
                            button.BackColor = System.Drawing.Color.Yellow;
                        }
                    });
                }
            }
        }

    }
    protected void checkvisible(Button button)
    {
        List<string> list1 = new List<string>();
        string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
        using (SqlConnection con = new SqlConnection(constr))
        {
            using (SqlCommand cmd1 = new SqlCommand())
            {
            string sql1 = @"
             SELECT
	                               mGDD.PressCavityName,
								   mGDD.AnomalyCode,
                                   mGDD.barcode
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
                            AND mGDD.PressCavityName " + Session["test"] + " 'CU385' and PressCavityName = '" + button.Text + "' order by mGDD.PressCavityName asc";

                cmd1.CommandText = sql1;
                cmd1.Connection = con;
                using (SqlDataAdapter sda = new SqlDataAdapter(cmd1))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    int contor = dt.Rows.Count;
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        list1.Add(Convert.ToString(dt.Rows[i]["barcode"]));
                    }
                }
            }
        }
        List<string> list2 = new List<string>();
        int number;
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
                          where Cavitate = '" + button.Text + @"' 
                          and DataOperatie > DATEADD(HOUR,-8,GETDATE())
                          order by DataOperatie desc";

                cmd1.CommandText = sql1;
                cmd1.Connection = con;
                using (SqlDataAdapter sda = new SqlDataAdapter(cmd1))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    number = dt.Rows.Count;
                    for(int i = 0; i < dt.Rows.Count; i++)
                    {
                        list2.Add(Convert.ToString(dt.Rows[0]["Barcode"]));
                        
                        if (list1.Except(list2).ToList().Count == list2.Except(list1).ToList().Count)
                        {
                            button.Visible = false;
                        }
                    }
                }
            }
        }
        
    }
}


