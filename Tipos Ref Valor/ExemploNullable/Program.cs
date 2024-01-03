namespace ExemploNullable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Nullable<double> x = null; essa atribuição pode ser simplificada: 
             double? x = null;
             double? y = 10.0;

            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);


            if (x.HasValue && y.HasValue)
            {
                Console.WriteLine(x.Value);
                Console.WriteLine(y.Value);
            }
            else
            {
                Console.WriteLine("X is null");
                Console.WriteLine("Y is null");
            }

            double? z = null;
            double? w = 10;

            double a = x ?? 5;
            double b = w ?? 5;
            //o b recebe o valor de w, mas se ele for null, vai receber 5 por causa do '??'

            Console.WriteLine(a);
            Console.WriteLine(b);

        }
    }
}