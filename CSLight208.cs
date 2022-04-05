using System;

namespace CSLight208
{
    class Program
    {
        static void Main(string[] args)
        {
            string phrase = "Перестаньте убивать селёдку ради шуб!";
            string[] separateWords = phrase.Split(' ');

            foreach (var oneWord in separateWords)
            {
                Console.WriteLine(oneWord);
            }

            Console.ReadKey();
        }
    }
}
