using System.IO;
using System.Security.Cryptography.X509Certificates;

public class Journal {
    public List<Entry> _entries = new List<Entry>();
    public List<Entry> _keywordEntries = new List<Entry>();


    public void AddEntry(Entry newEntry) {
        _entries.Add(newEntry);
    }

    public void DisplayAll() {
        foreach (Entry listEntry in _entries) {
            listEntry.DisplayEntry();
        }
    }

    public void DisplayKeyEntries() {
        foreach (Entry listEntry in _keywordEntries) {
            listEntry.DisplayEntry();
        }
    }

    public void SaveToFile(string file) {
        using(StreamWriter outputFile = new StreamWriter(file)) {
            foreach (Entry eachEntry in _entries) {
                string thisDate = eachEntry._date;
                string thisPrompt = eachEntry._prompt;
                string thisEntry = eachEntry._entryText;
                outputFile.WriteLine($"{thisDate},{thisPrompt},{thisEntry}");
            }
        }
    }

    public void LoadFromFile(string file) {
        string[] lines = System.IO.File.ReadAllLines(file);
        foreach (string line in lines) {
            Entry fileEntry = new Entry();

            string[] parts = line.Split(",");
            fileEntry._date = parts[0];
            fileEntry._prompt = parts[1];
            fileEntry._entryText =  parts[2]; 
            _entries.Add(fileEntry);       
        }
    }

    public void SearchForKeyword(string word) {
        foreach (Entry journalEntry in _entries) {
            if(journalEntry._entryText.Contains(word)) {
                _keywordEntries.Add(journalEntry);
            }
        }
        DisplayKeyEntries();
    }
}