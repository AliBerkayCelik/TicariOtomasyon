﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicariOtomasyon
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		FrmUrunler fr=new FrmUrunler();
		private void btnUrunler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			
				fr.MdiParent = this;
				fr.Show();
			
			

		}
		Musteriler fr2 = new Musteriler();
		private void btnMusteriler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			fr2.MdiParent = this;
			fr2.Show();
		}
		FrmFirmalar fr3 = new FrmFirmalar();
		private void btnFirmalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			fr3.MdiParent = this;
			fr3.Show();
		}
		FrmPersonel fr4 = new FrmPersonel();
		private void btnPersoneller_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			fr4.MdiParent = this;
			fr4.Show();
		}
		FrmRehber fr5 = new FrmRehber();
		private void btnRehber_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			fr5.MdiParent = this;
			fr5.Show();
		}
		FrmGiderler fr6 = new FrmGiderler();
		private void btnGiderler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			fr6.MdiParent = this;
			fr6.Show();
		}
		FrmBankalar fr7 = new FrmBankalar();
		private void btnBankalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			fr7.MdiParent = this;
			fr7.Show();
		}
	}
}
