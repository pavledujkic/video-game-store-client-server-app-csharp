using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Biblioteka;

namespace SistemskeOperacije.ProdajaSO
{
    public class UcitajProdaju:OpstaSO
    {
        public override object Izvrsi(Biblioteka.OpstiDomenskiObjekat odo)
        {
            Prodaja p = odo as Prodaja;
            p.Prodavac = Sesija.Broker.dajSesiju().dajZaUslovJedan(p.Prodavac) as Prodavac;
            StavkaProdaje sp = new StavkaProdaje();
            sp.ProdajaID = p.ProdajaID;
            List<StavkaProdaje> lista = Sesija.Broker.dajSesiju().dajSveZaUslovVise(sp).OfType<StavkaProdaje>().ToList<StavkaProdaje>();

            foreach (StavkaProdaje s in lista) 
            {
                s.VideoIgra = Sesija.Broker.dajSesiju().dajZaUslovJedan(s.VideoIgra) as VideoIgra;
                s.VideoIgra.Platforma = Sesija.Broker.dajSesiju().dajZaUslovJedan(s.VideoIgra.Platforma) as Platforma;

                p.ListaStavki.Add(s);
            }

            return p;
        }
    }
}
