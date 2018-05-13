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

        public HashEntry Search(string key)
        {
            for (int i = 0; i < Hash.Count; i++)
            {
                if (Hash[i].Key.Equals(key))
                {
                    HashEntry temp = Hash[i];
                    return temp;
                }
            }

            return null;

        }

    }
}
