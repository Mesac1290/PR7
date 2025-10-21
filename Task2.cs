using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR7_task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string txtOld;
            while (true)
            {
                Console.Write("Введите строку: ");
                txtOld = Console.ReadLine();
                if (string.IsNullOrEmpty(txtOld))
                {
                    Console.WriteLine("Ошибка: некоректное значение");
                    continue;
                }
                break;
            }
            StringBuilder txtOldSB = new StringBuilder(txtOld);
            StringBuilder txtNewSB = new StringBuilder();
            foreach (var item in txtOldSB.ToString())
            {
                bool item_True = false;
                foreach (var item2 in txtNewSB.ToString())
                {
                    if (string.Equals(item.ToString(), item2.ToString(), StringComparison.OrdinalIgnoreCase))
                    {
                        item_True = true;
                        break;
                    }
                }
                if (!item_True)
                {
                    txtNewSB.Append(item);
                }
            } 
            Console.WriteLine("Итог программы: ");
            Console.WriteLine(txtNewSB.ToString());
        }
    }
}
