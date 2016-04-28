using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Course_Work
{
    class Product
    {
        private string cost;
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
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string DateOfIncome
        {
            get { return dateOfIncome; }
            set { dateOfIncome = value; }
        }
        public string EndDate
        {
            get { return endDate; }
            set { endDate = value; }
        }
        public int Amount
        {
            get { return amount; }
            set { amount = value; }
        }
        public string Measure
        {
            get { return measure;}
            set { measure = value; }
        }
        public Product()
        {

        }
        public string Cost
        {
            set {cost = value;}
            get { return cost; }
        }
        public string ProductToString()
        {
            return code + " " + name + " " + amount + " " + measure + " " + cost + " " + dateOfIncome + " " + endDate;
        }
    }
}
