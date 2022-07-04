﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Dictionary.Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<StatoItaliano, string>> anagraficaCittadino = new Dictionary<string, Dictionary<StatoItaliano, string>>();
            anagraficaCittadino.Add("FRRBRN81AZ602H", new Dictionary<StatoItaliano, string>());
            anagraficaCittadino["FRRBRN81AZ602H"].Add(StatoItaliano.ANAGRAFE, "Residenza: Via roma 80 -  Milano 20141");

            Dictionary<StatoItaliano, string> MyValues = anagraficaCittadino["FRRBRN81AZ602H"];
            string residenza = MyValues[StatoItaliano.ANAGRAFE];
            Console.WriteLine(residenza);
            #region
            //   Dictionary<string, string> dizionario1 = new Dictionary<string, string>();
            //   Dictionary<int, string> dizionario2 = new Dictionary<int, string>();
            //   Dictionary<Crypto, List<string>> dizionario3 = new Dictionary<Crypto, List<string>>();

            //    dizionario1.Add("FRRBRN81AZ602H", "Bruno Ferreira");
            //    dizionario2.Add(54420001, "BANCA ING");


            //    dizionario3.Add(Crypto.ETH,new List<string>());

            //    dizionario3[Crypto.ETH].Add("Hai effettuato la transazione di 1000 EURO");
            //    dizionario3[Crypto.ETH].Add("Hai effettuato la transazione di 500 EURO");
            //    dizionario3[Crypto.ETH].Add("Hai effettuato la transazione di 10000 EURO");
            //    List<string> MieOperazioniETH = dizionario3[Crypto.ETH];
            //    List<string> MieOperazioniBTC = null;

            //    // RISULTATI

            //    Console.WriteLine(dizionario1["FRRBRN81AZ602H"]);
            //    Console.WriteLine(dizionario2[54420001]);


            //    foreach (string opr in MieOperazioniETH)
            //        Console.WriteLine(opr);

            //    if (dizionario3.ContainsKey(Crypto.BTC))
            //    {
            //        dizionario3[Crypto.BTC].Add("Hai effettuato la transazione di 10000 EURO in BTC");

            //    }
            //    else
            //    {
            //        dizionario3.Add(Crypto.BTC,new List<string>());
            //        MieOperazioniBTC = dizionario3[Crypto.BTC];
            //        dizionario3[Crypto.BTC].Add("Hai effettuato la transazione di 10000 EURO in BTC");

            //    }
            //    Console.ForegroundColor =  ConsoleColor.Red; 
            //    foreach (string opr in MieOperazioniBTC)
            //        Console.WriteLine(opr);


            //    Console.ResetColor(); 
            //} 
            #endregion
        }
        public enum Crypto
        {
            BTC,
            ETH
        }
        public enum StatoItaliano
        {
            ASL,
            INPS,
            UNIVERSITA,
            ANAGRAFE
        }
        }
}
