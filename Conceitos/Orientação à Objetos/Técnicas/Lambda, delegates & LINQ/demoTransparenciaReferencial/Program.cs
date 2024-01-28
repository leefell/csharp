namespace demoNaoTransparenciaReferencial
{
    internal class Program
    {

        public static int globalValue = 3;

        static void Main(string[] args)
        {
            int[] vect = new int[] { 3, 4, 5 };
            ChangeOddValues( vect );
            Console.WriteLine(string.Join(" ", vect));

        }

        public static void ChangeOddValues(int[] numbers)
        {

            // Essa funcao nao é referencialmente transparente porque é necessário olhar fora do 
            // escopo dela para saber oq ela faz, uma vez que o 'globalValue' esta fora dela;

            for(int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    numbers[i] += globalValue;
                }
            } 
        }
    }
}
