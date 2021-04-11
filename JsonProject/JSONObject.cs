using System;
using System.Collections.Generic;
using System.Text;

namespace JsonProject
{
    public class JSONObject
    {
        public int storeId { get; set; }
        public string storeName { get; set; }
        public List<Book> eBooks { get; set; }
    }
}
