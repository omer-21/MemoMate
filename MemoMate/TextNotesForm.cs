using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoteTaker;
namespace NoteTaker
{
    public partial class TextNotesForm : UserControl
    {
        public TextNotesForm()
        {
            InitializeComponent();
        }

        private void TextNotesForm_Load(object sender, EventArgs e)
        {
            RichTextBox richTextBox = new RichTextBox();
            richTextBox.Location = new Point(50,50);
            richTextBox.Width = 400;
            richTextBox.Height= 300;
            richTextBox.ForeColor = Color.DarkRed;
            richTextBox.BackColor= Color.Turquoise;
            richTextBox.Text = "This Is A Textbox!";
            Controls.Add(richTextBox);
        }
    }
}
