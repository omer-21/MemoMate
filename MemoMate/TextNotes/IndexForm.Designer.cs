using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System;

namespace NoteTaker
{
    partial class IndexForm
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        //[DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        //private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IndexForm));
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.newNoteButton = new System.Windows.Forms.Button();
            this.clearSearchButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblDate = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            this.textBoxSearch.Font = new System.Drawing.Font("Segoe UI Emoji", 12.5F);
            this.textBoxSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxSearch.Location = new System.Drawing.Point(105, 10);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(200, 30);
            this.textBoxSearch.TabIndex = 0;
            this.textBoxSearch.GotFocus += new System.EventHandler(this.txtboxGFocus);
            this.textBoxSearch.LostFocus += new System.EventHandler(this.txtboxLFocus);
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(180)))));
            this.searchButton.FlatAppearance.BorderSize = 0;
            this.searchButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Navy;
            this.searchButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.searchButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.searchButton.ForeColor = System.Drawing.Color.White;
            this.searchButton.Image = ((System.Drawing.Image)(resources.GetObject("searchButton.Image")));
            this.searchButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchButton.Location = new System.Drawing.Point(311, 10);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(102, 30);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "   Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // newNoteButton
            // 
            this.newNoteButton.AutoEllipsis = true;
            this.newNoteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(180)))));
            this.newNoteButton.FlatAppearance.BorderSize = 0;
            this.newNoteButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Navy;
            this.newNoteButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.newNoteButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.newNoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newNoteButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.newNoteButton.ForeColor = System.Drawing.Color.White;
            this.newNoteButton.Image = ((System.Drawing.Image)(resources.GetObject("newNoteButton.Image")));
            this.newNoteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.newNoteButton.Location = new System.Drawing.Point(437, 9);
            this.newNoteButton.Name = "newNoteButton";
            this.newNoteButton.Size = new System.Drawing.Size(117, 32);
            this.newNoteButton.TabIndex = 0;
            this.newNoteButton.Text = "     New Note";
            this.newNoteButton.UseCompatibleTextRendering = true;
            this.newNoteButton.UseVisualStyleBackColor = false;
            this.newNoteButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // clearSearchButton
            // 
            this.clearSearchButton.AutoEllipsis = true;
            this.clearSearchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(180)))));
            this.clearSearchButton.FlatAppearance.BorderSize = 0;
            this.clearSearchButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Navy;
            this.clearSearchButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.clearSearchButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.clearSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearSearchButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.clearSearchButton.ForeColor = System.Drawing.Color.White;
            this.clearSearchButton.Image = ((System.Drawing.Image)(resources.GetObject("clearSearchButton.Image")));
            this.clearSearchButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clearSearchButton.Location = new System.Drawing.Point(21, 10);
            this.clearSearchButton.Name = "clearSearchButton";
            this.clearSearchButton.Size = new System.Drawing.Size(80, 30);
            this.clearSearchButton.TabIndex = 2;
            this.clearSearchButton.Text = "      Clear";
            this.clearSearchButton.UseCompatibleTextRendering = true;
            this.clearSearchButton.UseVisualStyleBackColor = false;
            this.clearSearchButton.Click += new System.EventHandler(this.clrSrchButtonButton_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(16, 70);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(702, 402);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDate.Location = new System.Drawing.Point(568, 18);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(150, 19);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "5/27/2023 9:58:45 PM";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // IndexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.clearSearchButton);
            this.Controls.Add(this.newNoteButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.lblDate);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(0)))), ((int)(((byte)(102)))));
            this.Name = "IndexForm";
            this.Size = new System.Drawing.Size(735, 529);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox textBoxSearch;
        private Button searchButton;
        private Button newNoteButton;
        private Button clearSearchButton;
        private Label lblDate;

        private FlowLayoutPanel flowLayoutPanel1;
        private Timer timer1;
    }
}
