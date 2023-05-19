using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NoteTaker
{
    public partial class NoteEntryControl : UserControl
    {
        public event EventHandler EditButtonClicked;
        public event EventHandler DeleteButtonClicked;
        public event EventHandler LargeViewRequested;

        public NoteEntry Note;
        public NoteEntryControl(NoteEntry note)
        {
            this.Note = note;
            this.NoteName = this.Note.Name;
            this.Date = this.Note.Date.ToShortDateString();
            this.NoteText = this.Note.Text;

            //this.lblNoteName.Text = this.Note.Name == null ?  "": this.Note.Name;
            //this.lblDate.Text = this.Note.Date == null ? "":this.Note.Date.ToShortTimeString();
            //this.txtNote.Text = this.Note.Text== null ? "":this.Note.Text ;
            InitializeComponent();
        }
        public NoteEntryControl()
        {
            InitializeComponent();
        }
        public string NoteName
        {
            get { return this.Note.Name; }
            set { this.Note.Name= value; }
        }

        public string Date
        {
            get { return this.Note.Date.ToShortDateString(); }
            set { this.Note.Date = ConvertStringToDate(value); }
        }

        public string NoteText
        {
            get { return this.Note.Text; }
            set { Note.Text = value; }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Raise the EditButtonClicked event
            //EditButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Raise the DeleteButtonClicked event
            DeleteButtonClicked?.Invoke(this, EventArgs.Empty);

        }
        private void NoteEntryControl_Resize(object sender, EventArgs e)
        {
            txtNote.Height = this.Height + 10; // Adjust the padding
        }
        private void txtNote_TextChanged(object sender, EventArgs e)
        {
            AdjustTextBoxHeight();
        }
        private void AdjustTextBoxHeight()
        {
            txtNote.Height = txtNote.GetPreferredSize(new Size(txtNote.Width, int.MaxValue)).Height;
            //txtNote.Height = txtNote.GetPreferredSize(new Size(txtNote.Width, 0)).Height;
            int newHeight = txtNote.Height + 80; // Adjust the additional padding
            this.Height = Math.Max(newHeight, 120); // Set a minimum height for the control
        }
        private DateTime ConvertStringToDate(string dateString)
        {
            DateTime result;

            if (DateTime.TryParse(dateString, out result))
            {
                return result;
            }

            // If the string date cannot be parsed, you can handle the error or return a default value
            throw new ArgumentException("Invalid date format.");
        }
    }
}
