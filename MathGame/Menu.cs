using System;
using System.Collections.Generic;

namespace MathGame;

internal class Menu
{
    private int _menuSelection;
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
    
    internal List<string> RecentGames { get; set; } = new List<string>();
    
    internal static void DisplayMenu()
    {
        Console.Clear();
        Console.WriteLine("Hello! Welcome to the Math Game!");
        Console.WriteLine("--------------------------------------------------------------------------------------");
        Console.WriteLine("Please select a menu option:");
        Console.WriteLine(
            "1. Addition\n2. Subtraction\n3. Multiplication\n4. Division\n5. View Previous Games\n6. Exit");
    }
    internal void GetMenuSelection()
    {
        string? input = Console.ReadLine();
        if (int.TryParse(input, out int output))
        {
            MenuSelection = output;
        }
        else
        {
            MenuSelection = 0;
        }
    }

    internal void PlaySelection()
    {
        GameEngine game = new GameEngine();
        int score;
        switch (MenuSelection)
        {
            case 1:
                score = game.PlayAddition();
                RecordGame('+', score);
                break;
            case 2:
                score = game.PlaySubtraction();
                RecordGame('-', score);
                break;
            case 3:
                GameEngine.PlayMultiplication();
                break;
            case 4:
                GameEngine.PlayDivision();
                break;
            case 5:
                DisplayGameHistory();
                break;
            case 6:
                break;
            default:
                Console.WriteLine("Invalid menu selection. Press enter to try again.");
                Console.ReadLine();
                break;
        }
    }

    private void RecordGame(char operation, int score)
    {
        switch (operation)
        {
            case '+':
                RecentGames.Add($"{DateTime.Now} - Addition - Score: {score}");
                break;
            case '-':
                RecentGames.Add($"{DateTime.Now} - Subtraction - Score: {score}");
                break;
            case '*':
                RecentGames.Add($"{DateTime.Now} - Multiplication - Score: {score}");
                break;
            case '/':
                RecentGames.Add($"{DateTime.Now} - Division - Score: {score}");
                break;
            default:
                throw new ArgumentException("Argument Exception: Operation is invalid.");
        }
    }

    private void DisplayGameHistory()
    {
        Console.Clear();
        foreach (String game in RecentGames)
        {
            Console.WriteLine(game);
        }
        Console.WriteLine("\nPress Enter to return to menu.");
        Console.ReadLine();
    }
}