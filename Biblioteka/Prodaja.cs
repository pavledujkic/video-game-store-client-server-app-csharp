using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.ComponentModel;

namespace Biblioteka
{
    [Serializable]
    public class Prodaja:OpstiDomenskiObjekat
    {
        int prodajaID;

        public int ProdajaID
        {
            get { return prodajaID; }
            set { prodajaID = value; }
        }

        DateTime datumProdaje;

        public DateTime DatumProdaje
        {
            get { return datumProdaje; }
            set { datumProdaje = value; }
        }
        double iznosZaNaplatu;

        public double IznosZaNaplatu
        {
            get { return iznosZaNaplatu; }
            set { iznosZaNaplatu = value; }
        }
        Prodavac prodavac;
        [Browsable(false)]
        public Prodavac Prodavac
        {
            get { return prodavac; }
            set { prodavac = value; }
        }

        BindingList<StavkaProdaje> listaStavki;

        public BindingList<StavkaProdaje> ListaStavki
        {
            get { return listaStavki; }
            set { listaStavki = value; }
        }

        public Prodaja()
        {
            listaStavki = new BindingList<StavkaProdaje>();
        }


        #region ODO
        [Browsable(false)]

        public string tabela
        {
            get { return "Prodaja"; }
        }
        [Browsable(false)]

        public string kljuc
        {
            get { return "ProdajaID"; }
        }
        [Browsable(false)]

        public string uslovJedan
        {
            get { return "ProdajaID="+ProdajaID; }
        }
        [Browsable(false)]

        public string uslovVise
        {
            get { return " Day(DatumProdaje)=" + datumProdaje.Day + " and Month(DatumProdaje)=" + datumProdaje.Month + " and Year(DatumProdaje)=" + datumProdaje.Year + ""; }
        }
        [Browsable(false)]

        public string azuriranje
        {
            get { return " DatumProdaje='" + datumProdaje.ToString("yyyy-MM-dd") + "', IznosZaNaplatu=" + IznosZaNaplatu + ", ProdavacID=" + prodavac.ProdavacID + ""; }
        }
        [Browsable(false)]

        public string upisivanje
        {
            get { return "(ProdajaID) values (" + prodajaID +")"; }

        }

        public OpstiDomenskiObjekat napuni(DataRow red)
        {
            Prodaja p = new Prodaja();
            p.ProdajaID = Convert.ToInt32(red[0]);
            p.DatumProdaje = Convert.ToDateTime(red[1]);
            p.IznosZaNaplatu = Convert.ToDouble(red[2]);
            p.Prodavac = new Prodavac();
            p.Prodavac.ProdavacID = Convert.ToInt32(red[3]);

            return p;
        }
        #endregion 
    }
}
