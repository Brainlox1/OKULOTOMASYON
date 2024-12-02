namespace OKULOTOMASYON
{
    partial class frmveliler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmveliler));
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.msktelefon2 = new System.Windows.Forms.MaskedTextBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.msktelefon1 = new System.Windows.Forms.MaskedTextBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.btnkaydet = new DevExpress.XtraEditors.SimpleButton();
            this.btnguncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btntemizle = new DevExpress.XtraEditors.SimpleButton();
            this.btnsil = new DevExpress.XtraEditors.SimpleButton();
            this.txtmail = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.txtbabaad = new DevExpress.XtraEditors.TextEdit();
            this.txtannead = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbabaad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtannead.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(110, 29);
            this.txtID.Name = "txtID";
            this.txtID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtID.Properties.Appearance.Options.UseFont = true;
            this.txtID.Size = new System.Drawing.Size(150, 24);
            this.txtID.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(26, 119);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(65, 18);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "BABA AD:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(25, 77);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(66, 18);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "ANNE AD:";
            // 
            // msktelefon2
            // 
            this.msktelefon2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.msktelefon2.Location = new System.Drawing.Point(110, 180);
            this.msktelefon2.Mask = "(999) 000-0000";
            this.msktelefon2.Name = "msktelefon2";
            this.msktelefon2.Size = new System.Drawing.Size(150, 26);
            this.msktelefon2.TabIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(16, 154);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(75, 18);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "TELEFON1:";
            // 
            // msktelefon1
            // 
            this.msktelefon1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.msktelefon1.Location = new System.Drawing.Point(110, 146);
            this.msktelefon1.Mask = "(999) 000-0000";
            this.msktelefon1.Name = "msktelefon1";
            this.msktelefon1.Size = new System.Drawing.Size(150, 26);
            this.msktelefon1.TabIndex = 2;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(16, 188);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(75, 18);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "TELEFON2:";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(1596, 2);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(301, 657);
            this.xtraTabControl1.TabIndex = 3;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.groupControl1);
            this.xtraTabPage1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage1.ImageOptions.Image")));
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(299, 613);
            this.xtraTabPage1.Text = "Veli Bilgileri";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.groupControl3);
            this.groupControl1.Location = new System.Drawing.Point(4, 4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(292, 596);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "groupControl1";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.btnkaydet);
            this.groupControl3.Controls.Add(this.btnguncelle);
            this.groupControl3.Controls.Add(this.btntemizle);
            this.groupControl3.Controls.Add(this.btnsil);
            this.groupControl3.Controls.Add(this.txtmail);
            this.groupControl3.Controls.Add(this.labelControl10);
            this.groupControl3.Controls.Add(this.txtID);
            this.groupControl3.Controls.Add(this.labelControl1);
            this.groupControl3.Controls.Add(this.labelControl2);
            this.groupControl3.Controls.Add(this.msktelefon2);
            this.groupControl3.Controls.Add(this.labelControl3);
            this.groupControl3.Controls.Add(this.msktelefon1);
            this.groupControl3.Controls.Add(this.labelControl4);
            this.groupControl3.Controls.Add(this.txtbabaad);
            this.groupControl3.Controls.Add(this.txtannead);
            this.groupControl3.Controls.Add(this.labelControl7);
            this.groupControl3.Location = new System.Drawing.Point(1, 0);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.ShowCaption = false;
            this.groupControl3.Size = new System.Drawing.Size(292, 606);
            this.groupControl3.TabIndex = 3;
            this.groupControl3.Text = "groupControl3";
            // 
            // btnkaydet
            // 
            this.btnkaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnkaydet.ImageOptions.Image")));
            this.btnkaydet.Location = new System.Drawing.Point(87, 305);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(132, 33);
            this.btnkaydet.TabIndex = 7;
            this.btnkaydet.Text = "Kaydet";
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // btnguncelle
            // 
            this.btnguncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnguncelle.ImageOptions.Image")));
            this.btnguncelle.Location = new System.Drawing.Point(87, 386);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(132, 33);
            this.btnguncelle.TabIndex = 8;
            this.btnguncelle.Text = "Güncelle";
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // btntemizle
            // 
            this.btntemizle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btntemizle.ImageOptions.Image")));
            this.btntemizle.Location = new System.Drawing.Point(87, 425);
            this.btntemizle.Name = "btntemizle";
            this.btntemizle.Size = new System.Drawing.Size(132, 33);
            this.btntemizle.TabIndex = 9;
            this.btntemizle.Text = "Temizle";
            this.btntemizle.Click += new System.EventHandler(this.btntemizle_Click);
            // 
            // btnsil
            // 
            this.btnsil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnsil.ImageOptions.Image")));
            this.btnsil.Location = new System.Drawing.Point(87, 344);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(132, 33);
            this.btnsil.TabIndex = 10;
            this.btnsil.Text = "Sil";
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // txtmail
            // 
            this.txtmail.Location = new System.Drawing.Point(111, 227);
            this.txtmail.Name = "txtmail";
            this.txtmail.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtmail.Properties.Appearance.Options.UseFont = true;
            this.txtmail.Size = new System.Drawing.Size(150, 24);
            this.txtmail.TabIndex = 6;
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(52, 233);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(39, 18);
            this.labelControl10.TabIndex = 5;
            this.labelControl10.Text = "MAİL:";
            // 
            // txtbabaad
            // 
            this.txtbabaad.Location = new System.Drawing.Point(110, 113);
            this.txtbabaad.Name = "txtbabaad";
            this.txtbabaad.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtbabaad.Properties.Appearance.Options.UseFont = true;
            this.txtbabaad.Size = new System.Drawing.Size(150, 24);
            this.txtbabaad.TabIndex = 1;
            // 
            // txtannead
            // 
            this.txtannead.Location = new System.Drawing.Point(110, 71);
            this.txtannead.Name = "txtannead";
            this.txtannead.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtannead.Properties.Appearance.Options.UseFont = true;
            this.txtannead.Size = new System.Drawing.Size(150, 24);
            this.txtannead.TabIndex = 1;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(70, 35);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(21, 18);
            this.labelControl7.TabIndex = 0;
            this.labelControl7.Text = "ID:";
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.Name = "sqlDataSource1";
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.Appearance.Row.Options.UseBorderColor = true;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gridView1.FocusedRowObjectChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventHandler(this.gridView1_FocusedRowObjectChanged);
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(8, 2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1583, 657);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // frmveliler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 661);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmveliler";
            this.Text = "frmveliler";
            this.Load += new System.EventHandler(this.frmveliler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbabaad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtannead.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.TextEdit txtID;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.MaskedTextBox msktelefon2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.MaskedTextBox msktelefon1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.TextEdit txtbabaad;
        private DevExpress.XtraEditors.TextEdit txtannead;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraEditors.TextEdit txtmail;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.SimpleButton btnkaydet;
        private DevExpress.XtraEditors.SimpleButton btnguncelle;
        private DevExpress.XtraEditors.SimpleButton btntemizle;
        private DevExpress.XtraEditors.SimpleButton btnsil;
    }
}