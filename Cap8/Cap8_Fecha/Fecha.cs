using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Cap8_Fecha
{
    public partial class Fecha : Form
    {
        public Fecha()
        {
            InitializeComponent();
        }

        private void LblFecha_Click(object sender, EventArgs e)
        {

        }

        private void Fecha_Load(object sender, EventArgs e)
        {
            

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lblTiempo.Text = DateTime.Now.ToString("hh:MM:ss:tt");

            lblFecha.Text = DateTime.Now.ToString("yyyy-dd-MM");
        }

        private void Fecha_Load_1(object sender, EventArgs e)
        {
            int n = 0;
            n = Convert.ToInt32(DateTime.Now.ToString("HH"));
            if (n>14 || n <24)
            {
                lblFormato.Text = "FM";

            }
            else
            {
                lblFormato.Text = "AM";


            }
        }
    }
}
