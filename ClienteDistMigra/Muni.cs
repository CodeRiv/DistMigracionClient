using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Globalization;



namespace ClienteDistMigra
{
    class Muni
    {
        public bool success { get; set; }
        public IList<MuniDatum> data { get; set; }
    }

    public partial class MuniDatum
    {
        public string _id { get; set; }
        public string numBoleto { get; set; }
        public string numVIN { get; set; }
        public string estado { get; set; }
        public int __v { get; set; }
    }
}
