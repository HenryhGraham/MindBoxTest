using MindBoxTest.Shapes;
using System;
using Xunit;

namespace MindBoxUnitTests
{
    /// <summary>
    /// Класс тестов для фигур
    /// </summary>
    public class ShapesTest
    {
        /// <summary>
        /// Проверка расчета площади круга по радиусу
        /// </summary>
        [Fact]
        public void TestCircleArea()
        {
            double radius = 20;
            IShape circle = new Circle(radius);
            double circleArea = circle.GetArea();

            Assert.Equal(circleArea, Math.PI * Math.Pow(radius, 2));
        }

        /// <summary>
        /// Проверка расчета площади треугольника по трем сторонам
        /// </summary>
        [Fact]
        public void TestTriangleArea()
        {
            double firstSide = 10;
            double secondSide = 15;
            double thirdSide = 12;

            IShape triangle = new Triangle(firstSide, secondSide, thirdSide);
            double triangleArea = triangle.GetArea();

            double halfPerimeter = (firstSide + secondSide + thirdSide) / 2;
            double testTriangleArea = Math.Sqrt(halfPerimeter
                * (halfPerimeter - firstSide)
                * (halfPerimeter - secondSide)
                * (halfPerimeter - thirdSide));

            Assert.Equal(triangleArea, testTriangleArea);
        }
    }
}
