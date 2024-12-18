using System.Configuration.Assemblies;

public abstract class Goals {
    protected string _shortName;
    protected string _description;
    protected int _points;
    public Goals( string name, string description, int points) {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent();

    public abstract bool IsComplete();

    public string GetDetailsString(){
        string details = "";
        return details;
    }

    public abstract string GetStringRepresentation();


}