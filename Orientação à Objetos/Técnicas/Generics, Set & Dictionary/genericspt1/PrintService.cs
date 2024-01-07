namespace genericspt1
{
    internal class PrintService<T> // agora a classe esta parametrizada por tipo
        // então toda a classe printService é de um tipo generico especifico que no caso seria o 'T'
    {
        private T[] _values = new T[10]; // variavel interna que armazena 10 int
        private int _count = 0;

        public void AddValue(T value)
        {   
            if(_count == 10)
            {
                throw new InvalidOperationException("Print Serice is full.");
            }
            _values[_count] = value;
            _count++;
        }
        public T First()
        {
            if(_count == 0)
            {
                throw new InvalidOperationException("Print Service is empty");
            }
            return _values[0];
        }

        public T Last()
        {
            if(_count == 0)
            {
                throw new InvalidOperationException("Print Service is empty");
            }
            return _values[_count - 1];
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
