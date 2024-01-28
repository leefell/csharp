using exShapes.Entities.enums;

namespace exShapes.Entities
{
    internal abstract class Shape
    {
        public enumColor Color { get; set; }
        
        public Shape(enumColor receivedColor)
        {
            Color = receivedColor;
        }

        public abstract double Area();
    }
}
