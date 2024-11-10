using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        //instructions
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        //make list
        List <int> numbers = new List<int>();

        int value = -1;

        while (value != 0) {
            //ask a number
            Console.Write("Enter a number: ");
            string stringValue = Console.ReadLine();
            value = int.Parse(stringValue);

            if (value != 0) {
                numbers.Add(value);
            }
        }

        //compute the sum
        int total = 0;
        int max = 0;

        foreach (int num in numbers) {
            total += num;

            if (num > max) {
                max = num;
            }
        }

        //calculate average
        int length = numbers.Count;
        int average = total / length;

        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");
        
    }
}