using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploLibroCshar
{
    public partial class Factorial : Form
    {
        public Factorial()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            float cantidad, resultado = 1;
            cantidad = Convert.ToSingle(txtValor.Text);
            for (int i = 1; i <= cantidad; i++)
            {
                resultado = i * resultado;

            }
            label2.Text = resultado.ToString();
        }
    }
}
