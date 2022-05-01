using System;

namespace MindBoxTest.Shapes
{
    /// <summary>
    /// Круг
    /// </summary>
    public class Circle : IShape
    {
        /// <summary>
        /// Круг
        /// </summary>
        /// <param name="radius"> Радиус круга </param>
        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("Радиус должен быть положительным");

            _radius = radius;
        }

        private readonly double _radius;

        public double GetArea()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }
    }
}
