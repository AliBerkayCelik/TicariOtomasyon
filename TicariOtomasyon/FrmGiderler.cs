using DevExpress.Data.Linq.Helpers;
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
	public partial class FrmGiderler : Form
	{
		public FrmGiderler()
		{
			InitializeComponent();
		}
		sqlbaglanti bgl = new sqlbaglanti();

		void giderListesi()
		{
			DataTable dt = new DataTable();
			SqlDataAdapter da = new SqlDataAdapter("Select * From TBLGIDERLER",bgl.baglanti());
			da.Fill(dt);
			gridControl1.DataSource=dt;

		}
		void temizle()
		{

			cmbAy.Text = "";
			cmbYil.Text = "";
			txtElektirik.Text = "";
			txtSu.Text = "";
			txtdogalGaz.Text = "";
			txtInternet.Text = "";
			txtMaaslar.Text = "";
			txtEkstra.Text = "";
			rchNotlar.Text = "";
		}

		private void FrmGiderler_Load(object sender, EventArgs e)
		{
			giderListesi();
			temizle();
		}

		private void btnKaydet_Click(object sender, EventArgs e)
		{
			SqlCommand komut = new SqlCommand("insert into TBLGIDERLER (AY,YIL,ELEKTIRIK,SU,DOGALGAZ,INTERNET,MAASLAR,EKSTRA,NOTLAR) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", bgl.baglanti());
			komut.Parameters.AddWithValue("@p1", cmbAy.Text);
			komut.Parameters.AddWithValue("@p2", cmbYil.Text);
			komut.Parameters.AddWithValue("@p3", decimal.Parse(txtElektirik.Text));
			komut.Parameters.AddWithValue("@p4", decimal.Parse(txtSu.Text));
			komut.Parameters.AddWithValue("@p5", decimal.Parse(txtdogalGaz.Text));
			komut.Parameters.AddWithValue("@p6", decimal.Parse(txtInternet.Text));
			komut.Parameters.AddWithValue("@p7", decimal.Parse(txtMaaslar.Text));
			komut.Parameters.AddWithValue("@p8", decimal.Parse(txtEkstra.Text));
			komut.Parameters.AddWithValue("@p9", rchNotlar.Text);
			
			komut.ExecuteNonQuery();
			bgl.baglanti().Close();
			MessageBox.Show("Giderler Sisteme Eklendi");
			giderListesi();
			temizle();
		}

		private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
		{
			DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
			txtID.Text = dr["ID"].ToString();
			cmbAy.Text = dr["AY"].ToString();
			cmbYil.Text = dr["YIL"].ToString();
			txtElektirik.Text = dr["ELEKTIRIK"].ToString();
			txtSu.Text = dr["SU"].ToString();
			txtdogalGaz.Text = dr["DOGALGAZ"].ToString();
			txtInternet.Text = dr["INTERNET"].ToString();
			txtMaaslar.Text = dr["MAASLAR"].ToString();
			txtEkstra.Text = dr["EKSTRA"].ToString();
			rchNotlar.Text = dr["NOTLAR"].ToString();
		}

		private void btnTemizle_Click(object sender, EventArgs e)
		{
			temizle();
		}

		private void btnSil_Click(object sender, EventArgs e)
		{
			SqlCommand komut = new SqlCommand("Delete From TBLGIDERLER where ID=@p1", bgl.baglanti());
			komut.Parameters.AddWithValue("@p1", txtID.Text);
			komut.ExecuteNonQuery();
			bgl.baglanti().Close();
			MessageBox.Show("Gider Listeden Silindi");
			giderListesi();
			temizle();
		}

		private void btnGüncelle_Click(object sender, EventArgs e)
		{
			SqlCommand komut = new SqlCommand("update TBLGIDERLER set AY=@p1,YIL=@p2,ELEKTIRIK=@p3,SU=@p4,DOGALGAZ=@p5,INTERNET=@p6,MAASLAR=@p7,EKSTRA=@p8,NOTLAR=@p9 where ID=@p10", bgl.baglanti());
			komut.Parameters.AddWithValue("@p1", cmbAy.Text);
			komut.Parameters.AddWithValue("@p2", cmbYil.Text);
			komut.Parameters.AddWithValue("@p3", decimal.Parse(txtElektirik.Text));
			komut.Parameters.AddWithValue("@p4", decimal.Parse(txtSu.Text));
			komut.Parameters.AddWithValue("@p5", decimal.Parse(txtdogalGaz.Text));
			komut.Parameters.AddWithValue("@p6", decimal.Parse(txtInternet.Text));
			komut.Parameters.AddWithValue("@p7", decimal.Parse(txtMaaslar.Text));
			komut.Parameters.AddWithValue("@p8", decimal.Parse(txtEkstra.Text));
			komut.Parameters.AddWithValue("@p9", rchNotlar.Text);
			komut.Parameters.AddWithValue("@p10", txtID.Text);

			komut.ExecuteNonQuery();
			bgl.baglanti().Close();
			MessageBox.Show("Giderler Güncellendi");
			giderListesi();
			temizle();
		}
	}
}
