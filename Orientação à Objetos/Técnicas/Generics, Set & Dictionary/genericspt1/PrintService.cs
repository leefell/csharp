namespace genericspt1
{
    internal class PrintService
    {
        private int[] _values = new int[10]; // variavel interna que armazena 10 int
        private int _count = 0;

        public void AddValue(int value)
        {   
            if(_count == 10)
            {
                throw new InvalidOperationException("Print Serice is full.");
            }
            _values[_count] = value;
            _count++;
        }

        public int First()
        {
            if(_count == 0)
            {
                throw new InvalidOperationException("Print Service is empty");
            }
            return _values[0];
        }

        public void Print()
        {
            Console.Write("[");
            for(int i = 0; i < _count - 1; i++)
            {
                Console.Write(_values[i] + ", ");
            }
            if(_count > 0)
            {
                Console.Write(_values[_count - 1]); // imprimir até o penultimo valor
            }
            Console.WriteLine("]");
        }
    }
}
