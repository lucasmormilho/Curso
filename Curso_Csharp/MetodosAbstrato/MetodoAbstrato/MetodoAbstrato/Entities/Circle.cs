using MetodoAbstrato.Entities.Enums;
using System;

namespace MetodoAbstrato.Entities
{
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius, Color color) : base(color) //chamar o construtor da classe shape
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius; //circulo é valor de pi vezes raio ao quadrado
        }
    }
}
