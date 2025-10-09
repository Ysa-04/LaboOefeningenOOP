using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOefeningen
{
    internal class DemoMethoden
    {
        enum MilieuNormen
        {
            Euro1, Euro2, Euro3, Euro4, Euro5, Euro6
        }
        class Auto
        {
            public int Kilometers = 5;
            public double Benzine = 10;
            public DateTime LaatsteOnderhoud = DateTime.Now; //datum van aankoop
            public MilieuNormen NormVanAuto; //euronorm van een nieuwe auto is anders dan de oldtimer van den bompa, dit is sowieso afhankelijk van elke auto! Er is ook een europese norm waaraan elke auto moet voldoen
            public static MilieuNormen HuidigeNorm;

            public void Voltanken()
            {
                Benzine = 50.0; // we veronderstellen even dat dat het maximum is
            }

            public void Rijden(int aantalKilometers)
            {
                Kilometers += aantalKilometers;
                Benzine -= 5.0 * (aantalKilometers / 100.0);
            }

            public void Onderhouden()
            {
                LaatsteOnderhoud = DateTime.Now;
            }

            public double VerkoopsprijsBepalen()
            {
                return Math.Max(10000 * (1 - Kilometers / 200000.0), 1000);
            }
        }

    }
}
