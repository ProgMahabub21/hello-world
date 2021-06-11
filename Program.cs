using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            inhodt number = 10;                      //declare local variable (all rules following)
            const float Pi = 3.1416f;             // declare constant type variable 
            char letter = 'M';                    // declare char type var
            string name = "Mahabub";              // declare string var
            Console.WriteLine("Hi!!. Welcome to C# practice code session");
            Console.WriteLine("number :" + number + " " +"Pie value :"+Pi);   //displaying multiple variables 
            checked                                   //keep tracking of any exceptional events
            {
                byte overflow = 254;                  //max value of byte variable 255  
                overflow += 1;                        //variable value overflowed by var type
                Console.WriteLine("Overflowed value:" + overflow);
            }
            Console.WriteLine("name:" + name + "Starts with letter:" + letter);
            Console.WriteLine("{0} {1}", int.MinValue, int.MaxValue);  //string format/type/template
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);
            float f = 3.10f;
            string s = "1234";
            byte b = 254;
            int a = b;
            int c = (int)f;
            int g = Convert.ToInt32(s);
            Console.WriteLine("a:" + a + "," + "c:" + c+ "," + "g:" + g);           //all kind of type conversion
        }
    }
}
