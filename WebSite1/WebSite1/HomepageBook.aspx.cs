using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class HomepageBook : System.Web.UI.Page
{
    //var to store the blood number
    Int32 BookId;
    //event handler for the page load event
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the sesssion object to indiacrte this is new record
        Session["BookId"] = -1;

        //this page will nagivates to Addbooks//
        Response.Redirect("AddBook.aspx");
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record 
        Int32 BookId;
        //if a record has been selected from list 
        if (LstBook.SelectedIndex != -1)
        {
            //get the primary key value of the record 
            BookId = Convert.ToInt32(LstBook.SelectedValue);
            //store the data 
            Session["BookId"] = BookId;
            //redirect to the delete
        }

        //this page nagivates to delete pages//
        Response.Redirect("Delete.aspx");
    
         { 
            else //if no recored 
            {
                lblError.Text = "PLEASE SELCTED A RECORD TO DELETE FROM LIST";
            
            }
        }
    }

    protected void btnView_Click(object sender, EventArgs e)
    {
        //var to store the record count
        Int32 RecordCount;
        //assign the results of the DisplayBook function to the record count var
        


        //page nagivates to viewBook//
        Response.Redirect("ViewBook.aspx");
    }

    


    protected void btnupdateBooks_Click(object sender, EventArgs e)
    {
        //this page will nagivates to Addbooks//
        Response.Redirect("Update.aspx");
    }

    protected void LstBook_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
