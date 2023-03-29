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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SidePanel.Height = homeButton.Height;
            SidePanel.Top = homeButton.Top;
            homepage.BringToFront();
        }

        private void homepageB_Click(object sender, EventArgs e)
        {
            SidePanel.Height = homeButton.Height;
            SidePanel.Top = homeButton.Top;
            homepage.BringToFront();
        }

        /*private void textNotesB_Click(object sender, EventArgs e)
        {
            SidePanel.Height = textNotsButton.Height;
            SidePanel.Top = textNotsButton.Top;
            textnotes.BringToFront();
        }*/

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void SidePanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
