using System.Security.Cryptography.X509Certificates;

namespace H10_LeapYearCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CountLeapYears();
        }
        public static void CountLeapYears()
        {
            int count = 0;
           for (int year = 1799; year <= 2021; year++)
           {
                DateTime.IsLeapYear(year);
                count++;
           }
           Console.WriteLine($"Aantal schrikkeljaren tussen 1799 en 2021: {count}");
        }
    }
}
           
        
           
  
