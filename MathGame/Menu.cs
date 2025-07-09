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
    
    private List<string> RecentGames { get; set; } = new List<string>();
    
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
                game.GameOperation = Operation.Addition;
                score = game.PlayGame();
                RecordGame(game.GameOperation, score);
                break;
            case 2:
                game.GameOperation = Operation.Subtraction;
                score = game.PlayGame();
                RecordGame(game.GameOperation, score);
                break;
            case 3:
                game.GameOperation = Operation.Multiplication;
                score = game.PlayGame();
                RecordGame(game.GameOperation, score);
                break;
            case 4:
                game.GameOperation = Operation.Division;
                score = game.PlayGame();
                RecordGame(game.GameOperation, score);
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

    private void RecordGame(Operation operation, int score)
    {
        switch (operation)
        {
            case Operation.Addition:
                RecentGames.Add($"{DateTime.Now} - Addition - Score: {score}");
                break;
            case Operation.Subtraction:
                RecentGames.Add($"{DateTime.Now} - Subtraction - Score: {score}");
                break;
            case Operation.Multiplication:
                RecentGames.Add($"{DateTime.Now} - Multiplication - Score: {score}");
                break;
            case Operation.Division:
                RecentGames.Add($"{DateTime.Now} - Division - Score: {score}");
                break;
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