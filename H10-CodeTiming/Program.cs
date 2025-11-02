namespace H10_CodeTiming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime start = DateTime.Now;
            int[] array = new int[1000000];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i + 1;
            }
            DateTime end = DateTime.Now;
            TimeSpan elapsed = end - start;
            Console.WriteLine($"Het duurt {elapsed.TotalMilliseconds} milliseconden om een array van een miljoen elementen te vullen.");
        }
    }
}
