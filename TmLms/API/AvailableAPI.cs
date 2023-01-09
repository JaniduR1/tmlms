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
    public partial class AvailableAPI : Form
    {
        public AvailableAPI()
        {
            InitializeComponent();
        }

        private void pokeAPILbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PokemonAPI pokemonAPI = new PokemonAPI();
            pokemonAPI.Show();
        }
    }
}
