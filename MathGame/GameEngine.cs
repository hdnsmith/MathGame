using System;

namespace MathGame;

internal class GameEngine
{
    internal Operation GameOperation { get; set; }

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
        switch (GameOperation)
        {
            case Operation.Addition:
                Operand1 = random.Next(1, 51);
                Operand2 = random.Next(1, 51);
                break;
            case Operation.Subtraction:
                do
                {
                    Operand1 = random.Next(1, 101);
                    Operand2 = random.Next(1, 101);
                } while (Operand1 - Operand2 < 0);
                break;
            case Operation.Multiplication:
                Operand1 = random.Next(1, 13);
                Operand2 = random.Next(1, 13);
                break;
            case Operation.Division:
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
        switch (GameOperation)
        {
            case Operation.Addition:
                CorrectAnswer = Operand1 + Operand2;
                break;
            case Operation.Subtraction:
                CorrectAnswer = Operand1 - Operand2;
                break;
            case Operation.Multiplication:
                CorrectAnswer = Operand1 * Operand2;
                break;
            case Operation.Division:
                CorrectAnswer = Operand1 / Operand2;
                break;
        }
    }

    private void DisplayEquation()
    {
        switch (GameOperation)
        {
            case Operation.Addition:
                Console.WriteLine($"{Operand1} + {Operand2}");
                break;
            case Operation.Subtraction:
                Console.WriteLine($"{Operand1} - {Operand2}");
                break;
            case Operation.Multiplication:
                Console.WriteLine($"{Operand1} * {Operand2}");
                break;
            case Operation.Division:
                Console.WriteLine($"{Operand1} / {Operand2}");
                break;
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