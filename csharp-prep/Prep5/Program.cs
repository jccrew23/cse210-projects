using System;
using System.Globalization;
using System.Reflection.Metadata;

class Program
{
    static void DisplayWelcome() {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName() {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }

    static int PromptUserNumber() {
        Console.Write("Please enter your favorite number: ");
        string favNum = Console.ReadLine();
        int num = int.Parse(favNum);

        return num;
    }

    static int SquareNumber(int num) {
        int squaredNum = num * num;
        return squaredNum;
    }

    static void DisplayResult(string name, int num) {
        Console.WriteLine($"{name}, the square of your number is {num}");
    }

    static void Main(string[] args)
    {
        DisplayWelcome();
        
        string user = PromptUserName();

        int userNum = PromptUserNumber();

        int squareNum = SquareNumber(userNum);

        DisplayResult(user, squareNum);
    }
}