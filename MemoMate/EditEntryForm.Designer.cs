using System.Windows.Forms;

namespace NoteTaker
{
    partial class EditEntryForm
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
            this.Note = new System.Windows.Forms.TextBox();
            this.ChangeNote = new System.Windows.Forms.Button();
            this.DeleteNote = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.currentTime = new System.Windows.Forms.Timer(this.components);
            this.currentTimeLabel = new System.Windows.Forms.Label();
            this.noteBox = new System.Windows.Forms.ListBox();
            this.dateBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // topicBox
            // 
            this.topicBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.topicBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.topicBox.Font = new System.Drawing.Font("Arial", 11F);
            this.topicBox.ForeColor = System.Drawing.Color.White;
            this.topicBox.FormattingEnabled = true;
            this.topicBox.ItemHeight = 17;
            this.topicBox.Location = new System.Drawing.Point(13, 29);
            this.topicBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.topicBox.Name = "topicBox";
            this.topicBox.Size = new System.Drawing.Size(99, 272);
            this.topicBox.TabIndex = 0;
            this.topicBox.SelectedIndexChanged += new System.EventHandler(this.topicBox_SelectedIndexChanged);
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.title.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.title.Font = new System.Drawing.Font("Arial", 11F);
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(330, 29);
            this.title.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(349, 17);
            this.title.TabIndex = 1;
            // 
            // Note
            // 
            this.Note.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.Note.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Note.Font = new System.Drawing.Font("Arial", 11F);
            this.Note.ForeColor = System.Drawing.Color.White;
            this.Note.Location = new System.Drawing.Point(330, 65);
            this.Note.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Note.Multiline = true;
            this.Note.Name = "Note";
            this.Note.Size = new System.Drawing.Size(349, 209);
            this.Note.TabIndex = 2;
            // 
            // ChangeNote
            // 
            this.ChangeNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.ChangeNote.FlatAppearance.BorderSize = 0;
            this.ChangeNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeNote.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.ChangeNote.ForeColor = System.Drawing.Color.White;
            this.ChangeNote.Location = new System.Drawing.Point(330, 277);
            this.ChangeNote.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ChangeNote.Name = "ChangeNote";
            this.ChangeNote.Size = new System.Drawing.Size(103, 25);
            this.ChangeNote.TabIndex = 3;
            this.ChangeNote.Text = "Bearbeiten";
            this.ChangeNote.UseVisualStyleBackColor = false;
            this.ChangeNote.Click += new System.EventHandler(this.changeNote_Click);
            // 
            // DeleteNote
            // 
            this.DeleteNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.DeleteNote.FlatAppearance.BorderSize = 0;
            this.DeleteNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteNote.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.DeleteNote.ForeColor = System.Drawing.Color.White;
            this.DeleteNote.Location = new System.Drawing.Point(436, 277);
            this.DeleteNote.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DeleteNote.Name = "DeleteNote";
            this.DeleteNote.Size = new System.Drawing.Size(103, 25);
            this.DeleteNote.TabIndex = 4;
            this.DeleteNote.Text = "Löschen";
            this.DeleteNote.UseVisualStyleBackColor = false;
            this.DeleteNote.Click += new System.EventHandler(this.delete_Click);
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
            this.label2.Location = new System.Drawing.Point(112, 12);
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
            this.label3.Location = new System.Drawing.Point(196, 12);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Datum:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(330, 12);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Thema:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(330, 44);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Notiz:";
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
            this.noteBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.noteBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.noteBox.Font = new System.Drawing.Font("Arial", 11F);
            this.noteBox.ForeColor = System.Drawing.Color.White;
            this.noteBox.FormattingEnabled = true;
            this.noteBox.ItemHeight = 17;
            this.noteBox.Location = new System.Drawing.Point(107, 29);
            this.noteBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.noteBox.Name = "noteBox";
            this.noteBox.Size = new System.Drawing.Size(91, 272);
            this.noteBox.TabIndex = 13;
            this.noteBox.SelectedIndexChanged += new System.EventHandler(this.noteBox_SelectedIndexChanged);
            // 
            // dateBox
            // 
            this.dateBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.dateBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dateBox.Font = new System.Drawing.Font("Arial", 11F);
            this.dateBox.ForeColor = System.Drawing.Color.White;
            this.dateBox.FormattingEnabled = true;
            this.dateBox.ItemHeight = 17;
            this.dateBox.Location = new System.Drawing.Point(196, 29);
            this.dateBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateBox.Name = "dateBox";
            this.dateBox.Size = new System.Drawing.Size(130, 272);
            this.dateBox.TabIndex = 14;
            this.dateBox.SelectedIndexChanged += new System.EventHandler(this.dateBox_SelectedIndexChanged);
            // 
            // EditEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Controls.Add(this.dateBox);
            this.Controls.Add(this.noteBox);
            this.Controls.Add(this.currentTimeLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeleteNote);
            this.Controls.Add(this.ChangeNote);
            this.Controls.Add(this.Note);
            this.Controls.Add(this.title);
            this.Controls.Add(this.topicBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "EditEntryForm";
            this.Size = new System.Drawing.Size(800, 500);
            this.Load += new System.EventHandler(this.Abrufen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox topicBox;
        private TextBox title;
        private TextBox Note;
        private Button ChangeNote;
        private Button DeleteNote;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private System.Windows.Forms.Timer currentTime;
        private Label currentTimeLabel;
        private ListBox noteBox;
        private ListBox dateBox;
    }
}