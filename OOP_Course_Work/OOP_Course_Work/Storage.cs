using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Course_Work
{

    class Storage
    {
        private Product[] storageProducts = new Product[10000];
        int lastFree=0;
        public Storage()
        {

        }
        public int StorageCapacity
        {
            get { return storageProducts.Length; }
            private set { }
        }
        public int SearchByName(string name)
        {
            for (int i = 0; i < lastFree; i++)
                if (name == storageProducts[i].Name)
                    return i;
            return -1;
        }
        public int SearchByCode(string c)
        {
            for (int i = 0; i < lastFree; i++)
                if (Convert.ToInt32(c) == storageProducts[i].code)
                    return i;
            return -1;
        }
        public bool AddProduct(Product p)
        {
            if (lastFree < storageProducts.Length)
            {
                storageProducts[lastFree] = p;
                storageProducts[lastFree].code = lastFree;
                lastFree++;
                return true;
            }
            else return false;
        }
        public Product[] GetAllProducts()
        {
            Product[] retVal = new Product[lastFree];
            for (int i = 0; i < lastFree; i++)
                retVal[i] = storageProducts[i];
            return retVal;
        }
        public int FreePositions()
        {
            return storageProducts.Length - lastFree;
        }
    }
}
