using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TmLms.OtherUCs
{
    public partial class PokemonHeightWeight : UserControl
    {
        public PokemonHeightWeight(long height, long weight)
        {
            InitializeComponent();
            this.heightLbl.Text = height.ToString();
            this.weightLbl.Text = weight.ToString();
        }
    }
}
