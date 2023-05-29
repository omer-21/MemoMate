using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Media;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NoteTaker
{
    public partial class AlarmsForm : UserControl
    {
        private List<System.Windows.Forms.Timer> timers = new List<System.Windows.Forms.Timer>();
        public static bool home = true;
        private static AlarmsForm instance;
        public static AlarmsForm Instance
        {
            get
            {
                // Create a new instance if it doesn't exist
                if (instance == null)
                {
                    instance = new AlarmsForm();
                }

                // Return the existing instance
                return instance;
            }
        }
        public AlarmsForm()
        {
            InitializeComponent();
        }

        // Özel bir veri yapısı oluşturun
        public class Not
        {
            public string Baslik { get; set; }
            public DateTime Tarih { get; set; }
            public string Saat { get; set; }
            public string Metin { get; set; }
        }

        // Notların depolanacağı bir liste oluşturun
        List<Not> notlar = new List<Not>();

        // Seçilen notun indeksini tutmak için değişken
        int seciliNotIndeksi = -1;

        private void Form1_Load(object sender, EventArgs e)
        {
            // Takvim ayarları
            dateTimePicker1.MinDate = DateTime.Today;
            dateTimePicker1.Format = DateTimePickerFormat.Short;

            // ListView ayarları
            listView1.View = View.Details;
            listView1.Columns.Add("Note Name", 130);
            listView1.Columns.Add("Date", 90);
            listView1.Columns.Add("Time", 90);

            // TextBox'ları temizle
            textBoxBaslik.Clear();
            textBoxMetin.Clear();

            buttonGuncelle.Visible = false;
        }

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            string baslik = textBoxBaslik.Text;
            string metin = textBoxMetin.Text;
            DateTime tarih = dateTimePicker1.Value.Date;

            if (int.TryParse(textBoxSaat.Text, out int saat) && int.TryParse(textBoxDakika.Text, out int dakika))
            {
                if (saat >= 0 && saat <= 23 && dakika >= 0 && dakika <= 59)
                {
                    notlar.Add(new Not { Baslik = baslik, Tarih = tarih, Saat = saat.ToString("00") + ":" + dakika.ToString("00"), Metin = metin });

                    string[] row = { baslik, tarih.ToShortDateString(), saat.ToString("00") + ":" + dakika.ToString("00") };
                    ListViewItem item = new ListViewItem(row);
                    listView1.Items.Add(item);
                    textBoxBaslik.Clear();
                    textBoxMetin.Clear();
                    textBoxSaat.Clear();
                    textBoxDakika.Clear();
                    HatirlaticiOlustur(tarih, new TimeSpan(saat, dakika, 0), baslik, metin);



                    MessageBox.Show("Hatırlatıcı oluşturuldu.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Geçersiz saat veya dakika değeri.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Saat ve dakika değeri sayısal olmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedRow = listView1.SelectedItems[0];
                int indeks = listView1.Items.IndexOf(selectedRow);

                notlar.RemoveAt(indeks);
                listView1.Items.Remove(selectedRow);

                // Hatırlatıcıyı durdur
                DurdurHatirlatici(indeks);

                // Seçim sıfırla ve TextBox'ları temizle
                seciliNotIndeksi = -1;
                textBoxBaslik.Clear();
                textBoxMetin.Clear();
                textBoxDakika.Clear();
                textBoxSaat.Clear();
                // Güncelle butonunu gizle
                buttonGuncelle.Visible = false;
                buttonKaydet.Visible = true;
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedRow = listView1.SelectedItems[0];
                seciliNotIndeksi = listView1.Items.IndexOf(selectedRow);

                // Başlık ve metin bilgilerini TextBox'lara aktar
                textBoxBaslik.Text = notlar[seciliNotIndeksi].Baslik;
                textBoxMetin.Text = notlar[seciliNotIndeksi].Metin;

                // Tarih ve saat bilgilerini ayarla
                dateTimePicker1.Value = notlar[seciliNotIndeksi].Tarih;
                string[] saatDakika = notlar[seciliNotIndeksi].Saat.Split(':');
                textBoxSaat.Text= saatDakika[0];
                textBoxDakika.Text = saatDakika[1];

                // Güncelle butonunu göster
                buttonGuncelle.Visible = true;
                buttonKaydet.Visible = false;
            }

        }

        private void buttonGuncelle_Click_1(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                int indeks = selectedItem.Index;

                string yeniBaslik = textBoxBaslik.Text;
                string yeniMetin = textBoxMetin.Text;
                DateTime yeniTarih = dateTimePicker1.Value.Date;
                string yeniSaat = textBoxSaat.Text;
                string yeniDakika = textBoxDakika.Text;

                // Seçili notu güncelle
                notlar[indeks].Baslik = yeniBaslik;
                notlar[indeks].Metin = yeniMetin;
                notlar[indeks].Tarih = yeniTarih;
                notlar[indeks].Saat = yeniSaat + ":" + yeniDakika;

                // ListView'deki ilgili satırı güncelle
                selectedItem.SubItems[0].Text = yeniBaslik;
                selectedItem.SubItems[1].Text = yeniTarih.ToShortDateString();
                selectedItem.SubItems[2].Text = yeniSaat + ":" + yeniDakika;

                MessageBox.Show("Not güncellendi ve hatırlatıcı oluşturuldu", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Seçimi temizle ve TextBox'ları temizle
                listView1.SelectedItems.Clear();
                textBoxBaslik.Clear();
                textBoxMetin.Clear();
                textBoxSaat.Clear();
                textBoxDakika.Clear();

                // Hatırlatıcıyı güncelle
                DurdurHatirlatici(indeks);
                HatirlaticiOlustur(yeniTarih, new TimeSpan(int.Parse(yeniSaat), int.Parse(yeniDakika), 0), yeniBaslik, yeniMetin);


                // Güncelle butonunu gizle
                buttonGuncelle.Visible = false;
                buttonKaydet.Visible = true;
            }
        }

        private void HatirlaticiOlustur(DateTime tarih, TimeSpan saat, string baslik, string mesaj)
        {
            DateTime hatirlaticiTarihi = tarih.Date + saat;

            if (hatirlaticiTarihi > DateTime.Now)
            {
                TimeSpan gecikmeSure = hatirlaticiTarihi - DateTime.Now;

                System.Windows.Forms.Timer hatirlaticiTimer = new System.Windows.Forms.Timer();
                hatirlaticiTimer.Tick += (sender, e) =>
                {
                    SoundPlayer player = new SoundPlayer();
                    player.SoundLocation = @"G:\One Drive\OneDrive\Documents\MemoMate\MemoMate\bildirim_sesi.wav";
                    player.Play();

                    MessageBox.Show(mesaj, baslik, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    hatirlaticiTimer.Stop();
                    hatirlaticiTimer.Dispose();
                    timers.Remove(hatirlaticiTimer);
                };

                hatirlaticiTimer.Interval = (int)gecikmeSure.TotalMilliseconds;
                hatirlaticiTimer.Start();
                timers.Add(hatirlaticiTimer);
            }
        }

        private void DurdurHatirlatici(int indeks)
        {
            if (indeks >= 0 && indeks < timers.Count)
            {
                System.Windows.Forms.Timer hatirlaticiTimer = timers[indeks];
                hatirlaticiTimer.Stop();
                hatirlaticiTimer.Dispose();
                timers.RemoveAt(indeks);
            }
        }
    }
}
