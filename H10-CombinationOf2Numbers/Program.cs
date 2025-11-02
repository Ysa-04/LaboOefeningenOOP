namespace H10_CombinationOf2Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool go = true;
            while (go)
            {
                // submenu
                Console.WriteLine("MAAK EEN KEUZE");
                Console.WriteLine("\t1- SUM");
                Console.WriteLine("\t2- DIFFERENCE");
                Console.WriteLine("\t3- PRODUCT");
                Console.WriteLine("\t4- QUOTIENT");
                Console.WriteLine("\t5- STOPPEN");
                int choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                Console.Write("Geef het eerste getal: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Geef het tweede getal: ");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                CombinationOf2Numbers combination = new CombinationOf2Numbers();
                combination.Number1 = num1;
                combination.Number2 = num2;

                switch (choice)
                {
                    case 1:
                        Console.WriteLine($"De som van {num1} en {num2} is {combination.Sum()}");
                        Console.WriteLine();
                        break;
                    case 2:
                        Console.WriteLine($"Het verschil van {num1} en {num2} is {combination.Difference()}");
                        Console.WriteLine();
                        break;
                    case 3:
                        Console.WriteLine($"Het product van {num1} en {num2} is {combination.Product()}");
                        Console.WriteLine();
                        break;
                    case 4:
                        Console.WriteLine($"Het quotiënt van {num1} en {num2} is {combination.Quotient()}");
                        Console.WriteLine();
                        break;
                    case 5:
                        Console.WriteLine("Programma sluiten...");
                        go = false;
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Ongeldige keuze");
                        Console.ResetColor();
                        break;
                }

            }
        }

        public class CombinationOf2Numbers
        {
            public int Number1;
            public int Number2;

            public double Sum()
            {
                return Number1 + Number2;
            }

            public double Difference()
            {
                return Number1 - Number2;
            }

            public double Product()
            {
                return Number1 * Number2;
            }

            public double Quotient()
            {
                if (Number2 == 0)
                {
                    Console.WriteLine("Fout!");
                }
                return Math.Round(Convert.ToDouble(Number1) / Number2);
            }
        }
    }
}
