using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteTaker
{
    public partial class IndexForm : UserControl
    {
        private static IndexForm instance;
        private NotesManager notesManager;

        public static bool home = true;
        public string filePath = @"C:\Users\default\Documents\Notes.json";
        public static IndexForm Instance
        {
            get
            {
                // Create a new instance if it doesn't exist
                if (instance == null)
                {
                    instance = new IndexForm();
                }

                // Return the existing instance
                return instance;
            }
        }
        private IndexForm()
        {
            InitializeComponent();
            notesManager = new NotesManager(filePath);
            DisplayNoteEntries();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string searchQuery = textBoxSearch.Text.Trim();

            // Perform the search and update the display
            SearchNotes(searchQuery);
        }
        private void clrSrchButtonButton_Click(object sender,EventArgs e)
        {
            textBoxSearch.Text = string.Empty;

            // Clear the search and display all notes
            ClearSearch();
        }
        private void newButton_Click(object sender, EventArgs e)
        {
            // Show the NewNoteForm as a dialog
            using (NewNoteEntryForm newNoteForm = new NewNoteEntryForm())
            {
                if (newNoteForm.ShowDialog() == DialogResult.OK)
                {
                    // Retrieve the entered values from the NewNoteForm
                    string noteName = newNoteForm.NoteName;
                    string noteText = newNoteForm.NoteText;
                    Font font = newNoteForm.SelectedFont;
                    Color color = newNoteForm.SelectedColor;
                    int size = newNoteForm.SelectedSize;
                    notesManager.AddNote(noteName, DateTime.Now,noteText,font, color,size);
                    // Save the notes to the file
                    notesManager.SaveNotesToFile(filePath);
                }
            }
            DisplayNoteEntries();
        }
        private void SearchNotes(string searchQuery)
        {
            // Clear previous search results
            ClearSearch();

            // Filter notes based on search query
            List<NoteEntry> matchingNotes = notesManager.SearchNotes(searchQuery);

            // Display only the matching notes
            foreach (NoteEntryControl noteEntry in flowLayoutPanel1.Controls.OfType<NoteEntryControl>())
            {
                if (matchingNotes.Find(obj=>obj.Id==noteEntry.GetId())!=null)
                {
                    noteEntry.Visible = true;
                }
                else
                {
                    noteEntry.Visible = false;
                }
            }
        }

        private void ClearSearch()
        {
            // Show all notes
            foreach (NoteEntryControl noteEntry in flowLayoutPanel1.Controls.OfType<NoteEntryControl>())
            {
                noteEntry.Visible = true;
            }
        }
        private void DisplayNoteEntries()
        {
            // Clear the note entries panel
            flowLayoutPanel1.Controls.Clear();
            notesManager.LoadNotesFromFile(filePath);
            // Add a NoteEntryControl for each note in noteEntries
            foreach (NoteEntry note in notesManager.GetAllNotes())
            {
                NoteEntryControl noteEntryControl = new NoteEntryControl(note.Name, note.Date, note.Text, note.Id,note.Font,note.Color);
                noteEntryControl.EditButtonClicked += NoteEntryControl_EditButtonClicked;
                noteEntryControl.DeleteButtonClicked += NoteEntryControl_DeleteButtonClicked;
                flowLayoutPanel1.Controls.Add(noteEntryControl);
            }
        }

        private void NoteEntryControl_EditButtonClicked(object sender, EventArgs e)
        {
            // Handle edit button click
            NoteEntryControl noteEntryControl = (NoteEntryControl)sender;

            // Find the NoteEntry associated with the clicked NoteEntryControl
            NoteEntry note = notesManager.GetAllNotes().Find(n => n.Name== noteEntryControl.GetName() && n.Date.ToShortDateString() == noteEntryControl.GetDate()&&n.Text==noteEntryControl.GetText()&&n.Id==noteEntryControl.GetId());
            int noteId=note.Id;

            // Open an edit dialog for the note
            //EditEntryForm editNoteDialog = new EditEntryForm(note);
            if (note != null)
            {
                // Create an instance of NoteEditForm and pass the existing note details
                EditNoteEntryForm editForm = new EditNoteEntryForm(note.Name, note.Text,note.Font,note.Color);

                // Display the edit form and check the result
                DialogResult result = editForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    notesManager.EditNote(noteId,editForm.NoteName, editForm.NoteText, editForm.SelectedFont,editForm.SelectedColor,editForm.SelectedSize);
                }
            }
            notesManager.SaveNotesToFile(filePath);
            DisplayNoteEntries();
        }

        private void NoteEntryControl_DeleteButtonClicked(object sender, EventArgs e)
        {
            // Handle delete button click
            NoteEntryControl noteEntryControl = (NoteEntryControl)sender;
            // Remove the note entry
            notesManager.RemoveNote(noteEntryControl.GetId());
            // Save the notes to the file
            notesManager.SaveNotesToFile(filePath);
            // Redisplay the note entries
            DisplayNoteEntries();
        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            // Custom painting code for the flowLayoutPanel1
            Graphics graphics = e.Graphics;
        }
    }

}