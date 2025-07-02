using System;

namespace MathGame;

internal class Menu
{
    private int _menuSelection = 0;
    internal int MenuSelection
    {
        get => _menuSelection;
        set
        {
            if (value > 6)
            {
                _menuSelection = 0;
            }
            else
            {
                _menuSelection = value;
            }
        }
    }
    internal static void DisplayMenu()
    {
        Console.Clear();
        Console.WriteLine("Hello! Welcome to the Math Game!");
        Console.WriteLine("--------------------------------------------------------------------------------------");
        Console.WriteLine("Please select a menu option:");
        Console.WriteLine(
            "1. Addition\n2. Subtraction\n3. Multiplication\n4. Division\n5. View Previous Games\n6. Exit");
    }
    internal static int GetMenuSelection()
    {
        string? input = Console.ReadLine();
        if (int.TryParse(input, out int output))
        {
            return output;
        }
        else
        {
            return 0;
        }
    }

    internal void PlaySelection()
    {
        switch (_menuSelection)
        {
            case 1:
                GameEngine.PlayAddition();
                break;
            case 2:
                GameEngine.PlaySubtraction();
                break;
            case 3:
                GameEngine.PlayMultiplication();
                break;
            case 4:
                GameEngine.PlayDivision();
                break;
            case 5:
                Console.WriteLine("Display Previous Games option coming soon. Press enter to continue.");
                Console.ReadLine();
                // DisplayPreviousGames()
                break;
        }
    }
}