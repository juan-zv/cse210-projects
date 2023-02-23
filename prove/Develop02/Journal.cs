using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> entries;

    public Journal()
    {
        entries = new List<Entry>();
    }

    public void AddEntry(Entry entry)
    {
        entries.Add(entry);
    }

    public void DisplayJournal()
    {
        foreach (Entry entry in entries)
        {
            Console.WriteLine("Date: " + entry.date);
            Console.WriteLine("Prompt: " + entry.prompt);
            Console.WriteLine("Response: " + entry.response);
            Console.WriteLine("----------------------------------------------------------");
        }
    }

    public void SaveJournal(string fileName)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (Entry entry in entries)
            {
                writer.WriteLine(entry.date + "|" + entry.prompt + "|" + entry.response);
            }
        }
    }

    public void LoadJournal(string fileName)
    {
        entries.Clear();

        if (File.Exists(fileName))
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split("|");
                    Entry entry = new Entry();
                    entry.date = parts[0];
                    entry.prompt = parts[1];
                    entry.response = parts[2];
                    entries.Add(entry);
                }
            }
        }
    }
}