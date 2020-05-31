using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ClienteDistMigra
{
    class dataDPI
    {
        [JsonProperty("due_date")]
        public DateTimeOffset DueDate { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("birth_country")]
        public string BirthCountry { get; set; }

        [JsonProperty("citizenship")]
        public string Citizenship { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("birthdate")]
        public DateTimeOffset Birthdate { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("cui")]
        public string Cui { get; set; }

        [JsonProperty("civil_status")]
        public string CivilStatus { get; set; }

        [JsonProperty("neighbourship")]
        public string Neighbourship { get; set; }
    }
}
