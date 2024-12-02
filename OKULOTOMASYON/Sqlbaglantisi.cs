using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace OKULOTOMASYON
{
    internal class Sqlbaglantisi
    {
#pragma warning disable CRRSP08 // A misspelled word has been found
        public SqlConnection baglanti()
#pragma warning restore CRRSP08 // A misspelled word has been found
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=BARANYıLMAZ\SQLEXPRESS;Initial Catalog=dbo.OkulOtomasyon;Integrated Security=True;");
            baglan.Open();
            return baglan;
        }
    }
}
