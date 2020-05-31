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
    public partial class ViajePais : Form
    {
        string DPI = "";
        string pais = "";
        public ViajePais()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DPI = tbDPI.Text;

            existePasaporte(DPI);
        }

        public void existePasaporte(string DPI)
        {
            string passport = "";
            RandomNum num = new RandomNum();
            int a = num.randomNumber();

            switch(a)
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
                    tbCountry.Text = rs.Data[0].PaisActual;

                    pais = rs.Data[0].PaisActual;
                    btnUpdate.Enabled = true;
                    tbDPI.ReadOnly = true;
                }
                else
                {
                    MessageBox.Show("No existen los datos correspondientes");
                }

            }
            catch (Exception)
            {

                MessageBox.Show("No existen los datos correspondientes");

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            actualizarPais();
        }

        private void actualizarPais()
        {
            pais = tbCountryLeave.Text;

            var client = new MongoClient("mongodb+srv://Brian:nintendo99@cluster0-fxj7b.mongodb.net/test?retryWrites=true&w=majority");
            var database = client.GetDatabase("test");
            var collection = database.GetCollection<BsonDocument>("peoples");

            var filter = Builders<BsonDocument>.Filter.Eq("DPI", DPI);

            var update = Builders<BsonDocument>.Update.Set("PaisActual", pais);
            try
            {
                collection.UpdateOne(filter, update);

                MessageBox.Show("Pais actualizado");
            }
            catch (Exception)
            {

                MessageBox.Show("No se pudo actualizar");
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            MenuInicial mi = new MenuInicial();
            mi.Show();
            this.Hide();
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


    }
}
