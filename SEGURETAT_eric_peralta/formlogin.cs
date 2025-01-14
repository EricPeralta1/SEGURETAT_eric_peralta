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
        public formlogin()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(emailTextBox.Text) || !String.IsNullOrEmpty(passwordTextBox.Text))
            {
                string email = emailTextBox.Text;
                string contrasenya = passwordTextBox.Text;

                UsersBd.ckeckUsersBd(email, contrasenya);
            }
            else {
                MessageBox.Show("Omple els camps, siusplau.");
            }
            
        }
    }
}
