using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace ClienteDistMigra
{
    class DPIValid
    {
        [JsonProperty("valid")]
        public bool Valid { get; set; }
    }
}
