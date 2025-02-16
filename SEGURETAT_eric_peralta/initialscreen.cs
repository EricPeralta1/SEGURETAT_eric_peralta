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
    /// <summary>
    /// Form inicial. Pantalla de eleccion entre salir, roles y usuarios.
    /// </summary>
    public partial class initialscreen : Form
    {
        public initialscreen()
        {
            InitializeComponent();
        }

        private void sortirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Genera el form de usuarios.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void usuarisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formUsuaris formUsuaris = new formUsuaris();
            formUsuaris.ShowDialog();
            this.Hide();
        }
    }
}
