namespace tipoStruct
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Point p; // mesmo sendo struct deve ser inicializada
            p.X = 10;
            p.Y = 20;
            Console.WriteLine(p);
            p = new Point();
            Console.WriteLine(p);

        }
    }
}