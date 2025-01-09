using BCrypt.Net;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEGURETAT_eric_peralta.MODELS
{
    internal class UsersBd
    {
        public static void ckeckUsersBd(string email, string password) {
            SqlCommand sentencia = new SqlCommand();
            SqlDataReader usuaris;

            sentencia.Connection = Bd.connexió;
            sentencia.CommandText = "select * from usuaris";

            Bd.connexió.Open();

            usuaris = sentencia.ExecuteReader();

            Bd.connexió.Close();

            if (usuaris.HasRows)
            {
                usuaris.Read();

                string passwordEncrypted = usuaris.GetString(5);

                if (BCrypt.Net.BCrypt.EnhancedVerify(password, passwordEncrypted))
                {
                    MessageBox.Show("Usuari trobat. Benvingut.");
                }
                else
                {
                    MessageBox.Show("Contrasenya incorrecta.");
                }
            }
            else
            {
                MessageBox.Show("Usuari no trobat.");
            }

            usuaris.Close();


        }
    }
}
