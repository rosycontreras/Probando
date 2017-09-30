using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 12;
            double b = 5;
            double r = a / b;
            int r2 = int.Parse(a.ToString()) / Convert.ToInt32(b);
            double r3 = a % b;

            Console.WriteLine(r);
            Console.WriteLine(r2);
            Console.WriteLine(r3);
            Console.ReadKey();
        }
    }
}
