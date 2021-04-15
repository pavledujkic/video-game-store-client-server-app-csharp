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
    public partial class DetaljiVideoIgre : Form
    {
        KontrolerKorisnickogInterfejsa.KontrolerKI kki = new KontrolerKorisnickogInterfejsa.KontrolerKI();
        public DetaljiVideoIgre()
        {
            InitializeComponent();
        }

        private void DetaljiUsluge_Load(object sender, EventArgs e)
        {
            kki.popuniPoljaVideoIgre(txtCena, txtNaslov, txtOpis, cmbPlatforma);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (kki.zapamtiVideoIgru(txtCena, txtNaslov, txtOpis, cmbPlatforma)) this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (kki.obrisiVideoIgru()) this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
