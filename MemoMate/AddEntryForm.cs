using System.Drawing;
using System;
using System.Threading;
using System.Windows.Forms;

namespace NoteTaker
{
    public partial class AddEntryForm : UserControl
    {
        public AddEntryForm()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Es wird geprüft ob alle eingaben korrekt sind falls nicht wird erneute eingabe aufgefordert
            //Falls doch wird neue Notiz hinzugefügt
            if (topic.Text.Length == 0)
            {
                MessageBox.Show("Bitte Thema eingeben");
            }
            if (note.Text.Length == 0)
            {
                MessageBox.Show("Bitte Notiz eingeben");
            }
            if (topic.Text.Length != 0 && note.Text.Length != 0)
            {
                MessageBox.Show("Neue Notiz wurde hinzugefügt");
                Notes.AddNote(topic.Text, note.Text);
                topic.Text = "";
                note.Text = "";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //Form wird zentriert
            this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Width) / 2, (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2);
            //Ecken werden rund
            Region = System.Drawing.Region.FromHrgn(UUID.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void currentTime_Tick(object sender, EventArgs e)
        {
            currentTimeLabel.Text = (DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + "  " + DateTime.Now.Day + "." + DateTime.Now.Month + "." + DateTime.Now.Year);

        }

        private void note_TextChanged(object sender, EventArgs e)
        {

        }
    }
}