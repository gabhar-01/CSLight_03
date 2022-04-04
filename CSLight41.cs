using System;

namespace CSLight41
{
    class Program
    {
        static void Main(string[] args)
        {
            int amountOfArrayRows = 5;
            int amountOfArrayColumns = 5;
            int minArrayIndex = 0;
            int minArrayCount = 1;
            int maxArrayCount = 9 + 1;

            int requestedRow = 2;
            int requestedColumn = 1;

            int sumOfRequestedRow = 0;
            int multiplyOfRequestedColumn = 1;

            int[,] array = new int [amountOfArrayRows, amountOfArrayColumns];
            Random random = new Random();

            for (int i = minArrayIndex; i < array.GetLength(0); i++)
            {
                for (int j = minArrayIndex; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(minArrayCount, maxArrayCount);
                    Console.Write(array[i, j] + " ");

                    if (i == requestedRow)
                    {
                        sumOfRequestedRow += array[i, j];
                    }

                    if (j == requestedColumn)
                    {
                        multiplyOfRequestedColumn *= array[i, j];
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nСумма " + requestedRow + " строки равна " + sumOfRequestedRow + ". Произведение " + requestedColumn + " столбца равно " + multiplyOfRequestedColumn + ".");
            Console.ReadKey();       
        }
    }
}
