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
    // NewNoteForm.cs
    public partial class NewNoteEntryForm : Form
    {
        public string NoteName { get { return txtNoteName.Text; } }
        public string NoteText { get { return txtNoteText.Text; } }

        public NewNoteEntryForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK; // Set the dialog result to OK to indicate successful data entry
            this.Close(); // Close the form
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }
    }
}
