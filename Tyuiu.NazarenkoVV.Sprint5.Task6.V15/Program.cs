using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.NazarenkoVV.Sprint5.Task6.V15.Lib;

namespace Tyuiu.NazarenkoVV.Sprint5.Task6.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Назаренко В. В. | ИСПб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы. (ввод с клавиатуры)                            *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнил: Назаренко В. В.             | ИСПб-24-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* значениями с клавиатуры в диапазоне от 4 до 7. Заменить нечетные        *");
            Console.WriteLine("* элементы массива на 0.                                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            string path = @"C:\Users\Vivobook\source\repos\Tyuiu.NazarenkoVV.Sprint5\DataSprint5\InPutDataFileTask7V5.txt";
            Console.WriteLine("Файл: " + path);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("В строке находится " + ds.LoadFromDataFile(path) + " удвоенных букв \"с\"");
            Console.ReadKey();
        }
    }
}
