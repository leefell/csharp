using Devices;

namespace problemaDiamante
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Printer p = new Printer() { SerialNumber = 1080 };
            p.ProcessDoc("My letter");
            p.Print("My letter");

            Scanner s = new Scanner() { SerialNumber = 2003 };
            s.ProcessDoc("My email");
            Console.WriteLine(s.Scan());

            ComboDevice c = new ComboDevice() { SerialNumber = 3028};
            c.ProcessDoc("Meu TCC");
            c.Print("Meu tcc");
            Console.WriteLine(c.Scan());
        }
    }
}