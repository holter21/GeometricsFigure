using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricsFigure
{
    /// <summary>
    /// Класс треугольник.
    /// </summary>
    public class TriangleFigure:IFigure
    {
        private Point _startPoint;
        private double _sidea;
        private double _sideb;
        private double _sidec;

        /// <summary>
        /// Конструктор треугольника.
        /// </summary>
        public TriangleFigure()
        {
            _startPoint.X = 0;
            _startPoint.Y = 0;
            _sidea = 0;
            _sideb = 0;
            _sidec = 0;
        }

        /// <summary>
        /// Конструктор треугольника.
        /// </summary>
        /// <param name="startPoint">Начальные координаты треугольника.</param>
        /// <param name="a">Сторона А</param>
        /// <param name="b">Сторона В</param>
        /// <param name="c">Сторона С</param>
        public TriangleFigure(Point startPoint, double a, double b, double c)
        {
            StartPoint = startPoint;
            SideA = a;
            SideB = b;
            SideC = c;
        }

        /// <summary>
        /// Сторона А
        /// </summary>
        public double SideA
        {
            get
            {
                return _sidea;
            }
            set
            {
                if ( value <= 0 )
                {
                    throw new ArgumentException("Неккоректная сторона треугольника");
                }
                _sidea = value;
            }
        }

        /// <summary>
        /// Сторона В
        /// </summary>
        public double SideB
        {
            get
            {
                return _sideb;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Неккоректная сторона треугольника");
                }
                _sideb = value;
            }
        }

        /// <summary>
        /// Сторона С
        /// </summary>
        public double SideC
        {
            get
            {
                return _sidec;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Неккоректная сторона треугольника");
                }
                _sidec = value;
            }
        }

        #region Implementation of IFigure

        /// <summary>
        /// Начальные координаты треугольника.
        /// </summary>
        public Point StartPoint
        {
            get
            {
                return _startPoint;
            }
            set
            {
                _startPoint = value;
            }
        }

        /// <summary>
        /// Получение площади треугольника.
        /// </summary>
        /// <returns>Площадь треугольника.</returns>
        public double GetArea()
        {
            return
                    Math.Sqrt(GetSemiPerimetr() * ((GetSemiPerimetr() - SideA)) * (GetSemiPerimetr() - SideB)
                              * (GetSemiPerimetr() - SideC));
        }

        /// <summary>
        /// Получение периметра треугольника.
        /// </summary>
        /// <returns>Периметр треугольника.</returns>
        public double GetPerimeter()
        {
            return (SideA + SideB + SideC);
        }

        #endregion

        /// <summary>
        /// Получение полупериметра треугольника
        /// </summary>
        /// <returns>Полупериметр треугольника</returns>
        public double GetSemiPerimetr()
        {
            return (SideA + SideB + SideC) / 2;
        }
    }
}
