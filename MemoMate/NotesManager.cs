using System;
using Newtonsoft.Json;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteTaker
{
    public class NotesManager
    {
        private static List<NoteEntry> notes;

        public NotesManager()
        {
            notes = new List<NoteEntry>();
            LoadNotesFromFile(@"C:\Users\Omar\Desktop\Notes.json");
        }

        public void AddNote(string noteName,DateTime date, string input)
        {
            NoteEntry note=new NoteEntry(noteName, date, input);
            notes.Add(note);
            SaveNotesToFile(@"C:\Users\Omar\Desktop\Notes.json");
        }

        public void RemoveNote(NoteEntry note)
        {
            notes.Remove(note);
            SaveNotesToFile(@"C:\Users\Omar\Desktop\Notes.json");
        }

        public List<NoteEntry> GetAllNotes()
        {
            return notes;
        }
        public void SaveNotesToFile(string filePath)
        {
            string json = JsonConvert.SerializeObject(notes);
            File.WriteAllText(filePath, json);
        }
        public void LoadNotesFromFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                notes= JsonConvert.DeserializeObject<List<NoteEntry>>(json);
            }
        }
    }
}
