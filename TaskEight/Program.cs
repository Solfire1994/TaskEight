using System;
using System.Collections.Generic;

namespace TaskEight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = CompleteTheList();
            Print(list);
            Console.WriteLine();
            list = RemoveSomeListElements(list);
            Print(list);

        }

        static List<int> CompleteTheList()
        {
            List<int> list = new List<int>();
            Random random = new Random();
            for (int i = 0; i < 100; i++)
            {
                list.Add(random.Next(0, 101));
            }
            return list;    
        }

        static void Print(List<int> list)
        {
            for (int i = 0 ; i < list.Count; i++)
            {
                if (i % 20 == 0) Console.WriteLine();
                Console.Write($" {list[i]}");
            }
        }

        static List<int> RemoveSomeListElements(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] > 25 && list[i] < 50)
                {
                    list.RemoveAt(i);
                    i--;
                }
            }
            return list;
        }
    }
}
