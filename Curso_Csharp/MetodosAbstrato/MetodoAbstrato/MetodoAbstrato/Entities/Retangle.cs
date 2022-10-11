using MetodoAbstrato.Entities.Enums;

namespace MetodoAbstrato.Entities
{
    class Retangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Retangle(double width, double height, Color color) : base(color) //chamar o construtor da classe shape
        {
            Width = width;
            Height = height;
        }

        public override double Area()
        {
            return Width * Height;
        }
    }
}
