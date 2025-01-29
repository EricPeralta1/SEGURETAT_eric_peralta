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

        public formUsuaris()
        {
            InitializeComponent();

            dataGridViewUsuaris.Rows.Clear();

            DataTable dt = UsersBd.GetUsers();

            foreach (DataRow row in dt.Rows)
            {
                int rowIndex = dataGridViewUsuaris.Rows.Add();
                dataGridViewUsuaris.Rows[rowIndex].Cells["Id"].Value = row["id"];
                dataGridViewUsuaris.Rows[rowIndex].Cells["Correu"].Value = row["correu"];
                dataGridViewUsuaris.Rows[rowIndex].Cells["Nom"].Value = row["nom"];
                dataGridViewUsuaris.Rows[rowIndex].Cells["Cognoms"].Value = row["cognoms"];
                dataGridViewUsuaris.Rows[rowIndex].Cells["Actiu"].Value = row["actiu"];
                dataGridViewUsuaris.Rows[rowIndex].Cells["Rol"].Value = row["rol_nom"];

            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            formUsuariNou f = new formUsuariNou();
            f.ShowDialog();

            dataGridViewUsuaris.Rows.Clear();

            DataTable dt = UsersBd.GetUsers();

            foreach (DataRow row in dt.Rows)
            {
                int rowIndex = dataGridViewUsuaris.Rows.Add();
                dataGridViewUsuaris.Rows[rowIndex].Cells["Id"].Value = row["id"];
                dataGridViewUsuaris.Rows[rowIndex].Cells["Correu"].Value = row["correu"];
                dataGridViewUsuaris.Rows[rowIndex].Cells["Nom"].Value = row["nom"];
                dataGridViewUsuaris.Rows[rowIndex].Cells["Cognoms"].Value = row["cognoms"];
                dataGridViewUsuaris.Rows[rowIndex].Cells["Actiu"].Value = row["actiu"];
                dataGridViewUsuaris.Rows[rowIndex].Cells["Rol"].Value = row["rol_nom"];

            }
        }


        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsuaris.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewUsuaris.SelectedRows[0];

                int id = Convert.ToInt32(selectedRow.Cells["Id"].Value.ToString());

                UsersBd.Delete(id);

                dataGridViewUsuaris.Rows.Clear();

                DataTable dt = UsersBd.GetUsers();

                foreach (DataRow row in dt.Rows)
                {
                    int rowIndex = dataGridViewUsuaris.Rows.Add();
                    dataGridViewUsuaris.Rows[rowIndex].Cells["Id"].Value = row["id"];
                    dataGridViewUsuaris.Rows[rowIndex].Cells["Correu"].Value = row["correu"];
                    dataGridViewUsuaris.Rows[rowIndex].Cells["Nom"].Value = row["nom"];
                    dataGridViewUsuaris.Rows[rowIndex].Cells["Cognoms"].Value = row["cognoms"];
                    dataGridViewUsuaris.Rows[rowIndex].Cells["Actiu"].Value = row["actiu"];
                    dataGridViewUsuaris.Rows[rowIndex].Cells["Rol"].Value = row["rol_nom"];

                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila.");
            }
        }

        private void sortirButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
