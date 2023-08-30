using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oto.core.DatabaseLogicLayer
{
    public class SistemKontrolDatabase
    {

        public SqlCommand cmd;
        public SqlConnection con;
        public SqlDataReader reader;
        public int returnValue = 0;
        public object returnObject;
        public SistemKontrolDatabase()
        {

            con = new SqlConnection(connectionStringOlustur());

        }

        string connectionStringOlustur()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            #region
            builder.DataSource = "DESKTOP-1PBLKBH\\SQLEXPRESS";
            builder.InitialCatalog = "sehirler";
            builder.UserID = "sa";
            builder.Password = "12345";
            #endregion
            return builder.ConnectionString;
        }
        public void baglantiayarla()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            else
            {
                con.Close();
            }

        }

        public SqlDataReader sehirListele(SqlCommand cmd)
        {
            cmd.Connection = con;
            baglantiayarla();
            return cmd.ExecuteReader();


        }
        public int müsteriKayit(SqlCommand cmd)
        {

            cmd.Connection = con;
            baglantiayarla();
            returnValue = cmd.ExecuteNonQuery();
            baglantiayarla();
            return returnValue;
        }
        public SqlDataReader müsteriSorgu(SqlCommand cmd)
        {
            cmd.Connection = con;
            baglantiayarla();
            return cmd.ExecuteReader();

        }
        public SqlDataReader koltukSorgu(SqlCommand cmd)
        {
            cmd.Connection = con;
            baglantiayarla();
            return cmd.ExecuteReader();

        }

        public SqlDataReader müsteriListele(SqlCommand cmd)
        {
            cmd.Connection = con;
            baglantiayarla();
            return cmd.ExecuteReader();


        }
        public int müsteriSilme(SqlCommand cmd)
        {

            cmd.Connection = con;
            baglantiayarla();
            returnValue = cmd.ExecuteNonQuery();
            baglantiayarla();
            return returnValue;
        }












    }

}
