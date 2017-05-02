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
            if ( (triangle.SideA == a) && (triangle.SideB == b) && (triangle.SideC == c) )
            {
                return;
            }
            throw new Exception();
        }
    }
}