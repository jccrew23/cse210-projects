using System.Diagnostics;

public class BreathingActivity : Activities {
    public BreathingActivity(){
    }
    public void Run() {
        Console.Clear();
        SetActivity("Breathing Activity","This activity will help you relax by walking you through breathing in and out slowly.\nClear your mind and focus on your breathing.");
        DisplayStartingMessage();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());

        while (DateTime.Now < endTime) {
            Console.Write("Breathe in...");
            ShowCountDown(5);
            Console.WriteLine();
            Console.Write("Now breathe out...");
            ShowCountDown(5);
            Console.WriteLine();
        }
        DisplayEndingMessage();
    }
    
}