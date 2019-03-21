using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyClassLibraryC;
using MyClassLibrary;

namespace MyClassLibrary
{


    public class clsBook
    {
        //private data member for the BookId property 
        private Int32 mBookId;

        //private data member for the AuthorName property 
        private String mAuthorName;

        //private data member for the BookCategeory property 
        private String mBookCategeory;

        //private data member for the BookPublisher property 
        private String mBookPublisher;

        //private data member for the Booktitle property 
        private String mBooktitle;

        //private data member for the BookReleaseDate property 
        private DateTime mBookReleaseDate;



        clsDataConnection mThisBook = new clsDataConnection();

        
        //public property for BookId
        public int BookId
        {
            get
            {
                // return the private data 
                return mBookId;
            }
            set
            {
                //set the private data	
                BookId = value;
            }
        }


        //public property for AuthorName
        public string AuthorName
        {
            get
            {
                // return the private data 
                return mAuthorName;
            }
            set
            {
                //set the private data	
                mAuthorName = value;
            }
        }


        //public property for BookCategeory
        public string BookCategeory
        {
            get
            {
                // return the private data 
                return mBookCategeory;
            }
            set
            {
                //set the private data	
                mBookCategeory = value;
            }
        }


        //public property for BookPublisher
        public string BookPublisher
        {
            get
            {
                // return the private data 
                return mBookPublisher;
            }
            set
            {
                //set the private data	
                mBookPublisher = value;
            }
        }


        //public property for BookReleaseDate
        public DateTime BookReleaseDate
        {
            get
            {
                // return the private data 
                return mBookReleaseDate;
            }
            set
            {
                //set the private data	
                mBookReleaseDate = value;
            }
        }

        //public property for BookTitle
        public string Booktitle
        {
            get
            {
                // return the private data 
                return mBooktitle;
            }
            set
            {
                //set the private data	
                mBooktitle = value;
            }
        }

        public object DataTable { get; private set; }
        public int Count { get; set; }
        
        public bool Find(int BookId)

        {
            // create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add paramater for the address no to search for 
            DB.AddParameter("@BookId", BookId);
            //execute the store Procedure 
            DB.Execute("sproc_tblBook_FilterByBookId");
            //if one record is found (there should be either one ore zero
            if (DB.Count == 1)
            {
                //copy the data from the database to private data members
                mBookId = Convert.ToInt32(DB.DataTable.Rows[0]["BookId"]);

                mAuthorName = Convert.ToString(DB.DataTable.Rows[0]["AuthorName"]);

                mBookCategeory = Convert.ToString(DB.DataTable.Rows[0]["BookCategeory"]);

                mBookPublisher = Convert.ToString(DB.DataTable.Rows[0]["BookPublisher"]);

                mBookReleaseDate = Convert.ToDateTime(DB.DataTable.Rows[0]["BookReleaseDate"]);

                mBooktitle = Convert.ToString(DB.DataTable.Rows[0]["Booktitle"]);

                //return that evertthing worked OK
                return true;
            }

            //if no record was found 
            else
            {
                //return false indicating a problem
                return false;
            }
        }

        private void Execute(string v)
        {
            throw new NotImplementedException();
        }

        private void AddParameter(string v, int bookId)
        {
            throw new NotImplementedException();
        }

        public string Valid(string AuthorName, string BookCategeory, string BookPublisher, string BookReleaseDate, string Booktitle)
        {
            //create a string variable to store the error 
            string Error = "";
            //create a temp variable to store data values
            DateTime DateTemp;
            //if (AuthrName is blank
            if (AuthorName.Length == 0)
            {
                //recored the error 
                Error = Error + "The AuthorName may not be blank:";
            }
            // if the Authir name is greater then 25 char
            if (AuthorName.Length > 25)
            {
                //error the record 
                Error = Error + "The AuthorName must be less than 25 characters:";
            }

            //copy the dateAdded value to the DateTemp Variable 
            DateTemp = Convert.ToDateTime(BookReleaseDate);
            if (DateTemp < DateTime.Now.Date)
            {
                //record the error 
                Error = Error + "The date cannot be in the past :";
            }
            //check to see if the date is greater than today date 
            if (DateTemp > DateTime.Now.Date)
            {
                //record the error 
                Error = Error + "The date cannot be in the future:";
            }
            
                //is the BookCategeory blanlk
                if (BookCategeory.Length == 0)
                {
                //record the error 
                Error = Error + " The BookCategeroy may not be blank:";
            }
            // if (BookCategeory code is too long 
            if(BookCategeory.Length >15)
            {
                //record the error 
                Error = Error + " The BookCategeroy must be less than 15 characters:";
            }
            //is the BookPublisher 
            if(BookPublisher.Length == 0)
            {
                //record the error 
                Error = Error + "The BookPublisher may not be blank:";
            }
            // if BookPublisher code is too long 
            if (BookPublisher.Length > 15)
            {
                //record the error 
                Error = Error + " The BookPublisher must be less than 15 characters:";
            }
            //is the Booktilte
            if (Booktitle.Length == 0)
            {
                //record the error 
                Error = Error + "The Booktitle may not be blank:";
            }
            // if Booktitle code is too long 
            if (Booktitle.Length > 40)
            {
                //record the error 
                Error = Error + " The Booktitle must be less than 40 characters:";
            }
            //return any error message
            return Error;
        }

        public void Delete()
        {
            //detele the record pointed by thisbook
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameter for the stored p
            DB.AddParameter("@BookId", mThisBook.BookId);
            //exexute the scored 
            DB.Execute("sproc_tblBook_Delete");
        }

       public void add()
            {
                //add new record to the database
                //connect to teh database
                clsDataConnection DB = new clsDataConnection();
        //set the parameter forr store procedure
        DB.AddParameter("@AuthorName", mThisBook.AuthorName);
                DB.AddParameter("@BookCategeory", mThisBook.BookCategeory);
                DB.AddParameter("@BookPublisher", mThisBook.BookPublisher);
                DB.AddParameter("@BookReleaseDate", mThisBook.BookReleaseDate);
                DB.AddParameter("@Booktitle", mThisBook.Booktitle);
                //execute the query return the primary key 
                 DB.Execute("sproc_tblBook_Add");
            }
        public void Update()
        {
            //add new record to the database
            //connect to teh database
            clsDataConnection DB = new clsDataConnection();
            //set the parameter forr store procedure
            DB.AddParameter("@AuthorName", mThisBook.AuthorName);
            DB.AddParameter("@BookCategeory", mThisBook.BookCategeory);
            DB.AddParameter("@BookPublisher", mThisBook.BookPublisher);
            DB.AddParameter("@BookReleaseDate", mThisBook.BookReleaseDate);
            DB.AddParameter("@Booktitle", mThisBook.Booktitle);
            //execute the query return the primary key  
            DB.Execute("sproc_tblBook_Update");
        }

    }
}



 























