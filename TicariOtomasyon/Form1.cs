using System;
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
	}
}
