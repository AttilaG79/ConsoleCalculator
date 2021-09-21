using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Number number = new Number();
            Console.WriteLine("This is a calculator with basic functions Add,Subtract,Multiply,Divide");
            Console.WriteLine("-------------------START---------------");
            Console.WriteLine("Enter the first number : ");
            number.Fnumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the second number : ");
            number.Snumber = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Choose an action");
            Console.WriteLine("Please type 'a' for adding or 's' for subtract or 'm' for multiply or 'd' for divide, and press Enter");
            string a = Convert.ToString(Console.ReadLine());

            Console.WriteLine("-------------------RESULT------------------");
            Console.WriteLine(" ");
            if (a == "a")
            {
                double add = number.Adding();
                Console.WriteLine("Result of the added numbers : {0}", add);
            }
            else if (a == "s")
            {
                double sub = number.Subtract();
                Console.WriteLine("Result of the subtracted numbers : {0}", sub);
            }
            else if (a == "m")
            {
                double multi = number.Multiply();
                Console.WriteLine("Result of the multiplied numbers : {0}", multi);
            }
            else if (a == "d")
            {
                double div = number.Divide();
                Console.WriteLine("Result of divided numbers : {0}", div);
            }
            Console.WriteLine(" ");
            Console.WriteLine("---------------------END-------------------");

            Console.ReadLine();
        }
    }
}
    

