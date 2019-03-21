using System;
using System.Collections.Generic;
using MyClassLibraryC;


namespace MyClassLibraryC
{


    public class clsBookC
    {
        //private data member for list
        List<clsBook> mBookList = new List<clsBook>();

        //private data memebr thisBook
        clsBook mThisBook = new clsBook();

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
                mBookId = value;
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

        public void Add()
        {
            //add new record to the database
            Int32 PrimaryKey;
            //connect to teh database
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@AuthorName", mThisBook.AuthorName);
            DB.AddParameter("@BookCategeory", mThisBook.BookCategeory);
            DB.AddParameter("@BookPublisher", mThisBook.BookPublisher);
            DB.AddParameter("@BookReleaseDate", mThisBook.BookReleaseDate);
            DB.AddParameter("@Booktitle", mThisBook.Booktitle);
            //execute the query return the primary key 
            return DB.Execute("sproc_tblBook_Add");
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

        public void Update()
        {
            throw new NotImplementedException();
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
        //public property for the BookList
        public List<clsBook> BookList
        {
            get
            {
                //return the private data
                return mBookList;
            }
            set
            {
                //set the private data
                mBookList = value;
            }
        }
        //public property for Count
        public int Count
        {
            get
            {
                //return the countt of list
                return mBookList.Count;
            }
            set
            {
                //we shall worry aboiyt this later 
            }
        }

        public clsBook ThisBook
        {
            get
            {
                return mThisBook;
            }
            set
            {
                mThisBook = value;
            }
        }
    public class clsBook
        {
            public DateTime txtbookrd;

            public clsBook ThisBook { get; set; }
            public int Count { get; set; }
            public string BookCategeory { get; set; }
            public string AuthorName { get; set; }
            public string BookPublisher { get; set; }
            public DateTime BookReleaseDate { get; set; }
            public string Booktitle { get; set; }
            public string BookId { get; set; }

            public string Valid(string text1, string text2, string text3, string text4, string text5)
            {
                throw new NotImplementedException();
            }

            public bool Find(int primaryKey)
            {
                throw new NotImplementedException();
            }

            
        }

       
        private int Execute(string v)
        {
            throw new NotImplementedException();
        }

        private void AddParameter(string v, string authorName)
        {
            throw new NotImplementedException();
        }

       
    }
}
