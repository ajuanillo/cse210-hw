using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
        Console.WriteLine("\n-------------Printing Journal--------------");
        foreach (Entry b in _entries)
        {
            Console.WriteLine($"Date: {b._date} - Prompt: {b._promptText}");
            Console.WriteLine(b._entryText);
        }
        Console.WriteLine("---------------Finish print---------------\n");
    }
    public void SaveToFile(string fileName)
    {
         using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry e in _entries)
            {
                outputFile.WriteLine($"{e._date},{e._promptText},{e._entryText}");
            }
        }
    }
    public void LoadFromFile(string fileName)
    {
        string[] lines=System.IO.File.ReadAllLines(fileName);
        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            Entry newEntry= new Entry();
            newEntry._date=parts[0];
            newEntry._promptText=parts[1];
            newEntry._entryText=parts[2];
            _entries.Add(newEntry);
        }
    }
}