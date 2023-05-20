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
        private List<NoteEntry> notes;

        public NotesManager()
        {
            notes = new List<NoteEntry>();
            LoadNotesFromFile(@"C:\Users\Omar\Desktop\Notes.json");
        }
        public void AddNote(string noteName,DateTime date, string input)
        {
            NoteEntry note=new NoteEntry(noteName, date, input);
            notes.Add(note);
            //SaveNotesToFile(@"C:\Users\Omar\Desktop\Notes.json");
        }

        public void RemoveNote(NoteEntry note)
        {
            notes.Remove(note);
            //SaveNotesToFile(@"C:\Users\Omar\Desktop\Notes.json");
        }
        public void RemoveNote(int noteId)
        {
            NoteEntry obj = notes.FirstOrDefault(o => o.Id == noteId);
            notes.Remove(obj);
            //SaveNotesToFile(@"C:\Users\Omar\Desktop\Notes.json");
        }
        public void EditNote(int noteId,string newName,string newText) 
        {
            NoteEntry obj = notes.FirstOrDefault(o => o.Id == noteId);
            notes.Find(o => o.Id == noteId).Name = newName;
            notes.Find(o => o.Id == noteId).Text=newText;
        }
        public List<NoteEntry> GetAllNotes()
        {
            return notes;
        }
        public List<NoteEntry> SearchNotes(string content) 
        {
            List<NoteEntry> machingNotes = notes.FindAll(obj =>obj.Name.IndexOf(content, StringComparison.OrdinalIgnoreCase) >= 0 || obj.Text.IndexOf(content, StringComparison.OrdinalIgnoreCase) >= 0);
            return machingNotes;
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
