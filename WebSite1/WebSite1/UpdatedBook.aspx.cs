using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UpdatedBook : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnHpp_Click(object sender, EventArgs e)
    {
        //this page will nagivates to Addbooks//
        Response.Redirect("HomepageBook.aspx");
    }
}