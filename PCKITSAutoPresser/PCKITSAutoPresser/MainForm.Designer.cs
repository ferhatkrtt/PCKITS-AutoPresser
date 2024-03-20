namespace PCKITSAutoPresser
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.bgwSurecListesiYukle = new System.ComponentModel.BackgroundWorker();
            this.metroSetControlBox1 = new MetroSet_UI.Controls.MetroSetControlBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tusListesi = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.presserListContextMenuStrip = new MetroSet_UI.Controls.MetroSetContextMenuStrip();
            this.tümünüSeçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.düzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kaldırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tümünüKaldırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.processListContextMenuStrip = new MetroSet_UI.Controls.MetroSetContextMenuStrip();
            this.sonlandırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.durumLabel = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel2 = new MetroSet_UI.Controls.MetroSetLabel();
            this.btnDurdur = new MetroSet_UI.Controls.MetroSetButton();
            this.metroSetLabel1 = new MetroSet_UI.Controls.MetroSetLabel();
            this.btnBaslat = new MetroSet_UI.Controls.MetroSetButton();
            this.metroSetButton2 = new MetroSet_UI.Controls.MetroSetButton();
            this.metroSetButton1 = new MetroSet_UI.Controls.MetroSetButton();
            this.metroSetLabel3 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel4 = new MetroSet_UI.Controls.MetroSetLabel();
            this.suretipi = new MetroSet_UI.Controls.MetroSetComboBox();
            this.metroSetLabel5 = new MetroSet_UI.Controls.MetroSetLabel();
            this.tus = new MetroSet_UI.Controls.MetroSetTextBox();
            this.sure = new MetroSet_UI.Controls.MetroSetTextBox();
            this.btnEkle = new MetroSet_UI.Controls.MetroSetButton();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.bgwtimerCalistir = new System.ComponentModel.BackgroundWorker();
            this.timerTusla = new System.Windows.Forms.Timer(this.components);
            this.metroSetLabel6 = new MetroSet_UI.Controls.MetroSetLabel();
            this.groupBox1.SuspendLayout();
            this.presserListContextMenuStrip.SuspendLayout();
            this.processListContextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // bgwSurecListesiYukle
            // 
            this.bgwSurecListesiYukle.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BgwSurecListesiYukle_DoWork);
            this.bgwSurecListesiYukle.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BgwSurecListesiYukle_RunWorkerCompleted);
            // 
            // metroSetControlBox1
            // 
            this.metroSetControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroSetControlBox1.CloseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.metroSetControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.metroSetControlBox1.CloseNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.DisabledForeColor = System.Drawing.Color.DimGray;
            this.metroSetControlBox1.IsDerivedStyle = true;
            this.metroSetControlBox1.Location = new System.Drawing.Point(912, 5);
            this.metroSetControlBox1.MaximizeBox = false;
            this.metroSetControlBox1.MaximizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetControlBox1.MaximizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MaximizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MinimizeBox = true;
            this.metroSetControlBox1.MinimizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetControlBox1.MinimizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MinimizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.Name = "metroSetControlBox1";
            this.metroSetControlBox1.Size = new System.Drawing.Size(100, 25);
            this.metroSetControlBox1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetControlBox1.StyleManager = null;
            this.metroSetControlBox1.TabIndex = 4;
            this.metroSetControlBox1.Text = "metroSetControlBox1";
            this.metroSetControlBox1.ThemeAuthor = "Narwin";
            this.metroSetControlBox1.ThemeName = "MetroLite";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.groupBox1.Controls.Add(this.tusListesi);
            this.groupBox1.Controls.Add(this.processList);
            this.groupBox1.Controls.Add(this.durumLabel);
            this.groupBox1.Controls.Add(this.metroSetLabel2);
            this.groupBox1.Controls.Add(this.btnDurdur);
            this.groupBox1.Controls.Add(this.metroSetLabel1);
            this.groupBox1.Controls.Add(this.btnBaslat);
            this.groupBox1.Controls.Add(this.metroSetButton2);
            this.groupBox1.Controls.Add(this.metroSetButton1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 224);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1000, 532);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İşlemler";
            // 
            // tusListesi
            // 
            this.tusListesi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tusListesi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.tusListesi.ContextMenuStrip = this.presserListContextMenuStrip;
            this.tusListesi.ForeColor = System.Drawing.Color.White;
            this.tusListesi.HideSelection = false;
            this.tusListesi.Location = new System.Drawing.Point(503, 66);
            this.tusListesi.Name = "tusListesi";
            this.tusListesi.Size = new System.Drawing.Size(475, 387);
            this.tusListesi.TabIndex = 9;
            this.tusListesi.UseCompatibleStateImageBehavior = false;
            this.tusListesi.View = System.Windows.Forms.View.Details;
            this.tusListesi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProcessList_KeyDown);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Atanan Tuş";
            this.columnHeader4.Width = 265;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Süre";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Süre Tipi";
            this.columnHeader6.Width = 100;
            // 
            // presserListContextMenuStrip
            // 
            this.presserListContextMenuStrip.IsDerivedStyle = true;
            this.presserListContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tümünüSeçToolStripMenuItem,
            this.düzenleToolStripMenuItem,
            this.kaldırToolStripMenuItem,
            this.tümünüKaldırToolStripMenuItem});
            this.presserListContextMenuStrip.Name = "processListContextMenuStrip";
            this.presserListContextMenuStrip.Size = new System.Drawing.Size(153, 92);
            this.presserListContextMenuStrip.Style = MetroSet_UI.Enums.Style.Dark;
            this.presserListContextMenuStrip.StyleManager = null;
            this.presserListContextMenuStrip.ThemeAuthor = "Narwin";
            this.presserListContextMenuStrip.ThemeName = "MetroDark";
            this.presserListContextMenuStrip.MouseClick += new System.Windows.Forms.MouseEventHandler(this.presserListContextMenuStrip_MouseClick);
            // 
            // tümünüSeçToolStripMenuItem
            // 
            this.tümünüSeçToolStripMenuItem.Name = "tümünüSeçToolStripMenuItem";
            this.tümünüSeçToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.tümünüSeçToolStripMenuItem.Text = "Tümünü Seç";
            this.tümünüSeçToolStripMenuItem.Click += new System.EventHandler(this.tümünüSeçToolStripMenuItem_Click);
            // 
            // düzenleToolStripMenuItem
            // 
            this.düzenleToolStripMenuItem.Name = "düzenleToolStripMenuItem";
            this.düzenleToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.düzenleToolStripMenuItem.Text = "Düzenle";
            // 
            // kaldırToolStripMenuItem
            // 
            this.kaldırToolStripMenuItem.Name = "kaldırToolStripMenuItem";
            this.kaldırToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.kaldırToolStripMenuItem.Text = "Kaldır";
            this.kaldırToolStripMenuItem.Click += new System.EventHandler(this.kaldırToolStripMenuItem_Click);
            // 
            // tümünüKaldırToolStripMenuItem
            // 
            this.tümünüKaldırToolStripMenuItem.Name = "tümünüKaldırToolStripMenuItem";
            this.tümünüKaldırToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.tümünüKaldırToolStripMenuItem.Text = "Tümünü Kaldır";
            this.tümünüKaldırToolStripMenuItem.Click += new System.EventHandler(this.tümünüKaldırToolStripMenuItem_Click);
            // 
            // processList
            // 
            this.processList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.processList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.processList.ContextMenuStrip = this.processListContextMenuStrip;
            this.processList.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.processList.ForeColor = System.Drawing.Color.White;
            this.processList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.processList.HideSelection = false;
            this.processList.Location = new System.Drawing.Point(6, 66);
            this.processList.Name = "processList";
            this.processList.Size = new System.Drawing.Size(475, 387);
            this.processList.TabIndex = 9;
            this.processList.UseCompatibleStateImageBehavior = false;
            this.processList.View = System.Windows.Forms.View.Details;
            this.processList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProcessList_KeyDown);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Süreç Adı";
            this.columnHeader1.Width = 180;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "PID";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "RAM";
            this.columnHeader3.Width = 70;
            // 
            // processListContextMenuStrip
            // 
            this.processListContextMenuStrip.IsDerivedStyle = true;
            this.processListContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sonlandırToolStripMenuItem});
            this.processListContextMenuStrip.Name = "processListContextMenuStrip";
            this.processListContextMenuStrip.Size = new System.Drawing.Size(125, 26);
            this.processListContextMenuStrip.Style = MetroSet_UI.Enums.Style.Dark;
            this.processListContextMenuStrip.StyleManager = null;
            this.processListContextMenuStrip.ThemeAuthor = "Narwin";
            this.processListContextMenuStrip.ThemeName = "MetroDark";
            this.processListContextMenuStrip.MouseClick += new System.Windows.Forms.MouseEventHandler(this.processListContextMenuStrip_MouseClick);
            // 
            // sonlandırToolStripMenuItem
            // 
            this.sonlandırToolStripMenuItem.Name = "sonlandırToolStripMenuItem";
            this.sonlandırToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.sonlandırToolStripMenuItem.Text = "Sonlandır";
            this.sonlandırToolStripMenuItem.Click += new System.EventHandler(this.sonlandırToolStripMenuItem_Click);
            // 
            // durumLabel
            // 
            this.durumLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.durumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.durumLabel.IsDerivedStyle = true;
            this.durumLabel.Location = new System.Drawing.Point(3, 506);
            this.durumLabel.Name = "durumLabel";
            this.durumLabel.Size = new System.Drawing.Size(994, 23);
            this.durumLabel.Style = MetroSet_UI.Enums.Style.Dark;
            this.durumLabel.StyleManager = null;
            this.durumLabel.TabIndex = 12;
            this.durumLabel.Text = "Durum: ";
            this.durumLabel.ThemeAuthor = "Narwin";
            this.durumLabel.ThemeName = "MetroDark";
            // 
            // metroSetLabel2
            // 
            this.metroSetLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.metroSetLabel2.IsDerivedStyle = true;
            this.metroSetLabel2.Location = new System.Drawing.Point(715, 32);
            this.metroSetLabel2.Name = "metroSetLabel2";
            this.metroSetLabel2.Size = new System.Drawing.Size(100, 23);
            this.metroSetLabel2.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetLabel2.StyleManager = null;
            this.metroSetLabel2.TabIndex = 11;
            this.metroSetLabel2.Text = "Tuş Listesi";
            this.metroSetLabel2.ThemeAuthor = "Narwin";
            this.metroSetLabel2.ThemeName = "MetroDark";
            // 
            // btnDurdur
            // 
            this.btnDurdur.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnDurdur.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnDurdur.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnDurdur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDurdur.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnDurdur.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnDurdur.HoverTextColor = System.Drawing.Color.White;
            this.btnDurdur.IsDerivedStyle = true;
            this.btnDurdur.Location = new System.Drawing.Point(834, 459);
            this.btnDurdur.Name = "btnDurdur";
            this.btnDurdur.NormalBorderColor = System.Drawing.Color.LimeGreen;
            this.btnDurdur.NormalColor = System.Drawing.Color.LimeGreen;
            this.btnDurdur.NormalTextColor = System.Drawing.Color.White;
            this.btnDurdur.PressBorderColor = System.Drawing.Color.LimeGreen;
            this.btnDurdur.PressColor = System.Drawing.Color.LimeGreen;
            this.btnDurdur.PressTextColor = System.Drawing.Color.White;
            this.btnDurdur.Size = new System.Drawing.Size(144, 35);
            this.btnDurdur.Style = MetroSet_UI.Enums.Style.Custom;
            this.btnDurdur.StyleManager = null;
            this.btnDurdur.TabIndex = 1;
            this.btnDurdur.Text = "Durdur";
            this.btnDurdur.ThemeAuthor = "Narwin";
            this.btnDurdur.ThemeName = "MetroLite";
            this.btnDurdur.Click += new System.EventHandler(this.BtnDurdur_Click);
            // 
            // metroSetLabel1
            // 
            this.metroSetLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.metroSetLabel1.IsDerivedStyle = true;
            this.metroSetLabel1.Location = new System.Drawing.Point(162, 32);
            this.metroSetLabel1.Name = "metroSetLabel1";
            this.metroSetLabel1.Size = new System.Drawing.Size(100, 23);
            this.metroSetLabel1.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetLabel1.StyleManager = null;
            this.metroSetLabel1.TabIndex = 10;
            this.metroSetLabel1.Text = "Süreçler";
            this.metroSetLabel1.ThemeAuthor = "Narwin";
            this.metroSetLabel1.ThemeName = "MetroDark";
            // 
            // btnBaslat
            // 
            this.btnBaslat.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnBaslat.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnBaslat.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnBaslat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnBaslat.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnBaslat.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnBaslat.HoverTextColor = System.Drawing.Color.White;
            this.btnBaslat.IsDerivedStyle = true;
            this.btnBaslat.Location = new System.Drawing.Point(503, 459);
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.NormalBorderColor = System.Drawing.Color.LimeGreen;
            this.btnBaslat.NormalColor = System.Drawing.Color.LimeGreen;
            this.btnBaslat.NormalTextColor = System.Drawing.Color.White;
            this.btnBaslat.PressBorderColor = System.Drawing.Color.LimeGreen;
            this.btnBaslat.PressColor = System.Drawing.Color.LimeGreen;
            this.btnBaslat.PressTextColor = System.Drawing.Color.White;
            this.btnBaslat.Size = new System.Drawing.Size(144, 35);
            this.btnBaslat.Style = MetroSet_UI.Enums.Style.Custom;
            this.btnBaslat.StyleManager = null;
            this.btnBaslat.TabIndex = 0;
            this.btnBaslat.Text = "Başlat";
            this.btnBaslat.ThemeAuthor = "Narwin";
            this.btnBaslat.ThemeName = "MetroLite";
            this.btnBaslat.Click += new System.EventHandler(this.BtnBaslat_Click);
            // 
            // metroSetButton2
            // 
            this.metroSetButton2.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton2.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton2.DisabledForeColor = System.Drawing.Color.Gray;
            this.metroSetButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetButton2.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroSetButton2.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroSetButton2.HoverTextColor = System.Drawing.Color.White;
            this.metroSetButton2.IsDerivedStyle = true;
            this.metroSetButton2.Location = new System.Drawing.Point(337, 459);
            this.metroSetButton2.Name = "metroSetButton2";
            this.metroSetButton2.NormalBorderColor = System.Drawing.Color.LimeGreen;
            this.metroSetButton2.NormalColor = System.Drawing.Color.LimeGreen;
            this.metroSetButton2.NormalTextColor = System.Drawing.Color.White;
            this.metroSetButton2.PressBorderColor = System.Drawing.Color.LimeGreen;
            this.metroSetButton2.PressColor = System.Drawing.Color.LimeGreen;
            this.metroSetButton2.PressTextColor = System.Drawing.Color.White;
            this.metroSetButton2.Size = new System.Drawing.Size(144, 35);
            this.metroSetButton2.Style = MetroSet_UI.Enums.Style.Custom;
            this.metroSetButton2.StyleManager = null;
            this.metroSetButton2.TabIndex = 1;
            this.metroSetButton2.Text = "Sonlandır";
            this.metroSetButton2.ThemeAuthor = "Narwin";
            this.metroSetButton2.ThemeName = "MetroLite";
            this.metroSetButton2.Click += new System.EventHandler(this.MetroSetButton2_Click);
            // 
            // metroSetButton1
            // 
            this.metroSetButton1.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton1.DisabledForeColor = System.Drawing.Color.Gray;
            this.metroSetButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetButton1.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroSetButton1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroSetButton1.HoverTextColor = System.Drawing.Color.White;
            this.metroSetButton1.IsDerivedStyle = true;
            this.metroSetButton1.Location = new System.Drawing.Point(6, 459);
            this.metroSetButton1.Name = "metroSetButton1";
            this.metroSetButton1.NormalBorderColor = System.Drawing.Color.LimeGreen;
            this.metroSetButton1.NormalColor = System.Drawing.Color.LimeGreen;
            this.metroSetButton1.NormalTextColor = System.Drawing.Color.White;
            this.metroSetButton1.PressBorderColor = System.Drawing.Color.LimeGreen;
            this.metroSetButton1.PressColor = System.Drawing.Color.LimeGreen;
            this.metroSetButton1.PressTextColor = System.Drawing.Color.White;
            this.metroSetButton1.Size = new System.Drawing.Size(144, 35);
            this.metroSetButton1.Style = MetroSet_UI.Enums.Style.Custom;
            this.metroSetButton1.StyleManager = null;
            this.metroSetButton1.TabIndex = 0;
            this.metroSetButton1.Text = "Listeyi Yenile";
            this.metroSetButton1.ThemeAuthor = "Narwin";
            this.metroSetButton1.ThemeName = "MetroLite";
            this.metroSetButton1.Click += new System.EventHandler(this.MetroSetButton1_Click);
            // 
            // metroSetLabel3
            // 
            this.metroSetLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel3.IsDerivedStyle = true;
            this.metroSetLabel3.Location = new System.Drawing.Point(638, 88);
            this.metroSetLabel3.Name = "metroSetLabel3";
            this.metroSetLabel3.Size = new System.Drawing.Size(80, 23);
            this.metroSetLabel3.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetLabel3.StyleManager = null;
            this.metroSetLabel3.TabIndex = 7;
            this.metroSetLabel3.Text = "Tuş: ";
            this.metroSetLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroSetLabel3.ThemeAuthor = "Narwin";
            this.metroSetLabel3.ThemeName = "MetroDark";
            // 
            // metroSetLabel4
            // 
            this.metroSetLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel4.IsDerivedStyle = true;
            this.metroSetLabel4.Location = new System.Drawing.Point(638, 128);
            this.metroSetLabel4.Name = "metroSetLabel4";
            this.metroSetLabel4.Size = new System.Drawing.Size(80, 23);
            this.metroSetLabel4.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetLabel4.StyleManager = null;
            this.metroSetLabel4.TabIndex = 7;
            this.metroSetLabel4.Text = "Süre: ";
            this.metroSetLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroSetLabel4.ThemeAuthor = "Narwin";
            this.metroSetLabel4.ThemeName = "MetroDark";
            // 
            // suretipi
            // 
            this.suretipi.AllowDrop = true;
            this.suretipi.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.suretipi.BackColor = System.Drawing.Color.Transparent;
            this.suretipi.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.suretipi.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.suretipi.CausesValidation = false;
            this.suretipi.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.suretipi.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.suretipi.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.suretipi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.suretipi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.suretipi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.suretipi.FormattingEnabled = true;
            this.suretipi.IsDerivedStyle = true;
            this.suretipi.ItemHeight = 20;
            this.suretipi.Items.AddRange(new object[] {
            "MS",
            "SN"});
            this.suretipi.Location = new System.Drawing.Point(724, 173);
            this.suretipi.Name = "suretipi";
            this.suretipi.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.suretipi.SelectedItemForeColor = System.Drawing.Color.White;
            this.suretipi.Size = new System.Drawing.Size(115, 26);
            this.suretipi.Style = MetroSet_UI.Enums.Style.Dark;
            this.suretipi.StyleManager = null;
            this.suretipi.TabIndex = 2;
            this.suretipi.ThemeAuthor = "Narwin";
            this.suretipi.ThemeName = "MetroDark";
            // 
            // metroSetLabel5
            // 
            this.metroSetLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel5.IsDerivedStyle = true;
            this.metroSetLabel5.Location = new System.Drawing.Point(638, 172);
            this.metroSetLabel5.Name = "metroSetLabel5";
            this.metroSetLabel5.Size = new System.Drawing.Size(83, 23);
            this.metroSetLabel5.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetLabel5.StyleManager = null;
            this.metroSetLabel5.TabIndex = 7;
            this.metroSetLabel5.Text = "Süre Tipi: ";
            this.metroSetLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroSetLabel5.ThemeAuthor = "Narwin";
            this.metroSetLabel5.ThemeName = "MetroDark";
            // 
            // tus
            // 
            this.tus.AutoCompleteCustomSource = null;
            this.tus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tus.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.tus.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.tus.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tus.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tus.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.tus.Image = null;
            this.tus.IsDerivedStyle = true;
            this.tus.Lines = null;
            this.tus.Location = new System.Drawing.Point(724, 89);
            this.tus.MaxLength = 32767;
            this.tus.Multiline = false;
            this.tus.Name = "tus";
            this.tus.ReadOnly = false;
            this.tus.Size = new System.Drawing.Size(115, 26);
            this.tus.Style = MetroSet_UI.Enums.Style.Dark;
            this.tus.StyleManager = null;
            this.tus.TabIndex = 0;
            this.tus.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tus.ThemeAuthor = "Narwin";
            this.tus.ThemeName = "MetroDark";
            this.tus.UseSystemPasswordChar = false;
            this.tus.WatermarkText = "";
            // 
            // sure
            // 
            this.sure.AutoCompleteCustomSource = null;
            this.sure.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.sure.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.sure.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.sure.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.sure.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.sure.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.sure.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sure.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.sure.Image = null;
            this.sure.IsDerivedStyle = true;
            this.sure.Lines = null;
            this.sure.Location = new System.Drawing.Point(724, 129);
            this.sure.MaxLength = 32767;
            this.sure.Multiline = false;
            this.sure.Name = "sure";
            this.sure.ReadOnly = false;
            this.sure.Size = new System.Drawing.Size(115, 26);
            this.sure.Style = MetroSet_UI.Enums.Style.Dark;
            this.sure.StyleManager = null;
            this.sure.TabIndex = 1;
            this.sure.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.sure.ThemeAuthor = "Narwin";
            this.sure.ThemeName = "MetroDark";
            this.sure.UseSystemPasswordChar = false;
            this.sure.WatermarkText = "";
            this.sure.TextChanged += new System.EventHandler(this.Sure_TextChanged);
            // 
            // btnEkle
            // 
            this.btnEkle.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnEkle.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnEkle.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnEkle.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnEkle.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnEkle.HoverTextColor = System.Drawing.Color.White;
            this.btnEkle.IsDerivedStyle = true;
            this.btnEkle.Location = new System.Drawing.Point(845, 89);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.NormalBorderColor = System.Drawing.Color.LimeGreen;
            this.btnEkle.NormalColor = System.Drawing.Color.LimeGreen;
            this.btnEkle.NormalTextColor = System.Drawing.Color.White;
            this.btnEkle.PressBorderColor = System.Drawing.Color.LimeGreen;
            this.btnEkle.PressColor = System.Drawing.Color.LimeGreen;
            this.btnEkle.PressTextColor = System.Drawing.Color.White;
            this.btnEkle.Size = new System.Drawing.Size(129, 110);
            this.btnEkle.Style = MetroSet_UI.Enums.Style.Custom;
            this.btnEkle.StyleManager = null;
            this.btnEkle.TabIndex = 3;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.ThemeAuthor = "Narwin";
            this.btnEkle.ThemeName = "MetroLite";
            this.btnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(12, 73);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(293, 132);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 8;
            this.Logo.TabStop = false;
            // 
            // timerTusla
            // 
            this.timerTusla.Tick += new System.EventHandler(this.TimerTusla_Tick);
            // 
            // metroSetLabel6
            // 
            this.metroSetLabel6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroSetLabel6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.metroSetLabel6.IsDerivedStyle = true;
            this.metroSetLabel6.Location = new System.Drawing.Point(895, 11);
            this.metroSetLabel6.Name = "metroSetLabel6";
            this.metroSetLabel6.Size = new System.Drawing.Size(20, 23);
            this.metroSetLabel6.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetLabel6.StyleManager = null;
            this.metroSetLabel6.TabIndex = 9;
            this.metroSetLabel6.Text = "?";
            this.metroSetLabel6.ThemeAuthor = "Narwin";
            this.metroSetLabel6.ThemeName = "MetroDark";
            this.metroSetLabel6.Click += new System.EventHandler(this.metroSetLabel6_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.metroSetLabel6);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.sure);
            this.Controls.Add(this.tus);
            this.Controls.Add(this.suretipi);
            this.Controls.Add(this.metroSetLabel5);
            this.Controls.Add(this.metroSetLabel4);
            this.Controls.Add(this.metroSetLabel3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.metroSetControlBox1);
            this.MaximumSize = new System.Drawing.Size(1024, 768);
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "MainForm";
            this.Text = "PCKITS Auto Presser";
            this.TextColor = System.Drawing.Color.White;
            this.ThemeName = "MetroDark";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.groupBox1.ResumeLayout(false);
            this.presserListContextMenuStrip.ResumeLayout(false);
            this.processListContextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker bgwSurecListesiYukle;
        private MetroSet_UI.Controls.MetroSetControlBox metroSetControlBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel2;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel1;
        private System.Windows.Forms.ListView processList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private MetroSet_UI.Controls.MetroSetButton metroSetButton2;
        private MetroSet_UI.Controls.MetroSetButton metroSetButton1;
        private MetroSet_UI.Controls.MetroSetLabel durumLabel;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel3;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel4;
        private MetroSet_UI.Controls.MetroSetComboBox suretipi;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel5;
        private MetroSet_UI.Controls.MetroSetTextBox tus;
        private MetroSet_UI.Controls.MetroSetTextBox sure;
        private MetroSet_UI.Controls.MetroSetButton btnEkle;
        private System.Windows.Forms.PictureBox Logo;
        private System.ComponentModel.BackgroundWorker bgwtimerCalistir;
        private System.Windows.Forms.Timer timerTusla;
        private System.Windows.Forms.ListView tusListesi;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private MetroSet_UI.Controls.MetroSetButton btnDurdur;
        private MetroSet_UI.Controls.MetroSetButton btnBaslat;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel6;
        private MetroSet_UI.Controls.MetroSetContextMenuStrip processListContextMenuStrip;
        private MetroSet_UI.Controls.MetroSetContextMenuStrip presserListContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem sonlandırToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tümünüSeçToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem düzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kaldırToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tümünüKaldırToolStripMenuItem;
    }
}

