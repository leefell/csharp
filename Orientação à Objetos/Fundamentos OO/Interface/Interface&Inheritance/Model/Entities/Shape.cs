using Enums;

namespace Entities
{
    internal abstract class Shape
    {
        public Color Color { get; set; }
        public abstract double Area();
    }
}
