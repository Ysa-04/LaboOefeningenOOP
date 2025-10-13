
using H10_Clock;
using H10_Birthday;
using H10_DayOfTheWeek;
using H13_PhoneBookNameNumber;
using H14_PostOffice;
using System.Drawing;
namespace DemoOefeningen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool go = true;
            while (go)
            {
                Console.WriteLine();
                Console.WriteLine("Overzicht hoofdstukken");
                Console.WriteLine("---------------------------------");
                Console.WriteLine("1. Klassen en objecten");
                Console.WriteLine("2. Objecten aanmaken");
                Console.WriteLine("3. Geheugenmanagement bij klassen");
                Console.WriteLine("4. Datastructuren");
                Console.WriteLine("5. Overerving");
                Console.WriteLine("---------------------------------");
                Console.WriteLine("20. Stop programma");
                Console.WriteLine();
                
                Console.Write("Maak een keuze: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Gekozen hoofdstuk: \n1. Klassen en objecten");
                        Console.WriteLine();
                        Console.WriteLine("Overzicht oefeningen");
                        Console.WriteLine("-------------------------------------------");
                        Console.WriteLine("1. Clock");
                        Console.WriteLine("2. Birthday");
                        Console.WriteLine("3. DayOfTheWeek");
                        Console.WriteLine("4. Terug naar hoofdmenu");
                        Console.WriteLine();

                        Console.Write("Maak een keuze: ");
                        int answer = Convert.ToInt32(Console.ReadLine());
                        switch (answer)
                        {
                            case 1:
                                Console.Clear();
                                Console.WriteLine("1. Clock");
                                H10_Clock.Program.Main(args);
                                break;
                            case 2:
                                Console.Clear();
                                Console.WriteLine("2. Birthday");
                                H10_Birthday.Program.Main(args);
                                break;
                            case 3:
                                Console.Clear();
                                Console.WriteLine("3. DayOfTheWeek");
                                H10_DayOfTheWeek.Program.Main(args);
                                break;
                            case 4:
                                Console.Clear();
                                DemoOefeningen.Program.Main(args);
                                break;
                            default:
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Ongeldige keuze");
                                Console.ResetColor();
                                Console.WriteLine();
                                break;
                        }
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Gekozen hoofdstuk: \n2. Objecten aanmaken");
                        Console.WriteLine();
                        Console.WriteLine("Overzicht oefeningen");
                        Console.WriteLine("-------------------------------------------");
                        Console.WriteLine("1. Terug naar hoofdmenu");
                        Console.WriteLine();
                        Console.Write("Maak een keuze: ");
                        answer = Convert.ToInt32(Console.ReadLine());
                        switch (answer)
                        {
                            case 1:
                                Console.Clear();
                                DemoOefeningen.Program.Main(args);
                                break;
                            default:
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Ongeldige keuze");
                                Console.ResetColor();
                                Console.WriteLine();
                                break;
                        }
                        break;
                    case 3:
                        Console.Clear();
                        Console.Clear();
                        Console.WriteLine("Gekozen hoofdstuk: \n3. Geheugenmanagement bij klassen");
                        Console.WriteLine();
                        Console.WriteLine("Overzicht oefeningen");
                        Console.WriteLine("-------------------------------------------");
                        break;
                    case 4:
                        Console.Clear();
                        Console.Clear();
                        Console.WriteLine("Gekozen hoofdstuk: \n4. Datastructuren");
                        Console.WriteLine();
                        Console.WriteLine("Overzicht oefeningen");
                        Console.WriteLine("-------------------------------------------");
                        Console.WriteLine("1. PhoneBookNameNumber");
                        Console.WriteLine("2. Terug naar hoofdmenu");
                        Console.WriteLine("");
                        Console.WriteLine("Maak een keuze: ");
                        answer = Convert.ToInt32(Console.ReadLine());
                        switch (answer)
                        {
                            case 1:
                                Console.Clear();
                                H13_PhoneBookNameNumber.Program.Main(args);
                                break;
                            case 2:
                                Console.Clear();
                                DemoOefeningen.Program.Main(args);
                                break;
                            default:
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Ongeldige keuze");
                                Console.ResetColor();
                                Console.WriteLine();
                                break;
                        }
                        break;
                    case 5:
                        Console.Clear();
                        Console.Clear();
                        Console.WriteLine("Gekozen hoofdstuk: \n5. Overerving");
                        Console.WriteLine();
                        Console.WriteLine("Overzicht oefeningen");
                        Console.WriteLine("-------------------------------------------");
                        Console.WriteLine("1. PostOffice");
                        Console.WriteLine("3. Terug naar hoofdmenu");
                        Console.WriteLine("");
                        Console.WriteLine("Maak een keuze: ");
                        answer = Convert.ToInt32(Console.ReadLine());
                        switch (answer)
                        {
                            case 1:
                                Console.Clear();
                                H14_PostOffice.Program.Main(args);
                                break;
                            case 3:
                                Console.Clear();
                                DemoOefeningen.Program.Main(args);
                                break;
                            default:
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Ongeldige keuze");
                                Console.ResetColor();
                                Console.WriteLine();
                                break;                           
                        }
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Ongeldige keuze");
                        Console.ResetColor();
                        Console.WriteLine();
                        break;
                }
            }
        }
    }
}
