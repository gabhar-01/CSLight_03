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
                }
                Console.WriteLine();
            }

            for (int i = minArrayIndex; i < array.GetLength(1); i++)
            {
                sumOfRequestedRow += array[requestedRow, i]; 
            }

            Console.WriteLine("\nСумма " + requestedRow + " строки равна " + sumOfRequestedRow + ".");

            for (int i = minArrayIndex; i < array.GetLength(0); i++)
            {
                multiplyOfRequestedColumn *= array[i, requestedColumn];
            }

            Console.WriteLine("\nПроизведение " + requestedColumn + " столбца равно " + multiplyOfRequestedColumn + ".");
            Console.ReadKey();       
        }
    }
}
