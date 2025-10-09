namespace H10_Clock
{
    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {    
                DateTime hours = DateTime.Now;
                Console.WriteLine(hours.ToString("T"));
                System.Threading.Thread.Sleep(1000);
                Console.Clear();
            }
        }
    }
}
