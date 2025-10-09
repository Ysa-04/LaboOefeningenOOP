using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOefeningen
{
    internal class DemoAttributen
    {
        enum MilieuNormen
        {
            Euro1, Euro2, Euro3, Euro4, Euro5, Euro6
        }
        class Auto //beginwaarden (default) ->als je perongeluk vergeet, heeft je auto geen onderhoud/geen benzine/is laatste onderhoud 1jan 0001
        {
            //attributen
            //dit is de start van elke auto, geen static gebruiken! 
            public int Kilometers = 5;
            public double Benzine = 10;
            public DateTime LaatsteOnderhoud = DateTime.Now; //datum van aankoop
            public MilieuNormen NormVanAuto; //euronorm van een nieuwe auto is anders dan de oldtimer van den bompa, dit is sowieso afhankelijk van elke auto! Er is ook een europese norm waaraan elke auto moet voldoen
            public static MilieuNormen HuidigeNorm; //ELKE auto moet hieraan voldoen, als dit verandert, verandert dit voor IEDERE auto -> DAAROM is het static.
        }
        public static void DemoAuto1()
        {
            int aantalAutos = 3;
            Auto[] autos = new Auto[aantalAutos]; /*er is maar 1 array, ervoor hadden we een array voor 
                                                    ELKE eigenschap.. we maken ons eigen datatype, nl Auto */
            for (int i = 0; i < aantalAutos; i++) //loopen over array van auto's en elke lock behandelen als een aparte auto
            {
                Auto nieuweAuto = new Auto(); //object aanmaken
                autos[i] = nieuweAuto;
                Console.WriteLine($"Kilometerstand van auto {i + 1}?");
                nieuweAuto.Kilometers = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Benzinepeil van auto {i + 1}?");
                nieuweAuto.Benzine = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"Jaar recentste onderhoud auto {i + 1}?");
                int jaar = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Maand recentste onderhoud auto {i + 1}?");
                int maand = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Dag recentste onderhoud auto {i + 1}?");
                int dag = Convert.ToInt32(Console.ReadLine());
                nieuweAuto.LaatsteOnderhoud = new DateTime(jaar, maand, dag);
            }
            /* later in de code:
            for (int i = 0; i < aantalAutos; i++)
            {
                PrintOnderhoudsrapport(autos[i]);
            } */
        }

        public static void DemoAuto2()
        {
            Auto auto1 = new Auto();
            auto1.NormVanAuto = MilieuNormen.Euro2;
            Console.WriteLine($"auto1 {auto1.NormVanAuto}");
            Auto auto2 = new Auto();
            auto2.NormVanAuto = MilieuNormen.Euro2;
            Console.WriteLine($"auto1 {auto2.NormVanAuto}");
            Auto.HuidigeNorm = MilieuNormen.Euro4;
            Console.WriteLine(Auto.HuidigeNorm);
        }

        // leerdoel: afleren overal static gebruiken, enkel voor dingen zoals die milieunorm dat OVERAL hetzelfde moet zijn
    }
}
