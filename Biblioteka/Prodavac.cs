using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.ComponentModel;

namespace Biblioteka
{
    [Serializable]
    public class Prodavac:OpstiDomenskiObjekat
    {
        public override string ToString()
        {
            return imePrezime;
        }

        public override bool Equals(object obj)
        {
            try
            {
                Prodavac p = obj as Prodavac;
                if (p == null)
                {
                    return false;
                }
                if (p.ProdavacID == this.ProdavacID) return true;
                else return false;
            }
            catch (Exception)
            {

                return false;
            }
        }
         
        
        
        int prodavacID;

        public int ProdavacID
        {
            get { return prodavacID; }
            set { prodavacID = value; }
        }
        string imePrezime;

        public string ImePrezime
        {
            get { return imePrezime; }
            set { imePrezime = value; }
        }

        #region ODO
        [Browsable(false)]

        public string tabela
        {
            get { return "Prodavac"; }
        }
        [Browsable(false)]

        public string kljuc
        {
            get { return null; }
        }
        [Browsable(false)]

        public string uslovJedan
        {
            get { return "ProdavacID="+ProdavacID; }
        }
        [Browsable(false)]

        public string uslovVise
        {
            get { return null; }
        }
        [Browsable(false)]

        public string azuriranje
        {
            get { return null; }
        }
        [Browsable(false)]

        public string upisivanje
        {
            get { return null; }

        }

        public OpstiDomenskiObjekat napuni(DataRow red)
        {
            Prodavac p = new Prodavac();
            p.ProdavacID = Convert.ToInt32(red[0]);
            p.ImePrezime = red[1].ToString();
        
            return p;
        }
        #endregion 
    }
}
