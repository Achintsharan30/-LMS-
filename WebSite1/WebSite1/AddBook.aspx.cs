using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyClassLibrary;
using MyClassLibraryC;
using MyClassLibrary;


public partial class AddBook : System.Web.UI.Page
{
    public int BookId { get; private set; }

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button2_Click(object sender, EventArgs e)
    {

    }

    protected void TextBox3_TextChanged(object sender, EventArgs e)
    {

    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void buttonAdd_Click(object sender, EventArgs e)
    {
        if (BookId  == -1)
        {
            //add the new record
            Add();
        }
        else
        {
            //update the record
            Update();
        }
        //var to store any error messages
        string ErrorMsg;
        //create an instance 
        clsBookC WebSite1 = new clsBookC();
        ErrorMsg = WebSite1.ThisBook.Valid(txtAuthorname.Text, txtBookCategeory.Text,  txtBookPub.Text, txtBooktitle.Text, txtbookrd.Text);
        if (ErrorMsg == "")
        {
            //set the first name property of the object
            WebSite1.ThisBook.AuthorName = txtAuthorname.Text;
            WebSite1.ThisBook.BookCategeory = txtBookCategeory.Text;
            WebSite1.ThisBook.Booktitle = txtBooktitle.Text;
            WebSite1.ThisBook.BookReleaseDate = Convert.ToDateTime(txtbookrd.Text);
            WebSite1.ThisBook.BookPublisher = txtBookPub.Text;
            //add record 
            WebSite1.Add();
            
             { 
                else //this is an existing record to update
                // set the first name property of the object
                WebSite1.ThisBook.AuthorName = txtAuthorname.Text;
                WebSite1.ThisBook.BookCategeory = txtBookCategeory.Text;
                WebSite1.ThisBook.Booktitle = txtBooktitle.Text;
                WebSite1.ThisBook.BookReleaseDate = Convert.ToDateTime(txtbookrd.Text);
                WebSite1.ThisBook.BookPublisher = txtBookPub.Text;
                //update record
                WebSite1.Update();
                
            }

        }

        Response.Redirect("AddedBook.aspx");
    }

    private void Add()
    {
        throw new NotImplementedException();
    }

    private void Update()
    {
        throw new NotImplementedException();
    }

    protected void buttonHomepage_Click(object sender, EventArgs e)
    {
        Response.Redirect("HomepageBook.aspx");
    }
}