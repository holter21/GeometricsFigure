using System;
using GeometricsFigure;
using NUnit.Framework;

namespace UnitTest.GeometricsFigureModel

{
    [TestFixture]
    public class CircleTest
    {
        [Test]
        [TestCase(3,ExpectedResult = 28.27, TestName = "Тестирование свойства Area при значении радиуса = 3")]
        [TestCase(-3, ExpectedException = (typeof(ArgumentException)),TestName = "Тестирование свойства Area при значении радиуса = -3")]
        [TestCase(1, ExpectedResult = 3.14, TestName = "Тестирование свойства Area при значении радиуса = 1")]
        [TestCase(-1, ExpectedException = (typeof(ArgumentException)), TestName = "Тестирование свойства Area при значении радиуса = -1")]
        [TestCase(2, ExpectedResult = 12.57, TestName = "Тестирование свойства Area при значении радиуса = 2")]

        public double AreaTest(double radius)
        {
            var circle = new CircleFigure(radius);
            return circle.Area;
        }

        [Test]
        [TestCase(3, ExpectedResult = 18.85, TestName = "Тестирование свойства Perimeter при значении радиуса = 3")]
        [TestCase(-3, ExpectedException = (typeof(ArgumentException)), TestName = "Тестирование свойства Perimeter при значении радиуса = -3")]
        [TestCase(1, ExpectedResult = 6.28, TestName = "Тестирование свойства Perimeter при значении радиуса = 1")]
        [TestCase(-1, ExpectedException = (typeof(ArgumentException)), TestName = "Тестирование свойства Perimeter при значении радиуса = -1")]
        [TestCase(2, ExpectedResult = 12.57, TestName = "Тестирование свойства Perimeter при значении радиуса = 2")]

        public double PerimeterTest(double radius)
        {
            var circle = new CircleFigure(radius);
            return circle.Perimeter;
        }
    }
}