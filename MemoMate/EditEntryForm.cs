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
    public partial class EditEntryForm : UserControl
    {
        List<Notes> notes = Notes.GetNotes();
        public static bool home = true;
        private int SelectedIndex = 0;
        public EditEntryForm()
        {
            InitializeComponent();
        }
        //Methode die einen zwanzigzeiligen String zurückgibt
        string FirstTwenty(string input)
        {
            try
            {
                return input.Substring(0, 10);
            }
            catch { return input; }
        }
        //Methode die alle Einträge lädt
        private void LoadEntrys()
        {

            topicBox.Items.Clear();
            noteBox.Items.Clear();
            dateBox.Items.Clear();
            notes = Notes.GetNotes();
            for (int i = 0; i < notes.Count; i++)
            {
                string CurNote = FirstTwenty(notes[i].Note);
                string CurTopic = FirstTwenty(notes[i].Topic);
                topicBox.Items.Add(CurTopic);
                noteBox.Items.Add(CurNote/*+ " " + notes[i].UuID*/);
                dateBox.Items.Add(notes[i].Time /*+ " " + notes[i].UuID*/);
            }
            try
            {
                SetIndex();
            }
            catch { }
        }
        private void Abrufen_Load(object sender, EventArgs e)
        {
            //Form wird Zentriert
            this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Width) / 2, (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2);
            if (home)
            {
                //active.Top = 191;
                ChangeNote.Visible = false;
                DeleteNote.Visible = false;
                Note.Size = new Size(581, 466);
                Note.Enabled = false;
                title.Enabled = false;
            }
            else
            {
                Note.Enabled = true;
                title.Enabled = true;
                ChangeNote.Visible = true;
                DeleteNote.Visible = true;
            }

            LoadEntrys();
        }
        //Der gewählte Index wird manipuliert
        private void topicBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedIndex = topicBox.SelectedIndex;
            SetIndex();
            title.Text = notes[SelectedIndex].Topic;
            Note.Text = notes[SelectedIndex].Note.Replace(".", System.Environment.NewLine);
        }

        private void dateBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedIndex = dateBox.SelectedIndex;
            SetIndex();
            title.Text = notes[SelectedIndex].Topic;
            Note.Text = notes[SelectedIndex].Note.Replace(".", System.Environment.NewLine);
        }
        private void noteBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedIndex = noteBox.SelectedIndex;
            SetIndex();
            title.Text = notes[SelectedIndex].Topic;
            Note.Text = notes[SelectedIndex].Note.Replace(".", System.Environment.NewLine);
        }

        private void SetIndex()
        {
            topicBox.SelectedIndex = SelectedIndex;
            noteBox.SelectedIndex = SelectedIndex;
            dateBox.SelectedIndex = SelectedIndex;
        }

        //Es wird geprüft ob alle eingaben korrekt sind falls nicht wird erneute eingabe aufgefordert
        //Falls doch wird die Notiz bearbeitet
        private void changeNote_Click(object sender, EventArgs e)
        {
            if (notes.Count == 0)
            {
                MessageBox.Show("Kein Eintrag vorhanden");
            }
            else if (title.Text.Length == 0)
            {
                MessageBox.Show("Bitte Titel eingeben");
            }
            else if (Note.Text.Length == 0)
            {
                MessageBox.Show("Bitte Notiz eingeben");
            }
            else if (Note.Text.Length != 0 && title.Text.Length != 0)
            {
                Notes.Change(title.Text, Note.Text, topicBox.SelectedIndex);
                MessageBox.Show("Ein Eintrag wurde bearbeitet");
            }
            LoadEntrys();
        }
        //Eine Notiz wird gelöscht falls vorhanden
        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                Notes.Delete(title.Text, Note.Text, topicBox.SelectedIndex);
                LoadEntrys();
                if (notes.Count > 0)
                {
                    MessageBox.Show("Ein Eintrag wurde gelöscht");
                }
                else
                {
                    MessageBox.Show("Kein Eintrag vorhanden");
                }
            }
            catch
            {
                MessageBox.Show("Kein Eintrag vorhanden");
            }

        }



        //Derzeite Uhrzeit wird angezeigt
        private void timer1_Tick(object sender, EventArgs e)
        {
            currentTimeLabel.Text = (DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + "  " + DateTime.Now.Day + "." + DateTime.Now.Month + "." + DateTime.Now.Year);
        }
    }
}