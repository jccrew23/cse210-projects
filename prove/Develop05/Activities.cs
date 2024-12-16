using System.Diagnostics;

public class Activities {
    private string _name;
    private string _description;
    private int _duration;

    public Activities(){
        _name = "";
        _description = "";
    }

    public void DisplayStartingMessage(){
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}");
        Console.WriteLine();
        Console.WriteLine($"{_description}");
        Console.WriteLine();
        Console.WriteLine($"How long, in seconds, would you like for your session?");
        string time = Console.ReadLine();
        _duration = int.Parse(time);
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
    }
    public void DisplayEndingMessage(){       
        Console.WriteLine($"Well done!!");
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}");
    }
    public void ShowSpinner(int seconds) {
        List<string> spinnerChar = new List<string>{ "|", "/", "-", "\\" };

        int i = 0;
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        
        while (DateTime.Now < endTime){
            string s = spinnerChar[i];
            Console.Write(s);
            Thread.Sleep(300);
            Console.Write("\b \b");

            i++;
            if (i >= spinnerChar.Count) {
                i = 0;
            }
        }

    }
    public void ShowCountDown(int seconds) {
        for (int i = seconds; i>0; i--) {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    } 
    public void ShowGrowingLine(int seconds) {
        string line = "";
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        
        while (DateTime.Now < endTime){
             line += "-";
            Console.Write(line);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
    public string GetActName() {
        return _name;
    }
    public string GetActDesc() {
        return _description;
    }
    public int GetDuration() {
        return _duration;
    }
     public void SetActivity (string name,string desc){
       _name = name;
       _description = desc;
    }
}