public abstract class Activity {
    protected DateTime _date;
    protected double _length;
    protected double _distance;
    protected string _activity;
    private double _speed;
    private double _pace;
    public Activity(DateTime date, double length){
    }
    public abstract void Run();
    public abstract double CalculateDistance(double distance);
    public double CalculateSpeed(double distance, double length){
        _speed = (distance / length) * 60;
        _speed = Math.Round(_speed,2);
        return _speed;
    }
     public double CalculatePace(double distance, double length){
        _pace = length / distance;
        _pace = Math.Round(_pace,2);
        return _pace;
    }
    public void GetSummary () {
        Console.WriteLine($"{_date} {_activity} ({_length} min): Distance {_distance} miles, Speed {_speed} mph, Pace: {_pace} min per mile");
    }
    
}