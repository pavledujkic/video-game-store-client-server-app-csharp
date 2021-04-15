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
    public partial class UnosVideoIgre : Form
    {
        KontrolerKI kki = new KontrolerKI();
        public UnosVideoIgre()
        {
            
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KontrolerKI.videoIgra = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kki.kreirajVideoIgru(txtID, cmbPlatforma, gbVideoIgra);
            this.ActiveControl = txtNaslov;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (kki.zapamtiVideoIgru(txtCena, txtNaslov, txtOpis, cmbPlatforma)) this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            kki.odustaniOdVideoIgre();
            this.Close();
        }

        private void UnosVideoIgre_FormClosed(object sender, FormClosedEventArgs e)
        {
            kki.odustaniOdVideoIgre();
        }
    }
}
