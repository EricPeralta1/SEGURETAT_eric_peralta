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

        /// <summary>
        /// Realiza una comprobación en la DB mediante una select, pasando el correo y la contraseña previamente introducidos. En caso de existir y la contraseña
        /// ser equivalente a la encriptada, devuelve true como boolean. En caso contrario, false.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static bool ckeckUsersBd(string email, string password)
        {
            SqlCommand sentencia = new SqlCommand();
            SqlDataReader usuaris;
            bool check = false;

            sentencia.Connection = Bd.connexió;
            sentencia.CommandText = "select * from usuaris where correu = @Email";
            sentencia.Parameters.AddWithValue("@email", email);

            Bd.connexió.Open();

            usuaris = sentencia.ExecuteReader();


            if (usuaris.HasRows)
            {
                usuaris.Read();

                string passwordEncrypted = usuaris.GetString(4);

                
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

            return check;
        }

        /// <summary>
        /// Realiza un insert a la BD con todos los datos que componen al usuario. También encripta la contraseña,
        /// y se introduce en la tabla "Usuarios".
        /// </summary>
        /// <param name="email"></param>
        /// <param name="nom"></param>
        /// <param name="cognoms"></param>
        /// <param name="contrasenya"></param>
        /// <param name="actiu"></param>
        /// <param name="roleId"></param>
        public static void Insert(String email, String nom, String cognoms, String contrasenya, bool actiu, int roleId) {
            SqlCommand sentencia = new SqlCommand();

            sentencia.Connection = Bd.connexió;
            sentencia.CommandText = "insert into usuaris values (@email, @nom, @cognoms, @contrasenya, @actiu, @Role)";
            sentencia.Parameters.Clear();
            sentencia.Parameters.AddWithValue("@email", email);
            sentencia.Parameters.AddWithValue("@nom", nom);
            sentencia.Parameters.AddWithValue("@cognoms", cognoms);
            sentencia.Parameters.AddWithValue("@contrasenya", BCrypt.Net.BCrypt.EnhancedHashPassword(contrasenya, BCrypt.Net.HashType.SHA512)
);
            sentencia.Parameters.AddWithValue("@actiu", actiu);
            sentencia.Parameters.AddWithValue("@Role", roleId);

            Bd.connexió.Open();

            sentencia.ExecuteNonQuery();

            Bd.connexió.Close();

        }

        /// <summary>
        /// Realiza un delete en la DB, pasando la ID del usuario previamente para borrar el usuario especificado.
        /// </summary>
        /// <param name="id"></param>
        public static void Delete(int id) {
            DialogResult dialogResult = MessageBox.Show("Estàs segur que vols borrar aquest usuari? Es perdrà per sempre!", "Atenció", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                SqlCommand sentencia = new SqlCommand();

                sentencia.Connection = Bd.connexió;
                sentencia.CommandText = "delete from usuaris where id=@id";
                sentencia.Parameters.Clear();
                sentencia.Parameters.AddWithValue("@id", id);

                Bd.connexió.Open();

                sentencia.ExecuteNonQuery();

                Bd.connexió.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Esborrat cancelat.");
            }
        }


        /// <summary>
        /// Permite conseguir la lista de usuarios existentes en la DB mediante una select en la tabla de usuarios. Recoge los datos especificados en la query.
        /// </summary>
        /// <returns></returns>
        public static DataTable GetUsers()
        {
            DataTable dt = new DataTable();

            SqlCommand command = new SqlCommand(@"
      SELECT u.id, u.correu, u.nom, u.cognoms, u.actiu, r.nom as rol_nom
      FROM usuaris u
      JOIN rols r ON u.rols_id = r.id", Bd.connexió);

            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading users: {ex.Message}");
            }

            return dt;
        }

        /// <summary>
        /// Permite conseguir la lista de roles existentes mediante una select en la tabla de roles.
        /// </summary>
        /// <returns></returns>
        public static DataTable GetRoles()
        {
            SqlCommand sentencia = new SqlCommand();
            SqlDataReader data;
            DataTable rolesTable = new DataTable();

            sentencia.Connection = Bd.connexió;
            sentencia.CommandText = "select * from rols";

            Bd.connexió.Open();

            data = sentencia.ExecuteReader();
            rolesTable.Load(data);


            Bd.connexió.Close();

            return rolesTable;
        }
    }
}
