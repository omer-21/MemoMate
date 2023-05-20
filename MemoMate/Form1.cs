﻿using System;
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
            //textNotesForm = null;
        }

        private void homepageB_Click(object sender, EventArgs e)
        {
            SidePanel.Height = homeButton.Height;
            SidePanel.Top = homeButton.Top;
        }

        private void textNotesB_Click(object sender, EventArgs e)
        {
            SidePanel.Height = textNotsButton.Height;
            SidePanel.Top = textNotsButton.Top;
            active.Visible = true;
            active.Top = textNotsButton.Top;
            IndexForm.home = false;
            IndexForm instance = IndexForm.Instance;
            Loadform(instance);
        }
        private void imagesB_Click(object sender, EventArgs e)
        {
            SidePanel.Height = imagesButton.Height;
            SidePanel.Top = imagesButton.Top;
        }
        private void videosB_Click(object sender, EventArgs e)
        {
            SidePanel.Height = videosButton.Height;
            SidePanel.Top = videosButton.Top;
        }
        private void alarmsB_Click(object sender, EventArgs e)
        {
            SidePanel.Height = alarmsButton.Height;
            SidePanel.Top = alarmsButton.Top;
        }
        private void recycleBinB_Click(object sender, EventArgs e)
        {
            SidePanel.Height = recycleBinButton.Height;
            SidePanel.Top = recycleBinButton.Top;
        }
        private void audiosB_Click(object sender, EventArgs e)
        {
            SidePanel.Height = audiosButton.Height;
            SidePanel.Top = audiosButton.Top;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void SidePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void closeB_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void Loadform(object Form)
        {
            if (this.childPanel.Controls.Count > 0)
                this.childPanel.Controls.RemoveAt(0);
            UserControl f = Form as UserControl;
            //f.TopLevel = false;
            //f.Dock = DockStyle.Fill;
            this.childPanel.Controls.Add(f);
            this.childPanel.Tag = f;
            f.Location = new Point(10,10);
            f.BringToFront();
            //f.Show();
        }

    }
}
