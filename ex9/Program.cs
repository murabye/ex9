using System;
using MyLib;

namespace ex9
{
    internal class Program
    {
        private static void Main()
        {
            // запрос длины ввода
            var number = Ask.Num("Введите количество элементов списка: ", 1);

            // создание первого элемента, инициализация текущего и предыдущего
            var first = new Point(Ask.Word("Введите значение информационного поля (строка): "));
            var cur = first;
            var prev = first;

            // создание списка
            for (var i = 0; i < number; i++)
            {
                cur = new Point(Ask.Word("Введите значение информационного поля (строка): "));
                prev.Next = cur;
                prev = cur;
            }



        }
    }
}
