using Services;

namespace demoMultiDelegates
{
    delegate void BinaryNumericOperation(double n1, double n2);
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            BinaryNumericOperation op = CalculationService.ShowSum;
            op += CalculationService.ShowMax; // agr o delegate guarda ref para duas funcoes

            op.Invoke(a, b);
            //op(a, b);
        }
    }
}
