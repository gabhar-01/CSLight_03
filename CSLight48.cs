using System;

namespace CSLight48
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = 0;
            int maxArrayNumber = int.MinValue;

            int amountOfArrayRows = 10;
            int amountOfArrayColumns = 10;
            int minArrayIndex = 0;
            int minArrayCount = 0;
            int maxArrayCount = 20;

            int[,] array = new int[amountOfArrayRows,amountOfArrayColumns];
            Random random = new Random();

            Console.WriteLine("Исходная матрица:");

            for (int i = minArrayIndex; i < array.GetLength(0); i++)
            {
                for (int j = minArrayIndex; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(minArrayCount, maxArrayCount);
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }

            for (int i = minArrayIndex; i < array.GetLength(0); i++)
            {
                for (int j = minArrayIndex; j < array.GetLength(1); j++)
                {
                    if (maxArrayNumber < array[i, j])
                    {
                        maxArrayNumber = array[i, j];
                    }
                }
            }

            Console.WriteLine("\nНаибольший элемент: " + maxArrayNumber);
            Console.WriteLine("\nИзмененная матрица:");

            for (int i = minArrayIndex; i < array.GetLength(0); i++)
            {
                for (int j = minArrayIndex; j < array.GetLength(1); j++)
                {
                    if (maxArrayNumber == array[i, j])
                    {
                        array[i, j] = inputNumber;
                    }
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
            
            Console.ReadKey();
        }
    }
}
