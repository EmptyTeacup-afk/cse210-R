using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number = -1;
        

        while (number != 0)
        {
            Console.WriteLine("Enter a list of numbers, type 0 when finished.");
            string useranswer = Console.ReadLine();
            number = int.Parse(useranswer);

            if (number != 0)
            {
                numbers.Add(number);
            }

            
        }
        
        int sum = 0;
        foreach(int i in numbers)
        {
            sum += i;
        }
        
        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");
    
    
        int max = numbers[0];

        foreach (int i in numbers)
        {
            if (i > max)
            {
                // if this number is greater than the max, we have found the new max!
                max = i;
            }
        }

        Console.WriteLine($"The max is: {max}");

    }
}