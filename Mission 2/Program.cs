using System;

namespace Mission_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many times would you like to roll?");

            string numberRollsString = Console.ReadLine();
            int numberRollsInt = int.Parse(numberRollsString);

            int[] diceArray = new int[12];

            for (int roll = 0; roll < numberRollsInt; roll++)
            {
                Random random1 = new Random();
                Random random2 = new Random();

                int dice1 = random1.Next(1,7);
                int dice2 = random2.Next(1,7);

                int total = dice1 + dice2 - 1;

                diceArray[total] = diceArray[total] + 1;
            }

            Console.Write("Here are your results!\nEach " + "*" + " represents 1% of the total number of rolls.\n");

            for (int o = 1; o < diceArray.Length; o++)
            {
                double outputs = (double)diceArray[o] / numberRollsInt * 100;
                Console.Write((o + 1) + ": ");
                for (int i = 0; i < outputs; i++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            
            Console.Write("Thank you for playing!");
        }
    }
}
