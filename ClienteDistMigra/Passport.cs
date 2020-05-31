using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace ClienteDistMigra
{
    class Passport
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("data")]
        public Datum[] Data { get; set; }
    }

    public partial class Datum
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("DPI")]
        public string Dpi { get; set; }

        [JsonProperty("primernombre")]
        public string Primernombre { get; set; }

        [JsonProperty("segundonombre")]
        public string Segundonombre { get; set; }

        [JsonProperty("primerapellido")]
        public string Primerapellido { get; set; }

        [JsonProperty("segundoapellido")]
        public string Segundoapellido { get; set; }

        [JsonProperty("fechaprimertramite")]
        public DateTimeOffset Fechaprimertramite { get; set; }

        [JsonProperty("fechaexpiracion")]
        public DateTimeOffset Fechaexpiracion { get; set; }

        [JsonProperty("Nacionalidad")]
        public string Nacionalidad { get; set; }

        [JsonProperty("PaisActual")]
        public string PaisActual { get; set; }

        [JsonProperty("__v")]
        public long V { get; set; }
    }
}
