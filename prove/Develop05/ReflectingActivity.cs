public class ReflectingActivity : Activities {
    private List<string> _prompts = new List<string>{"Think of a time when you stood up for someone else.","Think of a time when you did something really difficult.","Think of a time when you helped someone in need.","Think of a time when you did something truly selfless.","Think of things that made you smile today.","Think about some beautiful things that you heard today.","Think of someone you love."};
    private List<string> _questions = new List<string>{"Why was this experience meaningful to you?","Have you ever done anything like this before?","How did you get started?","How did you feel when it was complete?","What made this time different than other times when you were not as successful?","What is your favorite thing about this experience?","What could you learn from this experience that applies to other situations?","What did you learn about yourself through this experience?","How can you keep this experience in mind in the future?"};

    public ReflectingActivity(){

    }
    public void Run(){
        Console.Clear();
        SetActivity("Reflecting Activity","This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        DisplayStartingMessage();
        Console.WriteLine($"Consider the following prompt: \n---{GetRandomPrompt()}---");
        Console.WriteLine($"When you have an answer press any key to continue.");
        Console.ReadKey();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());

        while (DateTime.Now < endTime) {
            Console.Write(GetRandomQuestion());
            ShowSpinner(5);
            Console.WriteLine();
        }
        DisplayEndingMessage();
    }
    public string GetRandomPrompt() {
        Random random = new Random();
        int randNum = random.Next(1,_prompts.Count());
        string newPrompt = _prompts[randNum];
        return newPrompt;
    }
    public string GetRandomQuestion() {
        Random random = new Random();
        int randNum = random.Next(1,_questions.Count());
        string newQuestion = _questions[randNum];
        return newQuestion;
    }
    public void DisplayPrompt() {

    }
    public void DisplayQuestions(){

    }
}