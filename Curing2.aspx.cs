using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Curing2 : System.Web.UI.Page
{
    //numele preselor
    public string name1, name2, name3, name4, name5, name6, name7, name8, name9, name10;
    public string name11, name12, name13, name14, name15, name16, name17, name18, name19, name20;
    public string name21, name22, name23, name24, name25, name26, name27, name28, name29, name30;
    public string name31, name32, name33, name34, name35, name36, name37, name38, name39, name40;
    public string name41, name42, name43, name44, name45, name46, name47, name48, name49, name50;
    public string name51, name52, name53, name54, name55, name56, name57, name58, name59, name60;
    public string name61, name62, name63, name64, name65, name66, name67, name68, name69, name70;
    public string name71, name72, name73, name74, name75, name76, name77, name78, name79, name80;
    int j = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        GetData();
        getSchimb();
    }
    //functiile butoanelor


    protected void b1(object sender, EventArgs e)
    {
        j = 0;
        Session["name"] = name1;
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b2(object sender, EventArgs e)
    {
        j = 1;
        Session["name"] = name2;
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b3(object sender, EventArgs e)
    {
        j = 2;
        Session["name"] = name3;
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b4(object sender, EventArgs e)
    {
        j = 3;
        Session["name"] = name4;
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b5(object sender, EventArgs e)
    {
        j = 4;
        Session["name"] = name5;
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b6(object sender, EventArgs e)
    {
        j = 5;
        Session["name"] = name6;
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b7(object sender, EventArgs e)
    {
        j = 6;
        Session["name"] = name7;
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b8(object sender, EventArgs e)
    {
        j = 7;
        Session["name"] = name8;
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b9(object sender, EventArgs e)
    {
        j = 8;
        Session["name"] = name9;
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b10(object sender, EventArgs e)
    {
        j = 9;
        Session["name"] = name10;
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b11(object sender, EventArgs e)
    {
        j = 10;
        Session["name"] = name11;
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b12(object sender, EventArgs e)
    {
        j = 11;
        Session["name"] = name12;
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b13(object sender, EventArgs e)
    {
        j = 12;
        Session["name"] = name13;
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b14(object sender, EventArgs e)
    {
        j = 13;
        Session["name"] = name14;
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b15(object sender, EventArgs e)
    {
        j = 14;
        Session["name"] = name15;
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b16(object sender, EventArgs e)
    {
        j = 15;
        Session["name"] = name16;
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b17(object sender, EventArgs e)
    {
        j = 16;
        Session["name"] = name17;
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b18(object sender, EventArgs e)
    {
        j = 17;
        Session["name"] = name18;
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b19(object sender, EventArgs e)
    {
        j = 18;
        Session["name"] = name19;
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b20(object sender, EventArgs e)
    {
        j = 19;
        Session["name"] = name20;
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b21(object sender, EventArgs e)
    {
        j = 20;
        Session["name"] = name21;
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b22(object sender, EventArgs e)
    {
        j = 21;
        Session["name"] = name22;
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b23(object sender, EventArgs e)
    {
        j = 22;
        Session["name"] = name23;
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b24(object sender, EventArgs e)
    {
        j = 23;
        Session["name"] = name24;
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b25(object sender, EventArgs e)
    {
        j = 24;
        Session["name"] = name25;
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b26(object sender, EventArgs e)
    {
        j = 25;
        Session["name"] = name26;
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b27(object sender, EventArgs e)
    {
        j = 26;
        Session["name"] = name27;
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b28(object sender, EventArgs e)
    {
        j = 27;
        Session["name"] = name28;
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b29(object sender, EventArgs e)
    {
        j = 28;
        Session["name"] = name29;
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b30(object sender, EventArgs e)
    {
        j = 29;
        Session["name"] = name30;
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b31(object sender, EventArgs e)
    {
        j = 30;
        Session["name"] = name31;
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b32(object sender, EventArgs e)
    {
        j = 31;
        Session["name"] = name32;
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b33(object sender, EventArgs e)
    {
        j = 32;
        Session["name"] = name33;
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b34(object sender, EventArgs e)
    {
        j = 33;
        Session["name"] = name34;
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b35(object sender, EventArgs e)
    {
        j = 34;
        Session["name"] = name35;
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b36(object sender, EventArgs e)
    {
        j = 35;
        Session["name"] = name36;
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b37(object sender, EventArgs e)
    {
        j = 36;
        Session["name"] = name37;
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b38(object sender, EventArgs e)
    {
        j = 37;
        Session["name"] = name38;
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b39(object sender, EventArgs e)
    {
        j = 38;
        Session["name"] = name39;
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b40(object sender, EventArgs e)
    {
        j = 39;
        Session["name"] = name40;
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b41(object sender, EventArgs e)
    {
        j = 40;
        Session["name"] = name41;
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b42(object sender, EventArgs e)
    {
        j = 41;
        Session["name"] = name42;
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b43(object sender, EventArgs e)
    {
        j = 42;
        Session["name"] = name43;
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b44(object sender, EventArgs e)
    {
        j = 43;
        Session["name"] = name44;
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b45(object sender, EventArgs e)
    {
        j = 44;
        Session["name"] = name45;
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b46(object sender, EventArgs e)
    {
        j = 45;
        Session["name"] = name46;
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b47(object sender, EventArgs e)
    {
        j = 46;
        Session["name"] = name47;
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b48(object sender, EventArgs e)
    {
        j = 47;
        Session["name"] = name48;
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b49(object sender, EventArgs e)
    {
        j = 48;
        Session["name"] = name1;
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b50(object sender, EventArgs e)
    {
        j = 49;
        Session["name"] = name50;
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b51(object sender, EventArgs e)
    {
        j = 50;
        Session["name"] = name1;
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b52(object sender, EventArgs e)
    {
        j = 51;
        Session["name"] = name52;
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b53(object sender, EventArgs e)
    {
        j = 52;
        Session["name"] = name53;
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b54(object sender, EventArgs e)
    {
        j = 53;
        Session["name"] = name54;
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b55(object sender, EventArgs e)
    {
        j = 54;
        Session["name"] = name55;
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b56(object sender, EventArgs e)
    {
        j = 55;
        Session["name"] = name56;
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b57(object sender, EventArgs e)
    {
        j = 56;
        Session["name"] = name57;
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b58(object sender, EventArgs e)
    {
        j = 57;
        Session["name"] = name58;
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b59(object sender, EventArgs e)
    {
        j = 58;
        Session["name"] = name59;
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b60(object sender, EventArgs e)
    {
        j = 59;
        Session["name"] = name60;
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b61(object sender, EventArgs e)
    {
        j = 60;
        Session["name"] = name1;
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b62(object sender, EventArgs e)
    {
        j = 61;
        Session["name"] = name62;
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b63(object sender, EventArgs e)
    {
        j = 62;
        Session["name"] = name63;
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b64(object sender, EventArgs e)
    {
        j = 63;
        Session["name"] = name64;
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b65(object sender, EventArgs e)
    {
        j = 64;
        Session["name"] = name65;
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b66(object sender, EventArgs e)
    {
        j = 65;
        Session["name"] = name66;
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b67(object sender, EventArgs e)
    {
        j = 66;
        Session["name"] = name67;
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b68(object sender, EventArgs e)
    {
        j = 67;
        Session["name"] = name68;
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b69(object sender, EventArgs e)
    {
        j = 68;
        Session["name"] = name69;
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b70(object sender, EventArgs e)
    {
        j = 69;
        Session["name"] = name1;
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b71(object sender, EventArgs e)
    {
        j = 70;
        Session["name"] = name71;
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b72(object sender, EventArgs e)
    {
        j = 71;
        Session["name"] = name72;
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b73(object sender, EventArgs e)
    {
        j = 72;
        Session["name"] = name73;
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b74(object sender, EventArgs e)
    {
        j = 73;
        Session["name"] = name74;
        string url = "InfoPres.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b75(object sender, EventArgs e)
    {
        j = 74;
        Session["name"] = name75;
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b76(object sender, EventArgs e)
    {
        j = 75;
        Session["name"] = name76;
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b77(object sender, EventArgs e)
    {
        j = 76;
        Session["name"] = name77;
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b78(object sender, EventArgs e)
    {
        j = 77;
        Session["name"] = name78;
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b79(object sender, EventArgs e)
    {
        j = 78;
        Session["name"] = name79;
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b80(object sender, EventArgs e)
    {
        j = 79;
        Session["name"] = name80;
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void GetData()
    {
        string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
        using (SqlConnection con = new SqlConnection(constr))
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                string sql = @"SELECT TOP (80)
                [GlobalName]
                ,ShortName
                ,WorkCenter.Name
                FROM [TITM09CGMDB02].[CGMSHistory].[dbo].[Area]
                INNER JOIN [TITM09CGMDB02].[CGMSHistory].[dbo].WorkCenter on Workcenter.AreaIDOrganizational=Area.AreaID";


                cmd.CommandText = sql;
                cmd.Connection = con;
                using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    int count = dt.Rows.Count;
                    Session["Data1"] = "";
                    Session["culoare"] = "";
                    Session["Defect"] = "";
                    Session["CLS"] = "";

                    if (count > 0)
                    {
                        name1 = dt.Rows[0]["GlobalName"].ToString();
                        Button1.Text = name1;
                        Button1.Visible = true;
                    }
                    else
                    {
                        Button1.Visible = false;
                    }
                    if (count > 1)
                    {
                        name2 = dt.Rows[1]["GlobalName"].ToString();
                        Button2.Text = name2;
                        Button2.Visible = true;
                    }
                    else
                    {
                        Button2.Visible = false;
                    }
                    if (count > 2)
                    {
                        name3 = dt.Rows[2]["GlobalName"].ToString();
                        Button3.Text = name3;
                        Button3.Visible = true;
                    }
                    else
                    {
                        Button3.Visible = false;
                    }
                    if (count > 3)
                    {
                        name4 = dt.Rows[3]["GlobalName"].ToString();
                        Button4.Text = name4;
                        Button4.Visible = true;
                    }
                    else
                    {
                        Button4.Visible = false;
                    }
                    if (count > 4)
                    {
                        name5 = dt.Rows[4]["GlobalName"].ToString();
                        Button5.Text = name5;
                        Button5.Visible = true;
                    }
                    else
                    {
                        Button5.Visible = false;
                    }
                    if (count > 5)
                    {
                        name6 = dt.Rows[5]["GlobalName"].ToString();
                        Button6.Text = name6;
                        Button6.Visible = true;
                    }
                    else
                    {
                        Button6.Visible = false;
                    }
                    if (count > 6)
                    {
                        name7 = dt.Rows[6]["GlobalName"].ToString();
                        Button7.Text = name7;
                        Button7.Visible = true;
                    }
                    else
                    {
                        Button7.Visible = false;
                    }
                    if (count > 7)
                    {
                        name8 = dt.Rows[7]["GlobalName"].ToString();
                        Button8.Text = name8;
                        Button8.Visible = true;
                    }
                    else
                    {
                        Button8.Visible = false;
                    }
                    if (count > 8)
                    {
                        name9 = dt.Rows[8]["GlobalName"].ToString();
                        Button9.Text = name9;
                        Button9.Visible = true;
                    }
                    else
                    {
                        Button9.Visible = false;
                    }
                    if (count > 9)
                    {
                        name10 = dt.Rows[9]["GlobalName"].ToString();
                        Button10.Text = name10;
                        Button10.Visible = true;
                    }
                    else
                    {
                        Button10.Visible = false;
                    }
                    if (count > 10)
                    {
                        name11 = dt.Rows[10]["GlobalName"].ToString();
                        Button11.Text = name11;
                        Button11.Visible = true;
                    }
                    else
                    {
                        Button11.Visible = false;
                    }
                    if (count > 11)
                    {
                        name12 = dt.Rows[11]["GlobalName"].ToString();
                        Button12.Text = name12;
                        Button12.Visible = true;
                    }
                    else
                    {
                        Button12.Visible = false;
                    }
                    if (count > 12)
                    {
                        name13 = dt.Rows[12]["GlobalName"].ToString();
                        Button13.Text = name13;
                        Button13.Visible = true;
                    }
                    else
                    {
                        Button13.Visible = false;
                    }
                    if (count > 13)
                    {
                        name14 = dt.Rows[13]["GlobalName"].ToString();
                        Button14.Text = name14;
                        Button14.Visible = true;
                    }
                    else
                    {
                        Button14.Visible = false;
                    }
                    if (count > 14)
                    {
                        name15 = dt.Rows[14]["GlobalName"].ToString();
                        Button15.Text = name15;
                        Button15.Visible = true;
                    }
                    else
                    {
                        Button15.Visible = false;
                    }
                    if (count > 15)
                    {
                        name16 = dt.Rows[15]["GlobalName"].ToString();
                        Button16.Text = name16;
                        Button16.Visible = true;
                    }
                    else
                    {
                        Button16.Visible = false;
                    }
                    if (count > 16)
                    {
                        name17 = dt.Rows[16]["GlobalName"].ToString();
                        Button17.Text = name17;
                        Button17.Visible = true;
                    }
                    else
                    {
                        Button17.Visible = false;
                    }
                    if (count > 17)
                    {
                        name18 = dt.Rows[17]["GlobalName"].ToString();
                        Button18.Text = name8;
                        Button18.Visible = true;
                    }
                    else
                    {
                        Button18.Visible = false;
                    }
                    if (count > 18)
                    {
                        name19 = dt.Rows[18]["GlobalName"].ToString();
                        Button19.Text = name19;
                        Button19.Visible = true;
                    }
                    else
                    {
                        Button19.Visible = false;
                    }
                    if (count > 19)
                    {
                        name20 = dt.Rows[19]["GlobalName"].ToString();
                        Button20.Text = name20;
                        Button20.Visible = true;
                    }
                    else
                    {
                        Button20.Visible = false;
                    }
                    if (count > 20)
                    {
                        name21 = dt.Rows[20]["GlobalName"].ToString();
                        Button21.Text = name21;
                        Button21.Visible = true;
                    }
                    else
                    {
                        Button21.Visible = false;
                    }
                    if (count > 21)
                    {
                        name22 = dt.Rows[21]["GlobalName"].ToString();
                        Button22.Text = name22;
                        Button22.Visible = true;
                    }
                    else
                    {
                        Button22.Visible = false;
                    }
                    if (count > 22)
                    {
                        name23 = dt.Rows[22]["GlobalName"].ToString();
                        Button23.Text = name23;
                        Button23.Visible = true;
                    }
                    else
                    {
                        Button23.Visible = false;
                    }
                    if (count > 23)
                    {
                        name24 = dt.Rows[23]["GlobalName"].ToString();
                        Button24.Text = name24;
                        Button24.Visible = true;
                    }
                    else
                    {
                        Button24.Visible = false;
                    }
                    if (count > 24)
                    {
                        name25 = dt.Rows[24]["GlobalName"].ToString();
                        Button25.Text = name25;
                        Button25.Visible = true;
                    }
                    else
                    {
                        Button25.Visible = false;
                    }
                    if (count > 25)
                    {
                        name26 = dt.Rows[25]["GlobalName"].ToString();
                        Button26.Text = name26;
                        Button26.Visible = true;
                    }
                    else
                    {
                        Button26.Visible = false;
                    }
                    if (count > 26)
                    {
                        name27 = dt.Rows[26]["GlobalName"].ToString();
                        Button27.Text = name27;
                        Button27.Visible = true;
                    }
                    else
                    {
                        Button27.Visible = false;
                    }
                    if (count > 27)
                    {
                        name28 = dt.Rows[27]["GlobalName"].ToString();
                        Button28.Text = name28;
                        Button28.Visible = true;
                    }
                    else
                    {
                        Button28.Visible = false;
                    }
                    if (count > 28)
                    {
                        name29 = dt.Rows[28]["GlobalName"].ToString();
                        Button29.Text = name29;
                        Button29.Visible = true;
                    }
                    else
                    {
                        Button29.Visible = false;
                    }
                    if (count > 29)
                    {
                        name30 = dt.Rows[29]["GlobalName"].ToString();
                        Button30.Text = name30;
                        Button30.Visible = true;
                    }
                    else
                    {
                        Button30.Visible = false;
                    }
                    if (count > 30)
                    {
                        name31 = dt.Rows[30]["GlobalName"].ToString();
                        Button31.Text = name31;
                        Button31.Visible = true;
                    }
                    else
                    {
                        Button31.Visible = false;
                    }
                    if (count > 31)
                    {
                        name32 = dt.Rows[31]["GlobalName"].ToString();
                        Button32.Text = name32;
                        Button32.Visible = true;
                    }
                    else
                    {
                        Button32.Visible = false;
                    }
                    if (count > 32)
                    {
                        name33 = dt.Rows[32]["GlobalName"].ToString();
                        Button33.Text = name33;
                        Button33.Visible = true;
                    }
                    else
                    {
                        Button33.Visible = false;
                    }
                    if (count > 33)
                    {
                        name34 = dt.Rows[33]["GlobalName"].ToString();
                        Button34.Text = name34;
                        Button34.Visible = true;
                    }
                    else
                    {
                        Button34.Visible = false;
                    }
                    if (count > 34)
                    {
                        name35 = dt.Rows[34]["GlobalName"].ToString();
                        Button35.Text = name35;
                        Button35.Visible = true;
                    }
                    else
                    {
                        Button35.Visible = false;
                    }
                    if (count > 35)
                    {
                        name36 = dt.Rows[35]["GlobalName"].ToString();
                        Button36.Text = name36;
                        Button36.Visible = true;
                    }
                    else
                    {
                        Button36.Visible = false;
                    }
                    if (count > 36)
                    {
                        name37 = dt.Rows[36]["GlobalName"].ToString();
                        Button37.Text = name37;
                        Button37.Visible = true;
                    }
                    else
                    {
                        Button37.Visible = false;
                    }
                    if (count > 37)
                    {
                        name38 = dt.Rows[37]["GlobalName"].ToString();
                        Button38.Text = name38;
                        Button38.Visible = true;
                    }
                    else
                    {
                        Button38.Visible = false;
                    }
                    if (count > 38)
                    {
                        name39 = dt.Rows[38]["GlobalName"].ToString();
                        Button39.Text = name39;
                        Button39.Visible = true;
                    }
                    else
                    {
                        Button39.Visible = false;
                    }
                    if (count > 39)
                    {
                        name40 = dt.Rows[39]["GlobalName"].ToString();
                        Button40.Text = name40;
                        Button40.Visible = true;
                    }
                    else
                    {
                        Button40.Visible = false;
                    }
                    if (count > 40)
                    {
                        name41 = dt.Rows[40]["GlobalName"].ToString();
                        Button41.Text = name41;
                        Button41.Visible = true;
                    }
                    else
                    {
                        Button41.Visible = false;
                    }
                    if (count > 41)
                    {
                        name42 = dt.Rows[41]["GlobalName"].ToString();
                        Button42.Text = name42;
                        Button42.Visible = true;
                    }
                    else
                    {
                        Button42.Visible = false;
                    }
                    if (count > 42)
                    {
                        name43 = dt.Rows[42]["GlobalName"].ToString();
                        Button43.Text = name43;
                        Button43.Visible = true;
                    }
                    else
                    {
                        Button43.Visible = false;
                    }
                    if (count > 43)
                    {
                        name44 = dt.Rows[43]["GlobalName"].ToString();
                        Button44.Text = name44;
                        Button44.Visible = true;
                    }
                    else
                    {
                        Button44.Visible = false;
                    }
                    if (count > 44)
                    {
                        name45 = dt.Rows[44]["GlobalName"].ToString();
                        Button45.Text = name5;
                        Button45.Visible = true;
                    }
                    else
                    {
                        Button45.Visible = false;
                    }
                    if (count > 45)
                    {
                        name46 = dt.Rows[45]["GlobalName"].ToString();
                        Button46.Text = name46;
                        Button46.Visible = true;
                    }
                    else
                    {
                        Button46.Visible = false;
                    }
                    if (count > 46)
                    {
                        name47 = dt.Rows[46]["GlobalName"].ToString();
                        Button47.Text = name47;
                        Button47.Visible = true;
                    }
                    else
                    {
                        Button47.Visible = false;
                    }
                    if (count > 47)
                    {
                        name48 = dt.Rows[47]["GlobalName"].ToString();
                        Button48.Text = name48;
                        Button48.Visible = true;
                    }
                    else
                    {
                        Button48.Visible = false;
                    }
                    if (count > 48)
                    {
                        name49 = dt.Rows[48]["GlobalName"].ToString();
                        Button49.Text = name49;
                        Button49.Visible = true;
                    }
                    else
                    {
                        Button49.Visible = false;
                    }
                    if (count > 49)
                    {
                        name50 = dt.Rows[49]["GlobalName"].ToString();
                        Button50.Text = name50;
                        Button50.Visible = true;
                    }
                    else
                    {
                        Button50.Visible = false;
                    }
                    if (count > 50)
                    {
                        name51 = dt.Rows[0]["GlobalName"].ToString();
                        Button51.Text = name51;
                        Button51.Visible = true;
                    }
                    else
                    {
                        Button51.Visible = false;
                    }
                    if (count > 51)
                    {
                        name52 = dt.Rows[51]["GlobalName"].ToString();
                        Button52.Text = name52;
                        Button52.Visible = true;
                    }
                    else
                    {
                        Button52.Visible = false;
                    }
                    if (count > 52)
                    {
                        name53 = dt.Rows[52]["GlobalName"].ToString();
                        Button53.Text = name53;
                        Button53.Visible = true;
                    }
                    else
                    {
                        Button53.Visible = false;
                    }
                    if (count > 53)
                    {
                        name54 = dt.Rows[53]["GlobalName"].ToString();
                        Button54.Text = name54;
                        Button54.Visible = true;
                    }
                    else
                    {
                        Button54.Visible = false;
                    }
                    if (count > 54)
                    {
                        name55 = dt.Rows[54]["GlobalName"].ToString();
                        Button55.Text = name55;
                        Button55.Visible = true;
                    }
                    else
                    {
                        Button55.Visible = false;
                    }
                    if (count > 55)
                    {
                        name56 = dt.Rows[55]["GlobalName"].ToString();
                        Button56.Text = name56;
                        Button56.Visible = true;
                    }
                    else
                    {
                        Button56.Visible = false;
                    }
                    if (count > 56)
                    {
                        name57 = dt.Rows[56]["GlobalName"].ToString();
                        Button57.Text = name57;
                        Button57.Visible = true;
                    }
                    else
                    {
                        Button57.Visible = false;
                    }
                    if (count > 57)
                    {
                        name58 = dt.Rows[57]["GlobalName"].ToString();
                        Button58.Text = name58;
                        Button58.Visible = true;
                    }
                    else
                    {
                        Button58.Visible = false;
                    }
                    if (count > 58)
                    {
                        name59 = dt.Rows[58]["GlobalName"].ToString();
                        Button59.Text = name59;
                        Button59.Visible = true;
                    }
                    else
                    {
                        Button59.Visible = false;
                    }
                    if (count > 59)
                    {
                        name60 = dt.Rows[59]["GlobalName"].ToString();
                        Button60.Text = name60;
                        Button60.Visible = true;
                    }
                    else
                    {
                        Button60.Visible = false;
                    }
                    if (count > 60)
                    {
                        name61 = dt.Rows[60]["GlobalName"].ToString();
                        Button61.Text = name61;
                        Button61.Visible = true;
                    }
                    else
                    {
                        Button61.Visible = false;
                    }
                    if (count > 61)
                    {
                        name62 = dt.Rows[61]["GlobalName"].ToString();
                        Button62.Text = name62;
                        Button62.Visible = true;
                    }
                    else
                    {
                        Button62.Visible = false;
                    }
                    if (count > 62)
                    {
                        name63 = dt.Rows[62]["GlobalName"].ToString();
                        Button63.Text = name63;
                        Button63.Visible = true;
                    }
                    else
                    {
                        Button63.Visible = false;
                    }
                    if (count > 63)
                    {
                        name64 = dt.Rows[63]["GlobalName"].ToString();
                        Button64.Text = name64;
                        Button64.Visible = true;
                    }
                    else
                    {
                        Button64.Visible = false;
                    }
                    if (count > 64)
                    {
                        name65 = dt.Rows[64]["GlobalName"].ToString();
                        Button65.Text = name65;
                        Button65.Visible = true;
                    }
                    else
                    {
                        Button65.Visible = false;
                    }
                    if (count > 65)
                    {
                        name66 = dt.Rows[65]["GlobalName"].ToString();
                        Button66.Text = name66;
                        Button66.Visible = true;
                    }
                    else
                    {
                        Button66.Visible = false;
                    }
                    if (count > 66)
                    {
                        name67 = dt.Rows[66]["GlobalName"].ToString();
                        Button67.Text = name67;
                        Button67.Visible = true;
                    }
                    else
                    {
                        Button67.Visible = false;
                    }
                    if (count > 67)
                    {
                        name68 = dt.Rows[67]["GlobalName"].ToString();
                        Button68.Text = name68;
                        Button68.Visible = true;
                    }
                    else
                    {
                        Button68.Visible = false;
                    }
                    if (count > 68)
                    {
                        name69 = dt.Rows[68]["GlobalName"].ToString();
                        Button69.Text = name69;
                        Button69.Visible = true;
                    }
                    else
                    {
                        Button69.Visible = false;
                    }
                    if (count > 69)
                    {
                        name70 = dt.Rows[69]["GlobalName"].ToString();
                        Button70.Text = name70;
                        Button70.Visible = true;
                    }
                    else
                    {
                        Button70.Visible = false;
                    }
                    if (count > 70)
                    {
                        name71 = dt.Rows[70]["GlobalName"].ToString();
                        Button71.Text = name71;
                        Button71.Visible = true;
                    }
                    else
                    {
                        Button71.Visible = false;
                    }
                    if (count > 71)
                    {
                        name72 = dt.Rows[71]["GlobalName"].ToString();
                        Button72.Text = name72;
                        Button72.Visible = true;
                    }
                    else
                    {
                        Button72.Visible = false;
                    }
                    if (count > 72)
                    {
                        name73 = dt.Rows[72]["GlobalName"].ToString();
                        Button73.Text = name3;
                        Button73.Visible = true;
                    }
                    else
                    {
                        Button73.Visible = false;
                    }
                    if (count > 73)
                    {
                        name74 = dt.Rows[73]["GlobalName"].ToString();
                        Button74.Text = name74;
                        Button74.Visible = true;
                    }
                    else
                    {
                        Button74.Visible = false;
                    }
                    if (count > 74)
                    {
                        name75 = dt.Rows[74]["GlobalName"].ToString();
                        Button75.Text = name75;
                        Button75.Visible = true;
                    }
                    else
                    {
                        Button75.Visible = false;
                    }
                    if (count > 75)
                    {
                        name76 = dt.Rows[75]["GlobalName"].ToString();
                        Button76.Text = name76;
                        Button76.Visible = true;
                    }
                    else
                    {
                        Button76.Visible = false;
                    }
                    if (count > 76)
                    {
                        name77 = dt.Rows[76]["GlobalName"].ToString();
                        Button77.Text = name77;
                        Button77.Visible = true;
                    }
                    else
                    {
                        Button7.Visible = false;
                    }
                    if (count > 77)
                    {
                        name78 = dt.Rows[77]["GlobalName"].ToString();
                        Button78.Text = name78;
                        Button78.Visible = true;
                    }
                    else
                    {
                        Button78.Visible = false;
                    }
                    if (count > 78)
                    {
                        name79 = dt.Rows[78]["GlobalName"].ToString();
                        Button79.Text = name79;
                        Button79.Visible = true;
                    }
                    else
                    {
                        Button79.Visible = false;
                    }
                    if (count > 79)
                    {
                        name80 = dt.Rows[79]["GlobalName"].ToString();
                        Button80.Text = name80;
                        Button80.Visible = true;
                    }
                    else
                    {
                        Button80.Visible = false;
                    }
                }
            }
        }
    }
    protected void getSchimb()
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
                    Session["Schimb"] = shiftcolor;
                }

            }
        }
    }
    protected void Logout(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }
    protected void Refresh1(object sender, EventArgs e)
    {
        Response.Redirect("Curing2.aspx");
    }
}
