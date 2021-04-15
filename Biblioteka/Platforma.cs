using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Biblioteka
{
    [Serializable]
    public class Platforma:OpstiDomenskiObjekat
    {
        public override string ToString()
        {
            return nazivPlatforme;
        }

        public override bool Equals(object obj)
        {
            
            try
            {
                Platforma p = obj as Platforma;
                if (p == null)
                {
                    return false;
                }
                if (p.PlatformaID == this.platformaID) return true;
                else return false;
            }
            catch (Exception)
            {

                return false;
            }
        }
        
        int platformaID;

        public int PlatformaID
        {
            get { return platformaID; }
            set { platformaID = value; }
        }
        string nazivPlatforme;

        public string NazivPlatforme
        {
            get { return nazivPlatforme; }
            set { nazivPlatforme = value; }
        }


        #region ODO
        public string tabela
        {
            get { return "Platforma"; }
        }

        public string kljuc
        {
            get { return "PlatformaID"; }
        }

        public string uslovJedan
        {
            get { return "PlatformaID=" + platformaID; }
        }

        public string uslovVise
        {
            get { return null; }
        }

        public string azuriranje
        {
            get { return null; }
        }

        public string upisivanje
        {
            get { return null; }
        }

        public OpstiDomenskiObjekat napuni(DataRow red)
        {
            Platforma p = new Platforma();
            p.PlatformaID = Convert.ToInt32(red[0]);
            p.NazivPlatforme = red[1].ToString();

            return p;
        } 
        #endregion 
    }
}
