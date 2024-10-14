public class BreathingActivity : Activity
{
    private int _count;

    public BreathingActivity() : base("Breathing Exercise", "Relax by focusing on your breath.", 20)
    {
        _count = _duration;
    }

    public override void Run()
    {
        base.DisplayStartingMessage();

        for (int i = 0; i < _count / 2; i++)
        {
            Console.WriteLine("Breathe in...");
            ShowCountDown(3);
            Console.WriteLine("Breathe out...");
            ShowCountDown(3);
        }

        base.DisplayEndingMessage();
    }
}