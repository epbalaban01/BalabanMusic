using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.ComponentModel.Composition;

namespace Balaban_Müzik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MP3Player pl = new MP3Player();
        OpenFileDialog openFileDialog1 = new OpenFileDialog();
        bool muziklerYuklendi = false, muzik_Caliyor = false, Karistir = false, Tekrarla = false;
        List<string> OynatmaListesi = new List<string>();
        int MuzikDegisti = 0;
    

        private void Form1_Load(object sender, EventArgs e)
        {

            tck_muzik_durum.MouseWheel += new MouseEventHandler(this.Tck_muzik_durum_MouseWheel);
        }


        private void Tck_muzik_durum_MouseWheel(object sender, MouseEventArgs e)
        {
            IleriGeriSar();
        }



        private void btn_Muzik_sec_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Medya Dosyası(*.mpg,*.dat,*.avi,*.wmv,*.wav,*.mp3)|*.wav;*.mp3;*.mpg;*.dat;*.avi;*.wmv";
            openFileDialog1.Multiselect = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < openFileDialog1.FileNames.Count(); i++)
                {
                    list_Muzik_Liste.Items.Add(openFileDialog1.SafeFileNames[i]);
                    OynatmaListesi.Add(openFileDialog1.FileNames[i]);
                }
                btn_muzik_oynat.Enabled = true;
                btn_muzik_durdur.Enabled = true;
                btn_duraklat.Enabled = true;
                muziklerYuklendi = true;
                btn_sonraki.Enabled = true;
                btn_onceki.Enabled = true;
                btn_rastgele.Enabled = true;
                spotify_button.Enabled = true;
                youtube_button.Enabled = true;
            }

        }

        private void btn_liste_temizle_Click(object sender, EventArgs e)
        {
            list_Muzik_Liste.Items.Clear();
            OynatmaListesi.Clear();
            pl.mp3_Kapat();
            if (MessageBox.Show("Mevcut listeler temizlendi. Yeni liste oluşturmak ister misiniz?", "Yeni Liste", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                btn_Muzik_sec.PerformClick();
            }
        }

        private void btn_muzik_oynat_Click(object sender, EventArgs e)
        {
            muzikDegistirTemizle();

            
            if (pl.muzikDuraklatildi == true)
            {
                pl.mp3_Oynat(Tekrarla);
                pl.muzikDuraklatildi = false;
            }
            else
            {
                if (muzik_Caliyor)
                {
                    pl.mp3_Kapat();
                    muzik_Caliyor = false;
                }
                if (list_Muzik_Liste.SelectedIndex < 0)
                    list_Muzik_Liste.SelectedIndex = 0;



                pl.mp3_Ac(OynatmaListesi[list_Muzik_Liste.SelectedIndex].ToString());
                pl.mp3_Oynat(Tekrarla);
                muzik_Caliyor = true;

                grp_muzik.Text = "Çalan Müzik : " + list_Muzik_Liste.SelectedItem.ToString();
                pl.ToplamSure();
                lbl_toplam_sn.Text = pl._st_ToplamSure.ToString();
                tck_muzik_durum.Maximum = pl._sn_ToplamSure;

                this.Text = "Çalan Müzik : ... " + list_Muzik_Liste.SelectedItem.ToString();
            }
            MuzikDegisti = 0;
        }

        private void btn_duraklat_Click(object sender, EventArgs e)
        {
           

            pl.mp3_Duraklat();
            pl.muzikDuraklatildi = true;
        }

        private void btn_muzik_durdur_Click(object sender, EventArgs e)
        {
            pl.mp3_Kapat();
            list_Muzik_Liste.SelectedIndex = 0;
            muzikDegistirTemizle();
        }

        private void btn_sonraki_Click(object sender, EventArgs e)
        {
            muzikDegistirTemizle();
            pl.mp3_Kapat();
            if (Karistir)
            {
                Karisik_Oynat();
            }
            else
            {
                try
                {
                    list_Muzik_Liste.SelectedIndex += 1;
                    pl.mp3_Ac(OynatmaListesi[list_Muzik_Liste.SelectedIndex].ToString());
                    grp_muzik.Text = "Çalan Müzik : ... " + list_Muzik_Liste.SelectedItem.ToString();
                }
                catch (ArgumentOutOfRangeException)
                {
                    MessageBox.Show("Müzik Listesinin Sonu");
                }
            }
            pl.mp3_Oynat(Tekrarla);
            pl.ToplamSure();
            lbl_toplam_sn.Text = pl._st_ToplamSure.ToString();
            tck_muzik_durum.Maximum = pl._sn_ToplamSure;
        }

        private void btn_onceki_Click(object sender, EventArgs e)
        {
            muzikDegistirTemizle();
            pl.mp3_Kapat();

            if (Karistir)
            {
                Karisik_Oynat();
            }
            else
            {
                try
                {
                    list_Muzik_Liste.SelectedIndex -= 1;
                    pl.mp3_Ac(OynatmaListesi[list_Muzik_Liste.SelectedIndex].ToString());
                    grp_muzik.Text = "Çalan Müzik : ... " + list_Muzik_Liste.SelectedItem.ToString();
                }
                catch (NullReferenceException)
                {
                    MessageBox.Show("Müzik Listesinin Başı");
                }
            }

            pl.mp3_Oynat(Tekrarla);
            pl.ToplamSure();
            lbl_toplam_sn.Text = pl._st_ToplamSure.ToString();
            tck_muzik_durum.Maximum = pl._sn_ToplamSure;
        }

        private void list_Muzik_Liste_SelectedIndexChanged(object sender, EventArgs e)
        {
            muzikDegistirTemizle();
            try
            {
                grp_muzik.Text = "Çalan Müzik : ... " + list_Muzik_Liste.SelectedItem.ToString();
                btn_muzik_oynat.PerformClick();
            }
            catch (NullReferenceException)
            {
            }
        }

        private void list_Muzik_Liste_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (list_Muzik_Liste.SelectedIndex >= 0)
                if (muziklerYuklendi)
                    if (pl.muzikDuraklatildi == true)
                    {
                        pl.mp3_Oynat(Tekrarla);
                        pl.muzikDuraklatildi = false;
                    }
                    else
                        btn_muzik_oynat.PerformClick();
        }

        private void tck_ana_ses_Scroll(object sender, EventArgs e)
        {
            pl.AnaSes = tck_ana_ses.Value;
        }

        private void tck_sol_ses_Scroll(object sender, EventArgs e)
        {
            pl.SolSes = tck_sol_ses.Value;
        }

        private void tck_sag_ses_Scroll(object sender, EventArgs e)
        {
            pl.SagSes = tck_sag_ses.Value;
        }

        private void tck_bas_Scroll(object sender, EventArgs e)
        {
            pl.Bass = tck_bas.Value;
        }

        private void tck_tiz_Scroll(object sender, EventArgs e)
        {
            pl.Tiz = tck_tiz.Value;
        }

        private void tck_muzik_durum_Scroll(object sender, EventArgs e)
        {
            IleriGeriSar();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (chk_tekrarla.CheckState == CheckState.Checked)
                Tekrarla = true;
            else
                Tekrarla = false;

            if (chk_karistir.CheckState == CheckState.Checked)
                Karistir = true;
            else
                Karistir = false;




            if (muzik_Caliyor)
            {
                if (list_Muzik_Liste.Items.Count > 0)
                {
                    if (muziklerYuklendi & muzik_Caliyor)
                    {
                        pl.Pozisyon();
                        lbl_pozisyon_sn.Text = pl._st_Pozisyon.ToString();
                        tck_muzik_durum.Value = pl._sn_Pozisyon;
                        OtoMuzikDegistir();
                    }
                }
            }
        }

        private void OtoMuzikDegistir()
        {
            if (pl._sn_Pozisyon == pl._sn_ToplamSure & MuzikDegisti == 0 & Tekrarla == false)
            {
                try
                {
                    if (Karistir)
                    {
                        Karisik_Oynat();
                    }
                    else
                    {
                        list_Muzik_Liste.SelectedIndex += 1;
                    }
                    MuzikDegisti = 1;
                    btn_muzik_oynat.PerformClick();
                }
                catch (ArgumentOutOfRangeException) { }
            }
        }


        private void muzikDegistirTemizle()
        {
            grp_muzik.Text = "Çalan Müzik : ... ";
            lbl_pozisyon_sn.Text = "00:00:00";
            lbl_toplam_sn.Text = "00:00:00";
            tck_muzik_durum.Value = 0;
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i = list_Muzik_Liste.SelectedIndex;
            list_Muzik_Liste.Items.RemoveAt(i);
            OynatmaListesi.RemoveAt(i);
            list_Muzik_Liste.Refresh();
            if (muzik_Caliyor == true)
            {
                pl.mp3_Kapat();
                MessageBox.Show("Müzik silindi. Şarkıya devam..");

                muzikDegistirTemizle();
                muzik_Caliyor = false;
            }
        }

        private void btn_rastgele_Click(object sender, EventArgs e)
        {
            Karisik_Oynat();
        }

        private void seçeneklerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            


            secenekler settingsForm = new secenekler();
            if (settingsForm.ShowDialog() == DialogResult.OK)
            {
                // TODO: reopen WaveOut device
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.MediaStop) //anahtar tuşu belirliyoruz
            {

                pl.mp3_Duraklat();
                pl.muzikDuraklatildi = true;
            }

            if (e.KeyData == Keys.MediaPlayPause) //anahtar tuşu belirliyoruz
            {
                muzikDegistirTemizle();


                if (pl.muzikDuraklatildi == true)
                {
                    pl.mp3_Oynat(Tekrarla);
                    pl.muzikDuraklatildi = false;
                }
                else
                {
                    if (muzik_Caliyor)
                    {
                        pl.mp3_Kapat();
                        muzik_Caliyor = false;
                    }
                    if (list_Muzik_Liste.SelectedIndex < 0)
                        list_Muzik_Liste.SelectedIndex = 0;



                    pl.mp3_Ac(OynatmaListesi[list_Muzik_Liste.SelectedIndex].ToString());
                    pl.mp3_Oynat(Tekrarla);
                    muzik_Caliyor = true;

                    grp_muzik.Text = "Çalan Müzik : " + list_Muzik_Liste.SelectedItem.ToString();
                    pl.ToplamSure();
                    lbl_toplam_sn.Text = pl._st_ToplamSure.ToString();
                    tck_muzik_durum.Maximum = pl._sn_ToplamSure;

                    this.Text = "Çalan Müzik : ... " + list_Muzik_Liste.SelectedItem.ToString();
                }
                MuzikDegisti = 0;
   
            }

            if (e.KeyData == Keys.MediaNextTrack) //anahtar tuşu belirliyoruz
            {
                muzikDegistirTemizle();
                pl.mp3_Kapat();
                if (Karistir)
                {
                    Karisik_Oynat();
                }
                else
                {
                    try
                    {
                        list_Muzik_Liste.SelectedIndex += 1;
                        pl.mp3_Ac(OynatmaListesi[list_Muzik_Liste.SelectedIndex].ToString());
                        grp_muzik.Text = "Çalan Müzik : ... " + list_Muzik_Liste.SelectedItem.ToString();
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        MessageBox.Show("Müzik Listesinin Sonu");
                    }
                }
                pl.mp3_Oynat(Tekrarla);
                pl.ToplamSure();
                lbl_toplam_sn.Text = pl._st_ToplamSure.ToString();
                tck_muzik_durum.Maximum = pl._sn_ToplamSure;

            }


            if (e.KeyData == Keys.MediaPreviousTrack) //anahtar tuşu belirliyoruz
            {

                muzikDegistirTemizle();
                pl.mp3_Kapat();

                if (Karistir)
                {
                    Karisik_Oynat();
                }
                else
                {
                    try
                    {
                        list_Muzik_Liste.SelectedIndex -= 1;
                        pl.mp3_Ac(OynatmaListesi[list_Muzik_Liste.SelectedIndex].ToString());
                        grp_muzik.Text = "Çalan Müzik : ... " + list_Muzik_Liste.SelectedItem.ToString();
                    }
                    catch (NullReferenceException)
                    {
                        MessageBox.Show("Müzik Listesinin Başı");
                    }
                }

                pl.mp3_Oynat(Tekrarla);
                pl.ToplamSure();
                lbl_toplam_sn.Text = pl._st_ToplamSure.ToString();
                tck_muzik_durum.Maximum = pl._sn_ToplamSure;
            }


            if (e.KeyCode == Keys.C && e.Control) //anahtar tuşu belirliyoruz
            {

                try
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (object row in list_Muzik_Liste.SelectedItems)
                    {
                        sb.Append(row.ToString());
                        sb.AppendLine();
                    }
                    sb.Remove(sb.Length - 1, 1); // Just to avoid copying last empty row
                    Clipboard.SetData(System.Windows.Forms.DataFormats.Text, sb.ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }


            if (e.KeyCode == Keys.V && e.Control) //anahtar tuşu belirliyoruz
            {

                try
                {
                    // Getting Text from Clip board
                    string s = Clipboard.GetText();
                    //Parsing criteria: New Line
                    string[] lines = s.Split('\n');
                    foreach (string ln in lines)
                    {
                        list_Muzik_Liste.Items.Add(ln.Trim());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }



            if (e.KeyCode == Keys.A && e.Control) //anahtar tuşu belirliyoruz
            {

                try
                {
                    list_Muzik_Liste.SelectedItems.Clear();
                    for (int i = 0; i < list_Muzik_Liste.Items.Count; i++)
                    {
                        list_Muzik_Liste.SetSelected(i, true);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }


            if (e.KeyCode == Keys.Delete) //anahtar tuşu belirliyoruz
            {

                int i = list_Muzik_Liste.SelectedIndex;
                list_Muzik_Liste.Items.RemoveAt(i);
                OynatmaListesi.RemoveAt(i);
                list_Muzik_Liste.Refresh();
                if (muzik_Caliyor == true)
                {
                    pl.mp3_Kapat();
                    MessageBox.Show("Müzik silindi. Şarkıya devam..");

                    muzikDegistirTemizle();
                    muzik_Caliyor = false;
                }
            }


            if (e.KeyCode == Keys.Escape) //anahtar tuşu belirliyoruz
            {
                const string message = "Çıkmak istediğinizden emin misiniz?";
                const string caption = "Çıkış";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Application.Exit();
                }

            }



            if (e.KeyCode == Keys.Space) //anahtar tuşu belirliyoruz
            {
               



                if (muzik_Caliyor==true)
                {
                    pl.mp3_Duraklat();
                    pl.muzikDuraklatildi = true;
                }
                else
                {
                    muzikDegistirTemizle();


                    if (pl.muzikDuraklatildi == true)
                    {
                        pl.mp3_Oynat(Tekrarla);
                        pl.muzikDuraklatildi = false;
                    }
                    else
                    {
                        if (muzik_Caliyor)
                        {
                            pl.mp3_Kapat();
                            muzik_Caliyor = false;
                        }
                        if (list_Muzik_Liste.SelectedIndex < 0)
                            list_Muzik_Liste.SelectedIndex = 0;



                        pl.mp3_Ac(OynatmaListesi[list_Muzik_Liste.SelectedIndex].ToString());
                        pl.mp3_Oynat(Tekrarla);
                        muzik_Caliyor = true;

                        grp_muzik.Text = "Çalan Müzik : " + list_Muzik_Liste.SelectedItem.ToString();
                        pl.ToplamSure();
                        lbl_toplam_sn.Text = pl._st_ToplamSure.ToString();
                        tck_muzik_durum.Maximum = pl._sn_ToplamSure;

                        this.Text = "Çalan Müzik : ... " + list_Muzik_Liste.SelectedItem.ToString();
                    }
                    MuzikDegisti = 0;
                }

            }

        }

        private void spotify_button_Click(object sender, EventArgs e)
        {
           
            MessageBox.Show("Yakında SPOTİFY uygulama bağlantısı eklenecektir.");
        }

        private void özelleştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yakında Eklenecektir.");
        }

        private void yenidenBaşlatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms[0] == this)//Uygulamanin main form'u
            {
                //uygulamanin ana formunu kapatirsaniz uygulama kapanir, ana formu yeniden baslatmak uygulamayi yeniden baslatmak demektir.
                Application.Restart();
            }
            else
            {
                Form1 f = new Form1();
                f.Show();
                this.Close();
            }
        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hakkinda ff = new hakkinda();
            ff.Show();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            const string message = "Çıkmak istediğinizden emin misiniz?";
            const string caption = "Çıkış";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {

            saveFileDialog1.Filter = "Metin dosyaları (*.txt)|*.txt|Tüm dosyalar (*.*)|*.*";
            saveFileDialog1.DefaultExt = ".txt";

            DialogResult result = saveFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                FileStream fs = new FileStream(saveFileDialog1.FileName, FileMode.Create);
                StreamWriter writer = new StreamWriter(fs);

                writer.Write(list_Muzik_Liste.SelectedItem);
             

                MessageBox.Show("Dosya Kaydedildi", "Dosya Yolu : " + saveFileDialog1.FileName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                writer.Close();

            }
        }

        private void farklıKaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                saveFileDialog2.Filter = "Word dosyaları (*.docx)|*.docx|Tüm dosyalar (*.*)|*.*";
                saveFileDialog2.DefaultExt = ".docx";

                if (saveFileDialog2.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter sw = new StreamWriter(saveFileDialog2.FileName);
                    sw.Write(list_Muzik_Liste.SelectedItem);
                    

                    MessageBox.Show("Dosya Kaydedildi", "Dosya Yolu : " + saveFileDialog2.FileName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    sw.Close();

                }


            }

            catch (Exception ex)
            {
                label1.Text = ex.Message;
                label1.ForeColor = Color.Red;
            }
        }

        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Medya Dosyası(*.mpg,*.dat,*.avi,*.wmv,*.wav,*.mp3)|*.wav;*.mp3;*.mpg;*.dat;*.avi;*.wmv";
            openFileDialog1.Multiselect = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < openFileDialog1.FileNames.Count(); i++)
                {
                    list_Muzik_Liste.Items.Add(openFileDialog1.SafeFileNames[i]);
                    OynatmaListesi.Add(openFileDialog1.FileNames[i]);
                }
                btn_muzik_oynat.Enabled = true;
                btn_muzik_durdur.Enabled = true;
                btn_duraklat.Enabled = true;
                muziklerYuklendi = true;
                btn_sonraki.Enabled = true;
                btn_onceki.Enabled = true;
                btn_rastgele.Enabled = true;
                spotify_button.Enabled = true;
                youtube_button.Enabled = true;
            }
        }

        private void kopyalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                foreach (object row in list_Muzik_Liste.SelectedItems)
                {
                    sb.Append(row.ToString());
                    sb.AppendLine();
                }
                sb.Remove(sb.Length - 1, 1); // Just to avoid copying last empty row
                Clipboard.SetData(System.Windows.Forms.DataFormats.Text, sb.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void yapıştırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Getting Text from Clip board
                string s = Clipboard.GetText();
                //Parsing criteria: New Line
                string[] lines = s.Split('\n');
                foreach (string ln in lines)
                {
                    list_Muzik_Liste.Items.Add(ln.Trim());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tümünüSeçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                list_Muzik_Liste.SelectedItems.Clear();
                for (int i = 0; i < list_Muzik_Liste.Items.Count; i++)
                {
                    list_Muzik_Liste.SetSelected(i, true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void youtube_button_Click(object sender, EventArgs e)
        {
            youtubedownloader youtube = new youtubedownloader();
            youtube.Show();
        }

        private void içindekilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("http://www.formula1turkey.epizy.com");
            }
            catch (Exception)
            {
                MessageBox.Show("Yardım dosyasını göstermek için tarayıcı başlatılamadı");
            }
        }

    


       


        private void şuAnkiPozisyonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void geriAlToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void yenidenBaşlatToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void Karisik_Oynat()
        {
            Random rnd = new Random();
            int i = rnd.Next(0, OynatmaListesi.Count() - 1);
            list_Muzik_Liste.SelectedIndex = i;
            btn_muzik_oynat.PerformClick();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void araToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bul deneme = new Bul();
            deneme.Show();
        }

        private void list_Muzik_Liste_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                list_Muzik_Liste.SelectedIndex = list_Muzik_Liste.IndexFromPoint(e.X, e.Y);
            else { }
        }

        private void IleriGeriSar()
        {
            pl.mp3_Duraklat();
            double d = TimeSpan.FromSeconds(tck_muzik_durum.Value).TotalMilliseconds;
            pl.IleriGeriSar(d);
            pl.mp3_Oynat(Tekrarla);
        }


      





    }
}
