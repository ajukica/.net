using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektWF
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnArtikli_Click(object sender, EventArgs e)
        {
            Artikli artikli = new Artikli();
            artikli.ShowDialog();
        }

        private void btnNoviRacun_Click(object sender, EventArgs e)
        {
            btnRacun racun = new btnRacun();
            racun.ShowDialog(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
