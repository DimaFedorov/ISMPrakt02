using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearExpressions
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите значение a : ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите значение b : ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите значение c : ");
            double c = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите значение d : ");
            double d = Convert.ToDouble(Console.ReadLine());

            Console.Write("Решение  x : ");
            double x = (((a + (2 * b) - c + d) / (c * d)) + ((a + b) / (c - d)) - ((a * a) / (b * b)));
            Console.WriteLine(x);

            Console.Write("Решение  y : ");
            double y = (((5 * (a + b) * (c - d)) / (0.5 * c)) + ((d * d) * (((a * a) - (b * b)) / (b - a))));
            Console.WriteLine(y);

            Console.Write("Решение  z : ");
            double z = (((Math.Pow((Math.Pow(x, 2) - 2 * x), 3)) - 4 * (Math.Pow(x, 4) + 1)) * (1 - b)) / (5 * a + 3 * b);
            Console.WriteLine(z);

            Console.Write("Решение  r : ");
            double r = ((0.5 * a + 0.75 * b - 1.4) / (3 * c + 1)) + (1 / (a - c));
            Console.WriteLine(r);

            Console.ReadKey();




        }
    }
}
