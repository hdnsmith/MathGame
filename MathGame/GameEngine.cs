using System;

namespace MathGame;

internal class GameEngine
{
    internal static void PlayAddition()
    {
        Random random = new Random();
        int score = 0;
        for (int i = 0; i < 5; i++)
        {
            Console.Clear();
            
            int num1 = random.Next(1, 101);
            int num2 = random.Next(1, 101);
            int correctAnswer = num1 + num2;
            
            Console.WriteLine($"{num1} + {num2}");
            
            int userAnswer = GetUserAnswer();
            if (userAnswer == correctAnswer)
            {
                Console.WriteLine("Correct! Press enter to continue.");
                score++;
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine($"Sorry, the correct answer was {correctAnswer}. Press enter to continue.");
                Console.ReadLine();
            }
        }
        Console.Clear();
        Console.Write($"Your final score was {score}. Press enter to return to menu.");
        Console.ReadLine();
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

    private static int GetUserAnswer()
    {
        string? input;
        int userAnswer;
        
        do
        {
            input = Console.ReadLine();
        } while (!int.TryParse(input, out userAnswer));
        
        return userAnswer;

    }
}