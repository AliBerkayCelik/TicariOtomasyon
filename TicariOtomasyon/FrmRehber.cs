using DevExpress.DirectX.Common.Direct2D;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicariOtomasyon
{
	public partial class FrmRehber : Form
	{
		public FrmRehber()
		{
			InitializeComponent();
		}
		sqlbaglanti bgl=new sqlbaglanti();

		//Müşteri Bilgileri
		void Musteri()
		{
			DataTable dt = new DataTable();
			SqlDataAdapter da = new SqlDataAdapter("Select AD,SOYAD,TELEFON,TELEFON2,MAIL from TBLMUSTERILER", bgl.baglanti());
			da.Fill(dt);
			gridControl1.DataSource = dt;
		}
		//Firma Bilgileri
		void Firma()
		{
			DataTable dt = new DataTable();
			SqlDataAdapter da = new SqlDataAdapter("Select AD,YETKILIADSOYAD,TELEFON1,TELEFON2,TELEFON3,MAIL,FAX from TBLFIRMALAR", bgl.baglanti());
			da.Fill(dt);
			gridControl2.DataSource = dt;
		}


		private void FrmRehber_Load(object sender, EventArgs e)
		{
			Musteri();
			Firma();
		}

		private void gridView1_DoubleClick(object sender, EventArgs e)
		{
			FrmMail frm = new FrmMail();
			DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

			if (dr != null)
			{
				frm.mail = dr["MAIL"].ToString();
			}
			frm.Show();
		}

		private void gridView2_DoubleClick(object sender, EventArgs e)
		{
			FrmMail frm = new FrmMail();
			DataRow dr = gridView2.GetDataRow(gridView2.FocusedRowHandle);

			if (dr != null)
			{
				frm.mail = dr["MAIL"].ToString();
			}
			frm.Show();
		}
	}
}
