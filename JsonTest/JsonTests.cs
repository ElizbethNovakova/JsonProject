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
        private BooksDTO parsedObject;
        private const string FILE_NAME = "books.json";
        [SetUp]
        public void Setup()
        {
            parsedObject = JsonConvert.DeserializeObject<BooksDTO>(File.ReadAllText(FILE_NAME));
        }

        [Test]
        public void isBookPresent()
        {
            var expectedBook = new Book("Pascal", "third", "200$");
            var actualBooks = parsedObject.getEBooks();
           
            Assert.IsTrue(actualBooks.Exists(expectedBook.Equals), "json should contain Pascal book");
        }
       
        [Test]
        public void isBookNotPresent()
        {
            var expectedBook = new Book("Java", "fourth", "250$");
            var actualBooks = parsedObject.getEBooks();
            Assert.IsFalse(actualBooks.Exists(expectedBook.Equals), "json should not contain Java book");
        }
    }
}