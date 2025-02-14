using System;

namespace NSLargestElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[,] numbers = new int[10, 10];
            int randomMin = 1;
            int randomMax = 11;
            int largestElement = int.MinValue;

            Console.WriteLine("Изначальный массив:\n");

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    numbers[i, j] = random.Next(randomMin, randomMax);

                    if (numbers[i, j] > largestElement)
                    {
                        largestElement = numbers[i, j];
                    }

                    Console.Write(numbers[i, j] + " ");
                }

                Console.WriteLine();
            }

            Console.WriteLine($"\nНаибольший элемент: {largestElement}.");
            Console.WriteLine("Изменённый массив:\n");

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    if (numbers[i, j] == largestElement)
                    {
                        numbers[i, j] = 0;
                    }

                    Console.Write(numbers[i,j] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}