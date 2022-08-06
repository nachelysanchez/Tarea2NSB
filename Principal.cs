using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tarea2NSB.Ejemplo2;

namespace Tarea2NSB
{
    public partial class Principal : FormSalir
    {
        public Principal()
        {
            InitializeComponent();
        }

        
        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void EstudiantesButton_Click(object sender, EventArgs e)
        {
            EstudiantesForm est = new EstudiantesForm();
            this.Hide();
            est.Show();
        }

        private void DocentesButton_Click(object sender, EventArgs e)
        {
            DocentesForm doc = new DocentesForm();
            this.Hide();
            doc.Show();
        }

        private void OperacionesButton_Click(object sender, EventArgs e)
        {
            Form1 calculo = new Form1();
            this.Hide();
            calculo.Show();
        }
    }
}
