using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLogDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter 1st number");
            int firstNumber=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter 2nd number");
            int secondNumber=Convert.ToInt32(Console.ReadLine());
            Addition.SumOfTwoNumbers(firstNumber,secondNumber);
        }
    }
}
