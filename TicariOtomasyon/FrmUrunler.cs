using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TicariOtomasyon
{
	public partial class FrmUrunler : Form
	{
		public FrmUrunler()
		{
			InitializeComponent();
		}

		sqlbaglanti bgl = new sqlbaglanti();

		void listele()
		{
			DataTable dt = new DataTable();
			SqlDataAdapter da = new SqlDataAdapter("Select * From TBLURUNLER",bgl.baglanti());
			da.Fill(dt);
			gridControl1.DataSource = dt;
		}
		private void FrmUrunler_Load(object sender, EventArgs e)
		{
			listele();
		}

		private void btnKaydet_Click(object sender, EventArgs e)
		{
			SqlCommand komut = new SqlCommand("insert into TBLURUNLER (URUNAD,MARKA,MODEL,YIL,ADET,ALISFIYAT,SATISFIYAT,DETAY) VALUES (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", bgl.baglanti());
			komut.Parameters.AddWithValue("@p1", txtAd.Text);
			komut.Parameters.AddWithValue("@p2", txtMarka.Text);
			komut.Parameters.AddWithValue("@p3", txtModel.Text);
			komut.Parameters.AddWithValue("@p4", mskYil.Text);
			komut.Parameters.AddWithValue("@p5", int.Parse((nudAdet.Value).ToString()));
			komut.Parameters.AddWithValue("@p6",decimal.Parse(txtAlis.Text));
			komut.Parameters.AddWithValue("@p7",decimal.Parse(txtSatis.Text));
			komut.Parameters.AddWithValue("@p8", rchDetay.Text);
			komut.ExecuteNonQuery();
			bgl.baglanti().Close();
			MessageBox.Show("Ürün Sisteme Eklendi");
			listele();
		}

		private void btnSil_Click(object sender, EventArgs e)
		{
			SqlCommand komut = new SqlCommand("Delete From TBLURUNLER where ID=@p1", bgl.baglanti());
			komut.Parameters.AddWithValue("@p1", txtID.Text);
			komut.ExecuteNonQuery();
			bgl.baglanti().Close();
			MessageBox.Show("Ürün Silindi");
			listele();
		}

		private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
		{
			DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
			txtID.Text = dr["ID"].ToString();
			txtAd.Text = dr["URUNAD"].ToString();
			txtMarka.Text = dr["MARKA"].ToString();
			txtModel.Text = dr["MODEL"].ToString();
			mskYil.Text = dr["YIL"].ToString();
			nudAdet.Value = decimal.Parse(dr["ADET"].ToString());
			txtAlis.Text = dr["ALISFIYAT"].ToString();
			txtSatis.Text = dr["SATISFIYAT"].ToString();
			rchDetay.Text = dr["DETAY"].ToString();
		}


		private void btnGüncelle_Click_1(object sender, EventArgs e)
		{
			SqlCommand komut = new SqlCommand("update TBLURUNLER set URUNAD=@P1,MARKA=@P2,MODEL=@P3,YIL=@P4,ADET=@P5,ALISFIYAT=@P6,SATISFIYAT=@P7,DETAY=@P8 where ID=@P9", bgl.baglanti());
			komut.Parameters.AddWithValue("@p1", txtAd.Text);
			komut.Parameters.AddWithValue("@p2", txtMarka.Text);
			komut.Parameters.AddWithValue("@p3", txtModel.Text);
			komut.Parameters.AddWithValue("@p4", mskYil.Text);
			komut.Parameters.AddWithValue("@p5", int.Parse((nudAdet.Value).ToString()));
			komut.Parameters.AddWithValue("@p6", decimal.Parse(txtAlis.Text));
			komut.Parameters.AddWithValue("@p7", decimal.Parse(txtSatis.Text));
			komut.Parameters.AddWithValue("@p8", rchDetay.Text);
			komut.Parameters.AddWithValue("@p9", txtID.Text);
			komut.ExecuteNonQuery();
			bgl.baglanti().Close();
			MessageBox.Show("Ürün Bilgisi Güncellendi");
			listele();
		}
	}
}
