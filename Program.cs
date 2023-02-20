using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1.

            //int[] mas = new int[6];
            //Random ran = new Random();
            //for (int i = 0; i < mas.Length; i++)
            //{
            //    mas[i] = ran.Next(1, 10);
            //    Console.WriteLine($"mas[{i}] = {mas[i]}");
            //}
            //Console.WriteLine("");
            //int index = 0;
            //for (int i = 0; i < mas.Length; i++)
            //{
            //    if (mas[i] == mas[0])
            //    {
            //        index = i;
            //        Console.WriteLine($"i = {index}");
            //    }
            //}
            //if (index == 0)
            //{
            //    Console.WriteLine("Чисел, значение которого равно значению первого элемента, нет!");
            //}
            //Console.ReadKey();

            //Задание 2.

            //int[] mas = { 5, -3, 4, -8, -9, 1, 9, 6, -3, 4, 8, 2 };
            //int count = 0;
            //for (int i = 0; i < mas.Length; i++)
            //{
            //    Console.WriteLine($"mas[{i}] = {mas[i]}");
            //    if (mas[i] < 0)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine($"Количество отрицательных элементов = {count}");
            //Console.ReadKey();

            //Задание 3.

            int[] mas = { 5, 2, 7, 4, 9, 6, };
            int sum = 0;
            int count = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] % 2 == 1)
                {
                    Console.WriteLine($"mas[{i}] = {mas[i]}");
                    sum += mas[i];
                    count++;
                }
            }
            double mid = sum / count;
            Console.WriteLine($"Среднее арифметическое = {mid}");
            Console.ReadKey();
        }
    }
}