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
	public partial class FrmPersonel : Form
	{
		public FrmPersonel()
		{
			InitializeComponent();
		}
		sqlbaglanti bgl = new sqlbaglanti();
		void personelListe()
		{
			DataTable dt = new DataTable();
			SqlDataAdapter da = new SqlDataAdapter("Select * From TBLPERSONELLER",bgl.baglanti());
			da.Fill(dt);
			gridControl1.DataSource = dt;
		}
		void sehirListesi()
		{
			SqlCommand komut = new SqlCommand("select SEHIR From TBLILLER", bgl.baglanti());
			SqlDataReader dr = komut.ExecuteReader();
			while (dr.Read())
			{
				cmbil.Properties.Items.Add(dr[0]);
			}
			bgl.baglanti().Close();
		}
		void temizle()
		{
			txtID.Text = "";
			txtAd.Text = "";
			txtGorev.Text = "";
			txtSoyad.Text = "";
			txtMail.Text = "";
			mskTC.Text = "";
			mskTel.Text = "";
			cmbil.Text = "";
			cmbilce.Text = "";
			rchAdres.Text = "";
		}
		private void FrmPersonel_Load(object sender, EventArgs e)
		{
			personelListe();
			sehirListesi();
			temizle();
		}

		private void btnKaydet_Click(object sender, EventArgs e)
		{
			SqlCommand komut = new SqlCommand("insert into TBLPERSONELLER (AD,SOYAD,TELEFON,TC,MAIL,IL,ILCE,ADRES,GOREV) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", bgl.baglanti());
			komut.Parameters.AddWithValue("@p1", txtAd.Text);
			komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
			komut.Parameters.AddWithValue("@p3", mskTel.Text);
			komut.Parameters.AddWithValue("@p4", mskTC.Text);
			komut.Parameters.AddWithValue("@p5", txtMail.Text);
			komut.Parameters.AddWithValue("@p6", cmbil.Text);
			komut.Parameters.AddWithValue("@p7", cmbilce.Text);
			komut.Parameters.AddWithValue("@p8", rchAdres.Text);
			komut.Parameters.AddWithValue("@p9", txtGorev.Text);
			komut.ExecuteNonQuery();
			bgl.baglanti().Close();
			MessageBox.Show("Personel Sisteme Eklendi");
			personelListe();
		}

		private void cmbil_SelectedIndexChanged(object sender, EventArgs e)
		{
			cmbilce.Properties.Items.Clear();
			SqlCommand komut = new SqlCommand("select ILCE from TBLILCELER where SEHIR=@p1", bgl.baglanti());
			komut.Parameters.AddWithValue("@p1", cmbil.SelectedIndex + 1);
			SqlDataReader dr = komut.ExecuteReader();
			while (dr.Read())
			{
				cmbilce.Properties.Items.Add(dr[0]);
			}
			bgl.baglanti().Close();
		}

		private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
		{
			DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
			txtID.Text = dr["ID"].ToString();
			txtAd.Text = dr["AD"].ToString();
			txtSoyad.Text = dr["SOYAD"].ToString();
			mskTel.Text = dr["TELEFON"].ToString();
			mskTC.Text = dr["TC"].ToString();
			txtMail.Text = dr["MAIL"].ToString();
			cmbil.Text = dr["IL"].ToString();
			cmbilce.Text = dr["ILCE"].ToString();
			rchAdres.Text = dr["ADRES"].ToString();
			txtGorev.Text = dr["GOREV"].ToString();
		}

		private void btnTemizle_Click(object sender, EventArgs e)
		{
			temizle();
		}

		private void btnSil_Click(object sender, EventArgs e)
		{
			SqlCommand komut = new SqlCommand("Delete From TBLPERSONELLER where ID=@P1", bgl.baglanti());
			komut.Parameters.AddWithValue("@P1", txtID.Text);
			komut.ExecuteNonQuery();
			bgl.baglanti().Close();
			personelListe();
			MessageBox.Show("Personel Silindi");
			temizle();
		}

		private void btnGüncelle_Click(object sender, EventArgs e)
		{
			SqlCommand komut = new SqlCommand("update TBLPERSONELLER set AD=@p1,SOYAD=@p2,TELEFON=@p3,TC=@p4,MAIL=@p5,IL=@p6,ILCE=@p7,ADRES=@p8,GOREV=@p9 where ID=@p10", bgl.baglanti());
			komut.Parameters.AddWithValue("@p1", txtAd.Text);
			komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
			komut.Parameters.AddWithValue("@p3", mskTel.Text);
			komut.Parameters.AddWithValue("@p4", mskTC.Text);
			komut.Parameters.AddWithValue("@p5", txtMail.Text);
			komut.Parameters.AddWithValue("@p6", cmbil.Text);
			komut.Parameters.AddWithValue("@p7", cmbilce.Text);
			komut.Parameters.AddWithValue("@p8", rchAdres.Text);
			komut.Parameters.AddWithValue("@p9", txtGorev.Text);
			komut.Parameters.AddWithValue("@p10", txtID.Text);
			komut.ExecuteNonQuery();
			bgl.baglanti().Close();
			MessageBox.Show("Personel Bilgisi Güncellendi");
			personelListe();
		}
	}
}
