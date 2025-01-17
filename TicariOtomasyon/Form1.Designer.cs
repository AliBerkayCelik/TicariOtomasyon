﻿namespace TicariOtomasyon
{
	partial class Form1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
			this.btnAnaSayfa = new DevExpress.XtraBars.BarButtonItem();
			this.btnUrunler = new DevExpress.XtraBars.BarButtonItem();
			this.btnStoklar = new DevExpress.XtraBars.BarButtonItem();
			this.btnMusteriler = new DevExpress.XtraBars.BarButtonItem();
			this.btnFirmalar = new DevExpress.XtraBars.BarButtonItem();
			this.btnPersoneller = new DevExpress.XtraBars.BarButtonItem();
			this.btnGiderler = new DevExpress.XtraBars.BarButtonItem();
			this.btnKasa = new DevExpress.XtraBars.BarButtonItem();
			this.btnNotlar = new DevExpress.XtraBars.BarButtonItem();
			this.btnBankalar = new DevExpress.XtraBars.BarButtonItem();
			this.btnRehber = new DevExpress.XtraBars.BarButtonItem();
			this.btnFatura = new DevExpress.XtraBars.BarButtonItem();
			this.btnAyarlar = new DevExpress.XtraBars.BarButtonItem();
			this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
			this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
			((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
			this.SuspendLayout();
			// 
			// ribbonControl1
			// 
			this.ribbonControl1.ExpandCollapseItem.Id = 0;
			this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnAnaSayfa,
            this.btnUrunler,
            this.btnStoklar,
            this.btnMusteriler,
            this.btnFirmalar,
            this.btnPersoneller,
            this.btnGiderler,
            this.btnKasa,
            this.btnNotlar,
            this.btnBankalar,
            this.btnRehber,
            this.btnFatura,
            this.btnAyarlar});
			this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
			this.ribbonControl1.MaxItemId = 14;
			this.ribbonControl1.Name = "ribbonControl1";
			this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
			this.ribbonControl1.Size = new System.Drawing.Size(1223, 150);
			// 
			// btnAnaSayfa
			// 
			this.btnAnaSayfa.Caption = "ANA SAYFA";
			this.btnAnaSayfa.Id = 1;
			this.btnAnaSayfa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAnaSayfa.ImageOptions.LargeImage")));
			this.btnAnaSayfa.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnAnaSayfa.ItemAppearance.Normal.Options.UseFont = true;
			this.btnAnaSayfa.Name = "btnAnaSayfa";
			// 
			// btnUrunler
			// 
			this.btnUrunler.Caption = "ÜRÜNLER";
			this.btnUrunler.Id = 2;
			this.btnUrunler.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnUrunler.ImageOptions.LargeImage")));
			this.btnUrunler.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnUrunler.ItemAppearance.Normal.Options.UseFont = true;
			this.btnUrunler.Name = "btnUrunler";
			this.btnUrunler.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUrunler_ItemClick);
			// 
			// btnStoklar
			// 
			this.btnStoklar.Caption = "STOKLAR";
			this.btnStoklar.Id = 3;
			this.btnStoklar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnStoklar.ImageOptions.LargeImage")));
			this.btnStoklar.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnStoklar.ItemAppearance.Normal.Options.UseFont = true;
			this.btnStoklar.Name = "btnStoklar";
			// 
			// btnMusteriler
			// 
			this.btnMusteriler.Caption = "MÜŞTERİLER";
			this.btnMusteriler.Id = 4;
			this.btnMusteriler.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnMusteriler.ImageOptions.LargeImage")));
			this.btnMusteriler.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnMusteriler.ItemAppearance.Normal.Options.UseFont = true;
			this.btnMusteriler.Name = "btnMusteriler";
			this.btnMusteriler.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMusteriler_ItemClick);
			// 
			// btnFirmalar
			// 
			this.btnFirmalar.Caption = "FİRMALAR";
			this.btnFirmalar.Id = 5;
			this.btnFirmalar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnFirmalar.ImageOptions.LargeImage")));
			this.btnFirmalar.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnFirmalar.ItemAppearance.Normal.Options.UseFont = true;
			this.btnFirmalar.Name = "btnFirmalar";
			this.btnFirmalar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnFirmalar_ItemClick);
			// 
			// btnPersoneller
			// 
			this.btnPersoneller.Caption = "PERSONELLER";
			this.btnPersoneller.Id = 6;
			this.btnPersoneller.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPersoneller.ImageOptions.LargeImage")));
			this.btnPersoneller.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnPersoneller.ItemAppearance.Normal.Options.UseFont = true;
			this.btnPersoneller.Name = "btnPersoneller";
			this.btnPersoneller.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPersoneller_ItemClick);
			// 
			// btnGiderler
			// 
			this.btnGiderler.Caption = "GİDERLER";
			this.btnGiderler.Id = 7;
			this.btnGiderler.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGiderler.ImageOptions.LargeImage")));
			this.btnGiderler.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnGiderler.ItemAppearance.Normal.Options.UseFont = true;
			this.btnGiderler.Name = "btnGiderler";
			this.btnGiderler.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGiderler_ItemClick);
			// 
			// btnKasa
			// 
			this.btnKasa.Caption = "KASA";
			this.btnKasa.Id = 8;
			this.btnKasa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnKasa.ImageOptions.LargeImage")));
			this.btnKasa.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnKasa.ItemAppearance.Normal.Options.UseFont = true;
			this.btnKasa.Name = "btnKasa";
			// 
			// btnNotlar
			// 
			this.btnNotlar.Caption = "NOTLAR";
			this.btnNotlar.Id = 9;
			this.btnNotlar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnNotlar.ImageOptions.LargeImage")));
			this.btnNotlar.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnNotlar.ItemAppearance.Normal.Options.UseFont = true;
			this.btnNotlar.Name = "btnNotlar";
			// 
			// btnBankalar
			// 
			this.btnBankalar.Caption = "BANKALAR";
			this.btnBankalar.Id = 10;
			this.btnBankalar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnBankalar.ImageOptions.LargeImage")));
			this.btnBankalar.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnBankalar.ItemAppearance.Normal.Options.UseFont = true;
			this.btnBankalar.Name = "btnBankalar";
			this.btnBankalar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBankalar_ItemClick);
			// 
			// btnRehber
			// 
			this.btnRehber.Caption = "REHBER";
			this.btnRehber.Id = 11;
			this.btnRehber.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRehber.ImageOptions.LargeImage")));
			this.btnRehber.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnRehber.ItemAppearance.Normal.Options.UseFont = true;
			this.btnRehber.Name = "btnRehber";
			this.btnRehber.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRehber_ItemClick);
			// 
			// btnFatura
			// 
			this.btnFatura.Caption = "FATURA";
			this.btnFatura.Id = 12;
			this.btnFatura.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnFatura.ImageOptions.LargeImage")));
			this.btnFatura.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnFatura.ItemAppearance.Normal.Options.UseFont = true;
			this.btnFatura.Name = "btnFatura";
			// 
			// btnAyarlar
			// 
			this.btnAyarlar.Caption = "AYARLAR";
			this.btnAyarlar.Id = 13;
			this.btnAyarlar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAyarlar.ImageOptions.LargeImage")));
			this.btnAyarlar.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnAyarlar.ItemAppearance.Normal.Options.UseFont = true;
			this.btnAyarlar.Name = "btnAyarlar";
			// 
			// ribbonPage1
			// 
			this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
			this.ribbonPage1.Name = "ribbonPage1";
			this.ribbonPage1.Text = "TİCARİ OTOMASYON";
			// 
			// ribbonPageGroup1
			// 
			this.ribbonPageGroup1.ItemLinks.Add(this.btnAnaSayfa);
			this.ribbonPageGroup1.ItemLinks.Add(this.btnUrunler);
			this.ribbonPageGroup1.ItemLinks.Add(this.btnStoklar);
			this.ribbonPageGroup1.ItemLinks.Add(this.btnMusteriler);
			this.ribbonPageGroup1.ItemLinks.Add(this.btnFirmalar);
			this.ribbonPageGroup1.ItemLinks.Add(this.btnPersoneller);
			this.ribbonPageGroup1.ItemLinks.Add(this.btnGiderler);
			this.ribbonPageGroup1.ItemLinks.Add(this.btnKasa);
			this.ribbonPageGroup1.ItemLinks.Add(this.btnNotlar);
			this.ribbonPageGroup1.ItemLinks.Add(this.btnBankalar);
			this.ribbonPageGroup1.ItemLinks.Add(this.btnRehber);
			this.ribbonPageGroup1.ItemLinks.Add(this.btnFatura);
			this.ribbonPageGroup1.ItemLinks.Add(this.btnAyarlar);
			this.ribbonPageGroup1.Name = "ribbonPageGroup1";
			// 
			// xtraTabbedMdiManager1
			// 
			this.xtraTabbedMdiManager1.MdiParent = this;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1223, 757);
			this.Controls.Add(this.ribbonControl1);
			this.IsMdiContainer = true;
			this.Name = "Form1";
			this.Text = "Form1";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
		private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
		private DevExpress.XtraBars.BarButtonItem btnAnaSayfa;
		private DevExpress.XtraBars.BarButtonItem btnUrunler;
		private DevExpress.XtraBars.BarButtonItem btnStoklar;
		private DevExpress.XtraBars.BarButtonItem btnMusteriler;
		private DevExpress.XtraBars.BarButtonItem btnFirmalar;
		private DevExpress.XtraBars.BarButtonItem btnPersoneller;
		private DevExpress.XtraBars.BarButtonItem btnGiderler;
		private DevExpress.XtraBars.BarButtonItem btnKasa;
		private DevExpress.XtraBars.BarButtonItem btnNotlar;
		private DevExpress.XtraBars.BarButtonItem btnBankalar;
		private DevExpress.XtraBars.BarButtonItem btnRehber;
		private DevExpress.XtraBars.BarButtonItem btnFatura;
		private DevExpress.XtraBars.BarButtonItem btnAyarlar;
		private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
	}
}

