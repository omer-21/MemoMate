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
        //private List<NoteEntry> noteEntries;
        private NotesManager notesManager;
        public static bool home = true;
        public IndexForm()
        {
            InitializeComponent();
            notesManager = new NotesManager();
            // Initialize noteEntries list
            //noteEntries = new List<NoteEntry>();

            // Add some example notes
            /*noteEntries.Add(new NoteEntry { Name = "Note 1", Date = new DateTime(2023, 5, 15), Text = "This is an example of note texts,Example1" });
            noteEntries.Add(new NoteEntry { Name = "Note 2", Date = new DateTime(2023, 5, 16), Text = "This is an example of note texts,Example2(aoiejofjoeijfeoifjeoijfoja;kjmainpaiejfaiojsieojfoaefja)ewfwefwefefwefew" });
            noteEntries.Add(new NoteEntry { Name = "Note 3", Date = new DateTime(2023, 5, 17), Text = "This is an example of note texts,Example3(aoiejofjoeijfeoifjeoijfoja;kjmainpaiejfaiojsieojfoaefja)feeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeefeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeewwwwwwwwwwwww" });
            noteEntries.Add(new NoteEntry { Name = "Note 3", Date = new DateTime(2023, 5, 17), Text = "This is an example of note texts,Example3(aoiejofjoeijfeoifjeoijfoja;kjmainpaiejfaiojsieojfoaefja)feeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeefeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeewwwwwwwwwwwww" });
            noteEntries.Add(new NoteEntry { Name = "Note 3", Date = new DateTime(2023, 5, 17), Text = "This is an example of note texts,Example3(aoiejofjoeijfeoifjeoijfoja;kjmainpaiejfaiojsieojfoaefja)feeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeefeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeewwwwwwwwwwwww" });
            */
            notesManager.AddNote("Note 3", new DateTime(2023, 5, 17), "This is an example of note texts\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\nfeee");

            // Display the notes
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
            notesManager.AddNote("Auto Note Entry",  DateTime.Now,"this is an example of create a new NotEntry");
            DisplayNoteEntries();
            // Save the notes to the file
            notesManager.SaveNotesToFile(@"C:\Users\Omar\Desktop\Notes.json");

        }
        private void SearchNotes(string searchQuery)
        {
            // Clear previous search results
            ClearSearch();

            // Filter notes based on search query
            List<NoteEntry> matchingNotes = new List<NoteEntry>();

            foreach (NoteEntry note in notesManager.GetAllNotes())
            {
                if (note.Name.Contains(searchQuery) || note.Text.Contains(searchQuery))
                {
                    matchingNotes.Add(note);
                }
            }

            // Display only the matching notes
            foreach (NoteEntryControl noteEntry in flowLayoutPanel1.Controls.OfType<NoteEntryControl>())
            {
                if (matchingNotes.Contains(noteEntry.Note))
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

        private void NoteEntryControl_LargeViewRequested(object sender, EventArgs e)
        {
            NoteEntryControl noteEntryControl = (NoteEntryControl)sender;
            string noteText = noteEntryControl.NoteText;

            // Show the larger view of the note using a dialog or any other means
            //LargeNoteViewDialog largeNoteViewDialog = new LargeNoteViewDialog(noteText);
            //largeNoteViewDialog.ShowDialog();
        }

        private void DisplayNoteEntries()
        {
            // Clear the note entries panel
            flowLayoutPanel1.Controls.Clear();
            notesManager.LoadNotesFromFile(@"C:\Users\Omar\Desktop\Notes.json");
            // Add a NoteEntryControl for each note in noteEntries
            foreach (NoteEntry note in notesManager.GetAllNotes())
            {
                NoteEntryControl noteEntryControl = new NoteEntryControl(note);
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
            NoteEntry note = notesManager.GetAllNotes().Find(n => n.Name== noteEntryControl.NoteName && n.Date.ToShortDateString() == noteEntryControl.Date);

            // Open an edit dialog for the note
            //EditEntryForm editNoteDialog = new EditEntryForm(note);
            /*if (editNoteDialog.ShowDialog() == DialogResult.OK)
            {
                // Update the note entry
                note.Name = editNoteDialog.Note.Name;
                note.Date= editNoteDialog.Note.Date;
                note.Text = editNoteDialog.Note.Text;
                // Redisplay the note entries
                DisplayNoteEntries();
            }*/
        }

        private void NoteEntryControl_DeleteButtonClicked(object sender, EventArgs e)
        {
            // Handle delete button click
            NoteEntryControl noteEntryControl = (NoteEntryControl)sender;

            // Find the NoteEntry associated with the clicked NoteEntryControl

            // Remove the note entry
            notesManager.RemoveNote(noteEntryControl.GetId());

            // Redisplay the note entries
            DisplayNoteEntries();
            // Save the notes to the file
            notesManager.SaveNotesToFile(@"C:\Users\Omar\Desktop\Notes.json");
        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            // Custom painting code for the flowLayoutPanel1
            Graphics graphics = e.Graphics;

            // Example: Drawing a border around the panel
            using (Pen pen = new Pen(Color.Red, 2))
            {
                graphics.DrawRectangle(pen, flowLayoutPanel1.ClientRectangle);
            }
        }
    }

}

