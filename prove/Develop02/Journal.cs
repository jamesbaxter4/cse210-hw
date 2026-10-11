using System.Collections.Generic;
using System;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public List<string> _prompts = new List<string>
    {
        "Did I do anything exciting today?",
        "What is something new that I learned today?",
        "Was there something that I did to push my boundaries?",
        "Is there something that I can improve on today?",
        "What am I grateful for today?",
        "Did I see any cats today?"
    };

    public void AddEntry()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        string prompt = _prompts[index];

        Console.WriteLine(prompt);
        string response = Console.ReadLine();

        string date = DateTime.Now.ToShortDateString();

        Entry newEntry = new Entry();
        newEntry._date = date;
        newEntry._prompt = prompt;
        newEntry._response = response;

        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("Your journal is currently empty.");
        }

        Console.WriteLine("--- Journal Entries ---");
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile()
    {
        Console.WriteLine("What is the Filename?");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine(entry.ToFileString());
            }
        }
        Console.WriteLine("Journal saved successfully!");
    }

    public void LoadFromFile (string filename)
    {
        if(!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        _entries.Clear();
        string[] line = File.ReadAllLines(filename);
    }

}