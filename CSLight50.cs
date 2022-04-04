using System;

namespace CSLight50
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            bool isRunning = true;

            string sumCommand = "sum";
            string exitCommand = "exit";

            int[] array = new int[0];

            Console.WriteLine("Введите числа для добавления их в массив." +
                "\nВведите команду sum для вывода суммы всех введенных чисел." +
                "\nВведите команду exit для выхода из программы.");

             while (isRunning)
             {
                userInput = Console.ReadLine();

                if (userInput == sumCommand)
                {
                    int sum = 0;

                    foreach (int number in array)
                    {
                        sum += number;
                    }

                    Console.WriteLine(sum);
                }
                else if (userInput == exitCommand)
                {
                    isRunning = false;
                }
                else
                {
                    int[] tempArray = new int[array.Length + 1];

                    for (int i = 0; i < array.Length; i++)
                    {
                        tempArray[i] = array[i];
                    }

                    tempArray[tempArray.Length - 1] = Convert.ToInt32(userInput);
                    array = tempArray;
                }
             }
        }
    }
}
