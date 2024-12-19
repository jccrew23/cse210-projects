public class Running : Activity {
    public Running(DateTime date, double length, double distance) : base(date,length){
        _date = date;
        _length = length;
        _distance = distance;
        _activity = "Running";
    }

    public override void Run()
    {
        CalculateSpeed(_distance,_length);
        CalculatePace(_distance,_length);
    }
    

    public override double CalculateDistance(double distance)
    {
        return distance;
    }

}