using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GeometricsFigure;

namespace GeometricsFigureConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var geometricsFigure = new List<IFigure>();
            var point = new Point(1,1);

            var rectangleFigure = new RectangleFigure(point, 3, 2);
            geometricsFigure.Add(rectangleFigure);

            var circleFigure = new CircleFigure(point, 3.5);
            geometricsFigure.Add(circleFigure);

            var triangleFigure = new TriangleFigure(point, 5, 4.1, 2);
            geometricsFigure.Add(triangleFigure);

            var squareFigure = new SquareFigure(point, 6);
            geometricsFigure.Add(squareFigure);

            var trapezeFigure = new TrapezeFigure(point, 5, 6, 3, 4, 2.5);
            geometricsFigure.Add(trapezeFigure);

            foreach (var figure in geometricsFigure)
            {
               Console.WriteLine("{0}. Площадь = {1}. Периметр = {2}", figure.GetType(), figure.GetArea(), figure.GetPerimeter()); 
            }

            Console.Read();
        }
    }
}
