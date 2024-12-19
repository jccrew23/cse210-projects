public class Swimming : Activity {
   public Swimming(DateTime date, int length, int laps) : base(date,length) {
        _length = length;
        _date = date;
        _distance = CalculateDistance(laps);
        _activity = "Swimming";

   }
    public override void Run()
    {
        CalculateSpeed(_distance,_length);
        CalculatePace(_distance,_length);
    }
    public override double CalculateDistance(double laps) {
        double distance = laps * 50 / 1000 * 0.62;
        _distance = Math.Round(distance,2);
        return distance; 
    }

}