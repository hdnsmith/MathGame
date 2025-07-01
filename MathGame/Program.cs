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
                    Console.WriteLine("Addition Game coming soon. Press enter to continue.");
                    Console.ReadLine();
                    // PlayAddition();
                    break;
                case "2":
                    Console.WriteLine("Subtraction Game coming soon. Press enter to continue.");
                    Console.ReadLine();
                    // PlaySubtraction();
                    break;
                case "3":
                    Console.WriteLine("Multiply Game coming soon. Press enter to continue.");
                    Console.ReadLine();
                    // PlayMultiplication();
                    break;
                case "4":
                    Console.WriteLine("Divide Game coming soon. Press enter to continue.");
                    Console.ReadLine();
                    // PlayDivision();
                    break;
                case "5":
                    Console.WriteLine("Previous Game coming soon. Press enter to continue.");
                    Console.ReadLine();
                    // DisplayPreviousGames
                    break;
            }
        }
    }
}