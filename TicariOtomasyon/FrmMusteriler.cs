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
	public partial class Musteriler : Form
	{
		public Musteriler()
		{
			InitializeComponent();
		}

		
		sqlbaglanti bgl=new sqlbaglanti();
		void listele()
		{
			DataTable dt = new DataTable();
			SqlDataAdapter da = new SqlDataAdapter("Select * From TBLMUSTERILER", bgl.baglanti());
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

		private void FrmMusteriler_Load(object sender, EventArgs e)
		{
			listele();
			sehirListesi();
		}

		private void cmbil_SelectedIndexChanged(object sender, EventArgs e)
		{
			cmbilce.Properties.Items.Clear();
			SqlCommand komut = new SqlCommand("select ILCE from TBLILCELER where SEHIR=@p1",bgl.baglanti());
			komut.Parameters.AddWithValue("@p1", cmbil.SelectedIndex+1);
			SqlDataReader dr = komut.ExecuteReader();
			while (dr.Read())
			{
				cmbilce.Properties.Items.Add(dr[0]);
			}
			bgl.baglanti().Close();
		}

		private void btnKaydet_Click(object sender, EventArgs e)
		{
			SqlCommand komut = new SqlCommand("insert into TBLMUSTERILER (AD,SOYAD,TELEFON,TELEFON2,TC,MAIL,IL,ILCE,VERGIDAIRE,ADRES) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)", bgl.baglanti());
			komut.Parameters.AddWithValue("@p1", txtAd.Text);
			komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
			komut.Parameters.AddWithValue("@p3", mskTel.Text);
			komut.Parameters.AddWithValue("@p4", mskTel2.Text);
			komut.Parameters.AddWithValue("@p5", mskTC.Text);
			komut.Parameters.AddWithValue("@p6", txtMail.Text);
			komut.Parameters.AddWithValue("@p7", cmbil.Text);
			komut.Parameters.AddWithValue("@p8", cmbilce.Text);
			komut.Parameters.AddWithValue("@p9", txtVergiDairesi.Text);
			komut.Parameters.AddWithValue("@p10", rchAdres.Text);
			komut.ExecuteNonQuery();
			bgl.baglanti().Close();
			MessageBox.Show("Müşteri Sisteme Eklendi");
			listele();
		}

		private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
		{
			DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
			txtID.Text = dr["ID"].ToString();
			txtAd.Text = dr["AD"].ToString();
			txtSoyad.Text = dr["SOYAD"].ToString();
			mskTel.Text = dr["TELEFON"].ToString();
			mskTel2.Text = dr["TELEFON2"].ToString();
			mskTC.Text = dr["TC"].ToString();
			txtMail.Text = dr["MAIL"].ToString();
			cmbil.Text = dr["IL"].ToString();
			cmbilce.Text = dr["ILCE"].ToString();
			rchAdres.Text = dr["ADRES"].ToString();
			txtVergiDairesi.Text = dr["VERGIDAIRE"].ToString();
		}

		private void btnSil_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Müşteriyi silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			if (result == DialogResult.Yes)
			{
				SqlCommand komut = new SqlCommand("Delete From TBLMUSTERILER where ID=@p1", bgl.baglanti());
				komut.Parameters.AddWithValue("@p1", txtID.Text);
				komut.ExecuteNonQuery();
				bgl.baglanti().Close();
				MessageBox.Show("Müşteri Silindi");
				listele();
			}
			else
			{
				MessageBox.Show("Silme işlemi iptal edildi.");
			}
		}

		private void btnGüncelle_Click(object sender, EventArgs e)
		{
			SqlCommand komut = new SqlCommand("update TBLMUSTERILER set AD=@P1,SOYAD=@P2,TELEFON=@P3,TELEFON2=@P4,TC=@P5,MAIL=@P6,IL=@P7,ILCE=@P8,ADRES=@P9,VERGIDAIRE=@P10 where ID=@P11", bgl.baglanti());
			komut.Parameters.AddWithValue("@p1", txtAd.Text);
			komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
			komut.Parameters.AddWithValue("@p3", mskTel.Text);
			komut.Parameters.AddWithValue("@p4", mskTel2.Text);
			komut.Parameters.AddWithValue("@p5", mskTC.Text);
			komut.Parameters.AddWithValue("@p6", txtMail.Text);
			komut.Parameters.AddWithValue("@p7", cmbil.Text);
			komut.Parameters.AddWithValue("@p8", cmbilce.Text);
			komut.Parameters.AddWithValue("@p9", rchAdres.Text);
			komut.Parameters.AddWithValue("@p10", txtVergiDairesi.Text);
			komut.Parameters.AddWithValue("@p11", txtID.Text);
			komut.ExecuteNonQuery();
			bgl.baglanti().Close();
			MessageBox.Show("Müşteri Bilgisi Güncellendi");
			listele();
		}
	}
}
