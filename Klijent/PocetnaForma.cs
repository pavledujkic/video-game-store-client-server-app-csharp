using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using KontrolerKorisnickogInterfejsa;

namespace Klijent
{
    public partial class PocetnaForma : Form
    {
        KontrolerKI kki = new KontrolerKI();
        public PocetnaForma()
        {
            InitializeComponent();
            if (KontrolerKI.poveziSeNaServer()) this.Text = "Uspesno povezan!";
        }

        private void unosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new UnosVideoIgre().ShowDialog();
        }

        private void pretragaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new PretragaVideoIgara().ShowDialog();
        }

        private void unosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new UnosProdaje().ShowDialog();
        }

        private void pretragaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new PretragaProdaje().ShowDialog();

        }

        private void PocetnaForma_Load(object sender, EventArgs e)
        {

        }

        private void PocetnaForma_FormClosed(object sender, FormClosedEventArgs e)
        {
            kki.kraj();
        }
    }
}
