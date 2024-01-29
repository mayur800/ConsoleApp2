using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;
            int ch;
            Calculator ca= new Calculator();

            Console.WriteLine("Enter 2 numbers for Arithmetic operation");
            num1=Convert.ToDouble(Console.ReadLine());
            num2=Convert.ToDouble(Console.ReadLine());

            while (true)
            {

                Console.WriteLine("Enter choice for operations" +
                    "\n 1 for Add" +
                    "\n 2 for Sub" +
                    "\n 3 for Mul" +
                    "\n 4 for Div" +
                    "\n 5 for Exit");
                ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        Console.WriteLine(ca.Add(num1, num2));
                        break;
                    case 2:
                        Console.WriteLine(ca.Sub(num1, num2));
                        break;
                    case 3:
                        Console.WriteLine(ca.Mul(num1, num2));
                        break;
                    case 4:
                        Console.WriteLine(ca.Div(num1, num2));
                        break;


                    case 5:
                        return;
                    case 6:
                        break;
                        



                }

            
            }
        }
    }
}
