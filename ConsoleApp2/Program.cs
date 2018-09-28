using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            const double p = 3.14;
            double r;
            double s;
            double rkv;
            int st = 2;
            Console.WriteLine("Введите радиус круга:");
            r = double.Parse(Console.ReadLine());
            rkv = Math.Pow(r,st);
            s = p * rkv;
            Console.WriteLine("Площадь круга равна "+s);

            Console.WriteLine("123");
  

        }
    }
}
