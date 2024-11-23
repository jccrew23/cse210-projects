public class Entry {
    public string _date;
    public string _prompt;
    public string _entryText;

    public void DisplayEntry(){
        Console.WriteLine("");
        Console.WriteLine($"Date: {_date} - Prompt: {_prompt} {_entryText}");
        Console.WriteLine("");
    }
}