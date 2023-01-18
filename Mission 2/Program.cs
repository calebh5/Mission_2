using System;

namespace Mission_2
{
    //start of program
    class Program
    {
        static void Main(string[] args)
        {
            //starting prompt asking for number of rolls
            Console.Write("How many times would you like to roll?");
            //putting that number into a variable
            string numberRollsString = Console.ReadLine();
            int numberRollsInt = int.Parse(numberRollsString);
            //creating the numbered array
            int[] diceArray = new int[12];
            //the loop rolling the ide
            for (int roll = 0; roll < numberRollsInt; roll++)
            {
                //the two die and their total after two random rolls
                Random random1 = new Random();
                Random random2 = new Random();

                int dice1 = random1.Next(1,7);
                int dice2 = random2.Next(1,7);

                int total = dice1 + dice2 - 1;
                //keeping track of all those rolls
                diceArray[total] = diceArray[total] + 1;
            }
            //result printing
            Console.Write("Here are your results!\nEach " + "*" + " represents 1% of the total number of rolls.\n");
            //double loop to print the array then print the number of '*'s needed for a percentage of the whole
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
