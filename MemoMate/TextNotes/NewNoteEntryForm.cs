using System;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace NoteTaker
{
    // NewNoteForm.cs
    public partial class NewNoteEntryForm : Form
    {
        public string NoteName { get { return txtNoteName.Text; } }
        public string NoteText { get { return txtNoteText.Text; } }
        public Font SelectedFont { set; get; }
        public Color SelectedColor { set; get; }
        public int SelectedSize { set; get; }
        public NewNoteEntryForm()
        {
            InitializeComponent();
            this.LoadFonts();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (NoteName != "" && NoteText != "")
            {
                this.DialogResult = DialogResult.OK; // Set the dialog result to OK to indicate successful data entry
                this.Close(); // Close the form
            }
            else if (NoteName == "" && NoteText != "")
            {
                MessageBox.Show("Please Input A Name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }
        
        // Event handler for the font selection
        private void cmbFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected font name
            string fontName = cmbFont.SelectedItem.ToString();
            UpdateTextFormatting();
        }

        // Event handler for the color selection
        private void btnColor_Click(object sender, EventArgs e)
        {
            // Show the color picker dialog and update the selected color
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                SelectedColor = colorDialog.Color;
                txtNoteText.ForeColor = colorDialog.Color;
                UpdateTextFormatting();
            }
        }

        // Event handler for the size selection
        private void numSize_ValueChanged(object sender, EventArgs e)
        {
            // Get the selected size
            SelectedSize = (int)numSize.Value;
            UpdateTextFormatting();
        }
        private void UpdateTextFormatting()
        {
            float fontSize = (float)numSize.Value;
            if (fontSize <= 0)
            {
                // Set a default font size if it's invalid
                fontSize = 14;
                numSize.Value = 14;
            }
            FontStyle fontStyle = GetFontStyle();
            SelectedFont = new Font(cmbFont.SelectedItem.ToString(), fontSize, fontStyle);
            txtNoteText.Font = SelectedFont;
        }
        private FontStyle GetFontStyle()
        {
            // Determine the font style based on the selected font name
            FontStyle fontStyle = FontStyle.Regular;
            if (cmbFont.SelectedItem != null && cmbFont.SelectedItem.ToString() == "Bold")
                fontStyle |= FontStyle.Bold;
            if (cmbFont.SelectedItem != null && cmbFont.SelectedItem.ToString() == "Italic")
                fontStyle |= FontStyle.Italic;
            if (cmbFont.SelectedItem != null && cmbFont.SelectedItem.ToString() == "Underline")
                fontStyle |= FontStyle.Underline;
            return fontStyle;
        }
        private void LoadFonts()
        {
            // Get the list of installed fonts
            InstalledFontCollection installedFonts = new InstalledFontCollection();
            FontFamily[] fontFamilies = installedFonts.Families;

            // Add each font name to the cmbFont dropdown
            foreach (FontFamily fontFamily in fontFamilies)
            {
                cmbFont.Items.Add(fontFamily.Name);
            }

            // Select the first font in the list by default
            if (cmbFont.Items.Count > 0)
            {
                cmbFont.SelectedIndex = 0;
            }
            numSize.Value = 14;
        }

    }
}
