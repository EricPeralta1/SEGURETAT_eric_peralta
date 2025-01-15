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

            DataTable dt = UsersBd.fillDataGridView();
            dataGridViewUsuaris.DataSource = dt;
        }

        private void addButton_Click(object sender, EventArgs e)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

        }

        private void sortirButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
