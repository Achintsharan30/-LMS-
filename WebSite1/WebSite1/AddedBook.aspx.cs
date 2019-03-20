using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AddedBook : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void buttonHp_Click(object sender, EventArgs e)
    {
        //nagiavtes to homepage//
        Response.Redirect("HomepageBook.aspx");
    }
}