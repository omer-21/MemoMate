using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteTaker
{
    public partial class Form1 : Form
    {
        private Form frm2;
        private PictureBox pictureBox1;
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
        //Screenshot codes:
        //{
        private void imagesB_Click(object sender, EventArgs e)
        {
            SidePanel.Height = imagesButton.Height;
            SidePanel.Top = imagesButton.Top;
            this.Hide();
            if (frm2 == null)
            {
                frm2 = CreateScreenshotForm();
                pictureBox1 = CreatePictureBox();
                Button btn = CreateCaptureButton();
                frm2.Controls.Add(btn);
                frm2.Controls.Add(pictureBox1);
            }
            frm2.Show();
        }
        private Form CreateScreenshotForm()
        {
            Form form = new Form();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Size = new Size(702, 453);
            return form;
        }
        private PictureBox CreatePictureBox()
        {
            PictureBox pictureBox = new PictureBox();
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.Size = new Size(660, 315);
            return pictureBox;
        }
        private Button CreateCaptureButton()
        {
            Button btn = new Button();
            btn.Location = new Point(538, 353);
            btn.Size = new Size(120, 41);
            btn.FlatStyle = FlatStyle.Flat;
            btn.Cursor = Cursors.Hand;
            btn.Text = "Capture";
            btn.Click += Capture_click;
            return btn;
        }
        private async void Capture_click(object sender, EventArgs e)
        {
            this.Hide();
            frm2.Hide();
            await Task.Delay(1000);
            using (Bitmap screenshot = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height))
            {
                using (Graphics graphics = Graphics.FromImage(screenshot))
                {
                    graphics.CopyFromScreen(0, 0, 0, 0, screenshot.Size);
                }
                pictureBox1.Image = screenshot;
                frm2.Show();
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "PNG Image|*.png";
                    saveFileDialog.Title = "Save Screenshot";
                    saveFileDialog.InitialDirectory = @"C:\Your\Specific\Folder\"; // Set the specific folder path here
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = saveFileDialog.FileName;
                        // Save the screenshot as PNG
                        screenshot.Save(filePath, ImageFormat.Png);
                        MessageBox.Show("Screenshot saved successfully!", "Screenshot App", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            this.Show();
        }
        //
        //}
        private void videosB_Click(object sender, EventArgs e)
        {
            SidePanel.Height = videosButton.Height;
            SidePanel.Top = videosButton.Top;
        }
        private void alarmsB_Click(object sender, EventArgs e)
        {
            SidePanel.Height = alarmsButton.Height;
            SidePanel.Top = alarmsButton.Top;
            active.Visible = true;
            active.Top = alarmsButton.Top;
            AlarmsForm.home = false;
            AlarmsForm instance = AlarmsForm.Instance;
            Loadform(instance);
        }
        private void recycleBinB_Click(object sender, EventArgs e)
        {
            SidePanel.Height = recycleBinButton.Height;
            SidePanel.Top = recycleBinButton.Top;
            active.Visible = true;
            active.Top = recycleBinButton.Top;
            RecycleBinForm.home = false;
            RecycleBinForm instance = RecycleBinForm.Instance;
            Loadform(instance);
        }
        private void audiosB_Click(object sender, EventArgs e)
        {
            SidePanel.Height = audiosButton.Height;
            SidePanel.Top = audiosButton.Top;
            active.Visible = true;
            active.Top = audiosButton.Top;
            AudiosForm.home = false;
            AudiosForm instance = AudiosForm.Instance;
            Loadform(instance);
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
            f.Location = new Point(10, 10);
            f.BringToFront();
            //f.Show();
        }
    }
}
