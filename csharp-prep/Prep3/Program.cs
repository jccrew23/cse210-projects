using System;

class Program
{
    static void Main(string[] args)
    {
        //generate random number
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);

        //ask for guess
        Console.Write("What is your guess? ");
        string guess = Console.ReadLine();
        int numGuess = int.Parse(guess);

        //tell if it's higher or lower
        int counter = 1;
        while (numGuess != number) {
            if (number < numGuess) {
                Console.WriteLine("Lower");
            }
            else if (numGuess < number) {
                Console.WriteLine("Higher");
            }
            else {
                Console.WriteLine("You've guessed correctly!");
            }
            
            counter++;

            Console.Write("What is your guess? ");
            guess = Console.ReadLine();
            numGuess = int.Parse(guess);  
        }

        //when guess is correct, tell how many 
        Console.WriteLine($"You made {counter} guesses.");
    }
}