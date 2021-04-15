using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Biblioteka;

namespace SistemskeOperacije.VideoIgraSO
{
    public class ZapamtiVideoIgru:OpstaSO
    {
        public override object Izvrsi(Biblioteka.OpstiDomenskiObjekat odo)
        {
            //VideoIgra vi = odo as VideoIgra;
            //vi.Tabela = "Naslov";
            return Sesija.Broker.dajSesiju().izmeni(odo);
            //vi.Tabela = "Opis";

        }
    }
}
