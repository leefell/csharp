namespace modRef
{
    internal class Calculadora
    {
        // Com o 'ref' o parametro x da funcao se torna uma referencia para a variavel original
        // então quando é executado ele ja modifica na variavel original
        public static void TriplicarREF(ref int x)
        {
            x = x * 3;
        }

        public static void TriplicarOUT(int origem, out int resultado)
        {
            resultado = origem * 3;
        }

    }
}
