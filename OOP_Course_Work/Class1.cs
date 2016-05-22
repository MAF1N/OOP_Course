using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Course_Work
{
    class FileMethods
    {
        public static string ReadFile()
        {
            return File.ReadAllText(Environment.CurrentDirectory + @"/textFiles/DataBase.txt");
        }
    }

}
