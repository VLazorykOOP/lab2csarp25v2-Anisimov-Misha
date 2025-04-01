using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Завдання 1: Замiнити всi елементи, меншi заданого числа, цим числом.");
        Console.Write("Введiть розмiр масиву: ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        Random rand = new Random();
        for (int i = 0; i < n; i++)
            array[i] = rand.Next(1, 20);
        Console.WriteLine("Початковий масив: " + string.Join(", ", array));
        Console.Write("Введiть число для порiвняння: ");
        int threshold = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
            if (array[i] < threshold)
                array[i] = threshold;
        Console.WriteLine("Оновлений масив: " + string.Join(", ", array));







        Console.WriteLine("\nЗавдання 2: Номери всiх мiнiмальних елементiв у двовимiрному масивi.");
        Console.Write("Введiть розмiр матрицi (n x n): ");
        int m = int.Parse(Console.ReadLine());
        double[,] matrix = new double[m, m];
        double minVal = double.MaxValue;
        for (int i = 0; i < m; i++)
            for (int j = 0; j < m; j++)
            {
                matrix[i, j] = rand.NextDouble() * 20 - 10; // Дiйснi числа [-10, 10]
                if (matrix[i, j] < minVal)
                    minVal = matrix[i, j];
            }
        Console.WriteLine("Мiнiмальне значення: " + minVal);
        Console.Write("iндекси мiнiмальних елементiв: ");
        for (int i = 0; i < m; i++)
            for (int j = 0; j < m; j++)
                if (matrix[i, j] == minVal)
                    Console.Write($"({i},{j}) ");
        Console.WriteLine();







        Console.WriteLine("\nЗавдання 3: Середнє арифметичне парних елементiв нижче головної дiагоналi.");
        int sum = 0, count = 0;
        for (int i = 1; i < m; i++)
            for (int j = 0; j < i; j++)
                if ((int)matrix[i, j] % 2 == 0)
                {
                    sum += (int)matrix[i, j];
                    count++;
                }
        Console.WriteLine("Середнє арифметичне: " + (count > 0 ? (double)sum / count : 0));







        Console.WriteLine("\nЗавдання 4: Мiнiмальнi елементи в кожному стовпцi схiдчастого масиву.");
        Console.Write("Введiть кiлькiсть рядкiв: ");
        int rows = int.Parse(Console.ReadLine());
        int[][] jaggedArray = new int[rows][];
        for (int i = 0; i < rows; i++)
        {
            Console.Write($"Введiть кiлькiсть елементiв у рядку {i + 1}: ");
            int cols = int.Parse(Console.ReadLine());
            jaggedArray[i] = new int[cols];
            for (int j = 0; j < cols; j++)
                jaggedArray[i][j] = rand.Next(1, 100);
        }
        int minCols = jaggedArray.Max(row => row.Length);
        int[] minValues = Enumerable.Repeat(int.MaxValue, minCols).ToArray();
        for (int i = 0; i < rows; i++)
            for (int j = 0; j < jaggedArray[i].Length; j++)
                minValues[j] = Math.Min(minValues[j], jaggedArray[i][j]);
        Console.WriteLine("Мiнiмальнi елементи у стовпцях: " + string.Join(", ", minValues));
        Console.Write("Enter... ");
        Console.ReadLine();
    }
}
