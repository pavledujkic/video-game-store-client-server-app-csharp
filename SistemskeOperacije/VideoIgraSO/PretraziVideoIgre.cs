using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Biblioteka;

namespace SistemskeOperacije.VideoIgraSO
{
    public class PretraziVideoIgre:OpstaSO
    {
        public override object Izvrsi(Biblioteka.OpstiDomenskiObjekat odo)
        {
           return Sesija.Broker.dajSesiju().dajSveZaUslovVise(odo).OfType<VideoIgra>().ToList<VideoIgra>();
        }
    }
}
