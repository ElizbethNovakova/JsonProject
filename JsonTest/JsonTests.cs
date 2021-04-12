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
        private BookStoreDTO parsedObject;
        private const string FILE_NAME = "books.json";
        [SetUp]
        public void Setup()
        {
            parsedObject = JsonConvert.DeserializeObject<BookStoreDTO>(File.ReadAllText(FILE_NAME));
        }

        [Test]
        public void isBookPresent()
        {
            var expectedBook = new BookDTO("Pascal", "third", "200$");
            var actualBooks = parsedObject.getEBooks();
          
            CollectionAssert.Contains(actualBooks, expectedBook, "json should contain Pascal book");
        }
       
        [Test]
        public void isBookNotPresent()
        {
            var expectedBook = new BookDTO("Java", "fourth", "250$");
            var actualBooks = parsedObject.getEBooks();

            CollectionAssert.DoesNotContain(actualBooks, expectedBook, "json should not contain Java book");
        }
    }
}