using System;
using System.Collections.Generic;
using System.Threading;

public abstract class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public virtual void DisplayStartingMessage()
    {
        Console.WriteLine("\n**" + _name + "**\n" + _description + "\n");
        Console.WriteLine("Preparing to begin...");
        Thread.Sleep(3000);
    }

    public virtual void DisplayEndingMessage()
    {
        Console.WriteLine("\n**Well done!** You've completed this activity.");
        Thread.Sleep(2000);
        Console.WriteLine("You finished " + _name + " in " + _duration + " seconds.");
    }

    public void ShowSpinner(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i + "... ");
            Thread.Sleep(1000);
            Console.Clear();
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i + "... ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    public abstract void Run();

}