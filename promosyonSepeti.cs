using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace promosyonTakip.Core.database
{
   public  class promosyonSepeti
    {

        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader reader;

        int returnInt;
        object returnObj;


        public promosyonSepeti()
        {
            con = new SqlConnection(connectionStringOlustur());
        }


        string connectionStringOlustur()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "DESKTOP-RK8Q7QD\\SQLEXPRESS";
            builder.InitialCatalog = "promosyonSepeti";
            builder.IntegratedSecurity = true;
            return builder.ConnectionString;
        }



        public void baglantıDurumuAyarla()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }

            else
                con.Close();
        }

        public int ekleDuzenleSil(SqlCommand cmd)
        {
            cmd.Connection = con;
            baglantıDurumuAyarla();
            returnInt = cmd.ExecuteNonQuery();
            baglantıDurumuAyarla();
            return returnInt;
        }


        public SqlDataReader liste(SqlCommand cmd)
        {
            cmd.Connection = con;
            baglantıDurumuAyarla();
            return cmd.ExecuteReader();
        }

        public object kolonGetir(SqlCommand cmd)
        {
            cmd.Connection = con;
            baglantıDurumuAyarla();
            returnObj = cmd.ExecuteScalar();
            baglantıDurumuAyarla();
            return returnObj;
        }
    }
}
