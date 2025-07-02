using System;

namespace MathGame;

internal class GameEngine
{
    private int UserAnswer { get; set; }

    private int CorrectAnswer { get; set; }
    
    private int Score { get; set; }
    
    private int Operand1 { get; set; }
    
    private int Operand2 { get; set; }

    internal int PlayAddition()
    {
        Score = 0;
        for (int i = 0; i < 5; i++)
        {
            Console.Clear();
            GetOperands();
            SetCorrectAnswer('+');
            Console.WriteLine($"{Operand1} + {Operand2}");
            GetUserAnswer();
            IsUserAnswerCorrect();
        }
        Console.Clear();
        Console.Write($"Your final score was {Score}. Press enter to return to menu.");
        Console.ReadLine();
        return Score;
    }
    
    internal static void PlaySubtraction()
    {
        Console.WriteLine("Subtraction Game coming soon. Press enter to continue.");
        Console.ReadLine();
    }
    
    internal static void PlayMultiplication()
    {
        Console.WriteLine("Multiplication Game coming soon. Press enter to continue.");
        Console.ReadLine();
    }
    
    internal static void PlayDivision()
    {
        Console.WriteLine("Division Game coming soon. Press enter to continue.");
        Console.ReadLine();
    }

    private void GetOperands()
    {
        Random random = new Random();
        Operand1 = random.Next(1, 101);
        Operand2 = random.Next(1, 101);
    }

    private void SetCorrectAnswer(char operation)
    {
        switch (operation)
        {
            case '+':
                CorrectAnswer = Operand1 + Operand2;
                break;
            case '-':
                CorrectAnswer = Operand1 - Operand2;
                break;
            case '*':
                CorrectAnswer = Operand1 * Operand2;
                break;
            case '/':
                CorrectAnswer = Operand1 / Operand2;
                break;
            default:
                throw new ArgumentException("Argument Exception: Operation is invalid.");
        }
    }

    private void GetUserAnswer()
    {
        string? input;
        int output;
        do
        {
            input = Console.ReadLine();
        } while (!int.TryParse(input, out output));
        UserAnswer = output;
    }

    private void IsUserAnswerCorrect()
    {
        if (UserAnswer == CorrectAnswer)
        {
            Console.WriteLine("Correct! Press enter to continue.");
            Score++;
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine($"Sorry, the correct answer was {CorrectAnswer}. Press enter to continue.");
            Console.ReadLine();
        }
    }
}