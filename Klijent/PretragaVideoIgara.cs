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
    public partial class PretragaVideoIgara : Form
    {
        KontrolerKorisnickogInterfejsa.KontrolerKI kki = new KontrolerKorisnickogInterfejsa.KontrolerKI();
        public PretragaVideoIgara()
        {
            InitializeComponent();
        }

        private void PretragaUsluge_Load(object sender, EventArgs e)
        {
            kki.pretraziVideoIgre(txtNaslov, dataGridView1);
        }

        private void txtNaslov_TextChanged(object sender, EventArgs e)
        {
            kki.pretraziVideoIgre(txtNaslov, dataGridView1);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (kki.ucitajVideoIgru(dataGridView1)) new DetaljiVideoIgre().ShowDialog();
            txtNaslov_TextChanged(sender, e);
        }
    }
}
