using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea2NSB
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 operaciones = new Form1();
            operaciones.Show();
        }
    }
}
