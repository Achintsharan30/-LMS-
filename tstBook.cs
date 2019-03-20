using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLibrary;

namespace MyTesting
{
    [TestClass]
    public class tstBook
    {
        public int BookId { get; private set; }

        [TestMethod]
        public void InstanceOK()
        {
            {
                clsBook AnBook = new clsBook();
                Assert.IsNotNull(AnBook);

            }
        }

        [TestMethod]
        public void BookIdPropertyOK()
        {
            {
                clsBook AnBook = new clsBook();
                Int32 TestData = 123;
                AnBook.BookId = TestData;
                Assert.AreEqual(AnBook.BookId, TestData);


            }
        }

        [TestMethod]
        public void AuthorNamePropertyOK()
        {
            {
                clsBook AnBook = new clsBook();
                string TestData = "john";
                AnBook.AuthorName = TestData;
                Assert.AreEqual(AnBook.AuthorName, TestData);

            }
        }


        [TestMethod]
        public void BookCategoryPropertyOK()
        {
            {
                clsBook AnBook = new clsBook();
                string TestData = "History";
                AnBook.BookCategory = TestData;
                Assert.AreEqual(AnBook.BookCategory, TestData);
            }
        }



        [TestMethod]
        public void BookPublisherPropertyOK()
        {
            {
                clsBook AnBook = new clsBook();
                string TestData = "walker books";
                AnBook.BookPublisher = TestData;
                Assert.AreEqual(AnBook.BookPublisher, TestData);
            }
        }

        [TestMethod]
        public void BookreleasedatePropertyOK()
        {
            {
                clsBook AnBook = new clsBook();
                Int32 TestData = 12 - 02 - 96;
                AnBook.Bookreleasedate = TestData;
                Assert.AreEqual(AnBook.Bookreleasedate, TestData);
            }
        }
        [TestMethod]
        public void BooktitlePropertyOK()
        {
            {
                clsBook AnBook = new clsBook();
                string TestData = "ark of blood";
                AnBook.Booktitle = TestData;
                Assert.AreEqual(AnBook.Booktitle, TestData);
            }
        }
        [TestMethod]
        public void ValidMethodOK()

        {
            clsBook Abook = new clsBook();
            string Error = "";
            string Somebook = "Harry";
            Error = Abook.Valid(Somebook);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsBook AnBook = new clsBook();
            Boolean Found = false;
            Int32 Book = 1;
            Found = AnBook.Find(Book);
            Assert.IsTrue(Found);

        }


        [TestMethod]
        public void TestAuthorNameFound()
        {
            //create an instance of the class we want to create 
            clsBook AnBook = new clsBook();
            //boolean variable to store the result of the serach 
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is )
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 AuthorName = 1;
            //invoke the method 
            Found = AnBook.Find(AuthorName);
            //check the author name
            if (AnBook.AuthorName != "Harry")
            {
                OK = false;
            }
            Assert.IsTrue(Found);

        }


         [TestMethod]
        public void TestBookCategeoryFound()
        {
            //create an instance of the class we want to create 
            clsBook AnBook = new clsBook();
            //boolean variable to store the result of the serach 
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is )
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 BookCategeory = 1;
            //invoke the method 
            Found = AnBook.Find(BookCategeory);
            //check the BookCategory
            if (AnBook.BookCategory != "Action")
            {
                OK = false;
            }
            Assert.IsTrue(Found);
        }


        [TestMethod]
        public void TestBookIdFound()
        {
            //create an instance of the class we want to create 
            clsBook AnBook = new clsBook();
            //boolean variable to store the result of the serach 
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is )
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 BookId = 1;
            //invoke the method 
            Found = AnBook.Find(BookId);
            //check the BookId
            if (AnBook.BookId != 1)
            {
                OK = false;
            }
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestBookPublisherFound()
        {
            //create an instance of the class we want to create 
            clsBook AnBook = new clsBook();
            //boolean variable to store the result of the serach 
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is )
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 BookPublisher = 1;
            //invoke the method 
            Found = AnBook.Find(BookPublisher);
            //check the BookPublisher
            if (AnBook.BookPublisher != "Oxford")
            {
                OK = false;
            }
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestBookReleaseDateFound()
        {
            //create an instance of the class we want to create 
            clsBook AnBook = new clsBook();
            //boolean variable to store the result of the serach 
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is )
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 BookReleaseDate = 1;
            //invoke the method 
            Found = AnBook.Find(BookReleaseDate);
            //check the BookReleaseDtae
            if (AnBook.BookReleaseDate != 09-11-2009)
            {
                OK = false;
            }
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestBookTitleFound()
        {
            //create an instance of the class we want to create 
            clsBook AnBook = new clsBook();
            //boolean variable to store the result of the serach 
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is )
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 BookTitle = 1;
            //invoke the method 
            Found = AnBook.Find(BookTitle);
            //check the BookTitle
            if (AnBook.BookTitle != 2)
            {
                OK = false;
            }
            Assert.IsTrue(Found);
        }
    }

}
    