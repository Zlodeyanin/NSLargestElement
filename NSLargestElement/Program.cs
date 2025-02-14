using System;

namespace NSLargestElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[,] arrayA = new int[10, 10];
            int randomMin = 1;
            int randomMax = 11;
            int largestElement = 0;

            Console.WriteLine("Изначальный массив:\n");

            for (int i = 0; i < arrayA.GetLength(0); i++)
            {
                for (int j = 0; j < arrayA.GetLength(1); j++)
                {
                    arrayA[i, j] = random.Next(randomMin, randomMax);

                    if (arrayA[i, j] > largestElement)
                    {
                        largestElement = arrayA[i, j];
                    }

                    Console.Write(arrayA[i, j] + " ");
                }

                Console.WriteLine();
            }

            Console.WriteLine($"\nНаибольший элемент: {largestElement}.");
            Console.WriteLine("Изменённый массив:\n");

            for (int i = 0; i < arrayA.GetLength(0); i++)
            {
                for (int j = 0; j < arrayA.GetLength(1); j++)
                {
                    if (arrayA[i, j] == largestElement)
                    {
                        arrayA[i, j] = 0;
                    }

                    Console.Write(arrayA[i,j] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}