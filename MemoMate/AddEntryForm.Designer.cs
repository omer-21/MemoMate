using System.Windows.Forms;

namespace NoteTaker
{
    partial class AddEntryForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AddNote = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Thema = new System.Windows.Forms.Label();
            this.topic = new System.Windows.Forms.TextBox();
            this.note = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.currentTime = new System.Windows.Forms.Timer(this.components);
            this.currentTimeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddNote
            // 
            this.AddNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.AddNote.FlatAppearance.BorderSize = 0;
            this.AddNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddNote.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.AddNote.ForeColor = System.Drawing.Color.White;
            this.AddNote.Location = new System.Drawing.Point(9, 283);
            this.AddNote.Margin = new System.Windows.Forms.Padding(2);
            this.AddNote.Name = "AddNote";
            this.AddNote.Size = new System.Drawing.Size(149, 28);
            this.AddNote.TabIndex = 0;
            this.AddNote.Text = "Add Note";
            this.AddNote.UseVisualStyleBackColor = false;
            this.AddNote.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 170);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // Thema
            // 
            this.Thema.AutoSize = true;
            this.Thema.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.Thema.ForeColor = System.Drawing.Color.White;
            this.Thema.Location = new System.Drawing.Point(7, 15);
            this.Thema.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Thema.Name = "Thema";
            this.Thema.Size = new System.Drawing.Size(47, 19);
            this.Thema.TabIndex = 2;
            this.Thema.Text = "Title:";
            // 
            // topic
            // 
            this.topic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.topic.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.topic.Font = new System.Drawing.Font("Arial", 11F);
            this.topic.ForeColor = System.Drawing.Color.White;
            this.topic.Location = new System.Drawing.Point(9, 33);
            this.topic.MinimumSize = new System.Drawing.Size(0, 29);
            this.topic.Name = "topic";
            this.topic.Size = new System.Drawing.Size(630, 17);
            this.topic.TabIndex = 3;
            // 
            // note
            // 
            this.note.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.note.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.note.Font = new System.Drawing.Font("Arial", 11F);
            this.note.ForeColor = System.Drawing.Color.White;
            this.note.Location = new System.Drawing.Point(20, 81);
            this.note.Margin = new System.Windows.Forms.Padding(2);
            this.note.MinimumSize = new System.Drawing.Size(332, 161);
            this.note.Multiline = true;
            this.note.Name = "note";
            this.note.Size = new System.Drawing.Size(630, 198);
            this.note.TabIndex = 4;
            this.note.TextChanged += new System.EventHandler(this.note_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(7, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Note:";
            // 
            // currentTime
            // 
            this.currentTime.Enabled = true;
            this.currentTime.Tick += new System.EventHandler(this.currentTime_Tick);
            // 
            // currentTimeLabel
            // 
            this.currentTimeLabel.AutoSize = true;
            this.currentTimeLabel.Font = new System.Drawing.Font("Arial", 11F);
            this.currentTimeLabel.ForeColor = System.Drawing.Color.White;
            this.currentTimeLabel.Location = new System.Drawing.Point(498, 6);
            this.currentTimeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.currentTimeLabel.Name = "currentTimeLabel";
            this.currentTimeLabel.Size = new System.Drawing.Size(46, 17);
            this.currentTimeLabel.TabIndex = 6;
            this.currentTimeLabel.Text = "label3";
            // 
            // AddEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Controls.Add(this.currentTimeLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.note);
            this.Controls.Add(this.topic);
            this.Controls.Add(this.Thema);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddNote);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddEntryForm";
            this.Size = new System.Drawing.Size(801, 311);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button AddNote;
        private Label label1;
        private Label Thema;
        private TextBox topic;
        private TextBox note;
        private Label label2;
        private System.Windows.Forms.Timer currentTime;
        private Label currentTimeLabel;
    }
}