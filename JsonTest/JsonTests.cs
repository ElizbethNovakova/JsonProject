using NUnit.Framework;
using Newtonsoft.Json;
using System.IO;
using JsonProject;
using System.Collections.Generic;
using System;

namespace JsonTest
{
    public class Tests
    {
        private JSONObject obj;
        [SetUp]
        public void Setup()
        {
           obj = JsonConvert.DeserializeObject<JSONObject>(File.ReadAllText(@"D:\SoftServe\books.json"));
        }

        [Test]
        public void TestName()
        {
            var expected = "Amazon";
            var actual = obj.storeName;
            Assert.AreEqual(expected, actual, "store names must be the same");
        }

        [Test]
        public void TestStoreId()
        {
            var expected = 1;
            var actual = obj.storeId;
            Assert.AreEqual(expected, actual, "store id must be the same");
        }

        [Test]
        public void TestEBooksSize()
        {
            var expected = 3;
            var actual = obj.eBooks.Count;
            Assert.AreEqual(expected, actual, "count of books must be the same");
        }

        [Test]
        public void TestEBooksContainsLanguage()
        {
            List<Book> books = obj.eBooks;
            Assert.IsTrue(books.Exists(book => book.language.Contains("Pascal")));
        }

        [Test]
        public void TestEBooksContainsEdition()
        {
            List<Book> books = obj.eBooks;
            Assert.IsTrue(books.Exists(book => book.edition.Contains("second")));
        }

        [Test]
        public void TestEBooksContainsPrice()
        {
            List<Book> books = obj.eBooks;
            Assert.IsTrue(books.Exists(book => book.price.Contains("150$")));
        }
    }
}