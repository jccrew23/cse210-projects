using System;
using System.Reflection;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        // get user grade percentage
        Console.Write("What is your grade percentage? ");
        string gradePerc = Console.ReadLine();
        int numPerc = int.Parse(gradePerc);

        // determine grade letter
        string gradeLet = " ";
        if (numPerc >= 90) {
            gradeLet = "A";
        }
        else if (numPerc >=80) {
            gradeLet = "B";
        }
        else if (numPerc >=70) {
            gradeLet = "C";
        } 
        else if (numPerc >=60) {
            gradeLet = "D";
        }
        else {
            gradeLet = "F";
        }

        //Determine if they passed
        string message = "";
        if (numPerc >= 70) {
            message = "Congratulations! You have passed!";
        }
        else {
            message = "Unfortunately, you have not passed.";
        }

        //display results
        if (gradeLet == "A") {
            Console.WriteLine($"{message} You got an {gradeLet}.");
        }
        else {
            Console.WriteLine($"{message} You got a {gradeLet}.");
        }
    }
}