using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TmLms.API
{
    public partial class PokemonAPI : Form
    {
        int x = 0;

        API_Modeling.APIRequest apiRequest = new API_Modeling.APIRequest();
        public PokemonAPI()
        {
            InitializeComponent();
            PokemonSetUp();
        }

        private void PokemonSetUp()
        {
            API_Modeling.PokeDataMap pdm = new API_Modeling.PokeDataMap();
            pdm = apiRequest.GetData(x);

            foreach (var item in pdm.PokemonSet)
            {
                OtherUCs.PokemonNameImage pnh = new OtherUCs.PokemonNameImage(item.name, item.GetImage());
                OtherUCs.PokemonHeightWeight phw = new OtherUCs.PokemonHeightWeight(item.GetHeight(), item.GetWeight());
                pokemonLayoutPanel.Controls.Add(pnh);
                statsLayoutPanel.Controls.Add(phw);
            }
            pdm.PokemonSet.Clear();
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            pokemonLayoutPanel.Controls.Clear();
            statsLayoutPanel.Controls.Clear();
            x += 1;
            PokemonSetUp();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            if(x != 0)
            {
                pokemonLayoutPanel.Controls.Clear();
                statsLayoutPanel.Controls.Clear();
                x -= 1;
                PokemonSetUp();
            }
        }
    }
}
