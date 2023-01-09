using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TmLms.API_Modeling
{
    public class PokeData
    {
        [JsonProperty("height")]
        public long Height { get; set; }

        [JsonProperty("weight")]
        public long Weight { get; set; }

        [JsonProperty("base_experience")]
        public long BaseExperience { get; set; }
    }
}
