
using System.IO;

public class GoalManager {
    private List<Goals> _goals;
    private int _score;

    public GoalManager(){
        _goals = new List<Goals>();
        _score = 0;  
    }
    public List<Goals> GetList() {
        return _goals;
    }

    public void Start() {
        DisplayPlayerInfo();
        Console.WriteLine("Menu Options:\n\t1. Create New Goal\n\t2. List Goals\n\t3. Save Goals\n\t4. Load Goals\n\t5. Record Event\n\t6. Quit");
        Console.Write("Select a choice from the menu:\t");
    }
    public void DisplayPlayerInfo(){
        Console.WriteLine($"You have {_score} points\n");
    }
    public void ListGoalNames() {
        foreach (Goals g in _goals) {
            Console.WriteLine($"{g}. {g.GetDetailsString()}");
        }
    }
    public void ListGoalDetails() {

    }
    public void CreateGoal() {
        Console.WriteLine($"The types of Goals are:\n\t1. Simple Goal\n\t2. Eternal Goal\n\t3. Checklist Goal");
        Console.Write($"Which type of goal would you like to create?");
        string goalType = Console.ReadLine();
        Console.Write("What is the name of your goal?" );
        string goalName = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string goalDesc = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        string stringPoints = Console.ReadLine();
        int points = int.Parse(stringPoints);
        //simple
        if (goalType == "1") {
            SimpleGoal simple = new SimpleGoal(goalName,goalDesc,points);
            _goals.Add(simple);
        }
        //eternal
        if (goalType == "2") {
            EternalGoal eternal = new EternalGoal(goalName,goalDesc,points);
            _goals.Add(eternal);
        }
        //checklist
        if (goalType == "3") {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());
            ChecklistGoal checklist = new ChecklistGoal(goalName,goalDesc,points,target,bonus);
            _goals.Add(checklist);
        }

    }
    public void RecordEvent() {

    }
    public void SaveGoals() {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        List<string> save = new List<string>();
        foreach (Goals goal in _goals) {
            string stringRep = goal.GetStringRepresentation();
            save.Add(stringRep);
        }
        using (StreamWriter outputFile = new StreamWriter(filename)) {
            foreach (string s in save) {
                outputFile.WriteLine(s);
            }
        }


    }
    public void LoadGoals() {
        Console.Write("What is the filename? ");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines) {
            string[] parts = line.Split(",");

            string type = parts[0];
            string name = parts[1];
            string description = parts[2];
            string points = parts[3];
                

            int intPoints = int.Parse(points);

            if (type == "SimpleGoal") {
                SimpleGoal simple = new SimpleGoal(name,description,intPoints);
                _goals.Add(simple);
            }
            else if (type == "EternalGoal") {
                EternalGoal eternal = new EternalGoal(name,description,intPoints);
                _goals.Add(eternal);
            }
            else if (type == "ChecklistGoal") {
                string target = parts[4];
                string amount = parts[5];
                string bonus = parts[6];
                int intTarget = int.Parse(target);
                int intAmount = int.Parse(amount);
                int intBonus = int.Parse(bonus);
                ChecklistGoal checklist = new ChecklistGoal(name,description,intPoints,intTarget,intBonus);
                _goals.Add(checklist);
            }

        }
    }
}