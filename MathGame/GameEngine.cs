using System;

namespace MathGame;

internal class GameEngine
{
    private char _operation;
    internal char Operation
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
    
    internal int PlayGame()
    {
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
    private void GetOperands()
    {
        Random random = new Random();
        switch (Operation)
        {
            case '+':
                Operand1 = random.Next(1, 101);
                Operand2 = random.Next(1, 101);
                break;
            case '-':
                do
                {
                    Operand1 = random.Next(1, 101);
                    Operand2 = random.Next(1, 101);
                } while (Operand1 - Operand2 < 0);
                break;
            case '*':
                Operand1 = random.Next(1, 12);
                Operand2 = random.Next(1, 12);
                break;
            case '/':
                do
                {
                    Operand1 = random.Next(1, 145);
                    Operand2 = random.Next(1, 145);
                } while (Operand1 % Operand2 != 0);
                break;
        }

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