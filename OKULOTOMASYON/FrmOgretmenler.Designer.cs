namespace OKULOTOMASYON
{
    partial class FrmOgretmenler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOgretmenler));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.pcrresim = new System.Windows.Forms.PictureBox();
            this.cmbbrans = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            this.cmbilce = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cmbil = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.msktelefon = new System.Windows.Forms.MaskedTextBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.msktc = new System.Windows.Forms.MaskedTextBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtsoyad = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtad = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnkaydet = new DevExpress.XtraEditors.SimpleButton();
            this.btnguncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btntemizle = new DevExpress.XtraEditors.SimpleButton();
            this.btnsil = new DevExpress.XtraEditors.SimpleButton();
            this.btnresimsec = new DevExpress.XtraEditors.SimpleButton();
            this.rchadres = new System.Windows.Forms.RichTextBox();
            this.txtmail = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcrresim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbbrans.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbilce.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbil.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsoyad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtad.Properties)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtmail.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(3, 2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1583, 657);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
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
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(1591, 2);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(301, 657);
            this.xtraTabControl1.TabIndex = 1;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            this.xtraTabControl1.Click += new System.EventHandler(this.xtraTabControl1_Click);
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.groupControl1);
            this.xtraTabPage1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage1.ImageOptions.Image")));
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(299, 613);
            this.xtraTabPage1.Text = "Öğretmen Bilgi-1";
            this.xtraTabPage1.Paint += new System.Windows.Forms.PaintEventHandler(this.xtraTabPage1_Paint);
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
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.pcrresim);
            this.groupControl3.Controls.Add(this.cmbbrans);
            this.groupControl3.Controls.Add(this.txtID);
            this.groupControl3.Controls.Add(this.cmbilce);
            this.groupControl3.Controls.Add(this.labelControl1);
            this.groupControl3.Controls.Add(this.cmbil);
            this.groupControl3.Controls.Add(this.labelControl2);
            this.groupControl3.Controls.Add(this.msktelefon);
            this.groupControl3.Controls.Add(this.labelControl3);
            this.groupControl3.Controls.Add(this.msktc);
            this.groupControl3.Controls.Add(this.labelControl4);
            this.groupControl3.Controls.Add(this.txtsoyad);
            this.groupControl3.Controls.Add(this.labelControl5);
            this.groupControl3.Controls.Add(this.txtad);
            this.groupControl3.Controls.Add(this.labelControl7);
            this.groupControl3.Controls.Add(this.labelControl8);
            this.groupControl3.Controls.Add(this.labelControl6);
            this.groupControl3.Location = new System.Drawing.Point(0, 0);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.ShowCaption = false;
            this.groupControl3.Size = new System.Drawing.Size(292, 606);
            this.groupControl3.TabIndex = 3;
            this.groupControl3.Text = "groupControl3";
            this.groupControl3.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl3_Paint);
            // 
            // pcrresim
            // 
            this.pcrresim.Location = new System.Drawing.Point(13, 19);
            this.pcrresim.Name = "pcrresim";
            this.pcrresim.Size = new System.Drawing.Size(114, 121);
            this.pcrresim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcrresim.TabIndex = 3;
            this.pcrresim.TabStop = false;
            this.pcrresim.Click += new System.EventHandler(this.pcrresim_Click);
            // 
            // cmbbrans
            // 
            this.cmbbrans.Location = new System.Drawing.Point(107, 434);
            this.cmbbrans.Name = "cmbbrans";
            this.cmbbrans.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbbrans.Properties.Appearance.Options.UseFont = true;
            this.cmbbrans.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbbrans.Size = new System.Drawing.Size(150, 24);
            this.cmbbrans.TabIndex = 2;
            this.cmbbrans.SelectedIndexChanged += new System.EventHandler(this.cmbbrans_SelectedIndexChanged);
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(107, 168);
            this.txtID.Name = "txtID";
            this.txtID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtID.Properties.Appearance.Options.UseFont = true;
            this.txtID.Size = new System.Drawing.Size(150, 24);
            this.txtID.TabIndex = 1;
            this.txtID.EditValueChanged += new System.EventHandler(this.txtID_EditValueChanged);
            // 
            // cmbilce
            // 
            this.cmbilce.Location = new System.Drawing.Point(107, 396);
            this.cmbilce.Name = "cmbilce";
            this.cmbilce.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbilce.Properties.Appearance.Options.UseFont = true;
            this.cmbilce.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbilce.Size = new System.Drawing.Size(150, 24);
            this.cmbilce.TabIndex = 2;
            this.cmbilce.SelectedIndexChanged += new System.EventHandler(this.cmbilce_SelectedIndexChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(25, 258);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(53, 18);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "SOYAD:";
            this.labelControl1.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // cmbil
            // 
            this.cmbil.Location = new System.Drawing.Point(107, 360);
            this.cmbil.Name = "cmbil";
            this.cmbil.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbil.Properties.Appearance.Options.UseFont = true;
            this.cmbil.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbil.Size = new System.Drawing.Size(150, 24);
            this.cmbil.TabIndex = 2;
            this.cmbil.SelectedIndexChanged += new System.EventHandler(this.cmbil_SelectedIndexChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(54, 213);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(24, 18);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "AD:";
            this.labelControl2.Click += new System.EventHandler(this.labelControl2_Click);
            // 
            // msktelefon
            // 
            this.msktelefon.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.msktelefon.Location = new System.Drawing.Point(107, 319);
            this.msktelefon.Mask = "(999) 000-0000";
            this.msktelefon.Name = "msktelefon";
            this.msktelefon.Size = new System.Drawing.Size(150, 26);
            this.msktelefon.TabIndex = 2;
            this.msktelefon.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.msktelefon_MaskInputRejected);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(54, 293);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(24, 18);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "TC:";
            this.labelControl3.Click += new System.EventHandler(this.labelControl3_Click);
            // 
            // msktc
            // 
            this.msktc.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.msktc.Location = new System.Drawing.Point(107, 285);
            this.msktc.Mask = "00000000000";
            this.msktc.Name = "msktc";
            this.msktc.Size = new System.Drawing.Size(150, 26);
            this.msktc.TabIndex = 2;
            this.msktc.ValidatingType = typeof(int);
            this.msktc.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.msktc_MaskInputRejected);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(13, 327);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(67, 18);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "TELEFON:";
            this.labelControl4.Click += new System.EventHandler(this.labelControl4_Click);
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(107, 252);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsoyad.Properties.Appearance.Options.UseFont = true;
            this.txtsoyad.Size = new System.Drawing.Size(150, 24);
            this.txtsoyad.TabIndex = 1;
            this.txtsoyad.EditValueChanged += new System.EventHandler(this.txtsoyad_EditValueChanged);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(28, 440);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(50, 18);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "BRANŞ:";
            this.labelControl5.Click += new System.EventHandler(this.labelControl5_Click);
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(107, 210);
            this.txtad.Name = "txtad";
            this.txtad.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtad.Properties.Appearance.Options.UseFont = true;
            this.txtad.Size = new System.Drawing.Size(150, 24);
            this.txtad.TabIndex = 1;
            this.txtad.EditValueChanged += new System.EventHandler(this.txtad_EditValueChanged);
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(57, 171);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(21, 18);
            this.labelControl7.TabIndex = 0;
            this.labelControl7.Text = "ID:";
            this.labelControl7.Click += new System.EventHandler(this.labelControl7_Click);
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(43, 402);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(35, 18);
            this.labelControl8.TabIndex = 0;
            this.labelControl8.Text = "İLÇE:";
            this.labelControl8.Click += new System.EventHandler(this.labelControl8_Click);
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(54, 366);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(18, 18);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "İL:";
            this.labelControl6.Click += new System.EventHandler(this.labelControl6_Click);
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.groupControl2);
            this.xtraTabPage2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage2.ImageOptions.Image")));
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(299, 613);
            this.xtraTabPage2.Text = "Ögretmen Bilgi-2";
            this.xtraTabPage2.Paint += new System.Windows.Forms.PaintEventHandler(this.xtraTabPage2_Paint);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btnkaydet);
            this.groupControl2.Controls.Add(this.btnguncelle);
            this.groupControl2.Controls.Add(this.btntemizle);
            this.groupControl2.Controls.Add(this.btnsil);
            this.groupControl2.Controls.Add(this.btnresimsec);
            this.groupControl2.Controls.Add(this.rchadres);
            this.groupControl2.Controls.Add(this.txtmail);
            this.groupControl2.Controls.Add(this.labelControl9);
            this.groupControl2.Controls.Add(this.labelControl10);
            this.groupControl2.Location = new System.Drawing.Point(3, 4);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.ShowCaption = false;
            this.groupControl2.Size = new System.Drawing.Size(292, 596);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "groupControl2";
            this.groupControl2.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl2_Paint);
            // 
            // btnkaydet
            // 
            this.btnkaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnkaydet.ImageOptions.Image")));
            this.btnkaydet.Location = new System.Drawing.Point(113, 266);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(132, 33);
            this.btnkaydet.TabIndex = 6;
            this.btnkaydet.Text = "Kaydet";
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // btnguncelle
            // 
            this.btnguncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnguncelle.ImageOptions.Image")));
            this.btnguncelle.Location = new System.Drawing.Point(113, 347);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(132, 33);
            this.btnguncelle.TabIndex = 6;
            this.btnguncelle.Text = "Güncelle";
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // btntemizle
            // 
            this.btntemizle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btntemizle.ImageOptions.Image")));
            this.btntemizle.Location = new System.Drawing.Point(113, 386);
            this.btntemizle.Name = "btntemizle";
            this.btntemizle.Size = new System.Drawing.Size(132, 33);
            this.btntemizle.TabIndex = 6;
            this.btntemizle.Text = "Temizle";
            this.btntemizle.Click += new System.EventHandler(this.btntemizle_Click);
            // 
            // btnsil
            // 
            this.btnsil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnsil.ImageOptions.Image")));
            this.btnsil.Location = new System.Drawing.Point(113, 305);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(132, 33);
            this.btnsil.TabIndex = 6;
            this.btnsil.Text = "Sil";
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnresimsec
            // 
            this.btnresimsec.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnresimsec.ImageOptions.Image")));
            this.btnresimsec.Location = new System.Drawing.Point(113, 227);
            this.btnresimsec.Name = "btnresimsec";
            this.btnresimsec.Size = new System.Drawing.Size(132, 33);
            this.btnresimsec.TabIndex = 6;
            this.btnresimsec.Text = "Resim Seç";
            this.btnresimsec.Click += new System.EventHandler(this.btnresimsec_Click);
            // 
            // rchadres
            // 
            this.rchadres.Location = new System.Drawing.Point(95, 125);
            this.rchadres.Name = "rchadres";
            this.rchadres.Size = new System.Drawing.Size(150, 96);
            this.rchadres.TabIndex = 5;
            this.rchadres.Text = "";
            this.rchadres.TextChanged += new System.EventHandler(this.rchadres_TextChanged);
            // 
            // txtmail
            // 
            this.txtmail.Location = new System.Drawing.Point(95, 73);
            this.txtmail.Name = "txtmail";
            this.txtmail.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtmail.Properties.Appearance.Options.UseFont = true;
            this.txtmail.Size = new System.Drawing.Size(150, 24);
            this.txtmail.TabIndex = 4;
            this.txtmail.EditValueChanged += new System.EventHandler(this.txtmail_EditValueChanged);
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(35, 124);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(49, 18);
            this.labelControl9.TabIndex = 2;
            this.labelControl9.Text = "ADRES:";
            this.labelControl9.Click += new System.EventHandler(this.labelControl9_Click);
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(45, 79);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(39, 18);
            this.labelControl10.TabIndex = 3;
            this.labelControl10.Text = "MAİL:";
            this.labelControl10.Click += new System.EventHandler(this.labelControl10_Click);
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.Name = "sqlDataSource1";
            // 
            // FrmOgretmenler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 661);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "FrmOgretmenler";
            this.Text = "FrmOgretmenler";
            this.Load += new System.EventHandler(this.FrmOgretmenler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcrresim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbbrans.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbilce.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbil.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsoyad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtad.Properties)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtmail.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.TextEdit txtsoyad;
        private DevExpress.XtraEditors.TextEdit txtad;
        private DevExpress.XtraEditors.TextEdit txtID;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.ComboBoxEdit cmbbrans;
        private DevExpress.XtraEditors.ComboBoxEdit cmbilce;
        private DevExpress.XtraEditors.ComboBoxEdit cmbil;
        private System.Windows.Forms.MaskedTextBox msktelefon;
        private System.Windows.Forms.MaskedTextBox msktc;
        private DevExpress.XtraEditors.SimpleButton btnkaydet;
        private DevExpress.XtraEditors.SimpleButton btnguncelle;
        private DevExpress.XtraEditors.SimpleButton btntemizle;
        private DevExpress.XtraEditors.SimpleButton btnsil;
        private DevExpress.XtraEditors.SimpleButton btnresimsec;
        private System.Windows.Forms.RichTextBox rchadres;
        private DevExpress.XtraEditors.TextEdit txtmail;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private System.Windows.Forms.PictureBox pcrresim;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
    }
}