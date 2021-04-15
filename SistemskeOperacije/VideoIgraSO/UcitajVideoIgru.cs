using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Biblioteka;

namespace SistemskeOperacije.VideoIgraSO
{
    public class UcitajVideoIgru:OpstaSO
    {
        public override object Izvrsi(Biblioteka.OpstiDomenskiObjekat odo)
        {
            VideoIgra vi = odo as VideoIgra;

            vi.Platforma = Sesija.Broker.dajSesiju().dajZaUslovJedan(vi.Platforma) as Platforma;

            return vi;
        }
    }
}
