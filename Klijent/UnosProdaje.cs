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
    public partial class UnosProdaje : Form
    {
        KontrolerKorisnickogInterfejsa.KontrolerKI kki = new KontrolerKorisnickogInterfejsa.KontrolerKI();
        public UnosProdaje()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            kki.kreirajProdaju(txtID,groupBox1,cmbProdavac,cmbVideoIgra,dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kki.dodajStavku(cmbVideoIgra, txtIznosZaNaplatu, txtKolicina);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kki.obrisiStavku(dataGridView1,txtIznosZaNaplatu);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (kki.sacuvajProdaju(dtpDatumProdaje, cmbProdavac)) this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            kki.odustaniOdProdaje();
            this.Close();
        }

        private void UnosProdaje_FormClosed(object sender, FormClosedEventArgs e)
        {
            kki.odustaniOdProdaje();
        }

        private void UnosProdaje_Load(object sender, EventArgs e)
        {

        }
    }
}
