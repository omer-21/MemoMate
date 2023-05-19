using System.Drawing;
using System;

namespace NoteTaker
{
    partial class NoteEntryControl
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNoteName = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtNote = new System.Windows.Forms.TextBox();
            NoteEntry note = this.Note;
            //NoteEntryControl noteEntryControl = new NoteEntryControl();
            this.SuspendLayout();
            // 
            // lblNoteName
            // 
            this.lblNoteName.AutoSize = true;
            this.lblNoteName.Text = note.Name;
            //this.lblNoteName.Text = note.Name;
            //this.lblNoteName.Text = noteEntryControl.Note.Name;
            this.lblNoteName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblNoteName.Location = new System.Drawing.Point(10, 10);
            this.lblNoteName.Name = "lblNoteName";
            this.lblNoteName.Size = new System.Drawing.Size(0, 21);
            this.lblNoteName.TabIndex = 0;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Text = note.Date.ToShortDateString();
            //this.lblDate.Text = note.Date.ToShortDateString();
            //this.lblDate.Text = noteEntryControl.Note.Date.ToShortDateString();
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDate.Location = new System.Drawing.Point(10, 40);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(0, 15);
            this.lblDate.TabIndex = 1;
            //
            // txtNote
            //
            this.txtNote.Location = new System.Drawing.Point(10, 60);
            this.txtNote.Text = note.Text;
            //this.txtNote.Text = note.Text;
            //this.txtNote.Text = noteEntryControl.Note.Text;
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNote.Size = new System.Drawing.Size(200, 68);
            this.txtNote.TabIndex = 4;
            //this.txtNote.Disposed += new System.EventHandler(this.txtNote_TextChanged);
            this.txtNote.TextChanged += new System.EventHandler(this.txtNote_TextChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(161, 33);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(49, 21);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(106, 33);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(49, 21);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // NoteEntryControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblNoteName);
            this.ForeColor = System.Drawing.Color.DarkBlue;
            this.Name = "NoteEntryControl";
            this.Size = new System.Drawing.Size(218, 142);
            this.Resize += new System.EventHandler(this.NoteEntryControl_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label lblNoteName;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
    }
}

