using System.Globalization;

namespace Entities
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public Category Category { get; set; }

        public override string ToString()
        {
            return "Id: " + Id + ", " + Name + ", " + Price.ToString("F2", CultureInfo.InvariantCulture)
                + ", " + Category.Name + ", Tier: " + Category.Tier;
        }
    }
}
