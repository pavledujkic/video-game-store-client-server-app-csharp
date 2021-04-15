using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Biblioteka;

namespace SistemskeOperacije.VideoIgraSO
{
    public class KreirajVideoIgru:OpstaSO
    {
        public override object Izvrsi(Biblioteka.OpstiDomenskiObjekat odo)
        {
            VideoIgra vi = odo as VideoIgra; 
            vi.VideoIgraID = Sesija.Broker.dajSesiju().dajSifru(vi);
            Sesija.Broker.dajSesiju().sacuvaj(vi);
            return vi;
        }
    }
}
