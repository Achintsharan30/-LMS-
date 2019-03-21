using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Delete : System.Web.UI.Page
{
   

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Buttonhomepage_Click(object sender, EventArgs e)
    {
        //navagites to homepages//
        Response.Redirect("HomepageBook.aspx");
    }





   
    protected void ButtonDelete_Click(object sender, EventArgs e)
    {
        //page nagivates to viewBook//
        Response.Redirect("DeletedBook.aspx");
    }
}