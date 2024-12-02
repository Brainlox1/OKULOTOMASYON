namespace OKULOTOMASYON
{
    partial class frmnufuscuzdani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmnufuscuzdani));
            this.lblsoyad = new DevExpress.XtraEditors.LabelControl();
            this.lbltc = new DevExpress.XtraEditors.LabelControl();
            this.lbldogtar = new DevExpress.XtraEditors.LabelControl();
            this.lblad = new DevExpress.XtraEditors.LabelControl();
            this.lblcinsiyet = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblsoyad
            // 
            this.lblsoyad.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsoyad.Appearance.Options.UseFont = true;
            this.lblsoyad.Location = new System.Drawing.Point(267, 133);
            this.lblsoyad.Name = "lblsoyad";
            this.lblsoyad.Size = new System.Drawing.Size(102, 18);
            this.lblsoyad.TabIndex = 0;
            this.lblsoyad.Text = "labelControl1";
            // 
            // lbltc
            // 
            this.lbltc.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbltc.Appearance.Options.UseFont = true;
            this.lbltc.Location = new System.Drawing.Point(31, 133);
            this.lbltc.Name = "lbltc";
            this.lbltc.Size = new System.Drawing.Size(102, 18);
            this.lbltc.TabIndex = 0;
            this.lbltc.Text = "labelControl1";
            // 
            // lbldogtar
            // 
            this.lbldogtar.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbldogtar.Appearance.Options.UseFont = true;
            this.lbldogtar.Location = new System.Drawing.Point(267, 252);
            this.lbldogtar.Name = "lbldogtar";
            this.lbldogtar.Size = new System.Drawing.Size(102, 18);
            this.lbldogtar.TabIndex = 0;
            this.lbldogtar.Text = "labelControl1";
            // 
            // lblad
            // 
            this.lblad.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblad.Appearance.Options.UseFont = true;
            this.lblad.Location = new System.Drawing.Point(267, 192);
            this.lblad.Name = "lblad";
            this.lblad.Size = new System.Drawing.Size(102, 18);
            this.lblad.TabIndex = 0;
            this.lblad.Text = "labelControl1";
            // 
            // lblcinsiyet
            // 
            this.lblcinsiyet.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblcinsiyet.Appearance.Options.UseFont = true;
            this.lblcinsiyet.Location = new System.Drawing.Point(468, 252);
            this.lblcinsiyet.Name = "lblcinsiyet";
            this.lblcinsiyet.Size = new System.Drawing.Size(102, 18);
            this.lblcinsiyet.TabIndex = 0;
            this.lblcinsiyet.Text = "labelControl1";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Location = new System.Drawing.Point(31, 157);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(182, 187);
            this.pictureEdit1.TabIndex = 1;
            // 
            // frmnufuscuzdani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(754, 407);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.lbltc);
            this.Controls.Add(this.lblcinsiyet);
            this.Controls.Add(this.lblad);
            this.Controls.Add(this.lbldogtar);
            this.Controls.Add(this.lblsoyad);
            this.Name = "frmnufuscuzdani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmnufuscuzdani";
            this.Load += new System.EventHandler(this.frmnufuscuzdani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblsoyad;
        private DevExpress.XtraEditors.LabelControl lbltc;
        private DevExpress.XtraEditors.LabelControl lbldogtar;
        private DevExpress.XtraEditors.LabelControl lblad;
        private DevExpress.XtraEditors.LabelControl lblcinsiyet;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
    }
}