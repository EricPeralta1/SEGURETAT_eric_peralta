using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SEGURETAT_eric_peralta.MODELS;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SEGURETAT_eric_peralta
{
    public partial class formUsuariNou : Form
    {

        /// <summary>
        /// Al generar el formulario, introduce los roles en la comboBox correspondiente, según los existentes en la BD.
        /// </summary>
        public formUsuariNou()
        {
            InitializeComponent();

            roleComboBox.DisplayMember = "nom";
            roleComboBox.ValueMember = "id";

            roleComboBox.DataSource = UsersBd.GetRoles();


        }

        /// <summary>
        /// Cancela la creación de usuarios, cerrando el form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Comprueba que los datos introducidos cumplan las condiciones establecidas. En caso correcto,
        /// realiza un insert a la BD, con los datos del usuario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void acceptButton_Click(object sender, EventArgs e)
        {
            string email = emailTextBox.Text;

            if (string.IsNullOrEmpty(emailTextBox.Text))
            {
                MessageBox.Show("Inserta un email, siusplau.");
            }
            else if (string.IsNullOrEmpty(nameTextBox.Text))
            {
                MessageBox.Show("Inserta un nom, siusplau.");
            }
            else if (string.IsNullOrEmpty(surnameTextBox.Text))
            {
                MessageBox.Show("Inserta el o els cognoms, siusplau.");
            }
            else if (string.IsNullOrEmpty(passwordTextBox.Text))
            {
                MessageBox.Show("Inserta una contrasenya, siusplau.");
            }
            else if (string.IsNullOrEmpty(confirmPasswordTextBox.Text))
            {
                MessageBox.Show("Confirma la contrasenya, siusplau.");
            }
            else if (string.IsNullOrEmpty(roleComboBox.Text))
            {
                MessageBox.Show("Inserta un rol, siusplau.");
            }
            else if (passwordTextBox.Text != confirmPasswordTextBox.Text)
            {
                MessageBox.Show("La contrasenya no es igual.");

            }
            else if (nameTextBox.Text.Any(char.IsDigit) || surnameTextBox.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Ni el nombre ni el apellido pueden contener numeros.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!email.Contains("@") || email.StartsWith("@") || email.EndsWith("@"))
            {
                MessageBox.Show("El correo electrónico debe tener un formato válido (con texto antes y después de '@').", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if (passwordTextBox.Text.Length< 8){
                MessageBox.Show("La contraseña debe tener 8 carácteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else {

                string correu = emailTextBox.Text;
                string nom = nameTextBox.Text;
                string cognoms = surnameTextBox.Text;
                string password = passwordTextBox.Text;

                bool check;
                if (activeCheckBox.Checked)
                {
                    check = true;
                }
                else { 
                 check = false;
                }
                int roleId = roleComboBox.SelectedIndex + 1;

                UsersBd.Insert(correu, nom, cognoms, password, check, roleId);

                this.Close();
            }
        }


    }
}
