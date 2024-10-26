public class SwimmingActivity : Activity
{
    private int Laps { get; set; }

    public SwimmingActivity(DateTime date, int durationInMinutes, int laps) : base(date, durationInMinutes)
    {
        Laps = laps;
    }

    public override double GetDistance() => Laps * 50 / 1000;
    public override double GetSpeed() => GetDistance() / DurationInMinutes * 60;
    public override double GetPace() => DurationInMinutes / GetDistance();
}