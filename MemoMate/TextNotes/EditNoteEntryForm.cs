using System;
using System.Windows.Forms;

namespace NoteTaker
{
    public partial class EditNoteEntryForm : Form
    {
        public string NoteName { get; set; }
        public string NoteText { get; set; }

        public EditNoteEntryForm(string noteName, string noteText)
        {
            InitializeComponent();
            NoteName = noteName;
            NoteText = noteText;
        }

        private void NoteEditForm_Load(object sender, EventArgs e)
        {
            txtNoteName.Text = NoteName;
            txtNoteText.Text = NoteText;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            NoteName = txtNoteName.Text;
            NoteText = txtNoteText.Text;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
