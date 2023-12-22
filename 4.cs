
using System;
using System.IO;
class work_4_4
{
    static void Main()
    {
        string[] lines = File.ReadAllLines("numsTask4.txt"); // чтение данных из файла и запись в массив
        int[] numbers = lines[0].Split(' ').Select(int.Parse).ToArray(); // получение чисел из строк, запись в массив
        int sum = 0;

        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i - 1] == numbers[i])
            {
                sum ++;
            }
        }
        Console.WriteLine($"Одинаковых рядом стоящих чисел: {sum}"); // вывод
    }
}