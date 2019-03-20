using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class HomepageBook : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //this page will nagivates to Addbooks//
        Response.Redirect("AddBook.aspx");
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //this page nagivates to delete pages//
        Response.Redirect("Delete.aspx");
    }

    protected void btnView_Click(object sender, EventArgs e)
    {
        //page nagivates to viewBook//
        Response.Redirect("ViewBook.aspx");
    }

    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {

    }



    protected void btnupdateBooks_Click(object sender, EventArgs e)
    {
        //this page will nagivates to Addbooks//
        Response.Redirect("Update.aspx");
    }
}