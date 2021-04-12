using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace JsonProject
{
    public class BookDTO
    {
        [JsonProperty("language")]
        private string language;
        [JsonProperty("edition")]
        private string edition;
        [JsonProperty("price")]
        private string price;

        public BookDTO(string language, string edition, string price)
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
            return obj is BookDTO book &&
                   language == book.language &&
                   edition == book.edition &&
                   price == book.price;
        }
    }
}
