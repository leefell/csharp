namespace modificadorParametros
{
    internal class Calculadora
    {

        // Definição de função com parametros variaveis

        public static int Soma(params int[] numeros)
        {
            int sum = 0;
            for(int i = 0; i < numeros.Length; i++)
            {
                sum += numeros[i];
            }
            return sum;
        }

    }
}
