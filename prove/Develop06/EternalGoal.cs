public class EternalGoal : Goals {
    public EternalGoal(string name, string description, int points) : base(name,description,points){}
    public override void RecordEvent() {
        
    }
    public override bool IsComplete(){
        return false;
    }
    public override string GetStringRepresentation() {

        string stringRep = $"EternalGoal,{_shortName},{_description},{_points}";
        return stringRep;
        
    }
}