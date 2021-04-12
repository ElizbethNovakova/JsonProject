using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace JsonProject
{
    public class BookStoreDTO
    {
        [JsonProperty("storeId")]
        private int storeId;
        [JsonProperty("storeName")]
        private string storeName;
        [JsonProperty("eBooks")]
        private List<BookDTO> eBooks;

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

        public List<BookDTO> getEBooks() { return eBooks; }
        public void setEBooks(List<BookDTO> eBooks)
        {
            this.eBooks = eBooks;
        }
    }
}
