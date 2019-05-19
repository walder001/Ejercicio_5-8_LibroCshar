using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cap8_Cadena
{
    public partial class Cadena : Form
    {
        public Cadena()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            string ordenado1 = new String(txtCadena1.Text.OrderBy(x => x).ToArray());
            string ordenado2 = new String(txtCadena2.Text.OrderBy(x => x).ToArray());

            txtOrganizada1.Text = ordenado1;
            txtOrganizada2.Text = ordenado2;


        }

        private void Button2_Click(object sender, EventArgs e)
        {
            txtCadena1.Text = string.Empty;
            txtCadena2.Text = string.Empty;
            txtOrganizada1.Text = string.Empty;
            txtOrganizada2.Text = string.Empty;


        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }
    }
}
