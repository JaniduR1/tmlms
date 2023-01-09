using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TmLms.API_Modeling
{
    public class PokeDataMap
    {
        [JsonProperty("count")]
        public long Count { get; set; }
        [JsonProperty("next")]
        public Uri Next { get; set; }
        [JsonProperty("previous")]
        public object Previous { get; set; }

        [JsonProperty("results")]
        public System.Collections.Generic.List<Pokemon> PokemonSet { get; set; }
    }
}
