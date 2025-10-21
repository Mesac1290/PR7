using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace PR7_task4
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
                if (string.IsNullOrEmpty(txt))
                {
                    Console.WriteLine("Ошибка, некоректное значение!");
                    continue;
                }
                break;
            }
            string txt2;
            while (true)
            {
                Console.Write("Введите подстроку: ");
                txt2 = Console.ReadLine();
                if (string.IsNullOrEmpty(txt2))
                {
                    Console.WriteLine("Ошибка, некоректное значение!");
                    continue;
                }
                break;
            }
            int substringQuantity = 0;
            for (int i = 0; i < txt.Length;)
            {
                if (txt.IndexOf(txt2, i) != -1)
                {
                    substringQuantity++;
                    i = txt.IndexOf(txt2, i) + (txt2.Length - 1);
                    continue;
                }
                break;
            }
            Console.WriteLine($"Кол-во подстрок = {substringQuantity}");
        }
    }
}
