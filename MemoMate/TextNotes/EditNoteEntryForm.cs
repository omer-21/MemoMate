using System;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace NoteTaker
{
    public partial class EditNoteEntryForm : Form
    {
        public string NoteName { get; set; }
        public string NoteText { get; set; }
        public Font SelectedFont { get; set; }
        public Color SelectedColor { get; set; }
        public int SelectedSize { get; set; }

        public EditNoteEntryForm(string noteName, string noteText,Font font,Color color)
        {
            InitializeComponent();
            NoteName = noteName;
            NoteText = noteText;
            SelectedFont = new Font(font.FontFamily, font.Size, font.Style); // Create a new Font instance
            SelectedColor= color;
            txtNoteName.Text = NoteName;
            txtNoteText.Text = NoteText;
            txtNoteText.Font = SelectedFont;
            txtNoteText.ForeColor = SelectedColor;
            this.LoadFonts();
        }
        private void NoteEditForm_Load(object sender, EventArgs e)
        {
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (NoteName != "" && NoteText != "")
            {
                NoteName = txtNoteName.Text;
                NoteText = txtNoteText.Text;
                DialogResult = DialogResult.OK;
                Close();
            }
            else if (NoteName == "" && NoteText != "")
            {
                MessageBox.Show("Please Input A Name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
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

        private void txtNoteText_TextChanged(object sender, EventArgs e)
        {

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
        }
    }
}
