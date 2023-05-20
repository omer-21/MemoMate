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
        private int Id;
        private static int counter=0;
        //public NoteEntry Note;
        public NoteEntryControl(string noteName,DateTime date,string noteText,int Id)
        {
            InitializeComponent();
            this.lblNoteName.Text= noteName;
            this.lblDate.Text = date.ToShortDateString();
            this.txtNote.Text= noteText;
            this.Id=Id;
            counter++;
        }
        public int GetId()
        {
            return Id;
        }
        public string GetText()
        {
            return txtNote.Text;
        }
        public string GetName()
        {
            return lblNoteName.Text;
        }
        public string GetDate()
        {
            return lblDate.Text;
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Raise the EditButtonClicked event
            EditButtonClicked?.Invoke(this, EventArgs.Empty);
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Raise the DeleteButtonClicked event
            DeleteButtonClicked?.Invoke(this, EventArgs.Empty);
        }
        public string GetNoteName()
        {
            return lblNoteName.Text;
        }
    }
}
