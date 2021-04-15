using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Biblioteka;

namespace SistemskeOperacije.ProdajaSO
{
    public class ZapamtiProdaju:OpstaSO
    {
        public override object Izvrsi(Biblioteka.OpstiDomenskiObjekat odo)
        {
            Sesija.Broker.dajSesiju().izmeni(odo);
            Prodaja p = odo as Prodaja;
            StavkaProdaje sp = new StavkaProdaje();
            sp.ProdajaID = p.ProdajaID;
            Sesija.Broker.dajSesiju().obrisiZaUslovVise(sp);
            
            foreach (StavkaProdaje s in p.ListaStavki) 
            {
                Sesija.Broker.dajSesiju().sacuvaj(s);
            }

            return 1;
        }
    }
}
