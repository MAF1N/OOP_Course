using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOP_Course_Work
{


    class Storage
    {
        private Product[] storageProducts = new Product[100];
        private float _storageHeight;
        private float _storageWidth;
        private float _storageLength;
        public float Height { get { return _storageHeight; } set { _storageHeight = value; } }
        public float Width { get { return _storageWidth; } set { _storageWidth = value; } }
        public float Length { get { return _storageLength; } set { _storageLength = value; } }
        int lastFree=0;
        public Storage()
        {
        }
        public Storage(float w,float l, float h)
        {
            _storageHeight = h;
            _storageLength = l;
            _storageWidth = w;
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
        public IEnumerable<Product> SearchName(string s)
        {
            for (int i=0; i<lastFree; i++)
            {
                if (storageProducts[i].Name.Contains(s))
                    yield return storageProducts[i];
            }
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
        public IEnumerable<Product> CheckPosition(float x, float y)
        {
            for (int i = 0; i < lastFree; i++)
                if (storageProducts[i].checkPos(x, y))
                    yield return storageProducts[i];
        }
        public void DisplayStorage(Graphics g)
        {
            
            g.DrawRectangle(new Pen(Color.Black), 0, 0, _storageWidth, _storageLength);
            float averageWidth = _storageWidth / (float) Math.Sqrt(storageProducts.Length);
            float averageLength = _storageLength / (float) Math.Sqrt(storageProducts.Length);
            SetAtributes(averageWidth, averageLength,0);
            for (int i =0; i<lastFree; i++)
            {
                storageProducts[i].SetPoint((i * averageWidth % _storageWidth), (int)(i / Math.Sqrt(storageProducts.Length)) * averageLength);
                g.DrawRectangle(new Pen(Color.Black), (i * averageWidth % _storageWidth), (int)(i / Math.Sqrt(storageProducts.Length)) * averageLength, averageWidth, averageLength);
            }
        }
        public void SetAtributes(float w,float l, float h)
        {
            for( int i=0; i<lastFree; i++)
            {
                storageProducts[i].Width = w;
                storageProducts[i].Height = h;
                storageProducts[i].Length = l;
            }
        }
        public Product Check(float mx, float my)
        {
            for (int i=0; i<lastFree; i++)
            {
                if (storageProducts[i].checkPos(mx, my))
                {
                    return storageProducts[i];
                }
            }
            return null;
        }
    }
}
