using System;
using System.IO;
using System.Runtime.CompilerServices;

public class Journal
{
    public List<Entry> _entries;
    public Journal()
    {
        _entries = new List<Entry>();
    }
    
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayEntries()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("The journal is empty.");
        }
        else
        {
            foreach (var entry in _entries)
            {
                Console.WriteLine(entry);
            }
        }
    }

    public void SaveToFile(string fileName)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (var entry in _entries)
            {
                writer.WriteLine($"{entry.GetDate().Replace(",","\\,")}|{entry.GetPrompt()}|{entry.GetResponse().Replace(",", "\\,")}");
        }
        }
    }

    public void LoadFromFile(string fileName)
    {
        _entries.Clear();

        using (StreamReader reader = new StreamReader(fileName))
        {
            //string headerLine = reader.ReadLine(); // Read and discard the header line

            while (!reader.EndOfStream)
            {
            string entryLine = reader.ReadLine();
            string[] fields = entryLine.Split('|');
         
            string date = fields[0];
            string prompt = fields[1].Replace("\\,", ","); 
            string response = fields[2].Replace("\\,", ",");

            _entries.Add(new Entry(prompt, response, date));
            }
        }

    }

}