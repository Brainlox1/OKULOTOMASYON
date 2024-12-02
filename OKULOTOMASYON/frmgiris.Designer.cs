namespace OKULOTOMASYON
{
    partial class frmgiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmgiris));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtsifre = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.msktc = new System.Windows.Forms.MaskedTextBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnyonetici = new System.Windows.Forms.Button();
            this.btnogretmen = new System.Windows.Forms.Button();
            this.btnogrenci = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtsifre.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1017, 61);
            this.panel1.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(184, 5);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(671, 53);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ATATÜRK ORTAOKULU GİRİŞ PANELİ";
            // 
            // txtsifre
            // 
            this.txtsifre.Location = new System.Drawing.Point(700, 564);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Properties.UseSystemPasswordChar = true;
            this.txtsifre.Size = new System.Drawing.Size(100, 20);
            this.txtsifre.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(255, 559);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(97, 25);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Kullanıcı:";
            // 
            // msktc
            // 
            this.msktc.Location = new System.Drawing.Point(358, 564);
            this.msktc.Mask = "00000000000";
            this.msktc.Name = "msktc";
            this.msktc.Size = new System.Drawing.Size(110, 20);
            this.msktc.TabIndex = 3;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(638, 559);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(56, 25);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Şifre:";
            // 
            // btnyonetici
            // 
            this.btnyonetici.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnyonetici.BackgroundImage")));
            this.btnyonetici.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnyonetici.Location = new System.Drawing.Point(255, 600);
            this.btnyonetici.Name = "btnyonetici";
            this.btnyonetici.Size = new System.Drawing.Size(177, 105);
            this.btnyonetici.TabIndex = 4;
            this.btnyonetici.UseVisualStyleBackColor = true;
            this.btnyonetici.Click += new System.EventHandler(this.btnyonetici_Click);
            // 
            // btnogretmen
            // 
            this.btnogretmen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnogretmen.BackgroundImage")));
            this.btnogretmen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnogretmen.Location = new System.Drawing.Point(438, 600);
            this.btnogretmen.Name = "btnogretmen";
            this.btnogretmen.Size = new System.Drawing.Size(178, 105);
            this.btnogretmen.TabIndex = 4;
            this.btnogretmen.UseVisualStyleBackColor = true;
            this.btnogretmen.Click += new System.EventHandler(this.btnogretmen_Click);
            // 
            // btnogrenci
            // 
            this.btnogrenci.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnogrenci.BackgroundImage")));
            this.btnogrenci.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnogrenci.Location = new System.Drawing.Point(622, 600);
            this.btnogrenci.Name = "btnogrenci";
            this.btnogrenci.Size = new System.Drawing.Size(179, 105);
            this.btnogrenci.TabIndex = 4;
            this.btnogrenci.UseVisualStyleBackColor = true;
            // 
            // frmgiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1041, 717);
            this.Controls.Add(this.btnogrenci);
            this.Controls.Add(this.btnogretmen);
            this.Controls.Add(this.btnyonetici);
            this.Controls.Add(this.msktc);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.MinimizeBox = false;
            this.Name = "frmgiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ATATÜRK ORTAOKULU GİRİŞ FORMU";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtsifre.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtsifre;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.MaskedTextBox msktc;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.Button btnyonetici;
        private System.Windows.Forms.Button btnogretmen;
        private System.Windows.Forms.Button btnogrenci;
    }
}