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
    public partial class Artikli : Form
    {
        public Artikli()
        {
            InitializeComponent();
        }

        private void Artikli_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_FastFood_MDFDataSet.Artikli' table. You can move, or remove it, as needed.
            this.artikliTableAdapter.Fill(this._FastFood_MDFDataSet.Artikli);

        }
    }
}
