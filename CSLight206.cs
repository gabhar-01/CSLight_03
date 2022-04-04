using System;

namespace CSLight206
{
    class Program
    {
        static void Main(string[] args)
        {
            int arrayMinIndex = 0;
            int arrayLength = 30;
            int[] array = new int[arrayLength];

            Random random = new Random();
            int arrayMinAmount = 5;
            int arrayMaxAmount = 10;

            int numberOfRepeats = 0;
            int maxNumberOfRepeats = 0;
            int theMostRepeatedNumber = 0;

            for (int i = arrayMinIndex; i < array.Length; i++)
            {
                array[i] = random.Next(arrayMinAmount, arrayMaxAmount);
            }

            for (int i = arrayMinIndex; i < array.Length - 1; i++)
            {
                if (array[i] == array [i + 1])
                {
                    numberOfRepeats++;

                    if (maxNumberOfRepeats < numberOfRepeats)
                    {
                        maxNumberOfRepeats = numberOfRepeats;
                        theMostRepeatedNumber = array[i];
                    }
                }
                else
                {
                    numberOfRepeats = 0;
                }
            }

            maxNumberOfRepeats++;
            Console.Write('{');

            for (int i = arrayMinIndex; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine("} - число " + theMostRepeatedNumber + " повторяется большее число раз подряд: " + maxNumberOfRepeats);
            Console.ReadKey();
        }
    }
}
