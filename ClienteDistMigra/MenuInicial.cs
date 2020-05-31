using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteDistMigra
{
    public partial class MenuInicial : Form
    {
        public MenuInicial()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void pbRegistrar_Click(object sender, EventArgs e)
        {
            registroPasaporte rp = new registroPasaporte();
            rp.Show();
            this.Hide();
        }

        private void pbRenovar_Click(object sender, EventArgs e)
        {
            RenovacionPasaporte RePa = new RenovacionPasaporte();
            RePa.Show();
            this.Hide();

        }

        private void pbViajar_Click(object sender, EventArgs e)
        {
            ViajePais vp = new ViajePais();
            vp.Show();
            this.Hide();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
