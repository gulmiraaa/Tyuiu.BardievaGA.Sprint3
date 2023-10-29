using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.BardievaGA.Sprint3.Task5.V18.Lib;
namespace Tyuiu.BardievaGA.Sprint3.Task5.V18
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService dataService = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Бардиева Г. А. | ИСПб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Алгоритмы цикличекой структуры                                    *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #18                                                             *");
            Console.WriteLine("* Выполнил: Бардиева Г. А. | ИСПб-23-1                                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* вычислить значение функции                                              *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x = 5, startValue1 = 1, startValue2 = 1, stopValue1 = 3, stopValue2 = 11;

            Console.WriteLine($"Переменная X: {x}");
            Console.WriteLine($"Старт шага первой суммы ряда: {startValue1}");
            Console.WriteLine($"Конец шага первой суммы ряда: {startValue1}");
            Console.WriteLine($"Старт шага второй суммы ряда: {startValue2}");
            Console.WriteLine($"Конец шага второй суммы ряда: {startValue2}");


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.Write($"Результат = {dataService.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2)}");

            Console.ReadKey();

        }
    }
}
