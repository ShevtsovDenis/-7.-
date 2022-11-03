using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_1
{
    class Program
    {
        static double get_square(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значения длин сторон первого треугольника");
            double a1 = Convert.ToDouble(Console.ReadLine());
            double b1 = Convert.ToDouble(Console.ReadLine());
            double c1 = Convert.ToDouble(Console.ReadLine());
            double s1= get_square(a1, b1, c1);
            Console.WriteLine("Введите значения длин сторон второго треугольника");
            double a2 = Convert.ToDouble(Console.ReadLine());
            double b2 = Convert.ToDouble(Console.ReadLine());
            double c2 = Convert.ToDouble(Console.ReadLine());
            double s2 = get_square(a2, b2, c2);
            if (s1>s2)
                Console.WriteLine("Площадь первого треугольника больше");
            else if(s2>s1)
                Console.WriteLine("Площадь второго треугольника больше");
            else
                Console.WriteLine("Площади треугольников равны");
            Console.ReadKey();
        }
    }
}
