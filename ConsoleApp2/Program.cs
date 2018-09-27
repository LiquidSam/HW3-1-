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
            double square;
            Console.WriteLine("Введите радиус круга:");
            r = Console.Read();
            square = Math.Pow(r, 2);
            s = p * square;
            Console.WriteLine("Площадь круга равна" + s);
            

        }
    }
}
