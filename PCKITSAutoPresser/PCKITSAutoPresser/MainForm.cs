using AutoItX3Lib;
using MetroSet_UI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PCKITSAutoPresser
{
    public partial class MainForm : MetroSetForm
    {
        readonly ProcessList list;
        List<string> atananTusListe;
        List<int> sureListe;
        List<string> sureTipiListe;
        int data;
        private AutoItX3 keySender;
        StreamWriter commandWriter;
        string commandData = "regsvr32 /s \""+ Application.StartupPath + "\\tools\\AutoItX3.DLL\"" + Environment.NewLine +
            "regsvr32 /s \"" + Application.StartupPath + "\\tools\\AutoItX3_x64.DLL\"";

        public MainForm()
        {
            InitializeComponent();
            list = new ProcessList();
            list.GetProcessInformations();
            CheckForIllegalCrossThreadCalls = false;
            bgwSurecListesiYukle.WorkerSupportsCancellation = true;
            bgwtimerCalistir.WorkerSupportsCancellation = true;

            processList.FullRowSelect = true;
            processList.Sorting = SortOrder.Ascending;

            suretipi.SelectedIndex = 0;
            tusListesi.FullRowSelect = true;
            atananTusListe = new List<string>();
            sureListe = new List<int>();
            sureTipiListe = new List<string>();
            commandWriter = new StreamWriter("registerDLL.cmd");
            commandWriter.Write(commandData);
            commandWriter.Close();
        }

        private void BgwSurecListesiYukle_DoWork(object sender, DoWorkEventArgs e)
        {
            durumLabel.Text = "Durum: Liste yükleniyor. Lütfen bekleyin...";
            durumLabel.ForeColor = Color.Orange;
            if (list.ProcessNames.Count > 0)
            {
                for (int i = 0; i < list.ProcessNames.Count; i++)
                {
                    ListViewItem items = new ListViewItem(list.ProcessNames[i]);
                    items.SubItems.Add(list.Pid[i]);
                    try
                    {
                        items.SubItems.Add((Convert.ToInt32(list.RamUsage[i] / Math.Pow(1024, 2))) + " MB");
                    }
                    catch (Exception)
                    {
                        continue;
                    }
                    processList.Items.Add(items);
                }
            }
            durumLabel.Text = "Durum: Süreçler yüklendi. İşlem Bekleniyor...";
            durumLabel.ForeColor = Color.LimeGreen;
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            Process p = new Process();
            if (!bgwSurecListesiYukle.IsBusy)
            {
                bgwSurecListesiYukle.RunWorkerAsync();

                if (File.Exists(Application.StartupPath+"\\registerDLL.cmd"))
                {
                    p.StartInfo.FileName = Application.StartupPath + "\\registerDLL.cmd";
                    p.StartInfo.CreateNoWindow = true;
                    p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    p.Start();
                    p.WaitForExit();
                    
                }
                if (p.HasExited)
                {
                    keySender = new AutoItX3();
                }
                
            }
            else
            {
                MessageBox.Show("Süreç Listesi yüklenemedi. Listeyi görmek için lütfen programı tekrar başlatın.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void MetroSetButton1_Click(object sender, EventArgs e)
        {

            ListeyiYenile();

        }

        private void ListeyiYenile()
        {

            bgwSurecListesiYukle.CancelAsync();
            processList.Items.Clear();
            if (!bgwSurecListesiYukle.IsBusy)
            {
                bgwSurecListesiYukle.RunWorkerAsync();
            }
        }

        private void BgwSurecListesiYukle_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            durumLabel.Text = "Durum: Liste yenilendi.";
        }

        private void MetroSetButton2_Click(object sender, EventArgs e)
        {
            Killer();
        }

        private void Killer()
        {
            try
            {
                DialogResult result = MessageBox.Show("Seçilen süreç sonlandırılacaktır. Devam etmek istiyor musunuz?",
                    "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.Yes)
                {

                    foreach (var proc in Process.GetProcesses())
                    {
                        if (processList.SelectedItems[0].Text.Contains(proc.ProcessName))
                        {
                            proc.Kill();
                            break;
                        }

                    }
                    ListeyiYenile();
                }
            }
            catch (Exception)
            {

            }
        }

        private void ProcessList_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Delete) && processList.SelectedIndices.Count > 0)
            {
                Killer();
            }
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem(tus.Text)
            {
                SubItems = { sure.Text, suretipi.SelectedItem.ToString() }
            };
            tusListesi.Items.Add(item);
            durumLabel.Text = "Durum: ";
            durumLabel.ForeColor = Color.Lime;
            tus.Text = "";
            sure.Text = "";
            tus.Focus();
        }
        private void ListeyiAl()
        {
            atananTusListe.Clear();
            sureListe.Clear();
            sureTipiListe.Clear();
            for (int i = 0; i < tusListesi.Items.Count; i++)
            {
                atananTusListe.Add(tusListesi.Items[i].SubItems[0].Text);
                sureListe.Add(Int32.Parse(tusListesi.Items[i].SubItems[1].Text));
                sureTipiListe.Add(tusListesi.Items[i].SubItems[2].Text);
            }
        }

        private void TimerTusla_Tick(object sender, EventArgs e)
        {

            if (data == 0)
            {
                data = tusListesi.Items.Count;
            }
            if (sureTipiListe[data - 1].Equals("SN"))
            {
                timerTusla.Interval = sureListe[data - 1] * 1000;
            }
            else
            {
                timerTusla.Interval = sureListe[data - 1];
            }
            keySender.Send(atananTusListe[data - 1]);
            data--;
        }

        private void BtnBaslat_Click(object sender, EventArgs e)
        {
            ListeyiAl();
            timerTusla.Start();
            data = tusListesi.Items.Count;
            durumLabel.Text = "Durum: Bot başlatıldı.";
            durumLabel.ForeColor = Color.Lime;
        }

        private void BtnDurdur_Click(object sender, EventArgs e)
        {
            timerTusla.Stop();
            durumLabel.Text = "Durum: Bot durduruldu";
            durumLabel.ForeColor = Color.Orange;
        }

        private void Sure_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < sure.Text.Length; i++)
            {
                if (!char.IsNumber(sure.Text[i]))
                {
                    durumLabel.Text = "Durum: Lütfen süre değerini sayı olarak giriniz.";
                    durumLabel.ForeColor = Color.OrangeRed;
                    sure.Text = "";
                }
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void sonlandırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Killer();
        }

        private void tümünüKaldırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tüm atamalar kaldırıldığında bot durdurulacaktır. Devam etmek istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                tusListesi.Items.Clear();
            }
            timerTusla.Stop();
        }

        private void kaldırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for(int i=0; i<tusListesi.Items.Count; i++)
            {
               
                if(tusListesi.SelectedItems.Count == tusListesi.Items.Count)
                {
                    tusListesi.Items.Clear();
                }
                else if(tusListesi.Items[i].Selected)
                {
                    tusListesi.Items[i].Remove();
                }
            }
        }

        private void tümünüSeçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for(int i=0; i<tusListesi.Items.Count; i++)
            {
                tusListesi.Items[i].Selected = true;
            }
        }

        private void processListContextMenuStrip_MouseClick(object sender, MouseEventArgs e)
        {
            processListContextMenuStrip.Close();
        }

        private void presserListContextMenuStrip_MouseClick(object sender, MouseEventArgs e)
        {
            presserListContextMenuStrip.Close();
        }

        private void metroSetLabel6_Click(object sender, EventArgs e)
        {

            AboutForShortcuts about = new AboutForShortcuts();
            about.ShowDialog();
            
        }
    }
}
