namespace TicariOtomasyon
{
	partial class FrmUrunler
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUrunler));
			this.gridControl1 = new DevExpress.XtraGrid.GridControl();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
			this.btnGüncelle = new DevExpress.XtraEditors.SimpleButton();
			this.btnSil = new DevExpress.XtraEditors.SimpleButton();
			this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
			this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
			this.rchDetay = new System.Windows.Forms.RichTextBox();
			this.txtSatis = new DevExpress.XtraEditors.TextEdit();
			this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
			this.nudAdet = new System.Windows.Forms.NumericUpDown();
			this.txtAlis = new DevExpress.XtraEditors.TextEdit();
			this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
			this.txtModel = new DevExpress.XtraEditors.TextEdit();
			this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
			this.txtMarka = new DevExpress.XtraEditors.TextEdit();
			this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
			this.txtAd = new DevExpress.XtraEditors.TextEdit();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.mskYil = new System.Windows.Forms.MaskedTextBox();
			this.txtID = new DevExpress.XtraEditors.TextEdit();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
			this.groupControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtSatis.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudAdet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtAlis.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtModel.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtMarka.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtAd.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// gridControl1
			// 
			this.gridControl1.Location = new System.Drawing.Point(0, 0);
			this.gridControl1.MainView = this.gridView1;
			this.gridControl1.Name = "gridControl1";
			this.gridControl1.Size = new System.Drawing.Size(809, 703);
			this.gridControl1.TabIndex = 0;
			this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
			// 
			// gridView1
			// 
			this.gridView1.GridControl = this.gridControl1;
			this.gridView1.Name = "gridView1";
			this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
			// 
			// groupControl1
			// 
			this.groupControl1.Controls.Add(this.btnGüncelle);
			this.groupControl1.Controls.Add(this.btnSil);
			this.groupControl1.Controls.Add(this.btnKaydet);
			this.groupControl1.Controls.Add(this.labelControl9);
			this.groupControl1.Controls.Add(this.rchDetay);
			this.groupControl1.Controls.Add(this.txtSatis);
			this.groupControl1.Controls.Add(this.labelControl8);
			this.groupControl1.Controls.Add(this.labelControl7);
			this.groupControl1.Controls.Add(this.labelControl6);
			this.groupControl1.Controls.Add(this.nudAdet);
			this.groupControl1.Controls.Add(this.txtAlis);
			this.groupControl1.Controls.Add(this.labelControl5);
			this.groupControl1.Controls.Add(this.txtModel);
			this.groupControl1.Controls.Add(this.labelControl4);
			this.groupControl1.Controls.Add(this.txtMarka);
			this.groupControl1.Controls.Add(this.labelControl3);
			this.groupControl1.Controls.Add(this.txtAd);
			this.groupControl1.Controls.Add(this.labelControl2);
			this.groupControl1.Controls.Add(this.mskYil);
			this.groupControl1.Controls.Add(this.txtID);
			this.groupControl1.Controls.Add(this.labelControl1);
			this.groupControl1.Location = new System.Drawing.Point(813, 0);
			this.groupControl1.Name = "groupControl1";
			this.groupControl1.Size = new System.Drawing.Size(283, 703);
			this.groupControl1.TabIndex = 1;
			this.groupControl1.Text = "groupControl1";
			// 
			// btnGüncelle
			// 
			this.btnGüncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnGüncelle.Appearance.Options.UseFont = true;
			this.btnGüncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGüncelle.ImageOptions.Image")));
			this.btnGüncelle.Location = new System.Drawing.Point(23, 657);
			this.btnGüncelle.Name = "btnGüncelle";
			this.btnGüncelle.Size = new System.Drawing.Size(111, 35);
			this.btnGüncelle.TabIndex = 20;
			this.btnGüncelle.Text = "GÜNCELLE";
			this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click_1);
			// 
			// btnSil
			// 
			this.btnSil.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnSil.Appearance.Options.UseFont = true;
			this.btnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.ImageOptions.Image")));
			this.btnSil.Location = new System.Drawing.Point(155, 616);
			this.btnSil.Name = "btnSil";
			this.btnSil.Size = new System.Drawing.Size(121, 35);
			this.btnSil.TabIndex = 19;
			this.btnSil.Text = "SİL";
			this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
			// 
			// btnKaydet
			// 
			this.btnKaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnKaydet.Appearance.Options.UseFont = true;
			this.btnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.ImageOptions.Image")));
			this.btnKaydet.Location = new System.Drawing.Point(23, 616);
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
			this.labelControl9.Location = new System.Drawing.Point(39, 466);
			this.labelControl9.Name = "labelControl9";
			this.labelControl9.Size = new System.Drawing.Size(52, 18);
			this.labelControl9.TabIndex = 17;
			this.labelControl9.Text = "DETAY:";
			// 
			// rchDetay
			// 
			this.rchDetay.Location = new System.Drawing.Point(108, 466);
			this.rchDetay.Name = "rchDetay";
			this.rchDetay.Size = new System.Drawing.Size(168, 144);
			this.rchDetay.TabIndex = 16;
			this.rchDetay.Text = "";
			// 
			// txtSatis
			// 
			this.txtSatis.Location = new System.Drawing.Point(108, 419);
			this.txtSatis.Name = "txtSatis";
			this.txtSatis.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtSatis.Properties.Appearance.Options.UseFont = true;
			this.txtSatis.Size = new System.Drawing.Size(168, 24);
			this.txtSatis.TabIndex = 15;
			// 
			// labelControl8
			// 
			this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.labelControl8.Appearance.Options.UseFont = true;
			this.labelControl8.Location = new System.Drawing.Point(8, 422);
			this.labelControl8.Name = "labelControl8";
			this.labelControl8.Size = new System.Drawing.Size(94, 18);
			this.labelControl8.TabIndex = 14;
			this.labelControl8.Text = "SATIŞ FİYAT:";
			// 
			// labelControl7
			// 
			this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.labelControl7.Appearance.Options.UseFont = true;
			this.labelControl7.Location = new System.Drawing.Point(49, 316);
			this.labelControl7.Name = "labelControl7";
			this.labelControl7.Size = new System.Drawing.Size(42, 18);
			this.labelControl7.TabIndex = 13;
			this.labelControl7.Text = "ADET:";
			// 
			// labelControl6
			// 
			this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.labelControl6.Appearance.Options.UseFont = true;
			this.labelControl6.Location = new System.Drawing.Point(63, 259);
			this.labelControl6.Name = "labelControl6";
			this.labelControl6.Size = new System.Drawing.Size(28, 18);
			this.labelControl6.TabIndex = 12;
			this.labelControl6.Text = "YIL:";
			// 
			// nudAdet
			// 
			this.nudAdet.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.nudAdet.Location = new System.Drawing.Point(108, 314);
			this.nudAdet.Name = "nudAdet";
			this.nudAdet.Size = new System.Drawing.Size(168, 26);
			this.nudAdet.TabIndex = 11;
			// 
			// txtAlis
			// 
			this.txtAlis.Location = new System.Drawing.Point(108, 368);
			this.txtAlis.Name = "txtAlis";
			this.txtAlis.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtAlis.Properties.Appearance.Options.UseFont = true;
			this.txtAlis.Size = new System.Drawing.Size(168, 24);
			this.txtAlis.TabIndex = 10;
			// 
			// labelControl5
			// 
			this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.labelControl5.Appearance.Options.UseFont = true;
			this.labelControl5.Location = new System.Drawing.Point(8, 371);
			this.labelControl5.Name = "labelControl5";
			this.labelControl5.Size = new System.Drawing.Size(83, 18);
			this.labelControl5.TabIndex = 9;
			this.labelControl5.Text = "ALIŞ FİYAT:";
			// 
			// txtModel
			// 
			this.txtModel.Location = new System.Drawing.Point(108, 207);
			this.txtModel.Name = "txtModel";
			this.txtModel.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtModel.Properties.Appearance.Options.UseFont = true;
			this.txtModel.Size = new System.Drawing.Size(168, 24);
			this.txtModel.TabIndex = 8;
			// 
			// labelControl4
			// 
			this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.labelControl4.Appearance.Options.UseFont = true;
			this.labelControl4.Location = new System.Drawing.Point(38, 210);
			this.labelControl4.Name = "labelControl4";
			this.labelControl4.Size = new System.Drawing.Size(53, 18);
			this.labelControl4.TabIndex = 7;
			this.labelControl4.Text = "MODEL:";
			// 
			// txtMarka
			// 
			this.txtMarka.Location = new System.Drawing.Point(108, 148);
			this.txtMarka.Name = "txtMarka";
			this.txtMarka.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtMarka.Properties.Appearance.Options.UseFont = true;
			this.txtMarka.Size = new System.Drawing.Size(168, 24);
			this.txtMarka.TabIndex = 6;
			// 
			// labelControl3
			// 
			this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.labelControl3.Appearance.Options.UseFont = true;
			this.labelControl3.Location = new System.Drawing.Point(38, 151);
			this.labelControl3.Name = "labelControl3";
			this.labelControl3.Size = new System.Drawing.Size(53, 18);
			this.labelControl3.TabIndex = 5;
			this.labelControl3.Text = "MARKA:";
			// 
			// txtAd
			// 
			this.txtAd.Location = new System.Drawing.Point(108, 92);
			this.txtAd.Name = "txtAd";
			this.txtAd.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtAd.Properties.Appearance.Options.UseFont = true;
			this.txtAd.Size = new System.Drawing.Size(168, 24);
			this.txtAd.TabIndex = 4;
			// 
			// labelControl2
			// 
			this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.labelControl2.Appearance.Options.UseFont = true;
			this.labelControl2.Location = new System.Drawing.Point(67, 95);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(24, 18);
			this.labelControl2.TabIndex = 3;
			this.labelControl2.Text = "AD:";
			// 
			// mskYil
			// 
			this.mskYil.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.mskYil.Location = new System.Drawing.Point(108, 256);
			this.mskYil.Mask = "0000";
			this.mskYil.Name = "mskYil";
			this.mskYil.Size = new System.Drawing.Size(168, 26);
			this.mskYil.TabIndex = 2;
			this.mskYil.ValidatingType = typeof(int);
			// 
			// txtID
			// 
			this.txtID.Location = new System.Drawing.Point(108, 35);
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
			this.labelControl1.Location = new System.Drawing.Point(67, 38);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(21, 18);
			this.labelControl1.TabIndex = 0;
			this.labelControl1.Text = "ID:";
			// 
			// FrmUrunler
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1223, 757);
			this.Controls.Add(this.groupControl1);
			this.Controls.Add(this.gridControl1);
			this.Name = "FrmUrunler";
			this.Text = "Ürünler";
			this.Load += new System.EventHandler(this.FrmUrunler_Load);
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
			this.groupControl1.ResumeLayout(false);
			this.groupControl1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtSatis.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudAdet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtAlis.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtModel.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtMarka.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtAd.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraGrid.GridControl gridControl1;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.XtraEditors.GroupControl groupControl1;
		private DevExpress.XtraEditors.LabelControl labelControl7;
		private DevExpress.XtraEditors.LabelControl labelControl6;
		private System.Windows.Forms.NumericUpDown nudAdet;
		private DevExpress.XtraEditors.TextEdit txtAlis;
		private DevExpress.XtraEditors.LabelControl labelControl5;
		private DevExpress.XtraEditors.TextEdit txtModel;
		private DevExpress.XtraEditors.LabelControl labelControl4;
		private DevExpress.XtraEditors.TextEdit txtMarka;
		private DevExpress.XtraEditors.LabelControl labelControl3;
		private DevExpress.XtraEditors.TextEdit txtAd;
		private DevExpress.XtraEditors.LabelControl labelControl2;
		private System.Windows.Forms.MaskedTextBox mskYil;
		private DevExpress.XtraEditors.TextEdit txtID;
		private DevExpress.XtraEditors.LabelControl labelControl1;
		private DevExpress.XtraEditors.SimpleButton btnKaydet;
		private DevExpress.XtraEditors.LabelControl labelControl9;
		private System.Windows.Forms.RichTextBox rchDetay;
		private DevExpress.XtraEditors.TextEdit txtSatis;
		private DevExpress.XtraEditors.LabelControl labelControl8;
		private DevExpress.XtraEditors.SimpleButton btnSil;
		private DevExpress.XtraEditors.SimpleButton btnGüncelle;
	}
}