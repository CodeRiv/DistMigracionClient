using MongoDB.Bson;
using MongoDB.Driver;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteDistMigra
{
    public partial class RenovacionPasaporte : Form
    {
        string DPI = "";
        DateTime fechaexp = new DateTime();
        DateTime fechaActual = new DateTime();


        public RenovacionPasaporte()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DPI = tbDPI.Text;

            existePasaporte(DPI);

        }

        private void existePasaporte(string DPI)
        {
            string passport = "";

            RandomNum num = new RandomNum();
            int a = num.randomNumber();

            switch (a)
            {
                case 1:
                    {
                        passport = "https://distmigra.herokuapp.com/api/people/" + DPI;
                        break;
                    }
                case 2:
                    {
                        passport = "https://distmigracion.cleverapps.io/api/people/" + DPI;
                        break;
                    }

            }
            var data = "";
            try
            {
                WebClient wc = new WebClient();
                data = wc.DownloadString(passport);

                var rs = JsonConvert.DeserializeObject<Passport>(data);

                if (rs.Success == true)
                {
                    txtResNombre.Text = rs.Data[0].Primernombre;
                    txtResSegundoNombre.Text = rs.Data[0].Segundonombre;
                    txtResApellido.Text = rs.Data[0].Primerapellido;
                    txtSegundoApellido.Text = rs.Data[0].Segundoapellido;

                    fechaexp = rs.Data[0].Fechaexpiracion.UtcDateTime;

                    fechaActual = DateTime.UtcNow;

                    tbExp.Text = fechaexp.ToString();

                    if (comparar(fechaActual, fechaexp) == -1 )
                    {
                        txtResStatus.Text = "Actualmente válido";
                    }
                    else
                    {
                        txtResStatus.Text = "Vencido";
                    }
                    tbDPI.ReadOnly = true;
                    btnRenovar.Enabled = true;

                }
                else
                {
                    MessageBox.Show("No existe registro de pasaporte");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No existe registro de pasaporte");
            }
        }

        private void tbDPI_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbDPI.Text))
            {
                btnSearch.Enabled = false;
            }

            if (!String.IsNullOrWhiteSpace(tbDPI.Text))
            {
                btnSearch.Enabled = true;
            }
        }

        private void tbOrnato_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRenovar_Click(object sender, EventArgs e)
        {
            string ornato = tbOrnato.Text;

            string result = ValidarBoleto(ornato);

            if (result == "true")
            {
                renovarPasaporte(DPI);
            }
            else
            {
                MessageBox.Show("Ingrese un número de boleto de ornato válido");
            }
        }

        public void renovarPasaporte(string DPI)
        {
            DateTime fechanueva = new DateTime();
            fechanueva = fechaActual;
            fechanueva = fechanueva.AddYears(5);

            var client = new MongoClient("mongodb+srv://Brian:nintendo99@cluster0-fxj7b.mongodb.net/test?retryWrites=true&w=majority");
            var database = client.GetDatabase("test");
            var collection = database.GetCollection<BsonDocument>("peoples");

            var filter = Builders<BsonDocument>.Filter.Eq("DPI", DPI);

            var update = Builders<BsonDocument>.Update.Set("fechaexpiracion", fechanueva);

            try
            {
                collection.UpdateOne(filter, update);

                MessageBox.Show("Pasaporte actualizado");
                txtResStatus.Text = "Actualmente válido";
                tbExp.Text = fechanueva.ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("No se pudo actualizar");
            }


        }

        public int comparar(DateTime Actual, DateTime exp)
        {
            int compare = DateTime.Compare(fechaActual, fechaexp);

            return compare;

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtResStatus_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtSegundoApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtResApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtResSegundoNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtResNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tbExp_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            MenuInicial mi = new MenuInicial();
            mi.Show();
            this.Hide();
        }

        public string ValidarBoleto(string Ornato)
        {
            string URLdataBoleto = "https://muni-boleto.herokuapp.com/api/boleto/" + Ornato;
            var datOrnato = "";


            try
            {
                WebClient wcb = new WebClient();
                datOrnato = wcb.DownloadString(URLdataBoleto);

                var rs2 = JsonConvert.DeserializeObject<Muni>(datOrnato);

                try
                {
                    if (rs2.data[0].estado == "Al dia")
                    {
                        return "true";
                    }
                    else
                    {
                        return "false";
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("No existe dicho registro");
                    return "false";
                }


            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
