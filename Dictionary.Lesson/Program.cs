using System;
using System.Collections.Generic;
using System.Linq;

namespace Dictionary.Lesson
{
    internal class Program
    {   public enum Corsi
        {
            INFORMATICA,
            LETTERE,
            FISICA
        }
        public enum Esami
        {
            PROGRAMMAZIONE,
            INGLESE,
            STORIA,
            MATEMATICA
        }
       
        static void Main(string[] args)
        {

            //CREATE UNIVERSITA'
            Dictionary<Corsi, Dictionary<string, Dictionary<Esami, int>>> universitaNetuno =
                new Dictionary<Corsi, Dictionary<string, Dictionary<Esami, int>>>();

            //Add CORSI
            universitaNetuno.Add(Corsi.FISICA, new Dictionary<string, Dictionary<Esami, int>>());
            universitaNetuno.Add(Corsi.LETTERE, new Dictionary<string, Dictionary<Esami, int>>());
            universitaNetuno.Add(Corsi.INFORMATICA, new Dictionary<string, Dictionary<Esami, int>>());

            // ADD matricole 
            universitaNetuno[Corsi.LETTERE].Add("1911584888", new Dictionary<Esami, int>());



            // Add ESAMI alla MATRICOLA
            universitaNetuno[Corsi.LETTERE]["1911584888"].Add(Esami.STORIA, 18);
            universitaNetuno[Corsi.LETTERE]["1911584888"].Add(Esami.PROGRAMMAZIONE, 18);
            universitaNetuno[Corsi.LETTERE]["1911584888"].Add(Esami.INGLESE, 20);


            foreach (var studenti in universitaNetuno[Corsi.LETTERE])
            {
                Console.WriteLine($"STUDENTE MATRICOLA: {studenti.Key} ");
                foreach (var esame in studenti.Value)
                {
                    Console.WriteLine($"            Esame: {esame.Key}, Voto: {esame.Value} ");

                }
            }
        }





        //Dictionary<Corsi, List<string>> universita = new Dictionary<Corsi, Dictionary<string,>>();
        //universita.Add(Corsi.FISICA,new Dictionary<string>()); 
        //universita.Add(Corsi.INFORMATICA,new Dictionary<string>());
        //universita.Add(Corsi.LETTERE,new Dictionary<string>());

        //for (int i = 0; i < 10;i++)
        //{   
        //    Random random = new Random();   
        //    universita[Corsi.FISICA].Add(random.Next(1000,20000).ToString());
        //    universita[Corsi.INFORMATICA].Add(random.Next(1000,20000).ToString());
        //    universita[Corsi.LETTERE].Add(random.Next(1000,20000).ToString());
        //}





        //List<string> myList = new List<string>();

        //myList.Add("Bruno");

        //Dictionary<string, Dictionary<string, object>> Banca = new Dictionary<string, Dictionary<string, object>>();

        //Banca.Add("FRBRNR93NFN32988", new List<ContoCorrente>());
        //Banca["FRBRNR93NFN32988"].Add(new ContoCorrente(1000));
        //Banca["FRBRNR93NFN32988"].Add(new ContoCorrente(1001));
        //Banca["FRBRNR93NFN32988"].Add(new ContoCorrente(1002));
        //Banca["FRBRNR93NFN32988"].Add(new ContoCorrente(1003));


        ///// COLLECTION 
        ///// ARRAY, LIST , DICTIONARY 

        //foreach (var conti in Banca["FRBRNR93NFN32988"])
        //{
        //    Console.WriteLine(conti._accountNumber);
        //}


        //Dictionary<string, Dictionary<StatoItaliano, List<string>>> Cittadino = new Dictionary<string, Dictionary<StatoItaliano, List<string>>>();
        //Cittadino.Add("FRRBRN81AZ602H", new Dictionary<StatoItaliano,List<string>>());
        //Cittadino["FRRBRN81AZ602H"].Add(StatoItaliano.ANAGRAFE, new List<string>());
        //Cittadino["FRRBRN81AZ602H"].Add(StatoItaliano.ASL, new List<string>());
        //Cittadino["FRRBRN81AZ602H"].Add(StatoItaliano.INPS, new List<string>());
        //Cittadino["FRRBRN81AZ602H"].Add(StatoItaliano.UNIVERSITA, new List<string>());

        //Dictionary<StatoItaliano, List<string>> FRRBRN81AZ602H = Cittadino["FRRBRN81AZ602H"];
        //List<string> datiAnagrafe = FRRBRN81AZ602H[StatoItaliano.ANAGRAFE];
        //datiAnagrafe.Add("Residenza: Via roma 80 - Milano - 20141"); 
        //datiAnagrafe.Add("Domicilio: Via Torino 100 - Milano - 20141");


        //List<string> datiINPS = FRRBRN81AZ602H[StatoItaliano.INPS];
        //datiINPS.Add("Pesione: 800EURO"); 


        //foreach (var datoAnagrafe in FRRBRN81AZ602H[StatoItaliano.ANAGRAFE])
        //{
        //    Console.WriteLine(datoAnagrafe);
        //}
        //foreach (var datoinps in FRRBRN81AZ602H[StatoItaliano.INPS])
        //{  
        //    Console.WriteLine(datoinps);
        //}

        //if (Cittadino.ContainsKey("FRRBRN81AZ602H"))
        //{

        //}

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

        //public enum StatoItaliano
        //{
        //    ASL,
        //    INPS,
        //    UNIVERSITA,
        //    ANAGRAFE
        //}
        //public class ContoCorrente
        //{
        //    public int _accountNumber { get; set; }

        //    public ContoCorrente(int AccountNumber)
        //    {
        //        _accountNumber = AccountNumber;
        //    }
        //}

    }
}
