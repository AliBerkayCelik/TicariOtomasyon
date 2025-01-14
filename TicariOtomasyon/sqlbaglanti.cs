using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TicariOtomasyon
{
	internal class sqlbaglanti
	{
		public SqlConnection baglanti()
		{
			SqlConnection bg = new SqlConnection(@"Data Source=LAPTOP-6OD692P5\SQLEXPRESS;Initial Catalog=DboTicariOtomasyon;Integrated Security=True");
			bg.Open();
			return bg;
		}
	}
}
