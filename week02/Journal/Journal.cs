using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> _entries = new List<Entry>();
    public string _fileName;

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (var entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        _fileName = file;
        
        using (StreamWriter writer = new StreamWriter(file))
        {
            foreach (var entry in _entries)
            {
                writer.WriteLine(entry._date + "," + entry._promptText + "," + entry._entryText);
            }
        }
    }

    public void LoadFromFile(string file)
    {
       
        if (File.Exists(file))
        {
            _fileName = file;
            _entries.Clear();
            string[] lines = File.ReadAllLines(file);
            foreach (var line in lines)
            {

                string[] parts = line.Split(",");
                Entry newEntry = new Entry(parts[0], parts[1], parts[2]);
                _entries.Add(newEntry);

            }
        }
        else
        {
            Console.WriteLine("File not found, please Save (option 3) the journal.");
        }
    }
    
    public bool CheckBeforeExit()
    {   

        if(_fileName == null)
        {
            Console.WriteLine("You have not saved the journal yet.");
            Console.WriteLine("Please save the journal before exiting.");
            return false;
        }
    
        if (!File.Exists(_fileName))
        {
            Console.WriteLine("Please save the journal before exiting.");
            return false;
        }

        string[] lines = File.ReadAllLines(_fileName);
        if (lines.Length != _entries.Count)
        {
            Console.WriteLine("Some of the entries are not saved.");
            Console.WriteLine("Please save the journal before exiting.");
            return false;
        }

        return true;
    }


}
