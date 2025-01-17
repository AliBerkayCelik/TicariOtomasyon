﻿using System;
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
	public partial class FrmFirmalar : Form
	{
		public FrmFirmalar()
		{
			InitializeComponent();
		}
		
		sqlbaglanti bgl = new sqlbaglanti();
		void listele()
		{
			DataTable dt = new DataTable();
			SqlDataAdapter da = new SqlDataAdapter("Select * From TBLFIRMALAR", bgl.baglanti());
			da.Fill(dt);
			gridControl1.DataSource = dt;
		}
		void sehirlistesi()
		{
			SqlCommand komut = new SqlCommand("Select SEHIR From TBLILLER", bgl.baglanti());
			SqlDataReader dr = komut.ExecuteReader();
			while (dr.Read())
			{
				cmbil.Properties.Items.Add(dr[0]);
			}
			bgl.baglanti().Close();
		}
		void temizle()
		{
			txtAd.Text = "";
			txtID.Text = "";
			txtKod1.Text = "";
			txtKod2.Text = "";
			txtKod3.Text = "";
			txtMail.Text = "";
			txtSektor.Text = "";
			txtVergiDairesi.Text = "";
			txtYetkili.Text = "";
			txtYetkiliGorev.Text = "";
			mskFax.Text = "";
			mskYetkiliTC.Text = "";
			mskTel.Text = "";
			mskTel2.Text = "";
			mskTel3.Text = "";
			rchAdres.Text = "";
		}
		void cariKodAciklamalar()
		{
			SqlCommand komut = new SqlCommand("select FIRMAKOD1 from TBLKODLAR", bgl.baglanti());
			SqlDataReader dr = komut.ExecuteReader();
			while (dr.Read())
			{
				rchKod1.Text = dr[0].ToString();
			}
			bgl.baglanti().Close();
		}
		private void FrmFirmalar_Load(object sender, EventArgs e)
		{
			listele();
			temizle();
			sehirlistesi();
			cariKodAciklamalar();
		}

		private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
		{
			DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
			txtID.Text = dr["ID"].ToString();
			txtAd.Text = dr["AD"].ToString();
			txtYetkiliGorev.Text = dr["YETKILISTATU"].ToString();
			txtYetkili.Text = dr["YETKILIADSOYAD"].ToString();
			mskYetkiliTC.Text = dr["YETKILITC"].ToString();
			txtSektor.Text = dr["SEKTOR"].ToString();
			mskTel.Text = dr["TELEFON1"].ToString();
			mskTel2.Text = dr["TELEFON2"].ToString();
			mskTel3.Text = dr["TELEFON3"].ToString();
			txtMail.Text = dr["MAIL"].ToString();
			mskFax.Text = dr["FAX"].ToString();
			cmbil.Text = dr["IL"].ToString();
			cmbilce.Text = dr["ILCE"].ToString();
			txtVergiDairesi.Text = dr["VERGIDAIRE"].ToString();
			rchAdres.Text = dr["ADRES"].ToString();
			txtKod1.Text = dr["OZELKOD1"].ToString();
			txtKod2.Text = dr["OZELKOD2"].ToString();
			txtKod3.Text = dr["OZELKOD3"].ToString();
		}

		private void btnKaydet_Click(object sender, EventArgs e)
		{
			SqlCommand komut = new SqlCommand("insert into TBLFIRMALAR (AD,YETKILISTATU,YETKILIADSOYAD,YETKILITC,SEKTOR,TELEFON1,TELEFON2,TELEFON3,MAIL,FAX,IL,ILCE,VERGIDAIRE,ADRES,OZELKOD1,OZELKOD2,OZELKOD3) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13,@p14,@p15,@p16,@p17)", bgl.baglanti());
			komut.Parameters.AddWithValue("@p1", txtAd.Text);
			komut.Parameters.AddWithValue("@p2", txtYetkiliGorev.Text);
			komut.Parameters.AddWithValue("@p3", txtYetkili.Text);
			komut.Parameters.AddWithValue("@p4", mskYetkiliTC.Text);
			komut.Parameters.AddWithValue("@p5", txtSektor.Text);
			komut.Parameters.AddWithValue("@p6", mskTel.Text);
			komut.Parameters.AddWithValue("@p7", mskTel2.Text);
			komut.Parameters.AddWithValue("@p8", mskTel3.Text);
			komut.Parameters.AddWithValue("@p9", txtMail.Text);
			komut.Parameters.AddWithValue("@p10", mskFax.Text);
			komut.Parameters.AddWithValue("@p11", cmbil.Text);
			komut.Parameters.AddWithValue("@p12", cmbilce.Text);
			komut.Parameters.AddWithValue("@p13", txtVergiDairesi.Text);
			komut.Parameters.AddWithValue("@p14", rchAdres.Text);
			komut.Parameters.AddWithValue("@p15", txtKod1.Text);
			komut.Parameters.AddWithValue("@p16", txtKod2.Text);
			komut.Parameters.AddWithValue("@p17", txtKod3.Text);
			komut.ExecuteNonQuery();
			bgl.baglanti().Close();
			MessageBox.Show("Firma Sisteme Kayıt Edildi");
			listele();
			temizle();
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

		private void btnSil_Click(object sender, EventArgs e)
		{
			SqlCommand komut = new SqlCommand("Delete From TBLFIRMALAR where ID=@P1",bgl.baglanti());
			komut.Parameters.AddWithValue("@P1", txtID.Text);
			komut.ExecuteNonQuery();
			bgl.baglanti().Close();
			listele();
			MessageBox.Show("Firma Silindi");
			temizle();
		}

		private void btnGüncelle_Click(object sender, EventArgs e)
		{
			SqlCommand komut = new SqlCommand("update TBLFIRMALAR set AD=@p1,YETKILISTATU=@p2,YETKILIADSOYAD=@p3,YETKILITC=@p4,SEKTOR=@p5,TELEFON1=@p6,TELEFON2=@p7,TELEFON3=@p8,MAIL=@p9,FAX=@p10,IL=@p11,ILCE=@p12,VERGIDAIRE=@p13,ADRES=@p14,OZELKOD1=@p15,OZELKOD2=@p16,OZELKOD3=@p17 where ID=@P18", bgl.baglanti());
			komut.Parameters.AddWithValue("@p1", txtAd.Text);
			komut.Parameters.AddWithValue("@p2", txtYetkiliGorev.Text);
			komut.Parameters.AddWithValue("@p3", txtYetkili.Text);
			komut.Parameters.AddWithValue("@p4", mskYetkiliTC.Text);
			komut.Parameters.AddWithValue("@p5", txtSektor.Text);
			komut.Parameters.AddWithValue("@p6", mskTel.Text);
			komut.Parameters.AddWithValue("@p7", mskTel2.Text);
			komut.Parameters.AddWithValue("@p8", mskTel3.Text);
			komut.Parameters.AddWithValue("@p9", txtMail.Text);
			komut.Parameters.AddWithValue("@p10", mskFax.Text);
			komut.Parameters.AddWithValue("@p11", cmbil.Text);
			komut.Parameters.AddWithValue("@p12", cmbilce.Text);
			komut.Parameters.AddWithValue("@p13", txtVergiDairesi.Text);
			komut.Parameters.AddWithValue("@p14", rchAdres.Text);
			komut.Parameters.AddWithValue("@p15", txtKod1.Text);
			komut.Parameters.AddWithValue("@p16", txtKod2.Text);
			komut.Parameters.AddWithValue("@p17", txtKod3.Text);
			komut.Parameters.AddWithValue("@p18", txtID.Text);
			komut.ExecuteNonQuery();
			bgl.baglanti().Close();
			MessageBox.Show("Firma Bilgileri Güncellendi");
			listele();
			temizle();
		}

		private void btnTemizle_Click(object sender, EventArgs e)
		{
			temizle();
		}
	}
}
