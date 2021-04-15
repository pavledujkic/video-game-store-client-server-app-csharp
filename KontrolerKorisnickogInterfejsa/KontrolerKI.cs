using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Komunikacija;
using Biblioteka;
using System.Windows.Forms;

namespace KontrolerKorisnickogInterfejsa
{
    public class KontrolerKI
    {
        public static Komunikacija.Komunikacija komunikacija;
        public static VideoIgra videoIgra;
        public static Prodaja prodaja;

        public static bool poveziSeNaServer()
        {
            komunikacija = new Komunikacija.Komunikacija();
            return komunikacija.poveziSeNaServer();
        }

        public void kraj()
        {
            komunikacija.kraj();
        }

        public void kreirajVideoIgru(TextBox txtID, ComboBox cmbPlatforma, GroupBox gbVideoIgra)
        {
            videoIgra = new VideoIgra();
            
            videoIgra = komunikacija.kreirajVideoIgru(videoIgra) as VideoIgra;

            if (videoIgra == null)
            {
                MessageBox.Show("Sistem ne moze da kreira novu video igru!");
                return;
            }
            else 
            {
                txtID.Text = videoIgra.VideoIgraID.ToString();
                gbVideoIgra.Enabled = true;
                cmbPlatforma.DataSource = komunikacija.vratiSvePlatforme() as List<Platforma>;
                MessageBox.Show("Sistem je kreirao video igru!");
            }


        }

        public bool zapamtiVideoIgru(TextBox txtCena, TextBox txtNaslov, TextBox txtOpis, ComboBox cmbPlatforma)
        {
            videoIgra.Naslov = txtNaslov.Text;
            videoIgra.Opis = txtOpis.Text;
            try
            {
                videoIgra.Cena = Convert.ToDouble(txtCena.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Niste ispravno uneli cenu!");
                return false;
            }

            try
            {
                videoIgra.Platforma = cmbPlatforma.SelectedItem as Platforma;
            }
            catch (Exception)
            {

                MessageBox.Show("Niste odabrali platformu!");
                return false;
            }


            if (videoIgra.Naslov == "") 
            {
                MessageBox.Show("Niste uneli naslov video igre!");
                return false;
            }

            if (videoIgra.Cena <= 0) 
            {
                MessageBox.Show("Cena mora biti veca od 0!");
                return false;
            }


            Object rez = komunikacija.zapamtiVideoIgru(videoIgra);

            if (rez == null)
            {
                MessageBox.Show("Sistem ne moze da zapamti video igru!");
                return false;
            }
            else 
            {
                MessageBox.Show("Sistem je zapamtio video igru!");
                videoIgra = null;
                return true;
            }
        }

        public void odustaniOdVideoIgre()
        {
            if (videoIgra != null) 
            {
                komunikacija.Odustani(videoIgra);
            }
        }

        public void pretraziVideoIgre(TextBox txtNaslov, DataGridView dataGridView1)
        {
            videoIgra = new VideoIgra();
            videoIgra.Naslov = txtNaslov.Text;

            List<VideoIgra> lista = komunikacija.pretraziVideoIgre(videoIgra) as List<VideoIgra>;

            if (lista == null) 
            {
                MessageBox.Show("Sistem ne moze da ucita video igru!");
                return;
            }
            dataGridView1.DataSource = lista;

            if (lista.Count == 0) 
            {
                MessageBox.Show("Nema video igre za uneti kriterijum!");
                return;
            }
            MessageBox.Show("Sistem je uspesno ucitao video igre!");
        }

        public bool ucitajVideoIgru(DataGridView dataGridView1)
        {
            try
            {
                videoIgra = dataGridView1.CurrentRow.DataBoundItem as VideoIgra;

                videoIgra=komunikacija.ucitajVideoIgru(videoIgra) as VideoIgra;

                if (videoIgra == null)
                {
                    MessageBox.Show("Sistem ne moze da ucita video igru!");
                    return false;
                }
                else 
                
                {
                    MessageBox.Show("Sistem je uspesno ucitao video igru!");
                    return true;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Niste odabrali video igru za prikaz!");
                return false;
            }

        }

        public void popuniPoljaVideoIgre(TextBox txtCena, TextBox txtNaslov, TextBox txtOpis, ComboBox cmbPlatforma)
        {
            cmbPlatforma.DataSource = komunikacija.vratiSvePlatforme();

            txtCena.Text = videoIgra.Cena.ToString();
            txtNaslov.Text = videoIgra.Naslov;
            txtOpis.Text = videoIgra.Opis;
            cmbPlatforma.SelectedItem = videoIgra.Platforma;
        }

        public bool obrisiVideoIgru()
        {
            Object rez = komunikacija.obrisiVideoIgru(videoIgra);

            if (rez == null)
            {
                MessageBox.Show("Sistem ne moze da obrise video igru!");
                return false;
            }
            else
            {
                MessageBox.Show("Sistem je obrisao video igru!");
                videoIgra = null;
                return true;
            }
        }

        public void kreirajProdaju(TextBox txtID, GroupBox groupBox1, ComboBox cmbProdavac, ComboBox cmbVideoIgra, DataGridView dataGridView1)
        {
            prodaja = new Prodaja();
            prodaja = komunikacija.kreirajProdaju(prodaja) as Prodaja;

            if (prodaja == null)
            {
                MessageBox.Show("Sistem ne moze da kreira prodaju!");
                return;
            }
            else 
            {
                txtID.Text = prodaja.ProdajaID.ToString();
                cmbProdavac.DataSource = komunikacija.vratiSveProdavce();
                Object tmp = komunikacija.vratiSveVideoIgre();
                cmbVideoIgra.DataSource = tmp;
                dataGridView1.DataSource = prodaja.ListaStavki;
                groupBox1.Enabled = true;
                MessageBox.Show("Sistem je kreirao prodaju!");
            }
        }

        public void dodajStavku(ComboBox cmbVideoIgra, TextBox txtIznosZaNaplatu, TextBox txtKolicina)
        {
            StavkaProdaje sp = new StavkaProdaje();
            sp.ProdajaID = prodaja.ProdajaID;
            sp.RedniBroj = prodaja.ListaStavki.Count + 1;
            try
            {
                sp.VideoIgra = cmbVideoIgra.SelectedItem as VideoIgra;
            }
            catch (Exception)
            {

                MessageBox.Show("Niste odabrali video igru!");
                return;
            }

            try
            {
                sp.Kolicina = Convert.ToInt32(txtKolicina.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Niste ispravno uneli kolicinu!");
                return;
            }

            double iznosZaNaplatu = 0;
            iznosZaNaplatu = sp.VideoIgra.Cena;
            sp.IznosStavke = iznosZaNaplatu;
            prodaja.IznosZaNaplatu += sp.IznosStavke*sp.Kolicina;
            txtIznosZaNaplatu.Text = prodaja.IznosZaNaplatu.ToString();
            prodaja.ListaStavki.Add(sp);
        }

        public void obrisiStavku(DataGridView dataGridView1, TextBox txtIznosZaNaplatu)
        {
            try
            {
                StavkaProdaje sp = dataGridView1.CurrentRow.DataBoundItem as StavkaProdaje;
                prodaja.ListaStavki.Remove(sp);
                prodaja.IznosZaNaplatu -= sp.IznosStavke*sp.Kolicina;
                txtIznosZaNaplatu.Text = prodaja.IznosZaNaplatu.ToString();

                int i = 1;
                foreach (StavkaProdaje s in prodaja.ListaStavki) 
                {
                    s.RedniBroj = i;
                    i++;
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Niste odabrali stavku za brisanje!");
            }
        }

        public bool sacuvajProdaju(DateTimePicker dtpDatumProdaje, ComboBox cmbProdavac)
        {
            prodaja.DatumProdaje = dtpDatumProdaje.Value;
            prodaja.Prodavac = cmbProdavac.SelectedItem as Prodavac;

            Object rez = komunikacija.zapamtiProdaju(prodaja);

            if (rez == null)
            {
                MessageBox.Show("Sistem ne moze da zapamti prodaju!");
                return false;
            }
            else
            {
                MessageBox.Show("Sistem je zapamtio prodaju!");
                prodaja = null;
                return true;
            }
        }
        public void odustaniOdProdaje()
        {
            if (prodaja != null) 
            {
                komunikacija.Odustani(prodaja);
            }
        }


        public void pretraziProdaje(DateTimePicker dtpDatumProdaje, DataGridView dataGridView1)
        {
            prodaja = new Prodaja();
            prodaja.DatumProdaje = dtpDatumProdaje.Value;

            List<Prodaja> lista = komunikacija.pretraziProdaje(prodaja) as List<Prodaja>;

            if (lista == null) 
            {
                MessageBox.Show("Sistem ne moze da pronadje prodaje!");
                return;
            }
            dataGridView1.DataSource = lista;
            if (lista.Count == 0) 
            {
                MessageBox.Show("Nema prodaje za izabrani datum prodaje!");
            }
            else MessageBox.Show("Sistem je pronasao prodaje za izabrani datum prodaje!");
        }

        public bool ucitajProdaju(DataGridView dataGridView1)
        {
            try
            {
                prodaja = dataGridView1.CurrentRow.DataBoundItem as Prodaja;

                prodaja = komunikacija.ucitajProdaju(prodaja) as Prodaja;

                if (prodaja == null)
                {
                    MessageBox.Show("Sistem ne moze da ucita prodaju!");
                    return false;
                }
                else 
                {
                    MessageBox.Show("Sistem je uspesno ucitao prodaju!");
                    return true;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Niste odabrali prodaju!");
                return false;
            }
        }

        public void popuniDetalje(TextBox txtIznosZaNaplatu, ComboBox cmbProdavac, ComboBox cmbVideoIgra, DataGridView dataGridView1, DateTimePicker dtpDatumProdaje)
        {
            txtIznosZaNaplatu.Text = prodaja.IznosZaNaplatu.ToString();
            cmbProdavac.DataSource = komunikacija.vratiSveProdavce();
            cmbVideoIgra.DataSource = komunikacija.vratiSveVideoIgre();
            cmbProdavac.Text = prodaja.Prodavac.ToString();
            dataGridView1.DataSource = prodaja.ListaStavki;
            dtpDatumProdaje.Value = prodaja.DatumProdaje;
        }

        public bool obrisiProdaju()
        {
            Object rez = komunikacija.obrisiProdaju(prodaja);

            if (rez == null)
            {
                MessageBox.Show("Sistem ne moze da obrise prodaju!"); 
                return false;
            }
            else
            {
                MessageBox.Show("Sistem je obrisao prodaju!");
                prodaja = null;
                return true;
            }
        }
    }
}
