namespace demoDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> cookies = new Dictionary<string, string>();

            cookies["user"] = "Maria";
            cookies["email"] = "maria@gmail.com";
            cookies["phone"] = "995706324";
            cookies["phone"] = "231283791"; // nesse caso o valor de 'phone' sera sobrescrevido

            Console.WriteLine(cookies["email"]);
            Console.WriteLine(cookies["phone"]);

            cookies.Remove("email");

            if (cookies.ContainsKey("email"))
            {
                Console.WriteLine(cookies["email"]);
            }
            else
            {
                Console.WriteLine("There is no 'email' key");
            }

            Console.WriteLine("Dictionary size: " + cookies.Count);
            Console.WriteLine("\nAll cookie: ");

            foreach(KeyValuePair<string, string> item in cookies) // (var item in cookies) funciona
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }

        }
    }
}