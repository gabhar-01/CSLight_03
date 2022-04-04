using System;

namespace CSLight49
{
    class Program
    {
        static void Main(string[] args)
        {
            int arrayLength = 30;
            int arrayMinValue = 0;
            int arrayMaxValue = 20;
            
            Random random = new Random();
            int[] array = new int[arrayLength];

            int firstArrayElementIndex = 0;
            int secondArrayElementIndex = firstArrayElementIndex + 1;
            int lastArrayElementIndex = array.Length - 1;
            int secondLastArrayElementIndex = lastArrayElementIndex - 1;

            for (int i = firstArrayElementIndex; i <= lastArrayElementIndex; i++)
            {
                array[i] = random.Next(arrayMinValue, arrayMaxValue);
                Console.Write(array[i] + " ");
            }

            Console.Write("\nЛокальные максимумы массива: ");

            if (array[firstArrayElementIndex] >= array[secondArrayElementIndex])
            {
                Console.Write(array[firstArrayElementIndex] + " ");
            }

            for (int i = secondArrayElementIndex; i <= secondLastArrayElementIndex; i++)
            {
                if (array[i] >= array[i - 1] && array[i] >= array[i + 1])
                {
                    Console.Write(array[i] + " ");
                }
            }

            if (array[lastArrayElementIndex] >= array[secondLastArrayElementIndex])
            {
                Console.Write(array[lastArrayElementIndex]);
            }

            Console.ReadKey();
        }
    }
}
