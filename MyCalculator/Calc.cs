using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculator
{
    public class Calc
    {
        /// <summary>
        /// This method is used for adding two numbers.
        /// </summary>
        /// <param name="num1">Pass number 1 value.</param>
        /// <param name="num2">Pass number 2 value</param>
        /// <returns></returns>
        public int Sum(int num1, int num2)
        {
            return num1 + num2; 
        }

        public int Substract(int num1, int num2)
        {
            return num1 - num2;
        }

        public int Multiplication (int num1, int num2) 
        {
            return num1 * num2;
        }

        private int Division (int num1, int num2) 
        {
            return num1 / num2;
        }
    }
}
