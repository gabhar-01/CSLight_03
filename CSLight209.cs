using System;

namespace CSLight209
{
    class Program
    {
        static void Main(string[] args)
        {
            int arrayLength = 4;

            int[] array = new int[arrayLength];
            int arrayMinValue = 0;
            int arrayMaxValue = 10;
            int arrayMinIndex = 0;
            int arrayMaxIndex = array.Length - 1;

            int temp;
            int iterationsOfShiftLeft;

            Random random = new Random();
            Console.WriteLine("Дан массив чисел:");

            for (int i = arrayMinIndex; i < array.Length; i++)
            {
                array[i] = random.Next(arrayMinValue, arrayMaxValue);
                Console.Write(array[i] + " ");
            }

            Console.Write("\n\nВведите значение позиций влево, на которое будет сдвинут массив: ");
            iterationsOfShiftLeft = Convert.ToInt32(Console.ReadLine());

            for (int i = arrayMinIndex; i < iterationsOfShiftLeft; i++)
            {
                temp = array[arrayMinIndex];

                for (int j = arrayMinIndex; j < arrayMaxIndex; j++)
                {
                    array[j] = array[j + 1];
                }

                array[arrayMaxIndex] = temp;
            }

            for (int i = arrayMinIndex; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine("\n\nМассив был сдвинут " + iterationsOfShiftLeft + " раз.");
            Console.ReadKey();
        }
    }
}
