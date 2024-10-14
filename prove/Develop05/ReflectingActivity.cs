public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity() : base("Reflecting Activity", "Reflect on past experiences.", 120)
    {
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    public string GetRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(_questions.Count);
        return _questions[index];
    }

    public void DisplayPrompt()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine(prompt);
        ShowCountDown(5);
    }

    public void DisplayQuestions()
    {
        for (int i = 0; i < _questions.Count; i++)
        {
            string question = GetRandomQuestion();
            Console.WriteLine(question);
            ShowCountDown(5);
        }
    }

    public List<string> GetListFromUser()
    {
        List<string> items = new List<string>();
        Console.WriteLine("Start listing...");
        ShowCountDown(_duration);

        while (true)
        {
            Console.Write("Enter an item: (press enter when done)");
            string item = Console.ReadLine();
            if (!string.IsNullOrEmpty(item))
            {
                items.Add(item);
            }
            else
            {
                break;
            }
        }

        return items;
    }

    public override void Run()
    {
        base.DisplayStartingMessage();

        DisplayPrompt();
        DisplayQuestions();

        // Get the list of items from the user
        List<string> items = GetListFromUser();

        // Display the list of items
        Console.WriteLine("Your list:");
        foreach (string item in items)
        {
            Console.WriteLine("- " + item);
        }

        base.DisplayEndingMessage();
    }
}