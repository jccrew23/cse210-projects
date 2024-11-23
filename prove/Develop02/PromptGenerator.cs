public class PromptGenerator {
    List<string> _prompts = new List<string>{
        "Who are the people that you want to do life with?",
        "What feels good about your life right now?",
        "What does success mean to you?",
        "Are there any new habits you want to incorporate into your life?",
        "What is your relationship with social media? Does it impact you in a positive way, or does it leave you feeling drained?",
        "What is holding you back from achieving your goals or living your dream life?",
        "What 5 lessons would you tell your 18-year-old self?",
        "What is your biggest source of joy? How can you cultivate more of it?",
        "What are you struggling with right now?",
        "What is one thing you can do to step outside of your comfort zone today/this week/month/year?"
    };     

    public string GetRandomPrompt() {
        Random _rnd = new Random();
        int _randInt = _rnd.Next(0,10); 
        string _currentPrompt = _prompts[_randInt];
        return _currentPrompt; 
    }
}