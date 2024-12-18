// using System.ComponentModel;
// using System.Runtime.CompilerServices;

public class SimpleGoal : Goals {
    private bool _isComplete;
    public SimpleGoal(string name, string description, int points) : base(name, description, points) {
        _isComplete = false;
    }
    public override void RecordEvent(){
        

    }

    public override bool IsComplete(){
        if (_isComplete == true) {
            return true;
        }
        else {
            return false;
        }
    }

    public override string GetStringRepresentation() {
        string stringRep = $"SimpleGoal,{_shortName},{_description}, {_points}";

        return stringRep;
    }
}