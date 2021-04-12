using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace JsonProject
{
    public class BooksDTO
    {
        [JsonProperty("storeId")]
        private int storeId;
        [JsonProperty("storeName")]
        private string storeName;
        [JsonProperty("eBooks")]
        private List<Book> eBooks;

        public int getStoreId() { return storeId; }
        public void setStoreId(int storeId)
        {
            this.storeId = storeId;
        }

        public string getStoreName() { return storeName; }
        public void setStoreName(string storeName)
        {
            this.storeName = storeName;
        }

        public List<Book> getEBooks() { return eBooks; }
        public void setEBooks(List<Book> eBooks)
        {
            this.eBooks = eBooks;
        }
    }
}
