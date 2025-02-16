using SEGURETAT_eric_peralta.MODELS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEGURETAT_eric_peralta
{
    public partial class formlogin : Form
    {
        initialscreen f = new initialscreen();

        /// <summary>
        /// Deshabilita el form de initialscreen, hasta iniciar sesión con un usuario de la BD.
        /// </summary>
        public formlogin()
        {
            InitializeComponent();
            f.Enabled = false;
            f.Show();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        /// <summary>
        /// Al aceptar, recoge los datos de las textBox, y las compara con los usuarios existentes de la DB. Si el check es true, rehabilita el form.
        /// En caso contrario, el usuario introducido serà erròneo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void acceptButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(emailTextBox.Text) || !String.IsNullOrEmpty(passwordTextBox.Text))
            {
                string email = emailTextBox.Text;
                string contrasenya = passwordTextBox.Text;

                bool check = UsersBd.ckeckUsersBd(email, contrasenya);

                if (check == true) {
                    f.Enabled = true;
                    this.Hide();
                }

            }
            else {
                MessageBox.Show("Omple els camps, siusplau.");
            }
            
        }
    }
}
