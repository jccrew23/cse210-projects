using System.Dynamic;

public class KidsActivites : Activities {
    public List<string> _kidsActivities = new List<string>{"Senses: Focus on the five senses, or try a game of eating a snack slowly and savoring the experience","Art: Create mandalas, draw in sand, or do leaf rubbings","Glitter jar: Make a glitter jar with various materials, which can represent the mind settling","Walking a maze: Draw a maze with chalk or masking tape and have your child walk it slowly and carefully","Drawing: Have your child notice how their favorite tool feels on the paper, and try doodling or Zentangling","Mindful reading: Read a book mindfully","Yoga: Practice yoga poses like the Superman or Wonder Woman","Spidey senses: Turn on your Spidey senses and focus on the present moment","Jenga: Play Jenga while your child is distracted, then play again after helping them cultivate a calm mind through mindful breathing"};
    public KidsActivites() {
    }
    public void Run() {
        SetActivity("Kids Activity","This will give you an idea of something you can do with your kids to practice mindfulness.");
        DisplayStartingMessage();
        Console.WriteLine("Here is an activity to with your children: ");
        Console.WriteLine(GetRandomPrompt());
        Console.WriteLine("When you are completed with the activity, press any key to continue");
        Console.ReadKey();
        DisplayEndingMessage();
    }
    public string GetRandomPrompt() {
        Random random = new Random();
        int randNum = random.Next(1,_kidsActivities.Count());
        string newPrompt = _kidsActivities[randNum];
        return newPrompt;
    }
}