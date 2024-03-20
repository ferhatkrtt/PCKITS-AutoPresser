using MetroSet_UI.Forms;
using System;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
namespace PCKITSAutoPresser
{
    public partial class AboutForShortcuts : MetroSetForm
    {
        public AboutForShortcuts()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void AboutForShortcuts_Load(object sender, EventArgs e)
        {
            if(!backgroundWorker1.IsBusy)
            backgroundWorker1.RunWorkerAsync();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void lblClose_MouseEnter(object sender, EventArgs e)
        {
            lblClose.BackColor = Color.Red;
            lblClose.ForeColor = Color.White;
        }

        private void lblClose_MouseLeave(object sender, EventArgs e)
        {
            lblClose.BackColor = Color.FromArgb(30,30,30);
            lblClose.ForeColor = Color.FromArgb(170,170,170);
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            if (File.Exists("SendKeyList.txt"))
            {
                kisayol.Text = File.ReadAllText(Application.StartupPath + "\\SendKeyList.txt");

            }
            else
            {
                MessageBox.Show("Liste bulunamadı. Lütfen üretici ile iletişime geçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
