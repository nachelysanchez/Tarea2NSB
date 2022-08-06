using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tarea2NSB.Clases;

namespace Tarea2NSB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SumarButton_Click(object sender, EventArgs e)
        {
            Sumar suma = new Sumar();
            restxt.Text = suma.operar(int.Parse(Valor1txt.Text), int.Parse(valor2txt.Text)).ToString();
        }

        private void RestarButton_Click(object sender, EventArgs e)
        {
            Restar resta = new Restar();
            restxt.Text = resta.operar(int.Parse(Valor1txt.Text), int.Parse(valor2txt.Text)).ToString();
        }

        private void MultiplicarButton_Click(object sender, EventArgs e)
        {
            Multiplicar mult = new Multiplicar();
            restxt.Text = mult.operar(int.Parse(Valor1txt.Text), int.Parse(valor2txt.Text)).ToString();
        }

        private void LimpiarButton_Click(object sender, EventArgs e)
        {
            Valor1txt.Clear();
            valor2txt.Clear();
            restxt.Clear();
        }
    }
}
