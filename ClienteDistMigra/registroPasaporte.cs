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
using MongoDB.Bson;
using MongoDB.Driver;

namespace ClienteDistMigra
{
    public partial class registroPasaporte : Form
    {
        string DPI = "";
        public registroPasaporte()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DPI = tbDPI.Text;

            if (verificarValidez(DPI) == "true")
            {
                buscarInformacion(DPI);
                btnRegistrar.Enabled = true;
            }

            else
            {
                MessageBox.Show("El número del DPI ingresado no existe");
            }

        }

        private string verificarValidez(string DPI)
        {
            var data = "";
            string URLcheck = "https://renap-api.now.sh/api/valid?number=" + DPI;
            try
            {
                WebClient wc = new WebClient();
                data = wc.DownloadString(URLcheck);

                var rs = JsonConvert.DeserializeObject<DPIValid>(data);

                if (rs.Valid == true)
                {
                    return "true";
                }
                else 
                {
                    return "false";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Excepción ocurrida " + ex);
                return "false";
            }
        }

        private void buscarInformacion(string DPI)
        {
            var datDPI = "";
            string URLdata = "https://renap-api.now.sh/api/dpi?number=" + DPI;

            try
            {
                WebClient wc = new WebClient();
                datDPI = wc.DownloadString(URLdata);

                var rs = JsonConvert.DeserializeObject<dataDPI>(datDPI);

                string[] name = rs.FirstName.Split(' ');
                string[] apellido = rs.LastName.Split(' ');
                txtResNombre.Text = name[0];
                try
                {
                    txtResSegundoNombre.Text = name[1];
                }
                catch (Exception)
                {
                    txtResSegundoNombre.Text = "N/A";
                }
                txtResApellido.Text = apellido[0];
                try
                {
                    txtSegundoApellido.Text = apellido[1];
                }
                catch (Exception)
                {
                    txtSegundoApellido.Text = "N/A";
                }

                txtResStatus.Text = "Válido";
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurió un error " + ex);
            }
        }

        private void insertarDatabase(string DPI, string primerNombre, string segundoNombre, string primerApellido, string segundoApellido)
        {
            var client = new MongoClient("mongodb+srv://Brian:nintendo99@cluster0-fxj7b.mongodb.net/test?retryWrites=true&w=majority");
            var database = client.GetDatabase("test");
            var collection = database.GetCollection<BsonDocument>("peoples");

            DateTime date = new DateTime();
            DateTime datexp = new DateTime();

            date = DateTime.UtcNow;

            datexp = DateTime.UtcNow;
            datexp = datexp.AddYears(5);

            string fechaexp = datexp.ToString("yyyy-MM-dd");

            try
            {
                var document = new BsonDocument
{
    { "DPI", DPI },
    { "primernombre", primerNombre },
    { "segundonombre", segundoNombre },
    { "primerapellido", primerApellido},
    { "segundoapellido", segundoApellido },
    { "fechaprimertramite", date},
    { "fechaexpiracion", datexp},
    { "Nacionalidad", "Guatemala" },
    { "PaisActual", "Guatemala"},
    { "_v", "0"}
};
                collection.InsertOne(document);

                MessageBox.Show("Registro añadido exitosamente");
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo añadir el registro, el registro ya existe");
            }



        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DPI = tbDPI.Text;
            string primerNombre = txtResNombre.Text;
            string segundoNombre = txtResSegundoNombre.Text;
            string primerApellido = txtResApellido.Text;
            string segundoApellido = txtSegundoApellido.Text;

            string ornato = tbOrnato.Text;

            string result = ValidarBoleto(ornato);

            if (result == "true")
            {
                insertarDatabase(DPI, primerNombre, segundoNombre, primerApellido, segundoApellido);

            }
            else
            {
                MessageBox.Show("Ingrese un número de boleto de ornato válido");
            }
        }

        private void tbDPI_TextChanged(object sender, EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(tbDPI.Text))
            {
                btnSearch.Enabled = false;
            }

            if (!String.IsNullOrWhiteSpace(tbDPI.Text))
            {
                btnSearch.Enabled = true;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
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
