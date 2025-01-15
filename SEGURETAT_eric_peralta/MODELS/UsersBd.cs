using BCrypt.Net;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEGURETAT_eric_peralta.MODELS
{
    internal class UsersBd
    {
        public static bool ckeckUsersBd(string email, string password) {
            SqlCommand sentencia = new SqlCommand();
            SqlDataReader usuaris;
            bool check = false;

            sentencia.Connection = Bd.connexió;
            sentencia.CommandText = "select * from usuaris";

            Bd.connexió.Open();

            usuaris = sentencia.ExecuteReader();


            if (usuaris.HasRows)
            {
                usuaris.Read();

                string passwordEncrypted = usuaris.GetString(4);
                string emailDb = usuaris.GetString(1);
                MessageBox.Show(passwordEncrypted);

                if (emailDb.Equals(email, StringComparison.OrdinalIgnoreCase)) {
                    if (BCrypt.Net.BCrypt.EnhancedVerify(password, passwordEncrypted, HashType.SHA512))
                    {
                        check = true;
                        MessageBox.Show("Usuari trobat. Benvingut.");
                    }
                    else
                    {
                        MessageBox.Show("Contrasenya incorrecta.");
                    }
                } else {
                MessageBox.Show("Usuari no trobat.");
            }

            Bd.connexió.Close();
            usuaris.Close();

            return check;
        }

        public static DataTable fillDataGridView() {
            SqlCommand sentencia = new SqlCommand();
            SqlDataReader data;
            DataTable taula = new DataTable();

            sentencia.Connection = Bd.connexió;
            sentencia.CommandText = "select * from usuaris";

            Bd.connexió.Open();

            data = sentencia.ExecuteReader();

            taula.Load(data);

            Bd.connexió.Close();
            return taula;
        }
    }
}
