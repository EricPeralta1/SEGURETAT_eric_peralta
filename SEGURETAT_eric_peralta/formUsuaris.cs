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
    public partial class formUsuaris : Form
    {

        /// <summary>
        /// Prueba x
        /// </summary>
        public formUsuaris()
        {
            InitializeComponent();

            DataTable dt = UsersBd.fillDataGridView();
            dataGridViewUsuaris.DataSource = dt;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            formUsuariNou f = new formUsuariNou();
            f.ShowDialog();

            DataTable dt = UsersBd.fillDataGridView();
            dataGridViewUsuaris.DataSource = dt;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsuaris.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewUsuaris.SelectedRows[0];

                string email = selectedRow.Cells["Email"].Value.ToString(); 

                UsersBd.Delete(email);

                DataTable dt = UsersBd.fillDataGridView();
                dataGridViewUsuaris.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila.");
            }
        }

        private void sortirButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
