using System.Net;

public class ListingActivity : Activities {
    private int _count;
    private List<string> _prompts = new List<string>{"Who are people that you appreciate?","What are personal strengths of yours?","Who are people that you have helped this week?","When have you felt the Holy Ghost this month?","Who are some of your personal heroes?"};
    public ListingActivity(){
        _count = 0;
    }
    public void Run() {
        Console.Clear();
        SetActivity("Listing Activity","This activity will help you relax by walking you through breathing in and out slowly.'\nClear your mind and focus on your breathing.");
        DisplayStartingMessage();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());
        Console.WriteLine(GetRandomPrompt());
        ShowCountDown(5);
        List<string> responses = new List<string>();
        
        while (DateTime.Now < endTime) {
           Console.Write("<");
            string response = Console.ReadLine();
            responses.Add("response");
            _count++;
        }
        Console.WriteLine($"You listed {_count} times!");
        DisplayEndingMessage();
    }
   public string GetRandomPrompt() {
        Random random = new Random();
        int randNum = random.Next(1,_prompts.Count());
        string newPrompt = _prompts[randNum];
        return newPrompt;
    }
    // public List<string> GetListFromUser() {
        
        

    // }
}