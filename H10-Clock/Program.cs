namespace H10_Clock
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Wil je starten?");
            Console.WriteLine("- JA: Druk op Enter");
            Console.WriteLine("- Stoppen: Druk op Esc");

            ConsoleKey key = Console.ReadKey(true).Key;
            if (key == ConsoleKey.Enter)
            {
                Console.Clear();
                Clock();
            }
        }

        public static void Clock()
        {
            bool running = true;

            while (running)
            {
                Console.Clear();
                DateTime now = DateTime.Now;
                Console.WriteLine(now.ToString("T"));
                Console.WriteLine();
                Console.WriteLine("Druk op Esc om te stoppen...");

                
                for (int i = 0; i < 10; i++) 
                {
                    Thread.Sleep(100);
                    if (Console.KeyAvailable)
                    {
                        if (Console.ReadKey(true).Key == ConsoleKey.Escape)
                        {
                            running = false;
                            break;
                        }
                    }
                }
            }
        }
    }
}
