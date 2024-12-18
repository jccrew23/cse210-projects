public class ChecklistGoal : Goals {
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    public ChecklistGoal(string name, string description,  int points, int target, int bonus) : base(name,description,points) {
        _amountCompleted = 0;
    }
    public override bool IsComplete(){
        if (_amountCompleted == _bonus) {
            return true;
        }
        else {
            return false;
        }
    }
    public override void RecordEvent() {

    }

    // public override string GetDetailsString() {

    // }

    public override string GetStringRepresentation() {

        string stringRep = $"ChecklistGoal,{_shortName},{_description},{_points},{_target},{_amountCompleted},{_bonus}";
        return stringRep;
    }
}