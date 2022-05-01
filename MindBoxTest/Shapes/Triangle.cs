using System;

namespace MindBoxTest.Shapes
{
    /// <summary>
    /// Треугольник
    /// </summary>
    public class Triangle : IShape
    {
        /// <summary>
        /// Треугольник
        /// </summary>
        /// <param name="firstSide">Длина первой стороны</param>
        /// <param name="secondSide">Длина второй стороны</param>
        /// <param name="thirdSide">Длина третьей стороны</param>
        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            if (firstSide <= 0 || secondSide <= 0 || thirdSide <= 0)
                throw new ArgumentException("Все стороны должны быть положительными");

            _firstSide = firstSide;
            _secondSide = secondSide;
            _thirdSide = thirdSide;
        }

        private readonly double _firstSide;
        private readonly double _secondSide;
        private readonly double _thirdSide;

        public double GetArea()
        {
            if (IsRight(out double rightArea))
            {
                return rightArea;
            }
            else
            {
                return GetCommonTriangleArea();
            }
        }

        private double GetCommonTriangleArea()
        {
            double halfPerimeter = (_firstSide + _secondSide + _thirdSide) / 2;
            return Math.Sqrt(halfPerimeter
                * (halfPerimeter - _firstSide)
                * (halfPerimeter - _secondSide)
                * (halfPerimeter - _thirdSide));
        }

        private bool IsRight(out double rightArea)
        {
            rightArea = 0;

            if (Math.Pow(_firstSide, 2) + Math.Pow(_secondSide, 2) == Math.Pow(_thirdSide, 2))
            {
                rightArea = _firstSide * _secondSide;
                return true;
            }
            if (Math.Pow(_firstSide, 2) + Math.Pow(_thirdSide, 2) == Math.Pow(_secondSide, 2))
            {
                rightArea = _firstSide * _thirdSide;
                return true;
            }
            if (Math.Pow(_secondSide, 2) + Math.Pow(_thirdSide, 2) == Math.Pow(_firstSide, 2))
            {
                rightArea = _secondSide * _thirdSide;
                return true;
            }

            return false;
        }
    }
}
