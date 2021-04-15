using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.ComponentModel;

namespace Biblioteka
{
    [Serializable]
    public class StavkaProdaje:OpstiDomenskiObjekat
    {
        int prodajaID;
        [Browsable(false)]
        public int ProdajaID
        {
            get { return prodajaID; }
            set { prodajaID = value; }
        }
        int rb;

        public int RedniBroj
        {
            get { return rb; }
            set { rb = value; }
        }
        int kolicina;

        public int Kolicina
        {
            get { return kolicina; }
            set { kolicina = value; }
        }
        double iznosStavke;

        public double IznosStavke
        {
            get { return iznosStavke; }
            set { iznosStavke = value; }
        }
        VideoIgra videoIgra;

        public VideoIgra VideoIgra
        {
            get { return videoIgra; }
            set { videoIgra = value; }
        }


        #region ODO
        [Browsable(false)]

        public string tabela
        {
            get { return "StavkaProdaje"; }
        }
        [Browsable(false)]

        public string kljuc
        {
            get { return null; }
        }
        [Browsable(false)]

        public string uslovJedan
        {
            get { return null; }
        }
        [Browsable(false)]

        public string uslovVise
        {
            get { return "ProdajaID="+prodajaID; }
        }
        [Browsable(false)]

        public string azuriranje
        {
            get { return null; }
        }
        [Browsable(false)]

        public string upisivanje
        {
            get { return " values (" + prodajaID + ","+rb+","+kolicina+","+iznosStavke+","+videoIgra.VideoIgraID+")"; }

        }

        public OpstiDomenskiObjekat napuni(DataRow red)
        {
            StavkaProdaje sp = new StavkaProdaje();
            sp.ProdajaID = Convert.ToInt32(red[0]);
            sp.RedniBroj = Convert.ToInt32(red[1]);
            sp.Kolicina = Convert.ToInt32(red[2]);
            sp.IznosStavke = Convert.ToDouble(red[3]);
            sp.VideoIgra = new VideoIgra();
            sp.VideoIgra.VideoIgraID = Convert.ToInt32(red[4]);

            return sp;
        }
        #endregion 
    }
}
