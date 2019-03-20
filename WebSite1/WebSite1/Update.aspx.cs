using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Update : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnHp_Click(object sender, EventArgs e)
    {
        //this page will nagivates to Addbooks//
        Response.Redirect("HomepageBook.aspx");
    }

    protected void btnupdate_Click(object sender, EventArgs e)
    {
        //this page will nagivates to Addbooks//
        Response.Redirect("UpdatedBook.aspx");
    }
}