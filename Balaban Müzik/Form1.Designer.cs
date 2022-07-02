namespace Balaban_Müzik
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.açToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.kaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.farklıKaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.yazdırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.düzenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geriAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yineleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.kesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kopyalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yapıştırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tümünüSeçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.araçlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.özelleştirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seçeneklerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yardımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.içindekilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.araToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.hakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yenidenBaşlatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tck_muzik_durum = new System.Windows.Forms.TrackBar();
            this.chk_tekrarla = new System.Windows.Forms.CheckBox();
            this.chk_karistir = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.youtube_button = new System.Windows.Forms.Button();
            this.spotify_button = new System.Windows.Forms.Button();
            this.btn_muzik_oynat = new System.Windows.Forms.Button();
            this.btn_rastgele = new System.Windows.Forms.Button();
            this.grp_muzik = new System.Windows.Forms.GroupBox();
            this.lbl_toplam_sn = new System.Windows.Forms.Label();
            this.lbl_pozisyon_sn = new System.Windows.Forms.Label();
            this.btn_muzik_durdur = new System.Windows.Forms.Button();
            this.btn_sonraki = new System.Windows.Forms.Button();
            this.btn_onceki = new System.Windows.Forms.Button();
            this.btn_duraklat = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tck_sol_ses = new System.Windows.Forms.TrackBar();
            this.lbl_sol_ses = new System.Windows.Forms.Label();
            this.tck_sag_ses = new System.Windows.Forms.TrackBar();
            this.lbl_sag_ses = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tck_ana_ses = new System.Windows.Forms.TrackBar();
            this.lbl_ana_ses = new System.Windows.Forms.Label();
            this.list_Muzik_Liste = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Muzik_sec = new System.Windows.Forms.Button();
            this.btn_liste_temizle = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tck_bas = new System.Windows.Forms.TrackBar();
            this.label8 = new System.Windows.Forms.Label();
            this.tck_tiz = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tck_muzik_durum)).BeginInit();
            this.panel1.SuspendLayout();
            this.grp_muzik.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tck_sol_ses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tck_sag_ses)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tck_ana_ses)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tck_bas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tck_tiz)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.düzenToolStripMenuItem,
            this.araçlarToolStripMenuItem,
            this.yardımToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(803, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniToolStripMenuItem,
            this.açToolStripMenuItem,
            this.toolStripSeparator,
            this.kaydetToolStripMenuItem,
            this.farklıKaydetToolStripMenuItem,
            this.toolStripSeparator1,
            this.yazdırToolStripMenuItem,
            this.toolStripSeparator2,
            this.çıkışToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.dosyaToolStripMenuItem.Text = "&Dosya";
            // 
            // yeniToolStripMenuItem
            // 
            this.yeniToolStripMenuItem.Enabled = false;
            this.yeniToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("yeniToolStripMenuItem.Image")));
            this.yeniToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.yeniToolStripMenuItem.Name = "yeniToolStripMenuItem";
            this.yeniToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.yeniToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.yeniToolStripMenuItem.Text = "Y&eni";
            this.yeniToolStripMenuItem.ToolTipText = "Eklemeyi düşünüyorum :)";
            // 
            // açToolStripMenuItem
            // 
            this.açToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("açToolStripMenuItem.Image")));
            this.açToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.açToolStripMenuItem.Name = "açToolStripMenuItem";
            this.açToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.açToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.açToolStripMenuItem.Text = "&Aç";
            this.açToolStripMenuItem.Click += new System.EventHandler(this.açToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(147, 6);
            // 
            // kaydetToolStripMenuItem
            // 
            this.kaydetToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("kaydetToolStripMenuItem.Image")));
            this.kaydetToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.kaydetToolStripMenuItem.Name = "kaydetToolStripMenuItem";
            this.kaydetToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.kaydetToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.kaydetToolStripMenuItem.Text = "&Kaydet";
            this.kaydetToolStripMenuItem.Click += new System.EventHandler(this.kaydetToolStripMenuItem_Click);
            // 
            // farklıKaydetToolStripMenuItem
            // 
            this.farklıKaydetToolStripMenuItem.Name = "farklıKaydetToolStripMenuItem";
            this.farklıKaydetToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.farklıKaydetToolStripMenuItem.Text = "&Farklı Kaydet";
            this.farklıKaydetToolStripMenuItem.Click += new System.EventHandler(this.farklıKaydetToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(147, 6);
            // 
            // yazdırToolStripMenuItem
            // 
            this.yazdırToolStripMenuItem.Enabled = false;
            this.yazdırToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("yazdırToolStripMenuItem.Image")));
            this.yazdırToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.yazdırToolStripMenuItem.Name = "yazdırToolStripMenuItem";
            this.yazdırToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.yazdırToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.yazdırToolStripMenuItem.Text = "Y&azdır";
            this.yazdırToolStripMenuItem.ToolTipText = "Kardeşim yazdır ne ya sanki şarkıları yazdırcan :)";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(147, 6);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.çıkışToolStripMenuItem.Text = "Çı&kış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // düzenToolStripMenuItem
            // 
            this.düzenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.geriAlToolStripMenuItem,
            this.yineleToolStripMenuItem,
            this.toolStripSeparator3,
            this.kesToolStripMenuItem,
            this.kopyalaToolStripMenuItem,
            this.yapıştırToolStripMenuItem,
            this.toolStripSeparator4,
            this.tümünüSeçToolStripMenuItem});
            this.düzenToolStripMenuItem.Name = "düzenToolStripMenuItem";
            this.düzenToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.düzenToolStripMenuItem.Text = "D&üzen";
            // 
            // geriAlToolStripMenuItem
            // 
            this.geriAlToolStripMenuItem.Name = "geriAlToolStripMenuItem";
            this.geriAlToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.geriAlToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.geriAlToolStripMenuItem.Text = "&Geri Al";
            // 
            // yineleToolStripMenuItem
            // 
            this.yineleToolStripMenuItem.Name = "yineleToolStripMenuItem";
            this.yineleToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.yineleToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.yineleToolStripMenuItem.Text = "Yi&nele";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(155, 6);
            // 
            // kesToolStripMenuItem
            // 
            this.kesToolStripMenuItem.Enabled = false;
            this.kesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("kesToolStripMenuItem.Image")));
            this.kesToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.kesToolStripMenuItem.Name = "kesToolStripMenuItem";
            this.kesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.kesToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.kesToolStripMenuItem.Text = "&Kes";
            // 
            // kopyalaToolStripMenuItem
            // 
            this.kopyalaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("kopyalaToolStripMenuItem.Image")));
            this.kopyalaToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.kopyalaToolStripMenuItem.Name = "kopyalaToolStripMenuItem";
            this.kopyalaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.kopyalaToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.kopyalaToolStripMenuItem.Text = "K&opyala";
            this.kopyalaToolStripMenuItem.Click += new System.EventHandler(this.kopyalaToolStripMenuItem_Click);
            // 
            // yapıştırToolStripMenuItem
            // 
            this.yapıştırToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("yapıştırToolStripMenuItem.Image")));
            this.yapıştırToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.yapıştırToolStripMenuItem.Name = "yapıştırToolStripMenuItem";
            this.yapıştırToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.yapıştırToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.yapıştırToolStripMenuItem.Text = "&Yapıştır";
            this.yapıştırToolStripMenuItem.Click += new System.EventHandler(this.yapıştırToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(155, 6);
            // 
            // tümünüSeçToolStripMenuItem
            // 
            this.tümünüSeçToolStripMenuItem.Name = "tümünüSeçToolStripMenuItem";
            this.tümünüSeçToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.tümünüSeçToolStripMenuItem.Text = "&Tümünü Seç";
            this.tümünüSeçToolStripMenuItem.Click += new System.EventHandler(this.tümünüSeçToolStripMenuItem_Click);
            // 
            // araçlarToolStripMenuItem
            // 
            this.araçlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.özelleştirToolStripMenuItem,
            this.seçeneklerToolStripMenuItem});
            this.araçlarToolStripMenuItem.Name = "araçlarToolStripMenuItem";
            this.araçlarToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.araçlarToolStripMenuItem.Text = "&Araçlar";
            // 
            // özelleştirToolStripMenuItem
            // 
            this.özelleştirToolStripMenuItem.Name = "özelleştirToolStripMenuItem";
            this.özelleştirToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.özelleştirToolStripMenuItem.Text = "&Özelleştir";
            this.özelleştirToolStripMenuItem.ToolTipText = "Basmana gerek yok daha eklenmedi :)";
            this.özelleştirToolStripMenuItem.Click += new System.EventHandler(this.özelleştirToolStripMenuItem_Click);
            // 
            // seçeneklerToolStripMenuItem
            // 
            this.seçeneklerToolStripMenuItem.Name = "seçeneklerToolStripMenuItem";
            this.seçeneklerToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.seçeneklerToolStripMenuItem.Text = "&Seçenekler";
            this.seçeneklerToolStripMenuItem.Click += new System.EventHandler(this.seçeneklerToolStripMenuItem_Click);
            // 
            // yardımToolStripMenuItem
            // 
            this.yardımToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.içindekilerToolStripMenuItem,
            this.araToolStripMenuItem,
            this.toolStripSeparator5,
            this.hakkındaToolStripMenuItem,
            this.yenidenBaşlatToolStripMenuItem});
            this.yardımToolStripMenuItem.Name = "yardımToolStripMenuItem";
            this.yardımToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.yardımToolStripMenuItem.Text = "&Yardım";
            // 
            // içindekilerToolStripMenuItem
            // 
            this.içindekilerToolStripMenuItem.Name = "içindekilerToolStripMenuItem";
            this.içindekilerToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.içindekilerToolStripMenuItem.Text = "İçi&ndekiler";
            this.içindekilerToolStripMenuItem.Click += new System.EventHandler(this.içindekilerToolStripMenuItem_Click);
            // 
            // araToolStripMenuItem
            // 
            this.araToolStripMenuItem.Name = "araToolStripMenuItem";
            this.araToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.araToolStripMenuItem.Text = "A&ra";
            this.araToolStripMenuItem.Click += new System.EventHandler(this.araToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(147, 6);
            // 
            // hakkındaToolStripMenuItem
            // 
            this.hakkındaToolStripMenuItem.Name = "hakkındaToolStripMenuItem";
            this.hakkındaToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.hakkındaToolStripMenuItem.Text = "&Hakkında...";
            this.hakkındaToolStripMenuItem.Click += new System.EventHandler(this.hakkındaToolStripMenuItem_Click);
            // 
            // yenidenBaşlatToolStripMenuItem
            // 
            this.yenidenBaşlatToolStripMenuItem.Name = "yenidenBaşlatToolStripMenuItem";
            this.yenidenBaşlatToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.yenidenBaşlatToolStripMenuItem.Text = "Yeniden Başlat";
            this.yenidenBaşlatToolStripMenuItem.Click += new System.EventHandler(this.yenidenBaşlatToolStripMenuItem_Click);
            // 
            // tck_muzik_durum
            // 
            this.tck_muzik_durum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tck_muzik_durum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tck_muzik_durum.Location = new System.Drawing.Point(4, 20);
            this.tck_muzik_durum.Margin = new System.Windows.Forms.Padding(2);
            this.tck_muzik_durum.Maximum = 500;
            this.tck_muzik_durum.Name = "tck_muzik_durum";
            this.tck_muzik_durum.Size = new System.Drawing.Size(794, 45);
            this.tck_muzik_durum.TabIndex = 4;
            this.tck_muzik_durum.Scroll += new System.EventHandler(this.tck_muzik_durum_Scroll);
            // 
            // chk_tekrarla
            // 
            this.chk_tekrarla.AutoSize = true;
            this.chk_tekrarla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chk_tekrarla.Location = new System.Drawing.Point(9, 99);
            this.chk_tekrarla.Margin = new System.Windows.Forms.Padding(2);
            this.chk_tekrarla.Name = "chk_tekrarla";
            this.chk_tekrarla.Size = new System.Drawing.Size(99, 17);
            this.chk_tekrarla.TabIndex = 37;
            this.chk_tekrarla.Text = "Şarkıyı Tekrarla";
            this.chk_tekrarla.UseVisualStyleBackColor = true;
            // 
            // chk_karistir
            // 
            this.chk_karistir.AutoSize = true;
            this.chk_karistir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chk_karistir.Location = new System.Drawing.Point(9, 77);
            this.chk_karistir.Margin = new System.Windows.Forms.Padding(2);
            this.chk_karistir.Name = "chk_karistir";
            this.chk_karistir.Size = new System.Drawing.Size(57, 17);
            this.chk_karistir.TabIndex = 36;
            this.chk_karistir.Text = "Karıştır";
            this.chk_karistir.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.youtube_button);
            this.panel1.Controls.Add(this.spotify_button);
            this.panel1.Controls.Add(this.btn_muzik_oynat);
            this.panel1.Controls.Add(this.chk_tekrarla);
            this.panel1.Controls.Add(this.chk_karistir);
            this.panel1.Controls.Add(this.btn_rastgele);
            this.panel1.Controls.Add(this.grp_muzik);
            this.panel1.Controls.Add(this.btn_muzik_durdur);
            this.panel1.Controls.Add(this.btn_sonraki);
            this.panel1.Controls.Add(this.btn_onceki);
            this.panel1.Controls.Add(this.btn_duraklat);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 411);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 145);
            this.panel1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // youtube_button
            // 
            this.youtube_button.BackColor = System.Drawing.Color.Transparent;
            this.youtube_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.youtube_button.Enabled = false;
            this.youtube_button.FlatAppearance.BorderSize = 0;
            this.youtube_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.youtube_button.Image = global::Balaban_Müzik.Properties.Resources.youtube;
            this.youtube_button.Location = new System.Drawing.Point(660, 76);
            this.youtube_button.Margin = new System.Windows.Forms.Padding(2);
            this.youtube_button.Name = "youtube_button";
            this.youtube_button.Size = new System.Drawing.Size(65, 61);
            this.youtube_button.TabIndex = 38;
            this.youtube_button.UseVisualStyleBackColor = false;
            this.youtube_button.Click += new System.EventHandler(this.youtube_button_Click);
            // 
            // spotify_button
            // 
            this.spotify_button.BackColor = System.Drawing.Color.Transparent;
            this.spotify_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.spotify_button.Enabled = false;
            this.spotify_button.FlatAppearance.BorderSize = 0;
            this.spotify_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.spotify_button.Image = global::Balaban_Müzik.Properties.Resources.spotify;
            this.spotify_button.Location = new System.Drawing.Point(729, 77);
            this.spotify_button.Margin = new System.Windows.Forms.Padding(2);
            this.spotify_button.Name = "spotify_button";
            this.spotify_button.Size = new System.Drawing.Size(56, 61);
            this.spotify_button.TabIndex = 38;
            this.spotify_button.UseVisualStyleBackColor = false;
            this.spotify_button.Click += new System.EventHandler(this.spotify_button_Click);
            // 
            // btn_muzik_oynat
            // 
            this.btn_muzik_oynat.BackColor = System.Drawing.Color.Transparent;
            this.btn_muzik_oynat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_muzik_oynat.Enabled = false;
            this.btn_muzik_oynat.FlatAppearance.BorderSize = 0;
            this.btn_muzik_oynat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_muzik_oynat.Image = global::Balaban_Müzik.Properties.Resources.play;
            this.btn_muzik_oynat.Location = new System.Drawing.Point(405, 77);
            this.btn_muzik_oynat.Margin = new System.Windows.Forms.Padding(2);
            this.btn_muzik_oynat.Name = "btn_muzik_oynat";
            this.btn_muzik_oynat.Size = new System.Drawing.Size(56, 61);
            this.btn_muzik_oynat.TabIndex = 3;
            this.btn_muzik_oynat.UseVisualStyleBackColor = false;
            this.btn_muzik_oynat.Click += new System.EventHandler(this.btn_muzik_oynat_Click);
            // 
            // btn_rastgele
            // 
            this.btn_rastgele.BackColor = System.Drawing.Color.Transparent;
            this.btn_rastgele.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_rastgele.Enabled = false;
            this.btn_rastgele.FlatAppearance.BorderSize = 0;
            this.btn_rastgele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rastgele.Image = global::Balaban_Müzik.Properties.Resources.karıstır;
            this.btn_rastgele.Location = new System.Drawing.Point(285, 76);
            this.btn_rastgele.Margin = new System.Windows.Forms.Padding(2);
            this.btn_rastgele.Name = "btn_rastgele";
            this.btn_rastgele.Size = new System.Drawing.Size(56, 61);
            this.btn_rastgele.TabIndex = 35;
            this.btn_rastgele.UseVisualStyleBackColor = false;
            this.btn_rastgele.Click += new System.EventHandler(this.btn_rastgele_Click);
            // 
            // grp_muzik
            // 
            this.grp_muzik.Controls.Add(this.lbl_toplam_sn);
            this.grp_muzik.Controls.Add(this.lbl_pozisyon_sn);
            this.grp_muzik.Controls.Add(this.tck_muzik_durum);
            this.grp_muzik.Dock = System.Windows.Forms.DockStyle.Top;
            this.grp_muzik.Location = new System.Drawing.Point(0, 0);
            this.grp_muzik.Margin = new System.Windows.Forms.Padding(2);
            this.grp_muzik.Name = "grp_muzik";
            this.grp_muzik.Padding = new System.Windows.Forms.Padding(2);
            this.grp_muzik.Size = new System.Drawing.Size(803, 72);
            this.grp_muzik.TabIndex = 34;
            this.grp_muzik.TabStop = false;
            this.grp_muzik.Text = "Çalan Müzik : ...";
            // 
            // lbl_toplam_sn
            // 
            this.lbl_toplam_sn.AutoSize = true;
            this.lbl_toplam_sn.BackColor = System.Drawing.Color.Transparent;
            this.lbl_toplam_sn.Location = new System.Drawing.Point(746, 54);
            this.lbl_toplam_sn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_toplam_sn.Name = "lbl_toplam_sn";
            this.lbl_toplam_sn.Size = new System.Drawing.Size(49, 13);
            this.lbl_toplam_sn.TabIndex = 31;
            this.lbl_toplam_sn.Text = "00:00:00";
            this.lbl_toplam_sn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_pozisyon_sn
            // 
            this.lbl_pozisyon_sn.AutoSize = true;
            this.lbl_pozisyon_sn.BackColor = System.Drawing.Color.Transparent;
            this.lbl_pozisyon_sn.Location = new System.Drawing.Point(694, 54);
            this.lbl_pozisyon_sn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_pozisyon_sn.Name = "lbl_pozisyon_sn";
            this.lbl_pozisyon_sn.Size = new System.Drawing.Size(49, 13);
            this.lbl_pozisyon_sn.TabIndex = 30;
            this.lbl_pozisyon_sn.Text = "00:00:00";
            this.lbl_pozisyon_sn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_muzik_durdur
            // 
            this.btn_muzik_durdur.BackColor = System.Drawing.Color.Transparent;
            this.btn_muzik_durdur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_muzik_durdur.Enabled = false;
            this.btn_muzik_durdur.FlatAppearance.BorderSize = 0;
            this.btn_muzik_durdur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_muzik_durdur.Image = global::Balaban_Müzik.Properties.Resources.stopp;
            this.btn_muzik_durdur.Location = new System.Drawing.Point(459, 77);
            this.btn_muzik_durdur.Margin = new System.Windows.Forms.Padding(2);
            this.btn_muzik_durdur.Name = "btn_muzik_durdur";
            this.btn_muzik_durdur.Size = new System.Drawing.Size(56, 61);
            this.btn_muzik_durdur.TabIndex = 4;
            this.btn_muzik_durdur.UseVisualStyleBackColor = false;
            this.btn_muzik_durdur.Click += new System.EventHandler(this.btn_muzik_durdur_Click);
            // 
            // btn_sonraki
            // 
            this.btn_sonraki.BackColor = System.Drawing.Color.Transparent;
            this.btn_sonraki.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sonraki.Enabled = false;
            this.btn_sonraki.FlatAppearance.BorderSize = 0;
            this.btn_sonraki.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sonraki.Image = global::Balaban_Müzik.Properties.Resources.ilerisar;
            this.btn_sonraki.Location = new System.Drawing.Point(528, 77);
            this.btn_sonraki.Margin = new System.Windows.Forms.Padding(2);
            this.btn_sonraki.Name = "btn_sonraki";
            this.btn_sonraki.Size = new System.Drawing.Size(56, 61);
            this.btn_sonraki.TabIndex = 32;
            this.btn_sonraki.UseVisualStyleBackColor = false;
            this.btn_sonraki.Click += new System.EventHandler(this.btn_sonraki_Click);
            // 
            // btn_onceki
            // 
            this.btn_onceki.BackColor = System.Drawing.Color.Transparent;
            this.btn_onceki.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_onceki.Enabled = false;
            this.btn_onceki.FlatAppearance.BorderSize = 0;
            this.btn_onceki.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_onceki.Image = global::Balaban_Müzik.Properties.Resources.gerisar;
            this.btn_onceki.Location = new System.Drawing.Point(216, 76);
            this.btn_onceki.Margin = new System.Windows.Forms.Padding(2);
            this.btn_onceki.Name = "btn_onceki";
            this.btn_onceki.Size = new System.Drawing.Size(56, 61);
            this.btn_onceki.TabIndex = 33;
            this.btn_onceki.UseVisualStyleBackColor = false;
            this.btn_onceki.Click += new System.EventHandler(this.btn_onceki_Click);
            // 
            // btn_duraklat
            // 
            this.btn_duraklat.BackColor = System.Drawing.Color.Transparent;
            this.btn_duraklat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_duraklat.Enabled = false;
            this.btn_duraklat.FlatAppearance.BorderSize = 0;
            this.btn_duraklat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_duraklat.Image = global::Balaban_Müzik.Properties.Resources.stop;
            this.btn_duraklat.Location = new System.Drawing.Point(345, 77);
            this.btn_duraklat.Margin = new System.Windows.Forms.Padding(2);
            this.btn_duraklat.Name = "btn_duraklat";
            this.btn_duraklat.Size = new System.Drawing.Size(56, 61);
            this.btn_duraklat.TabIndex = 7;
            this.btn_duraklat.UseVisualStyleBackColor = false;
            this.btn_duraklat.Click += new System.EventHandler(this.btn_duraklat_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tck_sol_ses
            // 
            this.tck_sol_ses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tck_sol_ses.Location = new System.Drawing.Point(12, 17);
            this.tck_sol_ses.Margin = new System.Windows.Forms.Padding(2);
            this.tck_sol_ses.Maximum = 100;
            this.tck_sol_ses.Name = "tck_sol_ses";
            this.tck_sol_ses.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tck_sol_ses.Size = new System.Drawing.Size(45, 342);
            this.tck_sol_ses.TabIndex = 15;
            this.tck_sol_ses.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tck_sol_ses.Value = 100;
            this.tck_sol_ses.Scroll += new System.EventHandler(this.tck_sol_ses_Scroll);
            // 
            // lbl_sol_ses
            // 
            this.lbl_sol_ses.AutoSize = true;
            this.lbl_sol_ses.Location = new System.Drawing.Point(22, 362);
            this.lbl_sol_ses.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_sol_ses.Name = "lbl_sol_ses";
            this.lbl_sol_ses.Size = new System.Drawing.Size(22, 13);
            this.lbl_sol_ses.TabIndex = 17;
            this.lbl_sol_ses.Text = "Sol";
            // 
            // tck_sag_ses
            // 
            this.tck_sag_ses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tck_sag_ses.Location = new System.Drawing.Point(58, 17);
            this.tck_sag_ses.Margin = new System.Windows.Forms.Padding(2);
            this.tck_sag_ses.Maximum = 100;
            this.tck_sag_ses.Name = "tck_sag_ses";
            this.tck_sag_ses.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tck_sag_ses.Size = new System.Drawing.Size(45, 342);
            this.tck_sag_ses.TabIndex = 18;
            this.tck_sag_ses.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tck_sag_ses.Value = 100;
            this.tck_sag_ses.Scroll += new System.EventHandler(this.tck_sag_ses_Scroll);
            // 
            // lbl_sag_ses
            // 
            this.lbl_sag_ses.AutoSize = true;
            this.lbl_sag_ses.Location = new System.Drawing.Point(68, 362);
            this.lbl_sag_ses.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_sag_ses.Name = "lbl_sag_ses";
            this.lbl_sag_ses.Size = new System.Drawing.Size(26, 13);
            this.lbl_sag_ses.TabIndex = 20;
            this.lbl_sag_ses.Text = "Sağ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tck_sol_ses);
            this.groupBox1.Controls.Add(this.lbl_sol_ses);
            this.groupBox1.Controls.Add(this.tck_sag_ses);
            this.groupBox1.Controls.Add(this.lbl_sag_ses);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(115, 387);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sol / Sağ Ses";
            // 
            // tck_ana_ses
            // 
            this.tck_ana_ses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tck_ana_ses.Location = new System.Drawing.Point(10, 17);
            this.tck_ana_ses.Margin = new System.Windows.Forms.Padding(2);
            this.tck_ana_ses.Maximum = 100;
            this.tck_ana_ses.Name = "tck_ana_ses";
            this.tck_ana_ses.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tck_ana_ses.Size = new System.Drawing.Size(45, 342);
            this.tck_ana_ses.TabIndex = 12;
            this.tck_ana_ses.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tck_ana_ses.Value = 100;
            this.tck_ana_ses.Scroll += new System.EventHandler(this.tck_ana_ses_Scroll);
            // 
            // lbl_ana_ses
            // 
            this.lbl_ana_ses.AutoSize = true;
            this.lbl_ana_ses.Location = new System.Drawing.Point(20, 362);
            this.lbl_ana_ses.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ana_ses.Name = "lbl_ana_ses";
            this.lbl_ana_ses.Size = new System.Drawing.Size(26, 13);
            this.lbl_ana_ses.TabIndex = 14;
            this.lbl_ana_ses.Text = "Ana";
            // 
            // list_Muzik_Liste
            // 
            this.list_Muzik_Liste.ContextMenuStrip = this.contextMenuStrip1;
            this.list_Muzik_Liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list_Muzik_Liste.FormattingEnabled = true;
            this.list_Muzik_Liste.Location = new System.Drawing.Point(0, 61);
            this.list_Muzik_Liste.Margin = new System.Windows.Forms.Padding(2);
            this.list_Muzik_Liste.Name = "list_Muzik_Liste";
            this.list_Muzik_Liste.Size = new System.Drawing.Size(499, 326);
            this.list_Muzik_Liste.TabIndex = 5;
            this.list_Muzik_Liste.SelectedIndexChanged += new System.EventHandler(this.list_Muzik_Liste_SelectedIndexChanged);
            this.list_Muzik_Liste.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.list_Muzik_Liste_MouseDoubleClick);
            this.list_Muzik_Liste.MouseDown += new System.Windows.Forms.MouseEventHandler(this.list_Muzik_Liste_MouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(87, 26);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(86, 22);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.list_Muzik_Liste);
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(803, 387);
            this.splitContainer1.SplitterDistance = 499;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_Muzik_sec);
            this.panel2.Controls.Add(this.btn_liste_temizle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(499, 61);
            this.panel2.TabIndex = 6;
            // 
            // btn_Muzik_sec
            // 
            this.btn_Muzik_sec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Muzik_sec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Muzik_sec.Image = global::Balaban_Müzik.Properties.Resources.playlist;
            this.btn_Muzik_sec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Muzik_sec.Location = new System.Drawing.Point(0, 0);
            this.btn_Muzik_sec.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Muzik_sec.Name = "btn_Muzik_sec";
            this.btn_Muzik_sec.Size = new System.Drawing.Size(257, 61);
            this.btn_Muzik_sec.TabIndex = 2;
            this.btn_Muzik_sec.Text = "Oynatma Listesi Oluştur";
            this.btn_Muzik_sec.UseVisualStyleBackColor = true;
            this.btn_Muzik_sec.Click += new System.EventHandler(this.btn_Muzik_sec_Click);
            // 
            // btn_liste_temizle
            // 
            this.btn_liste_temizle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_liste_temizle.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_liste_temizle.Image = global::Balaban_Müzik.Properties.Resources.temizle;
            this.btn_liste_temizle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_liste_temizle.Location = new System.Drawing.Point(257, 0);
            this.btn_liste_temizle.Margin = new System.Windows.Forms.Padding(2);
            this.btn_liste_temizle.Name = "btn_liste_temizle";
            this.btn_liste_temizle.Size = new System.Drawing.Size(242, 61);
            this.btn_liste_temizle.TabIndex = 3;
            this.btn_liste_temizle.Text = "Listeyi Temizle";
            this.btn_liste_temizle.UseVisualStyleBackColor = true;
            this.btn_liste_temizle.Click += new System.EventHandler(this.btn_liste_temizle_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tck_bas);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.tck_tiz);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(177, 0);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(124, 387);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ses Efekt";
            // 
            // tck_bas
            // 
            this.tck_bas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tck_bas.Location = new System.Drawing.Point(14, 17);
            this.tck_bas.Margin = new System.Windows.Forms.Padding(2);
            this.tck_bas.Maximum = 100;
            this.tck_bas.Name = "tck_bas";
            this.tck_bas.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tck_bas.Size = new System.Drawing.Size(45, 342);
            this.tck_bas.TabIndex = 21;
            this.tck_bas.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tck_bas.Value = 100;
            this.tck_bas.Scroll += new System.EventHandler(this.tck_bas_Scroll);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 362);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Bas";
            // 
            // tck_tiz
            // 
            this.tck_tiz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tck_tiz.Location = new System.Drawing.Point(61, 17);
            this.tck_tiz.Margin = new System.Windows.Forms.Padding(2);
            this.tck_tiz.Maximum = 100;
            this.tck_tiz.Name = "tck_tiz";
            this.tck_tiz.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tck_tiz.Size = new System.Drawing.Size(45, 342);
            this.tck_tiz.TabIndex = 24;
            this.tck_tiz.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tck_tiz.Value = 100;
            this.tck_tiz.Scroll += new System.EventHandler(this.tck_tiz_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 362);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Tiz";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tck_ana_ses);
            this.groupBox2.Controls.Add(this.lbl_ana_ses);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(115, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(62, 387);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ana Ses";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 556);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Balaban Müzik";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tck_muzik_durum)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grp_muzik.ResumeLayout(false);
            this.grp_muzik.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tck_sol_ses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tck_sag_ses)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tck_ana_ses)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tck_bas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tck_tiz)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem açToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem kaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem farklıKaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem yazdırToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem düzenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem geriAlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yineleToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem kesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kopyalaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yapıştırToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem tümünüSeçToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem araçlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem özelleştirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seçeneklerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yardımToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem içindekilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem araToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem hakkındaToolStripMenuItem;
        private System.Windows.Forms.TrackBar tck_muzik_durum;
        private System.Windows.Forms.CheckBox chk_tekrarla;
        private System.Windows.Forms.CheckBox chk_karistir;
        private System.Windows.Forms.Button btn_rastgele;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grp_muzik;
        private System.Windows.Forms.Label lbl_toplam_sn;
        private System.Windows.Forms.Label lbl_pozisyon_sn;
        private System.Windows.Forms.Button btn_muzik_durdur;
        private System.Windows.Forms.Button btn_sonraki;
        private System.Windows.Forms.Button btn_onceki;
        private System.Windows.Forms.Button btn_duraklat;
        private System.Windows.Forms.Button btn_muzik_oynat;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar tck_sol_ses;
        private System.Windows.Forms.Label lbl_sol_ses;
        private System.Windows.Forms.TrackBar tck_sag_ses;
        private System.Windows.Forms.Label lbl_sag_ses;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar tck_ana_ses;
        private System.Windows.Forms.Label lbl_ana_ses;
        private System.Windows.Forms.Button btn_Muzik_sec;
        private System.Windows.Forms.ListBox list_Muzik_Liste;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_liste_temizle;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TrackBar tck_bas;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TrackBar tck_tiz;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button spotify_button;
        private System.Windows.Forms.ToolStripMenuItem yenidenBaşlatToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button youtube_button;
    }
}

