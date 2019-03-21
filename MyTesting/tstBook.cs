using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLibrary;

namespace MyTesting
{
    [TestClass]

    public class tstBook
    {
        //good test data 
        //create some data to pass to the method 
        string AuthorName = "John";
        string BookCategeory = "Action";
        string BookPublisher = "Oxford";
        string Booktitle = "Dark of Knight";
        string BookReleaseDate = DateTime.Now.Date.ToString();

        [TestMethod]

        public void InstanceOK()
        {
            {
                //create an insatance of  the class we want to create
                clsBook AnBook = new clsBook();
                //test to see that it exists
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
                string TestData = "John";
                AnBook.AuthorName = TestData;
                Assert.AreEqual(AnBook.AuthorName, TestData);

            }
        }


        [TestMethod]
        public void BookCategeoryPropertyOK()
        {
            {
                clsBook AnBook = new clsBook();
                string TestData = "Action";
                AnBook.BookCategeory = TestData;
                Assert.AreEqual(AnBook.BookCategeory, TestData);
            }
        }



        [TestMethod]
        public void BookPublisherPropertyOK()
        {
            {
                clsBook AnBook = new clsBook();
                string TestData = "Oxford";
                AnBook.BookPublisher = TestData;
                Assert.AreEqual(AnBook.BookPublisher, TestData);
            }
        }

        [TestMethod]
        public void BookReleasedatePropertyOK()
        {
            {
                clsBook AnBook = new clsBook();
                DateTime TestData = Convert.ToDateTime("12/02/96");
                AnBook.BookReleaseDate = TestData;
                Assert.AreEqual(AnBook.BookReleaseDate, TestData);
            }
        }
        [TestMethod]
        public void BooktitlePropertyOK()
        {
            {
                clsBook AnBook = new clsBook();
                string TestData = "Dark of Knight";
                AnBook.Booktitle = TestData;
                Assert.AreEqual(AnBook.Booktitle, TestData);
            }
        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsBook AnBook = new clsBook();
            Boolean Found = false;
            Int32 Book = 11;
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
            if (AnBook.AuthorName != "John")
            {
                OK = false;
            }
            Assert.IsTrue(OK);

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
            Int32 BookCategeory = 21;
            //invoke the method 
            Found = AnBook.Find(BookCategeory);
            //check the BookCategory
            if (AnBook.BookCategeory != "Action")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
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
            if (AnBook.BookId != 123)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
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
            Assert.IsTrue(OK);
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
            if (AnBook.BookReleaseDate != Convert.ToDateTime("12/12/1998"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestBooktitleFound()
        {
            //create an instance of the class we want to create 
            clsBook AnBook = new clsBook();
            //boolean variable to store the result of the serach 
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is )
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 Booktitle = 21;
            //invoke the method 
            Found = AnBook.Find(Booktitle);
            //check the BookTitle
            if (AnBook.Booktitle != "Dark of Knight")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instsance of the class we want to create 
            clsBook AnBook = new clsBook();
            //string variabke to store any error message 
            string Error = "";
            //invoke the method 
            Error = AnBook.Valid(AuthorName, BookCategeory, BookPublisher, BookReleaseDate, Booktitle);
            //TEST to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void AuthorNameMinLessOne()
        {
            //create an instance of the class we want to create 
            clsBook AnBook = new clsBook();
            //string varibale to store any error message
            string Error = "";
            //create some test data to pass to the method 
            string AuthorName = ""; //this should trigger an error 
                                    //invoke the method 
            Error = AnBook.Valid(AuthorName, BookCategeory, BookPublisher, BookReleaseDate, Booktitle);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");

        }


        [TestMethod]
        public void AuthorNameMin()

        {
            //create an instance of the class we want to create 
            clsBook AnBook = new clsBook();
            //Boolean variable to store the result of validation
            Boolean OK = false;
            //create some test data to pass to the method 
            string AuthorName = "a"; //this should be ok 
                                     //invoke the method 
            OK = AnBook.Valid(AuthorName, BookCategeory, BookPublisher, BookReleaseDate, Booktitle);
            //test to see that the result is correct 
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void AuthorNameMinPlusOne()

        {
            //create an instance of the class we want to create 
            clsBook AnBook = new clsBook();
            //Boolean variable to store the result of validation
            Boolean OK = false;
            //create some test data to pass to the method 
            string AuthorName = "aa"; //this should be ok 
                                      //invoke the method 
            OK = AnBook.Valid(AuthorName, BookCategeory, BookPublisher, BookReleaseDate, Booktitle);
            //test to see that the result is correct 
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void AuthorNameMaxLessOne()

        {
            //create an instance of the class we want to create 
            clsBook AnBook = new clsBook();
            //Boolean variable to store the result of validation
            Boolean OK = false;
            //create some test data to pass to the method 
            string AuthorName = "aaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok 
                                                            //invoke the method 
            OK = AnBook.Valid(AuthorName, BookCategeory, BookPublisher, BookReleaseDate, Booktitle);
            //test to see that the result is correct 
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void AuthorNameMax()

        {
            //create an instance of the class we want to create 
            clsBook AnBook = new clsBook();
            //Boolean variable to store the result of validation
            Boolean OK = false;
            //create some test data to pass to the method 
            string AuthorName = "aaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok 
                                                             //invoke the method 
            OK = AnBook.Valid(AuthorName, BookCategeory, BookPublisher, BookReleaseDate, Booktitle);
            //test to see that the result is correct 
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void AuthorNameMid()

        {
            //create an instance of the class we want to create 
            clsBook AnBookId = new clsBook();
            //Boolean variable to store the result of validation
            Boolean OK = false;
            //create some test data to pass to the method 
            string AuthorName = "aaaaaaaaaaaaa"; //this should be ok 
                                                 //invoke the method 
            OK = AnBook.Valid(AuthorName, BookCategeory, BookPublisher, BookReleaseDate, Booktitle);
            //test to see that the result is correct 
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void AuthorNameMaxPlusOne()
        {
            //create an instsance of the class we want to create 
            clsBook AnBook = new clsBook();
            //string variabke to store any error message 
            string Error = "";
            //create some test dadta to pass to the method 
            string AuthorName = "aaaaaaaaaaaaaaaaaaaaaaaaaa"; //should be fail
                                                              //invoke the method 
            Error = AnBook.Valid(AuthorName, BookCategeory, BookPublisher, BookReleaseDate, Booktitle);
            //TEST to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void BookReleaseDateExtremeMin()
        {
            //create an instsance of the class we want to create 
            clsBook AnBook = new clsBook();
            //string variable to store any error message 
            string Error = "";
            //create variable to variable to store the test data
            DateTime TestDate;
            //set the date to today date
            TestDate = DateTime.Now.Date;
            //Change the date to whatever the date is less 1days
            TestDate = TestDate.AddDays(-1);
            //convert the data variabke to string variable 
            string BookReleaseDate = TestDate.ToString();
            //INVOKE the menthod
            Error = AnBook.Valid(AuthorName, BookCategeory, BookPublisher, BookReleaseDate, Booktitle);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void BookReleaseDateMinLessOne()
        {
            //create an instsance of the class we want to create 
            clsBook AnBook = new clsBook();
            //string variable to store any error message 
            string Error = "";
            //create variable to variable to store the test data
            DateTime TestDate;
            //set the date totoday date
            TestDate = DateTime.Now.Date;
            //Change the date to whatever the date is less 100 years
            TestDate = TestDate.AddDays(-1);
            //convert the data variabke to string variable 
            string BookReleaseDate = TestDate.ToString();
            //INVOKE the menthod
            Error = AnBook.Valid(AuthorName, BookCategeory, BookPublisher, BookReleaseDate, Booktitle);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void BookReleaseDateMin()
        {
            //create an instsance of the class we want to create 
            clsBook AnBook = new clsBook();
            //string variable to store any error message 
            string Error = "";
            //create variable to variable to store the test data
            DateTime TestDate;
            //set the date to today date
            TestDate = DateTime.Now.Date;
            //Convert the data variable to string variable 
            string BookReleaseDate = TestDate.ToString();
            //INVOKE the menthod
            Error = AnBook.Valid(AuthorName, BookCategeory, BookPublisher, BookReleaseDate, Booktitle);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void BookReleaseDateMinPlusOne()
        {
            //create an instsance of the class we want to create 
            clsBook AnBook = new clsBook();
            //string variable to store any error message 
            string Error = "";
            //create variable to variable to store the test data
            DateTime TestDate;
            //set the date to today date
            TestDate = DateTime.Now.Date;
            //cahnge the date variable to whatver the date is plus 1 day 
            TestDate = TestDate.AddDays(1);
            //Convert the data variable to string variable 
            string BookReleaseDate = TestDate.ToString();
            //INVOKE the menthod
            Error = AnBook.Valid(AuthorName, BookCategeory, BookPublisher, BookReleaseDate, Booktitle);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void BookReleaseDateExtremeMax()
        {
            //create an instsance of the class we want to create 
            clsBook AnBook = new clsBook();
            //string variable to store any error message 
            string Error = "";
            //create variable to variable to store the test data
            DateTime TestDate;
            //set the date to today date
            TestDate = DateTime.Now.Date;
            //cahnge the date variable to whatver the date is plus 100 years 
            TestDate = TestDate.AddYears(100);
            //Convert the data variable to string variable 
            string BookReleaseDate = TestDate.ToString();
            //INVOKE the menthod
            Error = AnBook.Valid(AuthorName, BookCategeory, BookPublisher, BookReleaseDate, Booktitle);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void BookReleaseDateInvaidData()
        {
            //create an instsance of the class we want to create 
            clsBook AnBook = new clsBook();
            //string variable to store any error message 
            string Error = "";
            //set the BookRelesaseDate to non date value 
            string BookReleaseDate = "this is not a date!";
            //invoke the method 
            Error = AnBook.Valid(AuthorName, BookCategeory, BookPublisher, BookReleaseDate, Booktitle);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void BookCategeoryMinLessOne()
        {
            //create an instsance of the class we want to create 
            clsBook AnBook = new clsBook();
            //string variable to store any error message 
            string Error = "";
            //this should be fail 
            string BookCategeory = "";
            //invoke the method 
            Error = AnBook.Valid(AuthorName, BookCategeory, BookPublisher, BookReleaseDate, Booktitle);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void BookCategeoryMin()
        {
            //create an instsance of the class we want to create 
            clsBook AnBook = new clsBook();
            //string variable to store any error message 
            string Error = "";
            //this should be pass
            string BookCategeory = "a";
            //invoke the method 
            Error = AnBook.Valid(AuthorName, BookCategeory, BookPublisher, BookReleaseDate, Booktitle);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void BookCategeoryMinPlusOne()
        {
            //create an instsance of the class we want to create 
            clsBook AnBook = new clsBook();
            //string variable to store any error message 
            string Error = "";
            //this should be pass
            string BookCategeory = "aa";
            //invoke the method 
            Error = AnBook.Valid(AuthorName, BookCategeory, BookPublisher, BookReleaseDate, Booktitle);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }



        [TestMethod]
        public void BookCategeoryMaxLessOne()
        {
            //create an instsance of the class we want to create 
            clsBook AnBook = new clsBook();
            //string variable to store any error message 
            string Error = "";
            //this should be Pass
            string BookCategeory = "aaaaaaaaaaaaaa";
            //invoke the method 
            Error = AnBook.Valid(AuthorName, BookCategeory, BookPublisher, BookReleaseDate, Booktitle);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BookCategeoryMax()
        {
            //create an instsance of the class we want to create 
            clsBook AnBook = new clsBook();
            //string variable to store any error message 
            string Error = "";
            //this should be pass
            string BookCategeory = "aaaaaaaaaaaaaaa";
            //invoke the method 
            Error = AnBook.Valid(AuthorName, BookCategeory, BookPublisher, BookReleaseDate, Booktitle);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void BookCategeoryMaxPlusOne()
        {
            //create an instsance of the class we want to create 
            clsBook AnBook = new clsBook();
            //string variable to store any error message 
            string Error = "";
            //this should be fail 
            string BookCategeory = "aaaaaaaaaaaaaaaa";
            //invoke the method 
            Error = AnBook.Valid(AuthorName, BookCategeory, BookPublisher, BookReleaseDate, Booktitle);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void BookCategeoryMid()
        {
            //create an instsance of the class we want to create 
            clsBook AnBook = new clsBook();
            //string variable to store any error message 
            string Error = "";
            //this should be pass
            string BookCategeory = "aaaaaaaa";
            //invoke the method 
            Error = AnBook.Valid(AuthorName, BookCategeory, BookPublisher, BookReleaseDate, Booktitle);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void BookPublisherMinLeesOne()
        {
            //create an instance of the class we want to create 
            clsBook AnBook = new clsBook();
            //string variable to store any error message
            string Error = "";
            //this should be fail 
            string BookPublisher = "";
            //invoke method 
            Error = AnBook.Valid(AuthorName, BookCategeory, BookPublisher, BookReleaseDate, Booktitle);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void BookPublisherMin()
        {
            //create an instance of the class we want to create 
            clsBook AnBook = new clsBook();
            //string variable to store any error message
            string Error = "";
            //this should be pass
            string BookPublisher = "a";
            //invoke method 
            Error = AnBook.Valid(AuthorName, BookCategeory, BookPublisher, BookReleaseDate, Booktitle);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BookPublisherMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsBook AnBook = new clsBook();
            //string variable to store any error message
            string Error = "";
            //this should be pass
            string BookPublisher = "aa";
            //invoke method 
            Error = AnBook.Valid(AuthorName, BookCategeory, BookPublisher, BookReleaseDate, Booktitle);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BookPublisherMaxLessOne()
        {
            //create an instance of the class we want to create 
            clsBook AnBook = new clsBook();
            //string variable to store any error message
            string Error = "";
            //this should be pass 
            string BookPublisher = "aaaaaaaaaaaaaa";
            //invoke method 
            Error = AnBook.Valid(AuthorName, BookCategeory, BookPublisher, BookReleaseDate, Booktitle);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void BookPublisherMax()
        {
            //create an instance of the class we want to create 
            clsBook AnBook = new clsBook();
            //string variable to store any error message
            string Error = "";
            //this should be pass 
            string BookPublisher = "aaaaaaaaaaaaaaa";
            //invoke method 
            Error = AnBook.Valid(AuthorName, BookCategeory, BookPublisher, BookReleaseDate, Booktitle);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void BookPublisherMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsBook AnBook = new clsBook();
            //string variable to store any error message
            string Error = "";
            //this should be FAIL
            string BookPublisher = "aaaaaaaaaaaaaaaa";
            //invoke method 
            Error = AnBook.Valid(AuthorName, BookCategeory, BookPublisher, BookReleaseDate, Booktitle);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void BookPublisherMid()
        {
            //create an instance of the class we want to create 
            clsBook AnBook = new clsBook();
            //string variable to store any error message
            string Error = "";
            //this should be fail 
            string BookPublisher = "aaaaaaa";
            //invoke method 
            Error = AnBook.Valid(AuthorName, BookCategeory, BookPublisher, BookReleaseDate, Booktitle);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void BooktitleMinLessOne()
        {
            //create an  instance of the class we want to create 
            clsBook AnBook = new clsBook();
            //string variable to store any error message 
            String Error = "";
            //this should be fail 
            string Booktitle = "";
            //invoke the method 
            Error = AnBook.Valid(AuthorName, BookCategeory, BookPublisher, BookReleaseDate, Booktitle);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void BooktitleMin()
        {
            //create an  instance of the class we want to create 
            clsBook AnBook = new clsBook();
            //string variable to store any error message 
            String Error = "";
            //this should be pass
            string Booktitle = "a";
            //invoke the method 
            Error = AnBook.Valid(AuthorName, BookCategeory, BookPublisher, BookReleaseDate, Booktitle);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void BooktitleMaxlessOne()
        {
            //create an  instance of the class we want to create 
            clsBook AnBook = new clsBook();
            //string variable to store any error message 
            String Error = "";
            //this should be pass
            string Booktitle = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            //invoke the method 
            Error = AnBook.Valid(AuthorName, BookCategeory, BookPublisher, BookReleaseDate, Booktitle);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void BooktitleMinPlusOne()
        {
            //create an  instance of the class we want to create 
            clsBook AnBook = new clsBook();
            //string variable to store any error message 
            String Error = "";
            //this should be pass
            string Booktitle = "aa";
            //invoke the method 
            Error = AnBook.Valid(AuthorName, BookCategeory, BookPublisher, BookReleaseDate, Booktitle);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void BooktitleMax()
        {
            //create an  instance of the class we want to create 
            clsBook AnBook = new clsBook();
            //string variable to store any error message 
            String Error = "";
            //this should be pass
            string Booktitle = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            //invoke the method 
            Error = AnBook.Valid(AuthorName, BookCategeory, BookPublisher, BookReleaseDate, Booktitle);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BooktitleMaxPlusOne()
        {
            //create an  instance of the class we want to create 
            clsBook AnBook = new clsBook();
            //string variable to store any error message 
            String Error = "";
            //this should be fail
            string Booktitle = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            //invoke the method 
            Error = AnBook.Valid(AuthorName, BookCategeory, BookPublisher, BookReleaseDate, Booktitle);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

     
        }
    }