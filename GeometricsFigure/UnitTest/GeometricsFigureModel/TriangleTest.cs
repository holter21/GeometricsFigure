using System;
using NUnit.Framework;
using GeometricsFigure;



namespace UnitTest.GeometricsFigureModel
{
    [TestFixture]
    public class TriangleTest
    {
        [Test]
        public void SetSidesTest(double a, double b, double c)
        {
            var triangle = new TriangleFigure(a, b, c);
        }
    }
}