using System;

namespace MathGame;

internal class GameEngine
{
    private char _operation;
    private char Operation
    {
        get => _operation;
        set
        {
            switch (value)
            {
                case '+':
                case '-':
                case '*':
                case '/':
                    _operation = value;
                    break;
                default:
                    throw new InvalidOperationException($"Unsupported Operation: {value}");
            }
        }
    }
    
    private int UserAnswer { get; set; }

    private int CorrectAnswer { get; set; }
    
    private int Score { get; set; }
    
    private int Operand1 { get; set; }
    
    private int Operand2 { get; set; }

    //TODO: Merge all Play methods into one method.
    internal int PlayAddition()
    {
        Operation = '+';
        Score = 0;
        for (int i = 0; i < 5; i++)
        {
            Console.Clear();
            GetOperands();
            SetCorrectAnswer();
            DisplayEquation();
            GetUserAnswer();
            if (IsUserAnswerCorrect())
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
        Console.Clear();
        Console.Write($"Your final score was {Score}. Press enter to return to menu.");
        Console.ReadLine();
        return Score;
    }
    
    internal int PlaySubtraction()
    {
        Operation = '-';
        Score = 0;
        for (int i = 0; i < 5; i++)
        {
            Console.Clear();
            GetOperands();
            SetCorrectAnswer();
            DisplayEquation();
            GetUserAnswer();
            if (IsUserAnswerCorrect())
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
        Console.Clear();
        Console.Write($"Your final score was {Score}. Press enter to return to menu.");
        Console.ReadLine();
        return Score;
    }
    
    internal int PlayMultiplication()
    {
        Operation = '*';
        Score = 0;
        for (int i = 0; i < 5; i++)
        {
            Console.Clear();
            GetOperands();
            SetCorrectAnswer();
            DisplayEquation();
            GetUserAnswer();
            if (IsUserAnswerCorrect())
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
        Console.Clear();
        Console.Write($"Your final score was {Score}. Press enter to return to menu.");
        Console.ReadLine();
        return Score;
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

    private void SetCorrectAnswer()
    {
        switch (Operation)
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
                throw new InvalidOperationException($"Unsupported operation: {Operation}");
        }
    }

    private void DisplayEquation()
    {
        switch (Operation)
        {
            case '+':
                Console.WriteLine($"{Operand1} + {Operand2}");
                break;
            case '-':
                Console.WriteLine($"{Operand1} - {Operand2}");
                break;
            case '*':
                Console.WriteLine($"{Operand1} * {Operand2}");
                break;
            case '/':
                Console.WriteLine($"{Operand1} / {Operand2}");
                break;
            default:
                throw new InvalidOperationException($"Unsupported operation: {Operation}");
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

    private bool IsUserAnswerCorrect()
    {
        if (UserAnswer == CorrectAnswer)
        {
            return true;
        }
        return false;
    }
}