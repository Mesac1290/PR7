using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR7_task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string txt;
            while (true)
            {
                Console.Write("Введите строку: ");
                txt = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(txt))
                {
                    Console.WriteLine("Ошибка: некоректное значение");
                    continue;
                }
                break;
            }
            string[] txtArray = txt.Split((char[]) null, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine($"Строка состоит из \"{txtArray.Length}\" подстрок");
            for (int i = 0; i < txtArray.Length; i++)
            {
                Console.Write($"Подстрока: \"{txtArray[i]}\" имеет длину \"{txtArray[i].Length}\"\n");
            }
        }
    }
}
