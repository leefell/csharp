namespace Services
{
    internal class CalculationService
        // generic pode ser pra interface, classe, métodos
    {
        public generico Max<generico>(List<generico> list) where generico : IComparable
            // minha lista é de um tipo generico qualquer desde que ele seja Comparavel, aqui esta a restrição para generics
        {
            if(list.Count == 0)
            {
                throw new ArgumentException("The list can not be empty.");
            }

            generico max = list[0];
            for(int i = 1; i < list.Count; i++)
            {
                if (list[i].CompareTo(max) > 0)
                {
                    max = list[i];
                }
            }
            return max;
        }
    }
}

//• where T: struct • where T : class
//• where T : unmanaged
//• where T : new() • where T : < base type name>
//• where T : U