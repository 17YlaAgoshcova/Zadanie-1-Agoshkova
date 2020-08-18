using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_1_Agoshkova
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сторону a");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("ВВедите сторону b");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("ВВедите сторону c");
            double c = Convert.ToDouble(Console.ReadLine());

            double p = (a + b + c) / 2;
            double Height_A = (2 / a) * Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            double Height_B = (2 / b) * Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            double Height_C = (2 / c) * Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            Console.WriteLine("Высота а={0}, Высота b={1}, Высота c={2}", Height_A,Height_B,Height_C);
        }
    }
}
