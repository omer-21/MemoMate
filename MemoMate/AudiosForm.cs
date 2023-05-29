using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Newtonsoft.Json;


namespace NoteTaker
{
    public partial class AudiosForm : UserControl
    {
        private WaveInEvent waveIn;
        private WaveFileWriter writer;
        private WaveOutEvent waveOut;
        private AudioFileReader audioFile;
        private string fileName; // Dosya adını tutmak için değişken
        private bool isRecording = false;
        public static bool home = true;
        private static AudiosForm instance;
        public static AudiosForm Instance
        {
            get
            {
                // Create a new instance if it doesn't exist
                if (instance == null)
                {
                    instance = new AudiosForm();
                }

                // Return the existing instance
                return instance;
            }
        }

        public AudiosForm()
        {
            InitializeComponent();
            waveIn = new WaveInEvent();
            waveIn.DataAvailable += WaveIn_DataAvailable;
            waveIn.RecordingStopped += WaveIn_RecordingStopped;
            waveOut = new WaveOutEvent();
            RecordButton.Text = "Start Record";

            LoadSoundsFromJSON(); // Sesleri JSON dosyasından yükle

        }

        private void RecordButton_Click(object sender, EventArgs e)
        {
            if (!isRecording)
            {
                string fileNameInput = textBox1.Text.Trim(); // TextBox'tan dosya adını alınması ve boşlukların temizlenmesi
                if (string.IsNullOrEmpty(fileNameInput))
                {
                    MessageBox.Show("Dosya adı boş bırakılamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                fileName = textBox1.Text + ".wav"; // TextBox'tan dosya adını alınması ve sonuna ".wav" eklenmesi
                if (waveIn == null)
                {
                    waveIn = new WaveInEvent();
                    waveIn.DataAvailable += WaveIn_DataAvailable;
                    waveIn.RecordingStopped += WaveIn_RecordingStopped;
                }
                waveIn.WaveFormat = new WaveFormat(44100, 16, 1); // Ses formatını ayarlayabilirsiniz (örn: 44100 Hz, 16 bit, 1 kanal)
                writer = new WaveFileWriter(fileName, waveIn.WaveFormat);
                waveIn.StartRecording();
                isRecording = true;
                RecordButton.Text = "Stop Record";
                textBox1.Text = " ";
            }
            else
            {
                waveIn.StopRecording();
                isRecording = false;
                RecordButton.Text = "Start Record";

                if (writer != null)
                {
                    writer.Close();
                    writer.Dispose();
                    writer = null;
                }

                if (waveIn != null)
                {
                    waveIn.Dispose();
                    waveIn = null;
                }
            }
        }

        private void WaveIn_DataAvailable(object sender, WaveInEventArgs e)
        {
            if (writer != null)
            {
                writer.Write(e.Buffer, 0, e.BytesRecorded);
            }
        }

        private void WaveIn_RecordingStopped(object sender, StoppedEventArgs e)
        {
            if (writer != null)
            {
                writer.Close();
                writer.Dispose();
                writer = null;
            }

            if (waveIn != null)
            {
                waveIn.Dispose();
                waveIn = null;
            }

            listBox1.Items.Add(fileName);
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                string selectedFileName = listBox1.SelectedItem.ToString();

                if (waveOut.PlaybackState == PlaybackState.Playing)
                    waveOut.Stop();

                audioFile = new AudioFileReader(selectedFileName);
                waveOut.Init(audioFile);
                waveOut.Play();
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                string selectedFileName = listBox1.SelectedItem.ToString();
                listBox1.Items.Remove(selectedFileName);

                try
                {
                    File.Delete(selectedFileName);

                    if (File.Exists(selectedFileName))
                    {
                        MessageBox.Show("Dosya silinemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        SaveSoundsToJSON(); // Sesleri JSON dosyasına kaydet
                    }
                }
                catch (IOException ex)
                {
                    MessageBox.Show($"Dosya silinirken bir hata oluştu: {ex.Message}");
                }
            }
        }
        private void SaveSoundsToJSON()
        {
            List<string> soundList = new List<string>(listBox1.Items.Cast<string>());
            string json = JsonConvert.SerializeObject(soundList, Formatting.Indented);
            File.WriteAllText("sounds.json", json);
        }

        private void LoadSoundsFromJSON()
        {
            if (File.Exists("sounds.json"))
            {
                string json = File.ReadAllText("sounds.json");
                List<string> soundList = JsonConvert.DeserializeObject<List<string>>(json);
                listBox1.Items.AddRange(soundList.ToArray());
            }
        }
    }
}
