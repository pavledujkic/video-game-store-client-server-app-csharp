using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Biblioteka;

namespace SistemskeOperacije.VideoIgraSO
{
    public class VratiSvePlatforme:OpstaSO
    {
        public override object Izvrsi(Biblioteka.OpstiDomenskiObjekat odo)
        {
            return Sesija.Broker.dajSesiju().dajSve(odo).OfType<Platforma>().ToList<Platforma>();
        }
    }
}
