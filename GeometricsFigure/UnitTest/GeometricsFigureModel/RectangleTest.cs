using System;
using NUnit.Framework;
using GeometricsFigure;

namespace UnitTest.GeometricsFigureModel
{
    [TestFixture]
    public class RectangleTest
    {
        [Test]
        [TestCase(2, 3, ExpectedResult = 6, TestName = "Тестирование класса RectangleFigure свойства Area при верном значении")]
        [TestCase(-3, 5, ExpectedException = (typeof(ArgumentException)),
            TestName = "Тестирование класса RectangleFigure свойства Area при ошибочном значении, отрицательное значение")]
        [TestCase(1, 5, ExpectedResult = 5, TestName = "Тестирование класса RectangleFigure свойства Area при верном значении")]
        [TestCase(-1, 5, ExpectedException = (typeof(ArgumentException)),
            TestName = "Тестирование класса RectangleFigure свойства Area при ошибочном значении, отрицательное значение")]
        [TestCase(4, 4, ExpectedResult = 16, TestName = "Тестирование класса RectangleFigure свойства Area при верном значении")]
        public double RectangleAreaTest(double height, double width)
        {
            var rectangle = new RectangleFigure(height, width);
            return rectangle.Area;
        }

        [Test]
        [TestCase(2, 3, ExpectedResult = 10, TestName = "Тестирование класса RectangleFigure свойства Perimeter при верном значении")]
        [TestCase(-3, 2, ExpectedException = (typeof(ArgumentException)),
            TestName = "Тестирование класса RectangleFigure свойства Perimeter при ошибочном значении, отрицательное значение")]
        [TestCase(1, 5, ExpectedResult = 12, TestName = "Тестирование класса RectangleFigure свойства Perimeter при верном значении")]
        [TestCase(-1, ExpectedException = (typeof(ArgumentException)),
            TestName = "Тестирование класса RectangleFigure свойства Perimeter при ошибочном значении, отрицательное значение")]
        [TestCase(4, 4, ExpectedResult = 16, TestName = "Тестирование класса RectangleFigure свойства Perimeter при верном значении")]
        public double CirclePerimeterTest(double height, double width)
        {
            var rectangle = new RectangleFigure(height, width);
            return rectangle.Perimeter;
        }

    }
}