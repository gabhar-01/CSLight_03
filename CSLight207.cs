using System;

namespace CSLight207
{
    class Program
    {
        static void Main(string[] args)
        {
            int arrayLength = 20;
            int[] array = new int[arrayLength];
            Random random = new Random();
            int arrayMinValue = 0;
            int arrayMaxValue = 20;

            int minElementIndex;

            int temp;

            Console.WriteLine("Неотсортированный массив:");

            for (int i = arrayMinValue; i < array.Length; i++)
            {
                array[i] = random.Next(arrayMinValue, arrayMaxValue);
                Console.Write(array[i] + " ");
            }

            for (int i = arrayMinValue; i < array.Length; i++)
            {
                minElementIndex = i;

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[minElementIndex])
                    {
                        minElementIndex = j;
                    }
                }

                if (array[i] == array[minElementIndex])
                {
                    continue;
                }

                temp = array[i];
                array[i] = array[minElementIndex];
                array[minElementIndex] = temp;
            }

            Console.WriteLine("\nОтсортированный массив:");

            for (int i = arrayMinValue; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.ReadKey();
        }
    }
}
