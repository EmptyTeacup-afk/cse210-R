public class CyclingActivity : Activity
{
    private double AverageSpeedInKph { get; set; }

    public CyclingActivity(DateTime date, int durationInMinutes, double averageSpeedInKph) : base(date, durationInMinutes)
    {
        AverageSpeedInKph = averageSpeedInKph;
    }

    public override double GetDistance() => AverageSpeedInKph * DurationInMinutes / 60;
    public override double GetSpeed() => AverageSpeedInKph;
    public override double GetPace() => 60 / AverageSpeedInKph;
}