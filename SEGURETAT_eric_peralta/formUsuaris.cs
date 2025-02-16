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
        /// Al generar el form, rellena el dataGrid con los usuarios existentes en la DB.
        /// </summary>
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

        /// <summary>
        /// Abre el form de creación de usuarios. Al acabar, limpia y actualiza el datagrid para introducir los datos nuevos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Borra el usuario elegido en el dataGrid mediante un delete en la DB. Luego, actualiza el dataGrid.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Cierra el form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sortirButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
