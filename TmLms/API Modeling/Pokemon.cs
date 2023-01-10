using System;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace TmLms.API_Modeling
{
    public class Pokemon
    {
        APIRequest api = new APIRequest();
        
        string index;
        public string name { get; set; }
        public string url { get; set; }



        private string getIndex()
        {
            string dir = url.ToString();
            dir = dir.Substring(0, dir.Length - 1);
            dir = dir.Substring(dir.LastIndexOf("/"));
            index = dir.Replace("/", "");
            return dir;
        }
        public Image GetImage()
        {

            var request = WebRequest.Create("https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/" + getIndex() + ".png");
            using (var response = request.GetResponse())
            {
                using (var stream = response.GetResponseStream())
                {
                    return Bitmap.FromStream(stream);
                }
            }
        }

        public long GetHeight()
        {
            PokeData pd = new PokeData();
            pd = api.GetPokemonData(Convert.ToInt32(index));
            return pd.Height;
        }

        public long GetWeight()
        {
            PokeData pd = new PokeData();
            pd = api.GetPokemonData(Convert.ToInt32(index));
            return pd.Weight;
        }

    }
}
