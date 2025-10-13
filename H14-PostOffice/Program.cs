namespace H14_PostOffice
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string input = " ";
            List<RegisteredLetter> letters = new List<RegisteredLetter>();
            bool continueLoop = true;
            do
            {
                
                Console.WriteLine("Wil je een brief verzenden? (ja/nee)");
                input = Console.ReadLine();
                Console.WriteLine();
                if (input == "ja")
                {
                    Console.WriteLine("Kies je tarief:");
                    Console.WriteLine("\t1. Standaard");
                    Console.WriteLine("\t2. Internationaal");
                    Console.WriteLine("\t3. Stop");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine("Hoe ver moet deze brief gaan?");
                    int distance = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    switch (choice)
                    {
                        case 1:
                            RegisteredLetter rl = new RegisteredLetter();
                            rl.Distance = distance;
                            letters.Add(rl);
                            break;
                        case 2:
                            InternationalRegisteredLetter irl = new InternationalRegisteredLetter();
                            irl.Distance = distance;
                            letters.Add(irl);
                            break;
                        case 3:
                            continueLoop = false;
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    continueLoop = false;
                }
            } while (input == "ja");
            for (int i = 0; i < letters.Count; i++)
            {
                Console.WriteLine($"Brief {i + 1}: \n\tafstand: {letters[i].Distance}km\n\treistijd: {letters[i].Duration}dagen\n\tprijs: {letters[i].Price}euro");
                Console.WriteLine();
            }
        }
    }
}
