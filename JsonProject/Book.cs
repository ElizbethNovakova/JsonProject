using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace JsonProject
{
    public class Book
    {
        [JsonProperty("language")]
        private string language;
        [JsonProperty("edition")]
        private string edition;
        [JsonProperty("price")]
        private string price;

        public Book(string language, string edition, string price)
        {
            this.language = language;
            this.edition = edition;
            this.price = price;
        }

        public string getLanguage() { return language; }
        public void setLanguage(string language)
        {
            this.language = language;
        }

        public string getEdition() { return edition; }
        public void setEdition(string edition)
        {
            this.edition = edition;
        }

        public string getPrice() { return price; }
        public void setPrice(string price)
        {
            this.price = price;
        }

        public override bool Equals(object obj)
        {
            return obj is Book book &&
                   language == book.language &&
                   edition == book.edition &&
                   price == book.price;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(language, edition, price);
        }


    }
}
