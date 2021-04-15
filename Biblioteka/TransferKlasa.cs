using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Biblioteka
{
    public enum Operacije { Kraj = 1, Odustani, KreirajProdaju, ZapamtiProdaju, PretraziProdaje, Ucitaj, UcitajProdaju, ObrisiProdaju, VratiSvePlatforme, KreirajVideoIgru, ZapamtiVideoIgru, ObrisiVideoIgru, PretraziVideoIgre, UcitajVideoIgru, VratiSveVideoIgre, VratiSveProdavce }
    [Serializable]
    public class TransferKlasa
    {
        Operacije operacija;

        public Operacije Operacija
        {
            get { return operacija; }
            set { operacija = value; }
        }
        Object transferObjekat;

        public Object TransferObjekat
        {
            get { return transferObjekat; }
            set { transferObjekat = value; }
        }
        Object rezultat;

        public Object Rezultat
        {
            get { return rezultat; }
            set { rezultat = value; } 
        }
    }
}
