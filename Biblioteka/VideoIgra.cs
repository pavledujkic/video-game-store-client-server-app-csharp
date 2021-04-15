using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.ComponentModel;

namespace Biblioteka
{
    [Serializable]
    public class VideoIgra:OpstiDomenskiObjekat
    {

        public override string ToString()
        {
            return naslov;
        }

        int videoIgraID;

        public int VideoIgraID
        {
            get { return videoIgraID; }
            set { videoIgraID = value; }
        }
        string naslov;

        public string Naslov
        {
            get { return naslov; }
            set { naslov = value; }
        }
        string opis;

        public string Opis
        {
            get { return opis; }
            set { opis = value; }
        }
        double cena;

        public double Cena
        {
            get { return cena; }
            set { cena = value; }
        }
        Platforma platforma;
        [Browsable(false)]
        public Platforma Platforma
        {
            get { return platforma; }
            set { platforma = value; }
        }

        

        #region ODO
        [Browsable(false)]

        public string tabela
        {
            get { return "VideoIgra"; }
        }
        [Browsable(false)]

        public string kljuc
        {
            get { return "VideoIgraID"; }
        }
        [Browsable(false)]

        public string uslovJedan
        {
            get { return "VideoIgraID=" + videoIgraID; }
        }
        [Browsable(false)]

        public string uslovVise
        {
            get { return "Naslov like '"+naslov+"%'"; }
        }
        [Browsable(false)]

        public string azuriranje
        {
            get { return " Naslov='"+naslov+"', Opis='"+Opis+"', Cena="+Cena+", PlatformaID="+platforma.PlatformaID+" "; }
        }
        [Browsable(false)]

        public string upisivanje
        {
            get { return " (VideoIgraID) values (" + videoIgraID + ")"; }
           
        }

        public OpstiDomenskiObjekat napuni(DataRow red)
        {
            try
            {
                VideoIgra vi = new VideoIgra();
                vi.VideoIgraID = Convert.ToInt32(red[0]);
                vi.Naslov = red[1].ToString();
                vi.Opis = red[2].ToString();
                vi.Cena = Convert.ToDouble(red[3]);
                vi.Platforma = new Platforma();
                vi.Platforma.PlatformaID = Convert.ToInt32(red[4]);

                return vi;
            }
            catch (Exception)
            {

                return null;
            }
        } 
        #endregion
    }
}
