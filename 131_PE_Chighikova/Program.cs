using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _131_PE_Chighikova
{
    class Program
    {
        static int TotalDay(int result, bool isOverride)
        {
            int totalMin = 300;
            int total;

            if (result == 10000)
            {
                total = 500;
            }
            if (result > 10000)
            {
                total = ((result - 10000) / 100) * 10 + 500;
            }
                if (result > 100000)
            {
                    total = result / 100 * 15;
            }
            else
            {
                total = totalMin;
            }

            return isOverride ? 2 * total : total;
        }

        static void Main(string[] args)
        {
            int total = 0;

            Console.Write("Введете отработанные дни: ");
            int dni = Convert.ToInt32(Console.ReadLine());

            for (int day = 1; day <= dni; day++)
            {
                Console.Write("Введете размер дневной выручки: ");
                int dayResult = Convert.ToInt32(Console.ReadLine());
                int dayPay = TotalDay(dayResult, day > 4);
                total += dayPay;

                Console.WriteLine("День {0}: {1} руб.", day, dayPay);
            }

            Console.WriteLine("Выручка за неделю: {0} руб.", total);
            Console.ReadKey();
        }
    }
}

    

