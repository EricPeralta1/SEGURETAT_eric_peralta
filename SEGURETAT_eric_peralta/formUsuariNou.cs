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

namespace SEGURETAT_eric_peralta
{
    public partial class formUsuariNou : Form
    {
        public formUsuariNou()
        {
            InitializeComponent();

            List<string> roles = UsersBd.GetRoles();

            roleComboBox.Items.Clear();

            foreach (string role in roles)
            {
                roleComboBox.Items.Add(role);
            }


        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(emailTextBox.Text))
            {
                MessageBox.Show("Inserta un email, siusplau.");
            }
            else if (!string.IsNullOrEmpty(nameTextBox.Text))
            {
                MessageBox.Show("Inserta un nom, siusplau.");
            }
            else if (!string.IsNullOrEmpty(surnameTextBox.Text))
            {
                MessageBox.Show("Inserta el o els cognoms, siusplau.");
            }
            else if (!string.IsNullOrEmpty(passwordTextBox.Text))
            {
                MessageBox.Show("Inserta una contrasenya, siusplau.");
            }
            else if (!string.IsNullOrEmpty(confirmPasswordTextBox.Text))
            {
                MessageBox.Show("Confirma la contrasenya, siusplau.");
            }
            else if (!string.IsNullOrEmpty(roleComboBox.Text))
            {
                MessageBox.Show("Inserta un rol, siusplau.");
            }
            else if (passwordTextBox.Text != confirmPasswordTextBox.Text)
            {
                MessageBox.Show("La contrasenya no es igual.");

            }
            else {

                string correu = emailTextBox.Text;
                string nom = nameTextBox.Text;
                string cognoms = surnameTextBox.Text;
                string password = encriptarContrasenya(passwordTextBox.Text);
                string rol = roleComboBox.Text;
                bool check;
                if (activeCheckBox.Checked)
                {
                    check = true;
                }
                else { 
                 check = false;
                }

                UsersBd.Insert(correu, nom, cognoms, password, check);

            }
        }

        public string encriptarContrasenya(string password)
        {
            using (SHA512 sha512 = SHA512.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);

                byte[] hashBytes = sha512.ComputeHash(bytes);

                StringBuilder hashStringBuilder = new StringBuilder();
                foreach (byte b in hashBytes)
                {
                    hashStringBuilder.Append(b.ToString("x2"));
                }

                return hashStringBuilder.ToString();
            }
        }
    }
}
