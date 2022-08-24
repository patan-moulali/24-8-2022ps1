using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_8_2022ps1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            int sum;

            Console.Write("Enter first number: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            b = Convert.ToInt32(Console.ReadLine());

            addition(a, b, out sum);
            Console.WriteLine("Sum is: " + sum);
            Console.ReadLine();
        }
        public static void addition(int a, int b, out int sum)
        {
            sum = a + b;
        }


      
    }
}
        
    


