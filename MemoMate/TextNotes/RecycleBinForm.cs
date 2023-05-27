using System;
using System.Drawing;
using System.Windows.Forms;

namespace NoteTaker
{
    public partial class RecycleBinForm : UserControl
    {
        private static RecycleBinForm instance;
        private NotesManager notesManager;
        public static bool home = true;
        public string filePath = @"C:\Users\omar\Documents\Notes.json";
        public static RecycleBinForm Instance
        {
            get
            {
                // Create a new instance if it doesn't exist
                if (instance == null)
                {
                    instance = new RecycleBinForm();
                }

                // Return the existing instance
                return instance;
            }
        }
        private RecycleBinForm()
        {
            InitializeComponent();
            notesManager = new NotesManager(filePath);
            DisplayNoteEntries();
            timer1.Start();
        }
        private void DisplayNoteEntries()
        {
            // Clear the note entries panel
            flowLayoutPanel1.Controls.Clear();
            notesManager.LoadNotesFromFile(filePath);
            // Add a NoteEntryControl for each note in noteEntries
            foreach (NoteEntry note in notesManager.GetAllNotes())
            {
                if (note.IsDeleted == true)
                {
                    NoteEntryControl noteEntryControl = new NoteEntryControl(note.Name, note.Date, note.Text, note.Id, note.Font, note.Color,note.IsDeleted);
                    flowLayoutPanel1.Controls.Add(noteEntryControl);
                }
            }
        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            // Custom painting code for the flowLayoutPanel1
            Graphics graphics = e.Graphics;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString();
        }
    }
}