public class RunningActivity : Activity
{
    private double DistanceInKilometers { get; set; }

    public RunningActivity(DateTime date, int durationInMinutes, double distanceInKilometers) : base(date, durationInMinutes)
    {
        DistanceInKilometers = distanceInKilometers;
    }

    public override double GetDistance() => DistanceInKilometers;
    public override double GetSpeed() => DistanceInKilometers / DurationInMinutes * 60;
    public override double GetPace() => DurationInMinutes / DistanceInKilometers;
}
