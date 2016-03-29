using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Port_classes_console;

namespace GestionPort
{
    public partial class FrmNavire : Form
    {
        public FrmNavire()
        {
            InitializeComponent();
        }

        private void FrmNavire_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Port Toulon = new Port();
            this.labelnbStockages.Text = Toulon.ToString();
           
        }

        private void BtnCreerPort_Click(object sender, EventArgs e)
        {
        }

        private void labelnbStockages_Click(object sender, EventArgs e)
        {

        }

        private void btnCreerStockage_Click(object sender, EventArgs e)
        {
            List<Stockage> unStock = new List<Stockage>();
            var meh = this.numericUpDown1.Value;

            // TODO : MERGE MON PROJET et Utiliser mes propres CLASSES ! MEH MEH MEH MEH MEH
            unStock.Add(meh);
        }
    }
}
