using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCastDelegate
{
    public class FunGenericDelegate
    {
        public static int Square(int number)
        {
             return number* number;
        }

        public  static int Cube(int number)
        {
            return number* number*number;
        }
    }
}
