using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLibraryC;
using System.Collections.Generic;
using MyClassLibrary;
using clsBook = MyClassLibraryC.clsBook;

namespace MyTestingC
{
    [TestClass]
    public class tstBookC
    {
        public clsBook TestItem { get; private set; }

        [TestMethod]
        public void InstanceOK()
        {
            clsBookC AllBook = new clsBookC();
            Assert.IsNotNull(AllBook);
        }

        [TestMethod]
        public void BookListOK()
        {
            //Create an instance of the class we want to create 
            clsBookC AllBook = new clsBookC();
            //create some test data to assign to the propery 
            //in this case test data needs to be a list of objevcts 
            List<clsBook> TestList = new List<clsBook>();
            //add an item to theh list 
            //create the items of test data
            clsBookC TestItem = new clsBookC();
            //set its properties 
            TestItem.AuthorName = "john";
            TestItem.BookCategeory = "Action";
            TestItem.BookPublisher = "Oxford";
            TestItem.BookReleaseDate = DateTime.Now.Date;
            TestItem.Booktitle = "Dark of Knight";
            TestItem.BookId = 123;
            //add items to the test list 
            TestList.Add(this.TestItem);
            //assign the data to the property 
            AllBook.BookList = TestList;
            //test to see that the two values are the same  
            Assert.AreEqual(AllBook.BookList, TestList);
        }
        [TestMethod]
        public void CountPropertyOK()
        {
            //Create an instance of the class we want to create 
            clsBookC AllBook = new clsBookC();
            //create some test data to assign to the  property 
            Int32 SomeCount = 2;
            //assign the data to the propery 
            AllBook.Count = SomeCount;
            //test to see that the two value are the same 
            Assert.AreEqual(AllBook.Count, SomeCount);

        }
        [TestMethod]
        public void ThisBookPropertyOK()
        {
            //create an instance of the class we want to create 
            clsBookC AllBook = new clsBookC();
            //create some test data to assign to the  property 
            clsBook TestBook = new clsBook();
            //set the property of the test object 
            TestBook.AuthorName = "john";
            TestBook.BookCategeory = "Action";
            TestBook.BookPublisher = "Oxford";
            TestBook.BookReleaseDate = DateTime.Now.Date;
            TestBook.Booktitle = "Dark of Knight";
            TestBook.BookId = "123";
            //assign the data to the  property 
            AllBook.ThisBook = TestBook;
            //test to see that the two values are the same
            Assert.AreEqual(AllBook.ThisBook, TestBook);
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create 
            clsBookC AllBook = new clsBookC();
            // create some test data to assign to the property
            //in this case data need to be a list of object 
            List<clsBook> TestList = new List<clsBook>();
            //add an items to the list 
            //create the items of test data
            clsBook TestItems = new clsBook();
            //set its properties 
            TestItem.AuthorName = "john";
            TestItem.BookCategeory = "Action";
            TestItem.BookPublisher = "Oxford";
            TestItem.BookReleaseDate = DateTime.Now.Date;
            TestItem.Booktitle = "Dark of Knight";
            TestItem.BookId = "123";
            //add items to the test list 
            TestList.Add(this.TestItem);
            //assign the data to the property 
            AllBook.BookList = TestList;
            //test to see that the two values are the same  
            Assert.AreEqual(AllBook.Count, TestList.Count);

        }
    }
}


