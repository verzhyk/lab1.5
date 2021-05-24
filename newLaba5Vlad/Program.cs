using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newLaba5Vlad
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int.TryParse(Console.ReadLine(), out int num1);

            Console.Write("Enter second double number: ");
            double.TryParse(Console.ReadLine(), out double num2);

            Pair p1 = new Pair(num1, num2);
            Console.WriteLine("Pair 1 was created.");

            Console.Write("Enter first number: ");
            int.TryParse(Console.ReadLine(), out num1);

            Console.Write("Enter second double number: ");
            double.TryParse(Console.ReadLine(), out num2);

            Pair p2 = new Pair(num1, num2);
            Console.WriteLine("Pair 1 was created.");


            Console.WriteLine("Result: ");
            Console.WriteLine(p1.Compare(p2));
        }
    }
}
