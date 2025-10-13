namespace H13_PhoneBookNameNumber
{
    public class Program
    {
        public static void Main(string[] args)
        {
            PhoneBookNumber();
        }
        public static void PhoneBookNumber()
        {
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();
            Console.WriteLine("Wil je een naam en nnummer inlezen?");
            string input = Console.ReadLine();
            bool loop = false;
            if (input == "ja")
            {
                loop = true;
            }
            else
            {
                loop = false;
            }
            
            while (loop)
            {
                Console.WriteLine("Naam?");
                string name = Console.ReadLine();
                Console.WriteLine("Nummer?");
                string number = Console.ReadLine();

                if (phoneBook.ContainsKey(name))
                {
                    phoneBook[name] = number;
                }
                else
                {
                    phoneBook.Add(name, number);
                }

                Console.WriteLine("Wil je nog een naam en nummer inlezen?");
                input = Console.ReadLine();
                if (input == "ja")
                {
                    loop = true;
                }
                else
                {
                    loop = false;
                }

                foreach (var item in phoneBook)
                {
                    Console.WriteLine($"{item.Key}: {item.Value}");
                }
            }
        }
    }
}
