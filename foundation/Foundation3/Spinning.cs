public class Spinning : Activity{
    public Spinning(DateTime date, int length, double distance) : base(date,length) {
        _date = date;
        _length = length;
        _distance = distance;
        _activity = "Spinning";

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