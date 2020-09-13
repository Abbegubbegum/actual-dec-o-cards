using System;

namespace dec_o_cards
{
    class Program
    {
        public static void Main(string[] args)
        {
            double correct = 0;
            double average = 0;



            for (int j = 0; j <= 100000; j++)
            {
                for (int i = 0; i <= 51; i++)
                {
                    correct += Gissa(i);
                }
            }

            average = correct / 100000;


            System.Console.WriteLine("The average amount of correct guesses was: " + average + " times");

            Console.ReadLine();
        }

        public static int Gissa(int card)
        {
            int guess = GetRandomNumber(card, 52);

            if (guess == card)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        private static readonly Random getrandom = new Random();

        public static int GetRandomNumber(int min, int max)
        {
            lock (getrandom)
            {
                return getrandom.Next(min, max);
            }
        }
    }
}
