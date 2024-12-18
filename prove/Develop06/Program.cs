using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager newGame = new GoalManager();
        newGame.Start();
        string userInput = Console.ReadLine();

        while (userInput != "6") {
            if (userInput == "1") {
                newGame.CreateGoal();
            }
            if (userInput == "2") {
                newGame.ListGoalNames();
            }
            if (userInput == "3") {
                newGame.SaveGoals();
            }
            if (userInput == "4") {
                newGame.LoadGoals();
            }
            if (userInput == "5") {
                newGame.RecordEvent();
            }
            newGame.Start();
            userInput = Console.ReadLine();

        }

        Console.WriteLine("Thanks for playing! See you next time!");


    }
}