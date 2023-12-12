using enumeracao.Entities;
using enumeracao.Entities.enums;

namespace enumeracao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString(); // CONVERTENDO ENUMERADO -> STRING

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered"); // CONVERTENDO STRING -> ENUMERADO

            Console.WriteLine(os);
            Console.WriteLine(txt);
        }
    }
}