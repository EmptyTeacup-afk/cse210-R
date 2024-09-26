using System;
public class Entry
{
    public string _prompt { get; set; }
    public string _response { get; set; }
    public string _date { get; set; }

    public Entry(string prompt, string response, string date)
    {
        _prompt = prompt;
        _response = response;
        _date = date;
    }
    public string GetPrompt()
    {
        return _prompt;
    }
    public string GetResponse()
    {
        return _response;
    }
    public string GetDate()
    {
        return _date;
    }
    public override string ToString()
    {
        return $"Date: {_date} - Prompt: {_prompt} \n{_response}\n";
    }
} 