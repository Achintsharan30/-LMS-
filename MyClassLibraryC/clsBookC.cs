using System;
using System.Collections.Generic;

namespace MyClassLibraryC
{
    public class clsBookC
    {
        //private data member for list
        List<clsBook> mBookList = new List<clsBook>();

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

        public clsBook ThisBook { get; set; }
        
    }

    public class clsBook
    {
       
        public clsBook ThisBook { get; set; }
        public int Count { get; set; }
        public string BookCategeory { get; set; }
        public string AuthorName { get; set; }
        public string BookPublisher { get; set; }
        public DateTime BookReleaseDate { get; set; }
        public string Booktitle { get; set; }
        public string BookId { get; set; }
    }
}