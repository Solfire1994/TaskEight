using System;
using System.Collections.Generic;

namespace PartThree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> set = new HashSet<int>();
            Print(AddNewElement(set));
        }

        static HashSet<int> AddNewElement(HashSet<int> set)
        {
            Console.WriteLine("Сколько чисел вы хотите добавить в коллекцию?");
            byte count = byte.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                System.Threading.Thread.Sleep(3000);
                Console.Clear();
                Console.WriteLine("Введите число для добавления в коллекцию");
                int number = int.Parse(Console.ReadLine());
                if (set.Contains(number)) Console.WriteLine($"Число {number} уже вводилось ранее");
                else
                {
                    set.Add(number);
                    Console.WriteLine($"Число {number} успешно добавлено в коллекцию");
                }
                
            }
            return set;
        }

        static void Print(HashSet<int> set)
        {
            Console.Write("Получившаяся коллекция:");
            foreach (int number in set) Console.Write($" {number}");
        }
    }
}
