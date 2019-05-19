using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cap7_AgendaTelefonica
{
    public partial class Agenda : Form
    {
        public Agenda()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            dataAgenda.Rows.Add(txtNombre.Text, txtTelefono.Text);
            txtNombre.Text = string.Empty;
            txtTelefono.Text = string.Empty;
        }
    }
}
