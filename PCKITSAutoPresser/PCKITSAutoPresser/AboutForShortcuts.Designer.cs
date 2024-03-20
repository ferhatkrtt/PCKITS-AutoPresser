namespace PCKITSAutoPresser
{
    partial class AboutForShortcuts
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
            this.kisayol = new MetroSet_UI.Controls.MetroSetRichTextBox();
            this.metroSetLabel1 = new MetroSet_UI.Controls.MetroSetLabel();
            this.lblClose = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // kisayol
            // 
            this.kisayol.AutoWordSelection = false;
            this.kisayol.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.kisayol.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.kisayol.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.kisayol.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.kisayol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.kisayol.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.kisayol.IsDerivedStyle = true;
            this.kisayol.Lines = null;
            this.kisayol.Location = new System.Drawing.Point(15, 148);
            this.kisayol.MaxLength = 32767;
            this.kisayol.Name = "kisayol";
            this.kisayol.ReadOnly = true;
            this.kisayol.Size = new System.Drawing.Size(759, 396);
            this.kisayol.Style = MetroSet_UI.Enums.Style.Dark;
            this.kisayol.StyleManager = null;
            this.kisayol.TabIndex = 0;
            this.kisayol.ThemeAuthor = "Narwin";
            this.kisayol.ThemeName = "MetroDark";
            this.kisayol.WordWrap = true;
            // 
            // metroSetLabel1
            // 
            this.metroSetLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.metroSetLabel1.IsDerivedStyle = true;
            this.metroSetLabel1.Location = new System.Drawing.Point(15, 109);
            this.metroSetLabel1.Name = "metroSetLabel1";
            this.metroSetLabel1.Size = new System.Drawing.Size(759, 23);
            this.metroSetLabel1.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetLabel1.StyleManager = null;
            this.metroSetLabel1.TabIndex = 1;
            this.metroSetLabel1.Text = "Aşağıda kullanabileceğiniz kısayolların listesi bulunmaktadır.";
            this.metroSetLabel1.ThemeAuthor = "Narwin";
            this.metroSetLabel1.ThemeName = "MetroDark";
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClose.Font = new System.Drawing.Font("Verdana", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.lblClose.Location = new System.Drawing.Point(759, 4);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(22, 20);
            this.lblClose.TabIndex = 2;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            this.lblClose.MouseEnter += new System.EventHandler(this.lblClose_MouseEnter);
            this.lblClose.MouseLeave += new System.EventHandler(this.lblClose_MouseLeave);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // AboutForShortcuts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(789, 559);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.metroSetLabel1);
            this.Controls.Add(this.kisayol);
            this.Name = "AboutForShortcuts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Style = MetroSet_UI.Enums.Style.Dark;
            this.Text = "Kısayollar Hakknda";
            this.TextColor = System.Drawing.Color.White;
            this.ThemeName = "MetroDark";
            this.Load += new System.EventHandler(this.AboutForShortcuts_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroSet_UI.Controls.MetroSetRichTextBox kisayol;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel1;
        private System.Windows.Forms.Label lblClose;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}