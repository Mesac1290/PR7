using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR7_task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string txtUser;
            while (true)
            {
                Console.Write("Введите 1 строку: ");
                txtUser = Console.ReadLine();
                if (string.IsNullOrEmpty(txtUser))
                {
                    Console.WriteLine("Ошибка: некоректное значение");
                    continue;
                }
                break;
            }
            StringBuilder txt1 = new StringBuilder(txtUser.ToLower());
            txt1.Replace(" ", "");
            while (true)
            {
                Console.Write("Введите 2 строку: ");
                txtUser = Console.ReadLine();
                if (string.IsNullOrEmpty(txtUser))
                {
                    Console.WriteLine("Ошибка: некоректное значение");
                    continue;
                }
                break;
            }
            StringBuilder txt2 = new StringBuilder(txtUser.ToLower());
            txt2.Replace(" ", "");
            bool anagrammString = true;
            if(!(txt1.Length==txt2.Length))
            {
                Console.WriteLine("Строки не валяется анаграммами");
                return;
            }

            foreach (var item1 in txt1.ToString())
            {
                bool work2fForeach = true;
                foreach (var item2 in txt2.ToString())
                {
                    if (item1 == item2)
                    {
                        work2fForeach = false;
                        break;
                    }
                }
                if (work2fForeach)
                {
                    anagrammString = false;
                    break;
                }
            }
if(anagrammString)
Console.WriteLine("Строки алявтся анаграмами");
else
Console.WriteLine("Строки не является аваграммами");
        }
    }
}
