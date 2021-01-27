using System;

namespace Library
{
    public class UI
    {

        //Vis startmeny
        public void showMenu() 
        {
            System.Console.WriteLine("------------------------------------------");
            System.Console.WriteLine("Velkommen til bedriftdatabasen.");
            System.Console.WriteLine("Trykk en tast tilsvarende ditt valg.\n");
            System.Console.WriteLine("1: Se alle bedrifter");
            System.Console.WriteLine("2: Finn bedrift via ID");
            System.Console.WriteLine("3: Legg til bedrift");
            System.Console.WriteLine("4: Fjern bedrift");
            System.Console.WriteLine("5: Oppdater en bedrifts med nytt organisasjonsnummer");
            System.Console.WriteLine("6: Avslutt");
            System.Console.WriteLine("------------------------------------------");
        }

        //Vent på at brukeren skal trykke en knapp
        public void wait()
        {
            System.Console.WriteLine("-----------------------------------");
            System.Console.WriteLine("Trykk en knapp for å gå tilbake til hovedmenyen.");
            Console.ReadKey();
        }
    }
}