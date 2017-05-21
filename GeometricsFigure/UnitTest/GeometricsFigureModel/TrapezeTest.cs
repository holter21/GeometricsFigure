using System;
using NUnit.Framework;
using GeometricsFigure;

namespace UnitTest.GeometricsFigureModel
{
    [TestFixture]
    public class TrapezeTest
    {
        [Test]
        [TestCase(2, 3, 4, 6, 5, ExpectedResult = 12.5, TestName = "Тестирование класса TrapezeFigure свойства Area при верном значении")]
        [TestCase(-3, 5, 6, -2, 6, ExpectedException = (typeof(ArgumentException)),
            TestName = "Тестирование класса TrapezeFigure свойства Area при ошибочном значении, отрицательное значение")]
        [TestCase(2, 2, 2, 2, 2, ExpectedResult = 5, TestName = "Тестирование класса TrapezeFigure свойства Area при верном значении")]
        [TestCase(-1, 5, 10, 10, 0, ExpectedException = (typeof(ArgumentException)),
            TestName = "Тестирование класса TrapezeFigure свойства Area при ошибочном значении, отрицательное значение")]
        [TestCase(5, 8, 4, 6, 5, ExpectedResult = 32.5, TestName = "Тестирование класса TrapezeFigure свойства Area при верном значении")]
        public double RectangleAreaTest(double SideA, double SideB, double SideC, double SideD, double Height)
        {
            var trapeze = new TrapezeFigure(SideA, SideB, SideC, SideD, Height);
            return trapeze.Area;
        }

        [Test]
        [TestCase(2, 3, 4, 6, 5, ExpectedResult = 15, TestName = "Тестирование класса TrapezeFigure свойства Perimeter при верном значении")]
        [TestCase(-3, 2, -4, 5, 6, ExpectedException = (typeof(ArgumentException)),
            TestName = "Тестирование класса TrapezeFigure свойства Perimeter при ошибочном значении, отрицательное значение")]
        [TestCase(2, 2, 2, 2, 2, ExpectedResult = 8, TestName = "Тестирование класса TrapezeFigure свойства Perimeter при верном значении")]
        [TestCase(-1, 5, 4, 8, -10, ExpectedException = (typeof(ArgumentException)),
            TestName = "Тестирование класса TrapezeFigure свойства Perimeter при ошибочном значении, отрицательное значение")]
        [TestCase(5, 8, 4, 6, 5, ExpectedResult = 23, TestName = "Тестирование класса TrapezeFigure свойства Perimeter при верном значении")]
        public double CirclePerimeterTest(double SideA, double SideB, double SideC, double SideD, double Height)
        {
            var trapeze = new TrapezeFigure(SideA, SideB, SideC, SideD, Height);
            return trapeze.Perimeter;
        }

    }
}