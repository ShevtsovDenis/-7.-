using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_2
{
    class Program
    {
        static void get_params_cube(double a, out double s, out double v)
        {
            s = 6 * Math.Pow(a, 2);
            v= Math.Pow(a, 3);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введити значение длины грани куба");
            double a= Convert.ToDouble(Console.ReadLine());
            double s;
            double v;
            get_params_cube(a, out s, out v);
            Console.WriteLine("Площадь поверхности куба ={0:.00}. Объем куба = {1:.00}", s, v);
            Console.ReadKey();
        }
    }
}
