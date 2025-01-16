namespace TicariOtomasyon
{
	partial class FrmGiderler
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGiderler));
			this.btnTemizle = new DevExpress.XtraEditors.SimpleButton();
			this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
			this.rchNotlar = new System.Windows.Forms.RichTextBox();
			this.txtEkstra = new DevExpress.XtraEditors.TextEdit();
			this.cmbYil = new DevExpress.XtraEditors.ComboBoxEdit();
			this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
			this.btnGüncelle = new DevExpress.XtraEditors.SimpleButton();
			this.btnSil = new DevExpress.XtraEditors.SimpleButton();
			this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
			this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
			this.txtdogalGaz = new DevExpress.XtraEditors.TextEdit();
			this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
			this.txtElektirik = new DevExpress.XtraEditors.TextEdit();
			this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
			this.txtSu = new DevExpress.XtraEditors.TextEdit();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.txtID = new DevExpress.XtraEditors.TextEdit();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.gridControl1 = new DevExpress.XtraGrid.GridControl();
			this.cmbAy = new DevExpress.XtraEditors.ComboBoxEdit();
			this.txtInternet = new DevExpress.XtraEditors.TextEdit();
			this.txtMaaslar = new DevExpress.XtraEditors.TextEdit();
			((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
			this.groupControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtEkstra.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmbYil.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtdogalGaz.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtElektirik.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtSu.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmbAy.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtInternet.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtMaaslar.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// btnTemizle
			// 
			this.btnTemizle.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnTemizle.Appearance.Options.UseFont = true;
			this.btnTemizle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTemizle.ImageOptions.Image")));
			this.btnTemizle.Location = new System.Drawing.Point(165, 501);
			this.btnTemizle.Name = "btnTemizle";
			this.btnTemizle.Size = new System.Drawing.Size(111, 35);
			this.btnTemizle.TabIndex = 30;
			this.btnTemizle.Text = "TEMİZLE";
			this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
			// 
			// groupControl1
			// 
			this.groupControl1.Controls.Add(this.txtMaaslar);
			this.groupControl1.Controls.Add(this.txtInternet);
			this.groupControl1.Controls.Add(this.cmbAy);
			this.groupControl1.Controls.Add(this.btnTemizle);
			this.groupControl1.Controls.Add(this.rchNotlar);
			this.groupControl1.Controls.Add(this.txtEkstra);
			this.groupControl1.Controls.Add(this.cmbYil);
			this.groupControl1.Controls.Add(this.labelControl11);
			this.groupControl1.Controls.Add(this.labelControl10);
			this.groupControl1.Controls.Add(this.btnGüncelle);
			this.groupControl1.Controls.Add(this.btnSil);
			this.groupControl1.Controls.Add(this.btnKaydet);
			this.groupControl1.Controls.Add(this.labelControl9);
			this.groupControl1.Controls.Add(this.labelControl8);
			this.groupControl1.Controls.Add(this.labelControl7);
			this.groupControl1.Controls.Add(this.txtdogalGaz);
			this.groupControl1.Controls.Add(this.labelControl5);
			this.groupControl1.Controls.Add(this.labelControl4);
			this.groupControl1.Controls.Add(this.txtElektirik);
			this.groupControl1.Controls.Add(this.labelControl3);
			this.groupControl1.Controls.Add(this.txtSu);
			this.groupControl1.Controls.Add(this.labelControl2);
			this.groupControl1.Controls.Add(this.txtID);
			this.groupControl1.Controls.Add(this.labelControl1);
			this.groupControl1.Location = new System.Drawing.Point(755, 1);
			this.groupControl1.Name = "groupControl1";
			this.groupControl1.Size = new System.Drawing.Size(313, 558);
			this.groupControl1.TabIndex = 7;
			// 
			// rchNotlar
			// 
			this.rchNotlar.Location = new System.Drawing.Point(100, 304);
			this.rchNotlar.Name = "rchNotlar";
			this.rchNotlar.Size = new System.Drawing.Size(162, 131);
			this.rchNotlar.TabIndex = 28;
			this.rchNotlar.Text = "";
			// 
			// txtEkstra
			// 
			this.txtEkstra.Location = new System.Drawing.Point(100, 274);
			this.txtEkstra.Name = "txtEkstra";
			this.txtEkstra.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtEkstra.Properties.Appearance.Options.UseFont = true;
			this.txtEkstra.Size = new System.Drawing.Size(168, 24);
			this.txtEkstra.TabIndex = 27;
			// 
			// cmbYil
			// 
			this.cmbYil.Location = new System.Drawing.Point(100, 87);
			this.cmbYil.Name = "cmbYil";
			this.cmbYil.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.cmbYil.Properties.Appearance.Options.UseFont = true;
			this.cmbYil.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.cmbYil.Properties.Items.AddRange(new object[] {
            "2017",
            "2018",
            "2019"});
			this.cmbYil.Size = new System.Drawing.Size(168, 24);
			this.cmbYil.TabIndex = 25;
			// 
			// labelControl11
			// 
			this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.labelControl11.Appearance.Options.UseFont = true;
			this.labelControl11.Location = new System.Drawing.Point(37, 277);
			this.labelControl11.Name = "labelControl11";
			this.labelControl11.Size = new System.Drawing.Size(58, 18);
			this.labelControl11.TabIndex = 22;
			this.labelControl11.Text = "EKSTRA:";
			// 
			// labelControl10
			// 
			this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.labelControl10.Appearance.Options.UseFont = true;
			this.labelControl10.Location = new System.Drawing.Point(34, 315);
			this.labelControl10.Name = "labelControl10";
			this.labelControl10.Size = new System.Drawing.Size(61, 18);
			this.labelControl10.TabIndex = 21;
			this.labelControl10.Text = "NOTLAR:";
			// 
			// btnGüncelle
			// 
			this.btnGüncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnGüncelle.Appearance.Options.UseFont = true;
			this.btnGüncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGüncelle.ImageOptions.Image")));
			this.btnGüncelle.Location = new System.Drawing.Point(33, 501);
			this.btnGüncelle.Name = "btnGüncelle";
			this.btnGüncelle.Size = new System.Drawing.Size(111, 35);
			this.btnGüncelle.TabIndex = 20;
			this.btnGüncelle.Text = "GÜNCELLE";
			this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
			// 
			// btnSil
			// 
			this.btnSil.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnSil.Appearance.Options.UseFont = true;
			this.btnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.ImageOptions.Image")));
			this.btnSil.Location = new System.Drawing.Point(165, 450);
			this.btnSil.Name = "btnSil";
			this.btnSil.Size = new System.Drawing.Size(111, 35);
			this.btnSil.TabIndex = 19;
			this.btnSil.Text = "SİL";
			this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
			// 
			// btnKaydet
			// 
			this.btnKaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnKaydet.Appearance.Options.UseFont = true;
			this.btnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.ImageOptions.Image")));
			this.btnKaydet.Location = new System.Drawing.Point(33, 450);
			this.btnKaydet.Name = "btnKaydet";
			this.btnKaydet.Size = new System.Drawing.Size(111, 35);
			this.btnKaydet.TabIndex = 18;
			this.btnKaydet.Text = "KAYDET";
			this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
			// 
			// labelControl9
			// 
			this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.labelControl9.Appearance.Options.UseFont = true;
			this.labelControl9.Location = new System.Drawing.Point(27, 244);
			this.labelControl9.Name = "labelControl9";
			this.labelControl9.Size = new System.Drawing.Size(68, 18);
			this.labelControl9.TabIndex = 17;
			this.labelControl9.Text = "MAAŞLAR:";
			// 
			// labelControl8
			// 
			this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.labelControl8.Appearance.Options.UseFont = true;
			this.labelControl8.Location = new System.Drawing.Point(19, 217);
			this.labelControl8.Name = "labelControl8";
			this.labelControl8.Size = new System.Drawing.Size(76, 18);
			this.labelControl8.TabIndex = 14;
			this.labelControl8.Text = "İNTERNET:";
			// 
			// labelControl7
			// 
			this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.labelControl7.Appearance.Options.UseFont = true;
			this.labelControl7.Location = new System.Drawing.Point(72, 152);
			this.labelControl7.Name = "labelControl7";
			this.labelControl7.Size = new System.Drawing.Size(23, 18);
			this.labelControl7.TabIndex = 13;
			this.labelControl7.Text = "SU:";
			// 
			// txtdogalGaz
			// 
			this.txtdogalGaz.Location = new System.Drawing.Point(100, 184);
			this.txtdogalGaz.Name = "txtdogalGaz";
			this.txtdogalGaz.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtdogalGaz.Properties.Appearance.Options.UseFont = true;
			this.txtdogalGaz.Size = new System.Drawing.Size(168, 24);
			this.txtdogalGaz.TabIndex = 10;
			// 
			// labelControl5
			// 
			this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.labelControl5.Appearance.Options.UseFont = true;
			this.labelControl5.Location = new System.Drawing.Point(16, 187);
			this.labelControl5.Name = "labelControl5";
			this.labelControl5.Size = new System.Drawing.Size(79, 18);
			this.labelControl5.TabIndex = 9;
			this.labelControl5.Text = "DOĞALGAZ:";
			// 
			// labelControl4
			// 
			this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.labelControl4.Appearance.Options.UseFont = true;
			this.labelControl4.Location = new System.Drawing.Point(18, 122);
			this.labelControl4.Name = "labelControl4";
			this.labelControl4.Size = new System.Drawing.Size(77, 18);
			this.labelControl4.TabIndex = 7;
			this.labelControl4.Text = "ELEKTİRİK:";
			// 
			// txtElektirik
			// 
			this.txtElektirik.Location = new System.Drawing.Point(100, 119);
			this.txtElektirik.Name = "txtElektirik";
			this.txtElektirik.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtElektirik.Properties.Appearance.Options.UseFont = true;
			this.txtElektirik.Size = new System.Drawing.Size(168, 24);
			this.txtElektirik.TabIndex = 6;
			// 
			// labelControl3
			// 
			this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.labelControl3.Appearance.Options.UseFont = true;
			this.labelControl3.Location = new System.Drawing.Point(67, 92);
			this.labelControl3.Name = "labelControl3";
			this.labelControl3.Size = new System.Drawing.Size(28, 18);
			this.labelControl3.TabIndex = 5;
			this.labelControl3.Text = "YIL:";
			// 
			// txtSu
			// 
			this.txtSu.Location = new System.Drawing.Point(100, 151);
			this.txtSu.Name = "txtSu";
			this.txtSu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtSu.Properties.Appearance.Options.UseFont = true;
			this.txtSu.Size = new System.Drawing.Size(168, 24);
			this.txtSu.TabIndex = 4;
			// 
			// labelControl2
			// 
			this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.labelControl2.Appearance.Options.UseFont = true;
			this.labelControl2.Location = new System.Drawing.Point(71, 62);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(24, 18);
			this.labelControl2.TabIndex = 3;
			this.labelControl2.Text = "AY:";
			// 
			// txtID
			// 
			this.txtID.Location = new System.Drawing.Point(100, 30);
			this.txtID.Name = "txtID";
			this.txtID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtID.Properties.Appearance.Options.UseFont = true;
			this.txtID.Size = new System.Drawing.Size(168, 24);
			this.txtID.TabIndex = 1;
			// 
			// labelControl1
			// 
			this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.labelControl1.Appearance.Options.UseFont = true;
			this.labelControl1.Location = new System.Drawing.Point(74, 32);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(21, 18);
			this.labelControl1.TabIndex = 0;
			this.labelControl1.Text = "ID:";
			// 
			// gridView1
			// 
			this.gridView1.GridControl = this.gridControl1;
			this.gridView1.Name = "gridView1";
			this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
			// 
			// gridControl1
			// 
			this.gridControl1.Location = new System.Drawing.Point(0, -1);
			this.gridControl1.MainView = this.gridView1;
			this.gridControl1.Name = "gridControl1";
			this.gridControl1.Size = new System.Drawing.Size(753, 560);
			this.gridControl1.TabIndex = 6;
			this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
			// 
			// cmbAy
			// 
			this.cmbAy.Location = new System.Drawing.Point(101, 59);
			this.cmbAy.Name = "cmbAy";
			this.cmbAy.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.cmbAy.Properties.Appearance.Options.UseFont = true;
			this.cmbAy.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.cmbAy.Properties.Items.AddRange(new object[] {
            "Ocak",
            "Şubat",
            "Mart",
            "Nisan",
            "Mayıs",
            "Haziran",
            "Temmuz",
            "Ağustos",
            "Eylül",
            "Ekim",
            "Kasım",
            "Aralık"});
			this.cmbAy.Size = new System.Drawing.Size(168, 24);
			this.cmbAy.TabIndex = 31;
			// 
			// txtInternet
			// 
			this.txtInternet.Location = new System.Drawing.Point(100, 214);
			this.txtInternet.Name = "txtInternet";
			this.txtInternet.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtInternet.Properties.Appearance.Options.UseFont = true;
			this.txtInternet.Size = new System.Drawing.Size(168, 24);
			this.txtInternet.TabIndex = 32;
			// 
			// txtMaaslar
			// 
			this.txtMaaslar.Location = new System.Drawing.Point(100, 244);
			this.txtMaaslar.Name = "txtMaaslar";
			this.txtMaaslar.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtMaaslar.Properties.Appearance.Options.UseFont = true;
			this.txtMaaslar.Size = new System.Drawing.Size(168, 24);
			this.txtMaaslar.TabIndex = 33;
			// 
			// FrmGiderler
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1067, 559);
			this.Controls.Add(this.groupControl1);
			this.Controls.Add(this.gridControl1);
			this.Name = "FrmGiderler";
			this.Text = "FrmGiderler";
			this.Load += new System.EventHandler(this.FrmGiderler_Load);
			((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
			this.groupControl1.ResumeLayout(false);
			this.groupControl1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtEkstra.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmbYil.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtdogalGaz.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtElektirik.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtSu.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmbAy.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtInternet.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtMaaslar.Properties)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraEditors.SimpleButton btnTemizle;
		private DevExpress.XtraEditors.GroupControl groupControl1;
		private System.Windows.Forms.RichTextBox rchNotlar;
		private DevExpress.XtraEditors.TextEdit txtEkstra;
		private DevExpress.XtraEditors.ComboBoxEdit cmbYil;
		private DevExpress.XtraEditors.LabelControl labelControl11;
		private DevExpress.XtraEditors.LabelControl labelControl10;
		private DevExpress.XtraEditors.SimpleButton btnGüncelle;
		private DevExpress.XtraEditors.SimpleButton btnSil;
		private DevExpress.XtraEditors.SimpleButton btnKaydet;
		private DevExpress.XtraEditors.LabelControl labelControl9;
		private DevExpress.XtraEditors.LabelControl labelControl8;
		private DevExpress.XtraEditors.LabelControl labelControl7;
		private DevExpress.XtraEditors.TextEdit txtdogalGaz;
		private DevExpress.XtraEditors.LabelControl labelControl5;
		private DevExpress.XtraEditors.LabelControl labelControl4;
		private DevExpress.XtraEditors.TextEdit txtElektirik;
		private DevExpress.XtraEditors.LabelControl labelControl3;
		private DevExpress.XtraEditors.TextEdit txtSu;
		private DevExpress.XtraEditors.LabelControl labelControl2;
		private DevExpress.XtraEditors.TextEdit txtID;
		private DevExpress.XtraEditors.LabelControl labelControl1;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.XtraGrid.GridControl gridControl1;
		private DevExpress.XtraEditors.TextEdit txtMaaslar;
		private DevExpress.XtraEditors.TextEdit txtInternet;
		private DevExpress.XtraEditors.ComboBoxEdit cmbAy;
	}
}