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

            int z = 0;

            int zmin = 300;
            Console.Write("Введете отработанные дни: ");
            int dni = Convert.ToInt32(Console.ReadLine());
           
                for (int i = 1; i <= dni; i++)
                {
                    Console.Write("Введете размер дневной выручки");
                    int v = Convert.ToInt32(Console.ReadLine());

                    if (v == 10000)
                    {
                        z = 500;
                    }

                    if (v > 10000)
                    {
                        z = (((v - 10000) / 100) * 10 + 500);
                    }
                    else
                    {
                        z = zmin;
                    }
                    if (i>5)
                    {
                        if (v == 10000)
                        {
                            z = 500*2;
                        }

                        if (v > 10000)
                        {
                            z = (((v - 10000) / 100) * 10 + 500)*2;
                        }
                        else
                        {
                            z = zmin*2;
                        }
                    }
                    Console.WriteLine("Отработанные дни ={0}, зарплата = {1}", i, z);
                }
        
                 Console.ReadKey();
            }
           
        }

    }

