using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteTaker
{
    public class Notes
    {
        protected string note;
        protected string topic;
        protected string uuid;
        protected string time;

        public string Note { get => note; set => note = value; }
        public string Topic { get => topic; set => topic = value; }
        public string UuID { get => uuid; set => uuid = value; }
        public string Time { get => time; set => time = value; }

        // Konstruktor, Methode die bei jeder Instanzierung vom Objekt Notes ausgeführt wird
        Notes(string topic, string note, string uuid, string time)
        {
            this.note = note;
            this.topic = topic;
            this.uuid = uuid;
            this.time = time;
        }

        // Durch diese Methode werden die Objekte gespeichert
        public static void AddNote(string topic, string note)
        {
            using (StreamWriter sw = File.AppendText(System.IO.Directory.GetCurrentDirectory()
            + "/../../../Database/note.txt"))
            {
                note = note.Replace(System.Environment.NewLine, ".");
                //MessageBox.Show(note);
                sw.WriteLine(UUID.GenerateUniqueID() + ";" + topic + ";" + note + ";" + (DateTime.Now.Hour + "." + DateTime.Now.Minute + "." + DateTime.Now.Second + "  " + DateTime.Now.Day + "." + DateTime.Now.Month + "." + DateTime.Now.Year) + ";");

            }
        }
        // Durch diese Methode werden die Objekte aus der Datei gelesen, instanziert
        public static List<Notes> GetNotes()
        {
            List<Notes> notes = new List<Notes>();
            using (StreamReader sr = new StreamReader(System.IO.Directory.GetCurrentDirectory()
            + "/../../../Database/note.txt"))
            {
                // Read and display lines from the file until the end of
                // the file is reached.
                while (!sr.EndOfStream)
                {

                    string[] zeile = sr.ReadLine().Split(';');
                    Notes premature = new Notes(zeile[1], zeile[2], zeile[0], zeile[3]);
                    notes.Add(premature);
                }

            }
            return notes;
        }
        // Diese Methode ändert einen bestimmten eintrag
        // Alle vorhandenen Einträge werden zwischengespeichert
        // Die Datei wird geleert
        // Alls Objekte werden gespeichert mit änderung
        public static void Change(string title, string note, int id, bool delete = false)
        {
            List<Notes> notes = Notes.GetNotes();
            using (StreamWriter writer = new StreamWriter(System.IO.Directory.GetCurrentDirectory()
            + "/../../../Database/note.txt"))
            {
                writer.Write(String.Empty);
                writer.Close();
            }
            using (StreamWriter sw = new StreamWriter(System.IO.Directory.GetCurrentDirectory()
          + "/../../../Database/note.txt"))
            {
                for (int index = 0; index < notes.Count; index++)
                {
                    if (index == id)
                    {
                        if (!delete)
                        {
                            note = note.Replace(System.Environment.NewLine, ".");
                            sw.WriteLine(UUID.GenerateUniqueID() + ";" + title + ";" + note + ";" + (DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + "  " + DateTime.Now.Day + "." + DateTime.Now.Month + "." + DateTime.Now.Year) + ";");
                        }
                    }
                    else
                    {
                        note = note.Replace(System.Environment.NewLine, ".");
                        sw.WriteLine(notes[index].uuid + ";" + notes[index].topic + ";" + notes[index].note + ";" + notes[index].time + ";");
                    }
                }
            }
        }
        // Ruft die Change Methode auf nur wird das zu löschende Objekt nicht gespeichert
        public static void Delete(string title, string note, int id)
        {

            Change(title, note, id, true);
        }

    }
}
