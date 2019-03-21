﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLibraryC;
using System.Collections.Generic;
using MyClassLibrary;
using MyClassLibraryC;




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
            TestBook.BookId = 123;
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
            TestItem.BookId = 123;
            //add items to the test list 
            TestList.Add(this.TestItem);
            //assign the data to the property 
            AllBook.BookList = TestList;
            //test to see that the two values are the same  
            Assert.AreEqual(AllBook.Count, TestList.Count);

        }
        [TestMethod]
        public void AddMethod()
        {

            //create an instance of the class we want to create 
            clsBookC AllBook = new clsBookC();
            //create the items of test data 
            clsBook TestItems = new clsBook();
            //var to store the primary key 
            Int32 PrimaryKey = 0;
            //set its properties 
            TestItems.AuthorName = "John";
            TestItems.BookCategeory = "Action";
            TestItems.BookPublisher = "Oxford";
            TestItems.BookReleaseDate = DateTime.Now.Date;
            TestItems.Booktitle = "Dark Of Knight";
            //set This Address to the test data
            AllBook.ThisBook = TestItem;
            //add the record 
            PrimaryKey = AllBook.Add();
            //set the primary key 
            TestItem.BookId = PrimaryKey;
            //find the record 
            AllBook.ThisBook.Find(PrimaryKey);
            //test to see that the two value are the same 
            Assert.AreEqual(AllBook.ThisBook, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //CREATE AN INSTANCE OF THE CLASS WE WANT TO CREATE 
            clsBookC AllBook = new clsBookC();
            //create the item of test data 
            clsBook TestItems = new clsBook();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties 
            TestItem.AuthorName = "john";
            TestItem.BookCategeory = "Action";
            TestItem.BookPublisher = "Oxford";
            TestItem.BookReleaseDate = DateTime.Now.Date;
            TestItem.BookId = 1;
            TestItem.Booktitle = "Dark of Knight";
            //set thisbook to the test data
            AllBook.ThisBook = TestItem;
            //add the record
            PrimaryKey = AllBook.Add();
            //set the primary key of the test data
            TestItem.BookId = PrimaryKey;
            //find the record
            AllBook.Delete();
            //now find the record
            Boolean Found = AllBook.ThisBook.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }
    }
        [TestMethod]
        public void UpdateMethodOK()
        {
        clsBookC AllBook = new clsBookC();
        //create the item of test data 
        clsBook TestItems = new clsBook();
        //var to store the primary key
        Int32 PrimaryKey = 0;
        //set its properties 
        TestItem.AuthorName = "john";
        TestItem.BookCategeory = "Action";
        TestItem.BookPublisher = "Oxford";
        TestItem.BookReleaseDate = DateTime.Now.Date;
        TestItem.Booktitle = "Dark of Knight";
        //set thisbook to the test data
        AllBook.ThisBook = TestItem;
        //add the record
        PrimaryKey = AllBook.Add();
        //set the primary key of the test data
        TestItem.BookId = PrimaryKey;
        //modify the test data 
        TestItems.AuthorName = "john";
        TestItems.BookCategeory = "Action";
        TestItem.BookReleaseDate = DateTime.Now.Date;
        TestItem.Booktitle = "Dark of Knight";
        //update the record 
        AllBook.Update();
        //find the record
        AllBook.ThisBook.Find(PrimaryKey);
        //test to see Thisbook matches the test data 
        Assert.AreEqual(AllBook.ThisBook, TestItem);
    }

    
}


