using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Web;
using System.Security.Policy;

namespace TmLms.API_Modeling
{
    public class APIRequest
    {
        public string url { get; set; }
        public string url2 { get; set; }

        public APIRequest()
        {
            this.url = "https://pokeapi.co/api/v2/pokemon?limit=1&offset=";
            this.url2 = "https://pokeapi.co/api/v2/pokemon/";
        }

        public PokeDataMap GetData(int pokeid)
        {
            var consult = (HttpWebRequest)WebRequest.Create(url+pokeid.ToString());
            consult.Method = "GET";
            consult.ContentType = "application/json";
            consult.Accept = "application/json";

            try
            {
                using (WebResponse resp = consult.GetResponse())
                {
                    using (System.IO.Stream stream = resp.GetResponseStream())
                    {
                        if (stream == null)
                        {
                            return null;
                        }
                        using (StreamReader lector = new StreamReader(stream))
                        {
                            string responsetext = lector.ReadToEnd();
                            PokeDataMap pokemondata = JsonConvert.DeserializeObject<PokeDataMap>(responsetext);

                            return pokemondata;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public PokeData GetPokemonData(int index)
        {
            var consult = (HttpWebRequest)WebRequest.Create(url2 + index);
            consult.Method = "GET";
            consult.ContentType = "application/json";
            consult.Accept = "application/json";

            try
            {
                using (WebResponse resp = consult.GetResponse())
                {
                    using (System.IO.Stream stream = resp.GetResponseStream())
                    {
                        if (stream == null)
                        {
                            return null;
                        }
                        using (StreamReader lector = new StreamReader(stream))
                        {
                            string responsetext = lector.ReadToEnd();
                            PokeData pokemondata = JsonConvert.DeserializeObject<PokeData>(responsetext);

                            return pokemondata;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
