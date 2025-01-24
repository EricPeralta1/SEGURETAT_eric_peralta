using BCrypt.Net;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SEGURETAT_eric_peralta.MODELS
{
    internal class UsersBd
    {
        public static bool ckeckUsersBd(string email, string password)
        {
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

                if (emailDb.Equals(email, StringComparison.OrdinalIgnoreCase))
                {
                    if (BCrypt.Net.BCrypt.EnhancedVerify(password, passwordEncrypted, HashType.SHA512))
                    {
                        check = true;
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

                Bd.connexió.Close();
                usuaris.Close();

            }
            return check;
        }

        public static void Insert(String email, String nom, String cognoms, String contrasenya, bool actiu) {
            SqlCommand sentencia = new SqlCommand();

            sentencia.Connection = Bd.connexió;
            sentencia.CommandText = "insert into usuaris values (@email, @nom, @cognoms, @contrasenya, @actiu)";
            sentencia.Parameters.Clear();
            sentencia.Parameters.AddWithValue("@email", email);
            sentencia.Parameters.AddWithValue("@nom", nom);
            sentencia.Parameters.AddWithValue("@cognoms", cognoms);
            sentencia.Parameters.AddWithValue("@contrasenya", contrasenya);
            sentencia.Parameters.AddWithValue("@actiu", actiu);

            Bd.connexió.Open();

            sentencia.ExecuteNonQuery();

            Bd.connexió.Close();

        }

        public static void Delete(string email) {
            DialogResult dialogResult = MessageBox.Show("Estàs segur que vols borrar aquest usuari? Es perdrà per sempre!", "Atenció", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                SqlCommand sentencia = new SqlCommand();

                sentencia.Connection = Bd.connexió;
                sentencia.CommandText = "delete from usuaris where correu='@email'";
                sentencia.Parameters.Clear();
                sentencia.Parameters.AddWithValue("@email", email);

                Bd.connexió.Open();

                sentencia.ExecuteNonQuery();

                Bd.connexió.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Esborrat cancelat.");
            }
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

        public static List<string> GetRoles()
        {
            SqlCommand sentencia = new SqlCommand();
            SqlDataReader data;
            List<string> roles = new List<string>();

            sentencia.Connection = Bd.connexió;
            sentencia.CommandText = "select nombre from rols";

            Bd.connexió.Open();

            data = sentencia.ExecuteReader();

            while (data.Read())
            {
                roles.Add(data.GetString(1)); 
            }

            Bd.connexió.Close();

            return roles;
        }
    }
}
