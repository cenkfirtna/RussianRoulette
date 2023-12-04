using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Russian Roulette game!");

        Console.Write("Please enter the number of chambers (default = 6): ");
        string chambersInput = Console.ReadLine();

        int chambers;
        if (string.IsNullOrEmpty(chambersInput) || !int.TryParse(chambersInput, out chambers))
        {
            Console.WriteLine("Invalid number of chambers! Exiting the game.");
            return;
        }

        int fatalBullet = new Random().Next(1, chambers + 1);

        for (int x = 1; x <= chambers; x++)
        {
            Console.WriteLine("Press enter to pull the trigger! ");
            Console.ReadLine();

            if (x == fatalBullet)
            {
                Console.WriteLine("You just got served!");
                Console.WriteLine("Game Over");

                Console.Write("Do you want to start again? (y/n): ");
                string startAgain = Console.ReadLine();

                if (!string.IsNullOrEmpty(startAgain) && startAgain.ToLower()[0] == 'y')
                {
                    Main(); // Restart the game
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine("You will live to see another day");
        }
    }
}
