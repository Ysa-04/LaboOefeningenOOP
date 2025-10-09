using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOefeningen
{
    internal class Demo1
    {
        public static void AutoDemo()
        {
            Auto auto = new Auto(); //nieuw object van iets aanmaken
            auto.brand = "Audi"; //deze auto is een Audi.
            Auto auto2 = new Auto();
            auto2.brand = "BMW"; //deze auto is een bmw
            Console.WriteLine(auto.brand);
            Console.WriteLine(auto2.brand);

            Console.WriteLine(auto.price); //dit geeft 0, waarom? DEFAULT waarde. standaard van int/double = 0

            DateTime dateTimeOfTodayTest = new DateTime();
            Console.WriteLine(dateTimeOfTodayTest); //geeft 1/01/0001 0:00:00 (default waarde want er zit niks in)

            DateTime dateTimeOfToday = DateTime.Now; //geeft de tijd en datum van vandaag
            Console.WriteLine(dateTimeOfToday.AddYears(1));


            dateTimeOfToday.AddYears(1);
            Console.WriteLine(dateTimeOfToday); //jaar geeft 2025 want je slaat de add years niet op.

            dateTimeOfToday = dateTimeOfToday.AddYears(1); //nu sla je het wel op en geeft die 2026 als jaar.
            Console.WriteLine(dateTimeOfToday);

            //als je een jaar naar beneden wil (dus naar 2024):
            dateTimeOfToday = dateTimeOfToday.AddYears(-1);

            DateTime otherDate = new DateTime(1989, 2, 10); //je kan hier ook constructors meegeven
            int number = 15;
            DateTime numberDate = new DateTime(1989, 2, number - 5);

            Random rng = new Random();
            DateTime randomDate = new DateTime(1989, rng.Next(1, 13), number - 5);

            Console.WriteLine(dateTimeOfToday.ToLongDateString());

            DateTime now = DateTime.Now;
            Console.WriteLine(now.ToString("d")); // short date 
            Console.WriteLine(now.ToString("D")); // long date
            Console.WriteLine(now.ToString("F")); // full date and time
            Console.WriteLine(now.ToString("M")); // month and day
            Console.WriteLine(now.ToString("o")); // date en time separated by T and time zone at the end
            Console.WriteLine(now.ToString("R")); // RFC1123 date and time
            Console.WriteLine(now.ToString("t")); // short time
            Console.WriteLine(now.ToString("T")); // long time
            Console.WriteLine(now.ToString("Y")); // year and month
        }
    }
}
