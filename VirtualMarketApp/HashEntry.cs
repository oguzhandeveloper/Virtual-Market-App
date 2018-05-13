using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VirtualMarketApp
{
    public class HashEntry
    {
        public string Key { get; set; } 
        public object Data { get; set; }

        public HashEntry(string key, object data)
        {
            this.Key = key;
            this.Data = data;
        }
    }
}
