using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Klijent
{
    public partial class DetaljiProdaje : Form
    {
        KontrolerKorisnickogInterfejsa.KontrolerKI kki = new KontrolerKorisnickogInterfejsa.KontrolerKI();
        public DetaljiProdaje()
        {
            InitializeComponent();
        }

        private void DetaljiProdaje_Load(object sender, EventArgs e)
        {
            kki.popuniDetalje(txtIznosZaNaplatu, cmbProdavac, cmbVideoIgra, dataGridView1, dtpDatumProdaje);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kki.dodajStavku(cmbVideoIgra, txtIznosZaNaplatu, txtKolicina);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kki.obrisiStavku(dataGridView1, txtIznosZaNaplatu);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (kki.sacuvajProdaju(dtpDatumProdaje, cmbProdavac)) this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (kki.obrisiProdaju()) this.Close();
        }
    }
}
