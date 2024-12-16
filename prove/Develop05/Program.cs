using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Activities mainActivity = new Activities();
        Console.WriteLine($"Menu Options:");
        Console.WriteLine($"\t1.Start breathing activity.\n\t2. Start reflecting activity\n\t3. Start listing activity\n\t4.Quit");
        string userInput = Console.ReadLine();

        while (userInput != "4") {
            if (userInput == "1") {
                BreathingActivity startBreathing = new BreathingActivity();
                startBreathing.Run();
            }
            else if (userInput == "2") {
                ReflectingActivity reflecting = new ReflectingActivity();
                reflecting.Run();
            }
            else if (userInput == "3") {
                ListingActivity lists = new ListingActivity();
                lists.Run();
            }
            Console.WriteLine($"Menu Options:");
            Console.WriteLine($"\t1.Start breathing activity.\n\t2. Start reflecting activity\n\t3. Start listing activity\n\t4.Quit");
            userInput = Console.ReadLine();
        }

        Console.WriteLine($"Great job practicing some mindfulness today.\nHave a great Day!\nSee you next time!");
        
    }
}