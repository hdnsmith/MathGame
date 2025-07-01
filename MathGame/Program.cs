using System;

namespace MathGame;

class Program
{
    static void Main()
    {
        string? menuSelection = "";
        
        while (menuSelection != "6")
        {
            Console.Clear();
            Console.WriteLine("Hello! Welcome to the Math Game!");
            Console.WriteLine("--------------------------------------------------------------------------------------");
            Console.WriteLine("Please select a menu option:");
            Console.WriteLine(
                "1. Addition\n2. Subtraction\n3. Multiplication\n4. Division\n5. View Previous Games\n6. Exit");

            menuSelection = Console.ReadLine();

            switch (menuSelection)
            {
                case "1":
                    GameEngine.PlayAddition();
                    break;
                case "2":
                    GameEngine.PlaySubtraction();
                    break;
                case "3":
                    GameEngine.PlayMultiplication();
                    break;
                case "4":
                    GameEngine.PlayDivision();
                    break;
                case "5":
                    Console.WriteLine("Display Previous Games option coming soon. Press enter to continue.");
                    Console.ReadLine();
                    // DisplayPreviousGames()
                    break;
            }
        }
    }
}