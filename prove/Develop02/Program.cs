using System;
using System.ComponentModel.Design;
using System.IO.Enumeration;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop02 World!");

        //Display welcome
        Console.WriteLine("Welcome to the Journal Program!");

        //Display Instructions
        Console.WriteLine("Please select one of the following choices:");

        //Display Options
        Console.WriteLine($"1.Write\n2.Display\n3.Load\n4.Save\n5.Search\n6.Quit");
        //Read chosen option
        string choice = Console.ReadLine();

        //new Journal instance
         Journal newJournal = new Journal();

        //while loop
        while (choice != "6") {

            //new instances of classes to work with
            Entry currentEntry = new Entry();
            PromptGenerator newPrompt = new PromptGenerator();
        

            //if 1 
            if(choice == "1") {
                //add carrot for easier reading
                Console.Write("> ");

                //new instance of PromptGenerator
                
                //get date and save
                DateTime currentDate = DateTime.Now;
                currentEntry._date = currentDate.ToShortDateString();

                //display and save prompt and entry
                currentEntry._prompt = newPrompt.GetRandomPrompt();
                Console.WriteLine(currentEntry._prompt);
                currentEntry._entryText= Console.ReadLine();

                //Display entry
                // currentEntry.DisplayEntry();
                //add to full list
                newJournal.AddEntry(currentEntry);
            }

            //if 2
            else if(choice == "2") {
                newJournal.DisplayAll();
            }

            //if 3
            else if(choice == "3") {
                Console.WriteLine("What is the filename?");
                string reqFile = Console.ReadLine();
                newJournal.LoadFromFile(reqFile);
            }

            //if 4
            else if(choice == "4") {
                Console.WriteLine("What is the filename?");
                string currentFile = Console.ReadLine();
                newJournal.SaveToFile(currentFile);
            }

            //if 5
            else if (choice == "5") {
                Console.WriteLine("What word would you like to search for? ");
                string keyword = Console.ReadLine();
                newJournal.SearchForKeyword(keyword);
            }

            //Display welcome
            Console.WriteLine("Welcome to the Journal Program!");

            //Display Instructions
            Console.WriteLine("Please select one of the following choices:");

            //Display Options
            Console.WriteLine($"1.Write\n2.Display\n3.Load\n4.Save\n5.Search \n6.Quit");
            //Read chosen option
            choice = Console.ReadLine();
        }

        Console.WriteLine("");
        Console.WriteLine("Goodbye");
    }
}