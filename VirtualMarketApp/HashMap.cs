using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VirtualMarketApp
{

    public class HashMap
    {
        int tableSize;
        HashList[] table;

        public HashMap(int size)
        {
            this.tableSize = size;
            table = new HashList[size];
            int i = 0;
            for (; i < size; i++)
                table[i] = null;
        }

        public void Add(string key, object value)
        {
            int keyValue = HashFunction(key);

            HashEntry temp = new HashEntry(key, value);

            table[keyValue].Add(temp);
        }

        public HashEntry Delete(string key)
        {
            int keyValue = HashFunction(key);

            HashEntry temp = table[keyValue].Delete(key);

            return temp;
        }

        public List<Product> Search(string key)
        {
            int keyValue = HashFunction(key);

            List<Product> temp = table[keyValue].Search(key);

            return temp;

        }

        private int HashFunction(string key)
        {
            int hashValue = 0;

            for (int i = 0; i < key.Length; i++)
            {
                hashValue += key[i];
            }

            return hashValue % tableSize;
        }

    }
}
