using DevExpress.XtraEditors;
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
	public partial class FrmBankalar : Form
	{
		public FrmBankalar()
		{
			InitializeComponent();
		}
		sqlbaglanti bgl = new sqlbaglanti();

		void FirmaListesi()
		{
			DataTable dt = new DataTable();
			SqlDataAdapter da = new SqlDataAdapter("execute BankaBilgileri", bgl.baglanti());
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
		void firmaListesi2()
		{
			DataTable dt = new DataTable();
			SqlDataAdapter da = new SqlDataAdapter("Select ID,AD From TBLFIRMALAR", bgl.baglanti());
			da.Fill(dt);
			lookUpEdit1.Properties.ValueMember = "ID";
			lookUpEdit1.Properties.DisplayMember = "AD";
			lookUpEdit1.Properties.DataSource = dt;
		}
		void temizle()
		{
			txtBankaAdi.Text = "";
			txtHesapNo.Text = "";
			txtHesapTürü.Text = "";
			txtIban.Text = "";
			txtID.Text = "";
			txtSube.Text = "";
			txtYetkili.Text = "";
			mskTarih.Text = "";
			mskTelefon.Text = "";
			lookUpEdit1.Text = "";
			cmbil.Text = "";
			cmbilce.Text = "";
		}
		private void FrmBankalar_Load(object sender, EventArgs e)
		{
			FirmaListesi();
			sehirlistesi();
			firmaListesi2();
			temizle();
		}

		

		private void btnKaydet_Click(object sender, EventArgs e)
		{
			SqlCommand komut = new SqlCommand("insert into TBLBANKALAR (BANKAADI,IL,ILCE,SUBE,IBAN,HESAPNO,YETKILI,TELEFON,TARIH,HESAPTURU,FIRMAID) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)", bgl.baglanti());
			komut.Parameters.AddWithValue("@p1", txtBankaAdi.Text);
			komut.Parameters.AddWithValue("@p2", cmbil.Text);
			komut.Parameters.AddWithValue("@p3", cmbilce.Text);
			komut.Parameters.AddWithValue("@p4", txtSube.Text);
			komut.Parameters.AddWithValue("@p5", txtIban.Text);
			komut.Parameters.AddWithValue("@p6", txtHesapNo.Text);
			komut.Parameters.AddWithValue("@p7", txtYetkili.Text);
			komut.Parameters.AddWithValue("@p8", mskTelefon.Text);
			komut.Parameters.AddWithValue("@p9", mskTarih.Text);
			komut.Parameters.AddWithValue("@p10", txtHesapTürü.Text);
			komut.Parameters.AddWithValue("@p11", lookUpEdit1.EditValue);
			komut.ExecuteNonQuery();
			FirmaListesi();
			bgl.baglanti().Close();
			MessageBox.Show("Banka Bilgisi Sisteme Kaydedildi");
			
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
			txtBankaAdi.Text = dr["BANKAADI"].ToString();
			cmbil.Text = dr["IL"].ToString();
			cmbilce.Text = dr["ILCE"].ToString();
			txtSube.Text = dr["SUBE"].ToString();
			txtIban.Text = dr["IBAN"].ToString();
			txtHesapNo.Text = dr["HESAPNO"].ToString();
			txtYetkili.Text = dr["YETKILI"].ToString();
			mskTelefon.Text = dr["TELEFON"].ToString();
			mskTarih.Text = dr["TARIH"].ToString();
			txtHesapTürü.Text = dr["HESAPTURU"].ToString();
		}

		

	

		private void btnTemizle_Click_1(object sender, EventArgs e)
		{
			temizle();
		}

		private void btnSil_Click_1(object sender, EventArgs e)
		{
			SqlCommand komut = new SqlCommand("delete from TBLBANKALAR where ID=@p1", bgl.baglanti());
			komut.Parameters.AddWithValue("@p1", txtID.Text);
			komut.ExecuteNonQuery();
			bgl.baglanti().Close();
			temizle();
			MessageBox.Show("Banka Bilgisi Sistemden Silindi.");
			FirmaListesi();
		}

		private void btnGüncelle_Click(object sender, EventArgs e)
		{
			SqlCommand komut = new SqlCommand("update TBLBANKALAR set BANKAADI=@p1,IL=@p2,ILCE=@p3,SUBE=@p4,IBAN=@p5,HESAPNO=@p6,YETKILI=@p7,TELEFON=@p8,TARIH=@p9,HESAPTURU=@p10,FIRMAID=@p11 WHERE ID=@p12", bgl.baglanti());
			komut.Parameters.AddWithValue("@p1", txtBankaAdi.Text);
			komut.Parameters.AddWithValue("@p2", cmbil.Text);
			komut.Parameters.AddWithValue("@p3", cmbilce.Text);
			komut.Parameters.AddWithValue("@p4", txtSube.Text);
			komut.Parameters.AddWithValue("@p5", txtIban.Text);
			komut.Parameters.AddWithValue("@p6", txtHesapNo.Text);
			komut.Parameters.AddWithValue("@p7", txtYetkili.Text);
			komut.Parameters.AddWithValue("@p8", mskTelefon.Text);
			komut.Parameters.AddWithValue("@p9", mskTarih.Text);
			komut.Parameters.AddWithValue("@p10", txtHesapTürü.Text);
			komut.Parameters.AddWithValue("@p11", lookUpEdit1.EditValue);
			komut.Parameters.AddWithValue("@p12", txtID.Text);
			komut.ExecuteNonQuery();
			FirmaListesi();
			bgl.baglanti().Close();
			MessageBox.Show("Banka Bilgisi Güncellendi");
		}
	}
}
