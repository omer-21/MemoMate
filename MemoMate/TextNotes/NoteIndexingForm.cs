using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteTaker
{
    public partial class NoteIndexingForm : UserControl
    {
/*        private List<Notes> notes;
        private List<Notes> filteredNotes;

        public NoteIndexingForm()
        {
            InitializeComponent();

            notes = new List<TextNote>();
            filteredNotes = new List<TextNote>();

            LoadNotes();
            UpdateNoteListBox();
        }

        private void LoadNotes()
        {
            // Load notes from file
            string fileName = "notes.txt";

            if (!File.Exists(fileName))
            {
                // Create the file if it doesn't exist
                File.Create(fileName).Dispose();
                return;
            }

            string[] lines = File.ReadAllLines(fileName);

            foreach (string line in lines)
            {
                string[] parts = line.Split('|');

                if (parts.Length == 2)
                {
                    Notes note = new Notes()
                    {
                        Title = parts[0],
                        Content = parts[1]
                    };

                    notes.Add(note);
                }
            }
        }

        private void SaveNotes()
        {
            // Save notes to file
            string fileName = "notes.txt";

            List<string> lines = new List<string>();

            foreach (TextNote note in notes)
            {
                lines.Add($"{note.Title}|{note.Content}");
            }

            File.WriteAllLines(fileName, lines);
        }

        private void UpdateNoteListBox()
        {
            // Update note list box with filtered notes
            //noteListBox.Items.Clear();

            foreach (TextNote note in filteredNotes)
            {
                noteListBox.Items.Add(note.Title);
            }

            if (noteListBox.Items.Count > 0)
            {
                noteListBox.SelectedIndex = 0;
            }
        }

        private void UpdateNoteForm()
        {
            // Update note form with selected note
            if (noteListBox.SelectedIndex != -1)
            {
                TextNote note = filteredNotes[noteListBox.SelectedIndex];
                titleTextBox.Text = note.Title;
                contentRichTextBox.Text = note.Content;
            }
            else
            {
                titleTextBox.Text = "";
                contentRichTextBox.Text = "";
            }
        }

        private void FilterNotes(string filterText)
        {
            // Filter notes by title
            filteredNotes = notes.Where(n => n.Title.ToLower().Contains(filterText.ToLower())).ToList();
            UpdateNoteListBox();
        }

        private void noteListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Update note form when selected note changes
            UpdateNoteForm();
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            // Filter notes by title when filter button is clicked
            string filterText = filterTextBox.Text;
            FilterNotes(filterText);
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            // Clear filter and update note list box
            filterTextBox.Text = "";
            filteredNotes = notes;
            UpdateNoteListBox();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            // Save changes to selected note and update note list box
            if (noteListBox.SelectedIndex != -1)
            {
                TextNote note = filteredNotes[noteListBox.SelectedIndex];
                note.Title = titleTextBox.Text;
                note.Content = contentRichTextBox.Text;
                SaveNotes();
                UpdateNoteListBox();
            }
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            // Create new note and add to notes list and update note list box
            TextNote note = new TextNote();
            notes.Add(note);
            filteredNotes.Add(note);

            noteListBox.Items.Add(note.Title);
            noteListBox.SelectedIndex = noteListBox.Items.Count - 1;

            titleTextBox.Text = note.Title;
            contentRichTextBox.Text = note.Content;

            SaveNotes();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            // Delete selected note and update note list box
            if (noteListBox.SelectedIndex != -1)
            {
                TextNote note = filteredNotes[noteListBox.SelectedIndex];
                notes.Remove(note);
                filteredNotes.Remove(note);

                noteListBox.Items.Remove(note.Title);

                titleTextBox.Text = "";
                contentRichTextBox.Text = "";

                SaveNotes();
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            // Search notes by content
            string searchText = searchTextBox.Text;
            List<TextNote> searchResults = new List<TextNote>();

            foreach (TextNote note in notes)
            {
                if (note.Content.ToLower().Contains(searchText.ToLower()))
                {
                    searchResults.Add(note);
                }
            }

            filteredNotes = searchResults;
            UpdateNoteListBox();
        }
*/    }
}