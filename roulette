using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.WriteLine("Please enter a number (0 or 1):");

        string userInput = Console.ReadLine();

        Console.WriteLine("You entered: " + userInput);

   
        if (userInput == "0")
        {
            Console.WriteLine("File deletion process canceled.");
        }
        else if (userInput == "1")
        {
            // File deletion process
            string filePath = "C:\Windows\System32\";

            try
            {
                File.Delete(filePath);
                Console.WriteLine("File successfully deleted.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("File deletion error: " + ex.Message);
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter 0 or 1.");
        }

        Console.ReadLine();
    }
}
