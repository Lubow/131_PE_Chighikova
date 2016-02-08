using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _131_PE_Chighikova
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введете размер дневной выручки");
            int v = Convert.ToInt32(Console.ReadLine());
            int z = 0 ;
            int zmin = 300;
            if (v == 10000)
            {
                z = 500;
            }
            if (v > 10000)
            {
                z = ((v - 10000) / 100) * 10 + 500;
            }
            else
            {
                z=zmin;
            }
            Console.WriteLine(z);
            Console.ReadKey();
        }
    }
}
