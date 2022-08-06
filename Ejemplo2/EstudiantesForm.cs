using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea2NSB.Ejemplo2
{
    public partial class EstudiantesForm : RegistroFrm
    {
        public EstudiantesForm()
        {
            InitializeComponent();
        }

        private void EstudiantesForm_Load(object sender, EventArgs e)
        {

        }

        private void EstudiantesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
