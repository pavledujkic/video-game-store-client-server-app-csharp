using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Biblioteka;

namespace SistemskeOperacije.ProdajaSO
{
    public class KreirajProdaju:OpstaSO
    {
        public override object Izvrsi(Biblioteka.OpstiDomenskiObjekat odo)
        {
            Prodaja r = odo as Prodaja;
            r.ProdajaID = Sesija.Broker.dajSesiju().dajSifru(r); 
            Sesija.Broker.dajSesiju().sacuvaj(r);
            return r;
        }
    }
}
