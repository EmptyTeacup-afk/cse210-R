using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string UserName = PromptUserName();
        int UserNumber = PromptUserNumber();
        int SquaredNumber = SquareNumber(UserNumber);
        DisplayResult(UserName, SquaredNumber);
    } 
    
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }
    
    static string PromptUserName()
    {
        Console.Write("Enter in your name: ");
        string name = Console.ReadLine();
        
        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    static int SquareNumber( int number)
    {
        int square = number * number;

        return square;
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}.");
    }

}