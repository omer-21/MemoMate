using System.Windows.Forms;

namespace NoteTaker
{
    partial class EditEntryForm2
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.topicBox = new System.Windows.Forms.ListBox();
            this.title = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.currentTime = new System.Windows.Forms.Timer(this.components);
            this.currentTimeLabel = new System.Windows.Forms.Label();
            this.noteBox = new System.Windows.Forms.ListBox();
            this.dateBox = new System.Windows.Forms.ListBox();
            this.DeleteNote = new System.Windows.Forms.Button();
            this.ChangeNote = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // topicBox
            // 
            this.topicBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.topicBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.topicBox.Font = new System.Drawing.Font("Arial", 11F);
            this.topicBox.ForeColor = System.Drawing.Color.White;
            this.topicBox.FormattingEnabled = true;
            this.topicBox.ItemHeight = 17;
            this.topicBox.Location = new System.Drawing.Point(17, 33);
            this.topicBox.Margin = new System.Windows.Forms.Padding(2);
            this.topicBox.Name = "topicBox";
            this.topicBox.Size = new System.Drawing.Size(176, 442);
            this.topicBox.TabIndex = 0;
            //this.topicBox.SelectedIndexChanged += new System.EventHandler(this.topicBox_SelectedIndexChanged);
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.title.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.title.Font = new System.Drawing.Font("Arial", 11F);
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(448, 14);
            this.title.Margin = new System.Windows.Forms.Padding(2);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(349, 17);
            this.title.TabIndex = 1;
            //this.title.TextChanged += new System.EventHandler(this.title_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Thema:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(188, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Notiz:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(343, 12);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Datum:";
            // 
            // currentTime
            // 
            this.currentTime.Enabled = true;
            this.currentTime.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // currentTimeLabel
            // 
            this.currentTimeLabel.AutoSize = true;
            this.currentTimeLabel.Font = new System.Drawing.Font("Arial", 11F);
            this.currentTimeLabel.ForeColor = System.Drawing.Color.White;
            this.currentTimeLabel.Location = new System.Drawing.Point(497, 12);
            this.currentTimeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.currentTimeLabel.Name = "currentTimeLabel";
            this.currentTimeLabel.Size = new System.Drawing.Size(46, 17);
            this.currentTimeLabel.TabIndex = 12;
            this.currentTimeLabel.Text = "label6";
            // 
            // noteBox
            // 
            this.noteBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.noteBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.noteBox.Font = new System.Drawing.Font("Arial", 11F);
            this.noteBox.ForeColor = System.Drawing.Color.White;
            this.noteBox.FormattingEnabled = true;
            this.noteBox.ItemHeight = 17;
            this.noteBox.Location = new System.Drawing.Point(192, 33);
            this.noteBox.Margin = new System.Windows.Forms.Padding(2);
            this.noteBox.Name = "noteBox";
            this.noteBox.Size = new System.Drawing.Size(161, 442);
            this.noteBox.TabIndex = 13;
            //this.noteBox.SelectedIndexChanged += new System.EventHandler(this.noteBox_SelectedIndexChanged);
            // 
            // dateBox
            // 
            this.dateBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.dateBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dateBox.Font = new System.Drawing.Font("Arial", 11F);
            this.dateBox.ForeColor = System.Drawing.Color.White;
            this.dateBox.FormattingEnabled = true;
            this.dateBox.ItemHeight = 17;
            this.dateBox.Location = new System.Drawing.Point(347, 33);
            this.dateBox.Margin = new System.Windows.Forms.Padding(2);
            this.dateBox.Name = "dateBox";
            this.dateBox.Size = new System.Drawing.Size(209, 442);
            this.dateBox.TabIndex = 14;
            //this.dateBox.SelectedIndexChanged += new System.EventHandler(this.dateBox_SelectedIndexChanged);
            // 
            // DeleteNote
            // 
            this.DeleteNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.DeleteNote.FlatAppearance.BorderSize = 0;
            this.DeleteNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteNote.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.DeleteNote.ForeColor = System.Drawing.Color.White;
            this.DeleteNote.Location = new System.Drawing.Point(628, 33);
            this.DeleteNote.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteNote.Name = "DeleteNote";
            this.DeleteNote.Size = new System.Drawing.Size(71, 25);
            this.DeleteNote.TabIndex = 4;
            this.DeleteNote.Text = "Delete";
            this.DeleteNote.UseVisualStyleBackColor = false;
            //this.DeleteNote.Click += new System.EventHandler(this.delete_Click);
            // 
            // ChangeNote
            // 
            this.ChangeNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ChangeNote.FlatAppearance.BorderSize = 0;
            this.ChangeNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeNote.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.ChangeNote.ForeColor = System.Drawing.Color.White;
            this.ChangeNote.Location = new System.Drawing.Point(560, 33);
            this.ChangeNote.Margin = new System.Windows.Forms.Padding(2);
            this.ChangeNote.Name = "ChangeNote";
            this.ChangeNote.Size = new System.Drawing.Size(64, 25);
            this.ChangeNote.TabIndex = 3;
            this.ChangeNote.Text = "Edit";
            this.ChangeNote.UseVisualStyleBackColor = false;
            //this.ChangeNote.Click += new System.EventHandler(this.changeNote_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(703, 33);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 25);
            this.button1.TabIndex = 15;
            this.button1.Text = "Set Alarm";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // EditEntryForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateBox);
            this.Controls.Add(this.noteBox);
            this.Controls.Add(this.currentTimeLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeleteNote);
            this.Controls.Add(this.ChangeNote);
            this.Controls.Add(this.title);
            this.Controls.Add(this.topicBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EditEntryForm2";
            this.Size = new System.Drawing.Size(800, 500);
            //this.Load += new System.EventHandler(this.Abrufen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox topicBox;
        private TextBox title;
        private Label label1;
        private Label label2;
        private Label label3;
        private System.Windows.Forms.Timer currentTime;
        private Label currentTimeLabel;
        private ListBox noteBox;
        private ListBox dateBox;
        private Button DeleteNote;
        private Button ChangeNote;
        private Button button1;
    }
}