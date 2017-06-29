using System;
using MyLib;

namespace ex9
{
    internal class Program
    {
        private static void deleteNotRec(Point first)
        {
            while (first != null)
            {
                var cur = first.Next;
                var prev = first;

                while (cur != null)
                {
                    if (cur.Info == first.Info)
                    {
                        prev.Next = cur.Next;
                        cur = cur.Next;
                    }
                    else
                    {
                        prev = cur;
                        cur = cur.Next;
                    }
                }

                first = first.Next;
            }
        }
        private static void deleteRec(Point first)
        {
            var cur = first;
            var prev = first;

            while (cur != null)
            {
                if (cur.Info == first.Info)
                {
                    prev.Next = cur.Next;
                    cur = cur.Next;
                }
                else
                {
                    prev = cur;
                    cur = cur.Next;
                }
            }

            if (first.Next != null) 
                deleteRec(first.Next);
        }

        private static void Main()
        {
            // запрос длины ввода
            var number = Ask.Num("Введите количество элементов списка: ", 1);

            // создание первого элемента, инициализация текущего и предыдущего
            var info = Ask.Word("Введите значение информационного поля (строка): ");
            var first = new Point(info);
            var firstRec = new Point(info);
            number--;

            var curRec = firstRec;
            var prevRec = firstRec;
            var cur = first;
            var prev = first;

            // создание списков
            for (var i = 0; i < number; i++)
            {
                info = Ask.Word("Введите значение информационного поля (строка): ");
                cur = new Point(info);
                curRec = new Point(info);

                prevRec.Next = curRec;
                prevRec = curRec;

                prev.Next = cur;
                prev = cur;
            }

            deleteNotRec(first);
            deleteRec(firstRec);

            Console.WriteLine("Результат нерекурсивного метода: ");
            cur = first;
            while (cur != null)
            {
                Console.Write(cur.Info + " ");
                cur = cur.Next;
            }
            Console.WriteLine();

            Console.WriteLine("Результат рекурсивного метода: ");
            cur = firstRec;
            while (cur != null)
            {
                Console.Write(cur.Info + " ");
                cur = cur.Next;
            }

            OC.Stay();
        }
    }
}
