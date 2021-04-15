using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using Biblioteka;
using Sesija;
using System.Threading;

using SistemskeOperacije.VideoIgraSO;
using SistemskeOperacije;
using SistemskeOperacije.ProdajaSO;

namespace Server
{
    public class Obrada
    {
        BinaryFormatter formater;
        NetworkStream tok;

        public Obrada(NetworkStream tok)
        {
            this.tok = tok;
            formater = new BinaryFormatter();

            ThreadStart ts = obradiKlijenta;
            Thread nit = new Thread(ts);
            nit.Start();
        }

        public void obradiKlijenta() 
        {
            int operacija = 0;
            while (operacija != (int)Operacije.Kraj) 
            {
                TransferKlasa transfer = formater.Deserialize(tok) as TransferKlasa;
                switch (transfer.Operacija)
                {
                    case Operacije.VratiSvePlatforme:
                        VratiSvePlatforme vspl = new VratiSvePlatforme();
                        transfer.Rezultat = vspl.izvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                        formater.Serialize(tok, transfer);
                        break;

                    case Operacije.KreirajVideoIgru:
                        KreirajVideoIgru kvi = new KreirajVideoIgru();
                        transfer.Rezultat = kvi.izvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat); 
                        formater.Serialize(tok, transfer);
                        break;

                    case Operacije.ZapamtiVideoIgru:
                        ZapamtiVideoIgru zvi = new ZapamtiVideoIgru();
                        transfer.Rezultat = zvi.izvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                        formater.Serialize(tok, transfer);
                        break;

                    case Operacije.ObrisiVideoIgru:
                        ObrisiVideoIgru ovi = new ObrisiVideoIgru();
                        transfer.Rezultat = ovi.izvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                        formater.Serialize(tok, transfer);
                        break;

                    case Operacije.PretraziVideoIgre:
                        PretraziVideoIgre pvi = new PretraziVideoIgre();
                        transfer.Rezultat = pvi.izvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                        formater.Serialize(tok, transfer);
                        break;

                    case Operacije.UcitajVideoIgru:
                        UcitajVideoIgru uvi = new UcitajVideoIgru();
                        transfer.Rezultat = uvi.izvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                        formater.Serialize(tok, transfer);
                        break;

                    case Operacije.KreirajProdaju:
                        KreirajProdaju kp = new KreirajProdaju();
                        transfer.Rezultat = kp.izvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                        
                        formater.Serialize(tok, transfer);
                        break;

                    case Operacije.ZapamtiProdaju:
                        ZapamtiProdaju zp = new ZapamtiProdaju();
                        transfer.Rezultat = zp.izvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                        formater.Serialize(tok, transfer);
                        break;

                    case Operacije.VratiSveVideoIgre:
                        VratiSveVideoIgre vsvi = new VratiSveVideoIgre();
                        transfer.Rezultat = vsvi.izvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                        formater.Serialize(tok, transfer);
                        break;

                    case Operacije.VratiSveProdavce:
                        VratiSveProdavce vspr = new VratiSveProdavce();
                        transfer.Rezultat = vspr.izvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                        formater.Serialize(tok, transfer);
                        break;

                    case Operacije.PretraziProdaje:
                        PretraziProdaje pp = new PretraziProdaje();
                        transfer.Rezultat = pp.izvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                        formater.Serialize(tok, transfer);
                        break;

                    case Operacije.UcitajProdaju:
                        UcitajProdaju up = new UcitajProdaju();
                        transfer.Rezultat = up.izvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                        formater.Serialize(tok, transfer);
                        break;

                    case Operacije.ObrisiProdaju:
                        ObrisiProdaju op = new ObrisiProdaju();
                        transfer.Rezultat = op.izvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                        formater.Serialize(tok, transfer);
                        break;

                    case Operacije.Odustani:
                        Odustani o = new Odustani();
                        transfer.Rezultat = o.izvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                        formater.Serialize(tok, transfer);
                        break;


                    case Operacije.Kraj: operacija = 1;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
