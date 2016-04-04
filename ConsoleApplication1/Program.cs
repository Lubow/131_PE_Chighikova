using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StreamReader reider = new StreamReader("Zarplata.txt")
namespace ConsoleApplication1
{
    
    class Program
    {
        static int TotalDay(int result, bool isOverride)//рассчет заработной платы
        {
            int totalMin = 300;
            int total;//получаемый %
            if (result == 10000)
            {
                total = 500;
            }
            else if (result > 10000)
            {
                total = ((result - 10000) / 100) * 10 + 500;
            }
            else if (result > 100000)
            {
                total = result / 100 * 15;
            }
            else
            {
                total = totalMin;
            }
            return isOverride ? 2 * total : total;//переработка
        }

        static int[] GetDaysFromConsole()// расчет % по дням
        {
            Console.Write("Введете отработанные дни: ");
            int weekSize = Convert.ToInt32(Console.ReadLine());
            int[] days = new int[weekSize];

            for (int i = 0; i < weekSize; i++)
            {
                Console.Write("Введете размер дневной выручки: ");
                days[i] = Convert.ToInt32(Console.ReadLine());
            }

            return days;
        }

        static void Main(string[] args)//выбор
        {
            int total = 0;
            int[] days = null;
            ConsoleKeyInfo mode;//проверка нажатой клавиши

            while (days == null)
            {
                Console.WriteLine("1 - чтение из файла, 2 - ручной ввод");

                mode = Console.ReadKey(true);

                switch (mode.Key)
                {
                    case ConsoleKey.D1:
              
                
                {
                    string line;
    int i;
    List<List<string>> resultList = new List<List<string>>();
    while (null != (line = reader.ReadLine()))
    {
        string[] array = line.Split(',');
        if (resultList.Count != array.Length)
        {
            for (i = 0; i < array.Length; i++)
            {
                resultList.Add(new List<string>());
            }
        }
 
        for (i = 0; i < array.Length; i++)
        {
            resultList[i].Add(array[i]);
        }
    }
  
                        break;
                    case ConsoleKey.D2:

                        days = GetDaysFromConsole();//переход  на метод, подсчет по дням

                        break;
                }

            }


            for (int i = 0; i < days.Length; i++)//Вывод на экран
            {
                int dayPay = TotalDay(days[i], i > 4);//переработка
                total += dayPay;
                Console.WriteLine("День {0}: {1} руб.", i, dayPay);
            }
            Console.WriteLine("Выручка за неделю: {0} руб.", total);
            Console.ReadKey();
        }

       
    }
}



//запуск проверки окончания строк, чтение из файла при помощи reader, считываение по строчно, разбиение строк
// FileStream file1 = new FileStream("d:\\test.txt", FileMode.Open); 
//G:\\Zarplata.txt
