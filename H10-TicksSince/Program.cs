namespace H10_TicksSince
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TimeSpan diff = DateTime.Today - new DateTime(2000, 1, 1);
            Console.WriteLine($"Sinds 1 januari 2000 zijn er {diff.Ticks} ticks voorbij gegaan.");

        }
    }
}
