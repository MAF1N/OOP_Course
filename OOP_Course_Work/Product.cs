using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Course_Work
{
    class Product
    {
        private Point point;
        private float _width;
        private float _height;
        private float _length;
        private string cost;
        private string provider;
        public int code;
        string name;
        string measure;
        int amount;
        string dateOfIncome;
        string endDate;
        public Product(string[] s)
        {
            name = s[0];
            amount = Convert.ToInt32(s[1]);
            measure = s[2];
            cost = s[3];
            dateOfIncome = s[4];
            endDate = s[5];
        }
        public float Width { get { return _width; } set { _width = value; } }
        public float Height { get { return _height; } set { _height = value; } }
        public float Length { get { return _length; } set { _length = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string DateOfIncome { get { return dateOfIncome; } set { dateOfIncome = value; } }
        public string EndDate { get { return endDate; } set { endDate = value; } }
        public int Amount { get { return amount; } set { amount = value; } }
        public string Measure { get { return measure;} set { measure = value; } }
        public string Cost { set { cost = value; } get { return cost; } }
        public Product()
        {

        }
        public void SetPoint(float x, float y)
        {
            point.X =(int) x;
            point.Y =(int) y;
        }
        public string ProductToString()
        {
            return code + " " + name + " " + amount + " " + measure + " " + cost + " " + dateOfIncome + " " + endDate;
        }
        public bool checkPos(float x, float y)
        {
            return (point.X <= x) && (point.X + _width > x )&& (point.Y <= y )&& (point.Y + _length >= y);
        }
        public override string ToString()
        {
            return code+";"+Environment.NewLine+ name + ";" + Environment.NewLine + amount+measure+Environment.NewLine;
    }
    }
}
