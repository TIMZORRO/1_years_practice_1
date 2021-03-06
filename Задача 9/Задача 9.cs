﻿using System;

namespace Задача_9
{
    class Program
    {
        static void Main(string[] args)
        {
            CircularList list = new CircularList();
            bool ok = false;
            int N = 0;
            while (!ok)
            {
                Console.WriteLine("Введите число, до которого следует заполнить список");
                try
                {
                    N = Convert.ToInt32(Console.ReadLine());
                    if (N <= 0) throw new Exception();
                    ok = true;
                }
                catch { Console.WriteLine("Ошибка ввода"); }
            }
            for (int i=0; i < N; i++) 
                list.Add(new CircularListEntry(i + 1));
            Console.WriteLine("Полученный список:\n" + list.ToString() + "\n\nУдаление члена из списка\n\nПолученный список: ");
            list.Remove(new CircularListEntry(list.Count));
            list.Show();
            Console.WriteLine("Поиск 6 элемента: ");
            if (list.SearchKey(5) == null) Console.WriteLine("Такого элемента нет в списке");
            else list.SearchKey(5).Show();
            Console.ReadKey();
        }
    }
}
