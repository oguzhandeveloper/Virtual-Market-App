using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VirtualMarketApp
{
    class HashList
    {



        public List<HashEntry> Hash { get; set; }

        public HashList()
        {
            Hash = new List<HashEntry>();
        }

        public void Add(HashEntry hashEntry)
        {
            Hash.Add(hashEntry);
        }

        public HashEntry Delete(string key)
        {
            for (int i = 0; i < Hash.Count; i++)
            {
                if (Hash[i].Key.Equals(key))
                {
                    HashEntry temp = Hash[i];
                    Hash.RemoveAt(i);
                    return temp;
                }
            }

            return null;

        }

        public List<Product> Search(string key)
        {
            List<Product> list = new List<Product>();
            for (int i = 0; i < Hash.Count; i++)
            {
                if (Hash[i].Key.Equals(key))
                {
                    list.Add((Product)Hash[i].Data);
                }
            }

            return list;

        }

    }
}
