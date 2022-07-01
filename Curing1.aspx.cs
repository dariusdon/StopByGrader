using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Curing1 : System.Web.UI.Page
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

    public string c1, c2, c3, c4, c5, c6, c7, c8, c9, c10;
    public string c11, c12, c13, c14, c15, c16, c17, c18, c19, c20;
    public string c21, c22, c23, c24, c25, c26, c27, c28, c29, c30;
    public string c31, c32, c33, c34, c35, c36, c37, c38, c39, c40;
    public string c41, c42, c43, c44, c45, c46, c47, c48, c49, c50;
    public string c51, c52, c53, c54, c55, c56, c57, c58, c59, c60;
    public string c61, c62, c63, c64, c65, c66, c67, c68, c69, c70;
    public string c71, c72, c73, c74, c75, c76, c77, c78, c79, c80;
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
        Param(j);
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b2(object sender, EventArgs e)
    {
        j = 1;
        Param(j);
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b3(object sender, EventArgs e)
    {
        j = 2;
        Param(j);
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b4(object sender, EventArgs e)
    {
        j = 3;
        Param(j);
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b5(object sender, EventArgs e)
    {
        j = 4;
        Param(j);
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b6(object sender, EventArgs e)
    {
        j = 5;
        Param(j);
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b7(object sender, EventArgs e)
    {
        j = 6;
        Param(j);
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b8(object sender, EventArgs e)
    {
        j = 7;
        Param(j);
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b9(object sender, EventArgs e)
    {
        j = 8;
        Param(j);
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b10(object sender, EventArgs e)
    {
        j = 9;
        Param(j);
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b11(object sender, EventArgs e)
    {
        j = 10;
        Param(j);
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b12(object sender, EventArgs e)
    {
        j = 11;
        Param(j);
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b13(object sender, EventArgs e)
    {
        j = 12;
        Param(j);
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b14(object sender, EventArgs e)
    {
        j = 13;
        Param(j);
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b15(object sender, EventArgs e)
    {
        j = 14;
        Param(j);
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b16(object sender, EventArgs e)
    {
        j = 15;
        Param(j);
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b17(object sender, EventArgs e)
    {
        j = 16;
        Param(j);
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b18(object sender, EventArgs e)
    {
        j = 17;
        Param(j);
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b19(object sender, EventArgs e)
    {
        j = 18;
        Param(j);
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b20(object sender, EventArgs e)
    {
        j = 19;
        Param(j);
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b21(object sender, EventArgs e)
    {
        j = 20;
        Param(j);
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b22(object sender, EventArgs e)
    {
        j = 21;
        Param(j);
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b23(object sender, EventArgs e)
    {
        j = 22;
        Param(j);
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b24(object sender, EventArgs e)
    {
        j = 23;
        Param(j);
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b25(object sender, EventArgs e)
    {
        j = 24;
        Param(j);
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b26(object sender, EventArgs e)
    {
        j = 25;
        Param(j);
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b27(object sender, EventArgs e)
    {
        j = 26;
        Param(j);
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b28(object sender, EventArgs e)
    {
        j = 27;
        Param(j);
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b29(object sender, EventArgs e)
    {
        j = 28;
        Param(j);
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b30(object sender, EventArgs e)
    {
        j = 29;
        Param(j);
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b31(object sender, EventArgs e)
    {
        j = 30;
        Param(j);
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b32(object sender, EventArgs e)
    {
        j = 31;
        Param(j);
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b33(object sender, EventArgs e)
    {
        j = 32;
        Param(j);
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b34(object sender, EventArgs e)
    {
        j = 33;
        Param(j);
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b35(object sender, EventArgs e)
    {
        j = 34;
        Param(j);
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b36(object sender, EventArgs e)
    {
        j = 35;
        Param(j);
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b37(object sender, EventArgs e)
    {
        j = 36;
        Param(j);
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b38(object sender, EventArgs e)
    {
        j = 37;
        Param(j);
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b39(object sender, EventArgs e)
    {
        j = 38;
        Param(j);
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b40(object sender, EventArgs e)
    {
        j = 39;
        Param(j);
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b41(object sender, EventArgs e)
    {
        j = 40;
        Param(j);
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b42(object sender, EventArgs e)
    {
        j = 41;
        Param(j);
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b43(object sender, EventArgs e)
    {
        j = 42;
        Param(j);
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b44(object sender, EventArgs e)
    {
        j = 43;
        Param(j);
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b45(object sender, EventArgs e)
    {
        j = 44;
        Param(j);
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b46(object sender, EventArgs e)
    {
        j = 45;
        Param(j);
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b47(object sender, EventArgs e)
    {
        j = 46;
        Param(j);
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b48(object sender, EventArgs e)
    {
        j = 47;
        Param(j);
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b49(object sender, EventArgs e)
    {
        j = 48;
        Param(j);
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b50(object sender, EventArgs e)
    {
        j = 49;
        Param(j);
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b51(object sender, EventArgs e)
    {
        j = 50;
        Param(j);
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b52(object sender, EventArgs e)
    {
        j = 51;
        Param(j);
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b53(object sender, EventArgs e)
    {
        j = 52;
        Param(j);
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b54(object sender, EventArgs e)
    {
        j = 53;
        Param(j);
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b55(object sender, EventArgs e)
    {
        j = 54;
        Param(j);
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b56(object sender, EventArgs e)
    {
        j = 55;
        Param(j);
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b57(object sender, EventArgs e)
    {
        j = 56;
        Param(j);
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b58(object sender, EventArgs e)
    {
        j = 57;
        Param(j);
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b59(object sender, EventArgs e)
    {
        j = 58;
        Param(j);
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b60(object sender, EventArgs e)
    {
        j = 59;
        Param(j);
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b61(object sender, EventArgs e)
    {
        j = 60;
        Param(j);
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b62(object sender, EventArgs e)
    {
        j = 61;
        Param(j);
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b63(object sender, EventArgs e)
    {
        j = 62;
        Param(j);
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b64(object sender, EventArgs e)
    {
        j = 63;
        Param(j);
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b65(object sender, EventArgs e)
    {
        j = 64;
        Param(j);
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b66(object sender, EventArgs e)
    {
        j = 65;
        Param(j);
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b67(object sender, EventArgs e)
    {
        j = 66;
        Param(j);
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b68(object sender, EventArgs e)
    {
        j = 67;
        Param(j);
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b69(object sender, EventArgs e)
    {
        j = 68;
        Param(j);
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b70(object sender, EventArgs e)
    {
        j = 69;
        Param(j);
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b71(object sender, EventArgs e)
    {
        j = 70;
        Param(j);
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b72(object sender, EventArgs e)
    {
        j = 71;
        Param(j);
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b73(object sender, EventArgs e)
    {
        j = 72;
        Param(j);
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b74(object sender, EventArgs e)
    {
        j = 73;
        Param(j);
        string url = "InfoPres.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b75(object sender, EventArgs e)
    {
        j = 74;
        Param(j);
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b76(object sender, EventArgs e)
    {
        j = 75;
        Param(j);
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b77(object sender, EventArgs e)
    {
        j = 76;
        Param(j);
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b78(object sender, EventArgs e)
    {
        j = 77;
        Param(j);
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b79(object sender, EventArgs e)
    {
        j = 78;
        Param(j);
        string url = "InfoPresa.aspx";
        string s = "window.open('" + url + "', 'popup_window', 'width=500,height=700,left=700,top=100,fullscreen=yes');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
    }
    protected void b80(object sender, EventArgs e)
    {
        j = 79;
        Param(j);
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
                string sql = @"";

                
                cmd.CommandText = sql;
                cmd.Connection = con;
                using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    int count = dt.Rows.Count;
                    Session["Data1"] = @"
                SELECT distinct mGDD.barcode,
	            mGDD.ColorSignature,
                mGDD.AnomalyCode,
	            mGDD.Overallgrade,
	            mGDD.PressCavityName as Cavity,
                shiftDateTime

                FROM [TITM15C02DB02\TI_MCAT_HIST].[HistorianAndReports].[dbo].mcat_GradingDetailData mGDD WITH (NOLOCK)
                WHERE shiftDateTime >= DATEADD(HOUR,-8,GETDATE())
                AND mGDD.Overallgrade = 'X'
                ORDER BY shiftDateTime DESC";
                    
                    
                    if (count > 0)
                    {
                        name1 = dt.Rows[0]["GlobalName"].ToString();
                        c1 = dt.Rows[0]["Shortname"].ToString();
                        Color(Button1, c1);
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
                        c2 = dt.Rows[1]["Shortname"].ToString();
                        Color(Button2, c2);
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
                        c3 = dt.Rows[2]["Shortname"].ToString();
                        Color(Button3, c3);
                        Button3.Text = name3;
                        Button3.Visible = true;
                    }
                    else
                    {
                        Button3.Visible = false;
                    }
                    if (count > 3)
                    {
                        c4 = dt.Rows[3]["Shortname"].ToString();
                        Color(Button4, c4);
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
                        c5 = dt.Rows[4]["Shortname"].ToString();
                        Color(Button5, c5);
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
                        c6 = dt.Rows[5]["Shortname"].ToString();
                        Color(Button6, c6);
                        Button6.Text = name6;
                        Button6.Visible = true;
                    }
                    else
                    {
                        Button6.Visible = false;
                    }
                    if (count > 6)
                    {
                        c7 = dt.Rows[6]["Shortname"].ToString();
                        Color(Button7, c7);
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
                        c8 = dt.Rows[7]["Shortname"].ToString();
                        Color(Button8, c8);
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
                        c9 = dt.Rows[8]["Shortname"].ToString();
                        Color(Button9, c9);
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
                        c10 = dt.Rows[9]["Shortname"].ToString();
                        Color(Button10, c10);
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
                        c11 = dt.Rows[10]["Shortname"].ToString();
                        Color(Button11, c11);
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
                        c12 = dt.Rows[11]["Shortname"].ToString();
                        Color(Button12, c12);
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
                        c13 = dt.Rows[12]["Shortname"].ToString();
                        Color(Button13, c13);
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
                        c14 = dt.Rows[13]["Shortname"].ToString();
                        Color(Button14, c14);
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
                        c15 = dt.Rows[14]["Shortname"].ToString();
                        Color(Button15, c15);
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
                        c16 = dt.Rows[15]["Shortname"].ToString();
                        Color(Button16, c16);
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
                        c17 = dt.Rows[16]["Shortname"].ToString();
                        Color(Button17, c17);
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
                        c18 = dt.Rows[17]["Shortname"].ToString();
                        Color(Button18, c18);
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
                        c19 = dt.Rows[18]["Shortname"].ToString();
                        Color(Button19, c19);
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
                        c20 = dt.Rows[19]["Shortname"].ToString();
                        Color(Button20, c20);
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
                        c21 = dt.Rows[20]["Shortname"].ToString();
                        Color(Button21, c21);
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
                        c22 = dt.Rows[21]["Shortname"].ToString();
                        Color(Button22, c22);
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
                        c23 = dt.Rows[22]["Shortname"].ToString();
                        Color(Button23, c23);
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
                        c24 = dt.Rows[23]["Shortname"].ToString();
                        Color(Button24, c24);
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
                        c25 = dt.Rows[24]["Shortname"].ToString();
                        Color(Button25, c25);
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
                        c26 = dt.Rows[25]["Shortname"].ToString();
                        Color(Button26, c26);
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
                        c27 = dt.Rows[26]["Shortname"].ToString();
                        Color(Button27, c27);
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
                        c28 = dt.Rows[27]["Shortname"].ToString();
                        Color(Button28, c28);
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
                        c29 = dt.Rows[28]["Shortname"].ToString();
                        Color(Button29, c29);
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
                        c30 = dt.Rows[29]["Shortname"].ToString();
                        Color(Button30, c30);
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
                        c31 = dt.Rows[30]["Shortname"].ToString();
                        Color(Button31, c31);
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
                        c32 = dt.Rows[31]["Shortname"].ToString();
                        Color(Button32, c32);
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
                        c33 = dt.Rows[32]["Shortname"].ToString();
                        Color(Button33, c33);
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
                        c34 = dt.Rows[33]["Shortname"].ToString();
                        Color(Button34, c34);
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
                        c35 = dt.Rows[34]["Shortname"].ToString();
                        Color(Button35, c35);
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
                        c36 = dt.Rows[35]["Shortname"].ToString();
                        Color(Button36, c36);
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
                        c37 = dt.Rows[36]["Shortname"].ToString();
                        Color(Button37, c37);
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
                        c38 = dt.Rows[37]["Shortname"].ToString();
                        Color(Button38, c38);
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
                        c39 = dt.Rows[38]["Shortname"].ToString();
                        Color(Button39, c39);
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
                        c40 = dt.Rows[39]["Shortname"].ToString();
                        Color(Button40, c40);
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
                        c41 = dt.Rows[40]["Shortname"].ToString();
                        Color(Button41, c41);
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
                        c42 = dt.Rows[41]["Shortname"].ToString();
                        Color(Button42, c42);
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
                        c43 = dt.Rows[42]["Shortname"].ToString();
                        Color(Button43, c43);
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
                        c44 = dt.Rows[43]["Shortname"].ToString();
                        Color(Button44, c44);
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
                        c45 = dt.Rows[44]["Shortname"].ToString();
                        Color(Button45, c45);
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
                        c46 = dt.Rows[45]["Shortname"].ToString();
                        Color(Button46, c46);
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
                        c47 = dt.Rows[46]["Shortname"].ToString();
                        Color(Button47, c47);
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
                        c48 = dt.Rows[47]["Shortname"].ToString();
                        Color(Button48, c48);
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
                        c49 = dt.Rows[48]["Shortname"].ToString();
                        Color(Button49, c49);
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
                        c50 = dt.Rows[49]["Shortname"].ToString();
                        Color(Button50, c50);
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
                        c51 = dt.Rows[50]["Shortname"].ToString();
                        Color(Button51, c51);
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
                        c52 = dt.Rows[51]["Shortname"].ToString();
                        Color(Button52, c52);
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
                        c53 = dt.Rows[52]["Shortname"].ToString();
                        Color(Button53, c53);
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
                        c54 = dt.Rows[53]["Shortname"].ToString();
                        Color(Button54, c54);
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
                        c55 = dt.Rows[54]["Shortname"].ToString();
                        Color(Button55, c55);
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
                        c56 = dt.Rows[54]["Shortname"].ToString();
                        Color(Button56, c56);
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
                        c57 = dt.Rows[56]["Shortname"].ToString();
                        Color(Button57, c57);
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
                        c58 = dt.Rows[57]["Shortname"].ToString();
                        Color(Button58, c58);
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
                        c59 = dt.Rows[58]["Shortname"].ToString();
                        Color(Button59, c59);
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
                        c60 = dt.Rows[59]["Shortname"].ToString();
                        Color(Button60, c60);
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
                        c61 = dt.Rows[60]["Shortname"].ToString();
                        Color(Button61, c61);
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
                        c62 = dt.Rows[61]["Shortname"].ToString();
                        Color(Button62, c62);
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
                        c63 = dt.Rows[62]["Shortname"].ToString();
                        Color(Button63, c63);
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
                        c64 = dt.Rows[63]["Shortname"].ToString();
                        Color(Button64, c64);
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
                        c65 = dt.Rows[64]["Shortname"].ToString();
                        Color(Button65, c65);
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
                        c66 = dt.Rows[65]["Shortname"].ToString();
                        Color(Button66, c66);
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
                        c67 = dt.Rows[66]["Shortname"].ToString();
                        Color(Button67, c67);
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
                        c68 = dt.Rows[67]["Shortname"].ToString();
                        Color(Button68, c68);
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
                        c69 = dt.Rows[68]["Shortname"].ToString();
                        Color(Button69, c69);
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
                        c70 = dt.Rows[69]["Shortname"].ToString();
                        Color(Button70, c70);
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
                        c71 = dt.Rows[70]["Shortname"].ToString();
                        Color(Button71, c71);
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
                        c72 = dt.Rows[71]["Shortname"].ToString();
                        Color(Button72, c72);
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
                        c73 = dt.Rows[72]["Shortname"].ToString();
                        Color(Button73, c73);
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
                        c74 = dt.Rows[73]["Shortname"].ToString();
                        Color(Button74, c74);
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
                        c75 = dt.Rows[74]["Shortname"].ToString();
                        Color(Button75, c75);
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
                        c76 = dt.Rows[75]["Shortname"].ToString();
                        Color(Button76, c76);
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
                        c77 = dt.Rows[76]["Shortname"].ToString();
                        Color(Button77, c77);
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
                        c78 = dt.Rows[77]["Shortname"].ToString();
                        Color(Button78, c78);
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
                        c79 = dt.Rows[78]["Shortname"].ToString();
                        Color(Button79, c79);
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
                        c80 = dt.Rows[79]["Shortname"].ToString();
                        Color(Button80, c80);
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

    protected void Logout(object sender,EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }
    protected void Refresh1(object sender,EventArgs e)
    {
        Response.Redirect("Curing1.aspx");
    }
    protected void Color(Button button,string culoare)
    {

        if (culoare == "Rosu")
        {
            button.BackColor = System.Drawing.Color.Green;
        }
        else
        {
            button.BackColor = System.Drawing.Color.AliceBlue;
        }
    }
    protected void Param(int j)
    {
        string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
        using (SqlConnection con = new SqlConnection(constr))
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                string sql = @"
                SELECT distinct mGDD.barcode,
	            mGDD.ColorSignature,
                mGDD.AnomalyCode,
	            mGDD.Overallgrade,
	            mGDD.PressCavityName as Cavity,
                shiftDateTime

        FROM [TITM15C02DB02\TI_MCAT_HIST].[HistorianAndReports].[dbo].mcat_GradingDetailData mGDD WITH (NOLOCK)
        WHERE shiftDateTime >= DATEADD(HOUR,-8,GETDATE())
        AND mGDD.Overallgrade = 'X'
        ORDER BY shiftDateTime DESC";


                cmd.CommandText = sql;
                cmd.Connection = con;
                using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    Session["Name"] = dt.Rows[j]["GlobalName"];
                }
            }
        }
    }

    //returnezi datele din MCAT
    //faci un filtru de click pe fiecare presa
    //va fi folosita pentru fiecare template creat
    //de acolo trebe sa returneze niste link buttons care sa arate informatiile
    //informatiile se vor face in functie de cod de bare

    protected void getScrap()
    {

    }
    //functia verify ca sa verifici daca a fost atins acel barcode, cod de culori pentru link button
    //si sa se dea disable la buton 
    //de inserat intr-o tabela temporara toate datele
   
   
}