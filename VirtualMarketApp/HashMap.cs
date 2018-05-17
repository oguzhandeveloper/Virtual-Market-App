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

            if(table[keyValue]==null)
            {
                table[keyValue] = new HashList();
            }

            table[keyValue].Add(temp);
        }

        public Product Delete(string key)
        {
            int keyValue = HashFunction(key);

            if (table[keyValue] == null)
                return null;

            HashEntry temp = table[keyValue].Delete(key);

            return (Product)temp.Data;
        }

        public List<Product> Search(string key)
        {
            int keyValue = HashFunction(key);

            List<Product> temp = table[keyValue].Search(key);

            return temp;

        }

        public List<Product> List()
        {
            List<Product> liste = new List<Product>();

            for (int i = 0; i < table.Length; i++)
            {
                if (table[i] == null)
                    continue;
                for (int j = 0; j < table[i].Hash.Count; j++)
                {
                    liste.Add((Product)table[i].Hash[j].Data);
                }
            }

            return liste;
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
