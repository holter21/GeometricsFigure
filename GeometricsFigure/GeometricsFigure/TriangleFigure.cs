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
        private double _sideA;
        private double _sideB;
        private double _sideC;

        /// <summary>
        /// Конструктор треугольника.
        /// </summary>
        public TriangleFigure()
        {
            _startPoint.X = 0;
            _startPoint.Y = 0;
            _sideA = 0;
            _sideB = 0;
            _sideC = 0;
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
            SetSides(a, b, c);
        }

        /// <summary>
        /// Сторона А
        /// </summary>
        private double SideA
        {
            get
            {
                return _sideA;
            }
            set
            {
                if ( value <= 0 )
                {
                    throw new ArgumentException("Некорректная сторона треугольника");
                }
                _sideA = value;
            }
        }

        /// <summary>
        /// Сторона В
        /// </summary>
        private double SideB
        {
            get
            {
                return _sideB;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Некорректная сторона треугольника");
                }
                _sideB = value;
            }
        }

        /// <summary>
        /// Сторона С
        /// </summary>
        private double SideC
        {
            get
            {
                return _sideC;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Некорректная сторона треугольника");
                }
                _sideC = value;
            }
        }

        /// <summary>
        /// Функция проверки сторон треугольника.
        /// </summary>
        /// <param name="a">Сторона А</param>
        /// <param name="b">Сторона В</param>
        /// <param name="c">Сторона С</param>
        public void SetSides(double a, double b, double c)
        {
            if ((a + c) < b || (b + c) < a || (a + b) < c)
            {
                throw new ArgumentException("Неверно введены стороны треугольника");
            }
            else
            {
                SideA = a;
                SideB = b;
                SideC = c; 
            }
        }

        /// <summary>
        /// Получение полупериметра треугольника
        /// </summary>
        /// <returns>Полупериметр треугольника</returns>
        public double GetSemiPerimetr()
        {
            if (SideA == 0 || SideB == 0 || SideC == 0)
            {
                throw new ArgumentException("Треугольник не инициализирован значениями");
            }
            return (SideA + SideB + SideC) / 2;
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
            if (SideA == 0 || SideB == 0 || SideC ==0)
            {
                throw new ArgumentException("Треугольник не инициализирован значениями");
            }
            var tmp = GetSemiPerimetr() * ((GetSemiPerimetr() - SideA)) * (GetSemiPerimetr() - SideB) * (GetSemiPerimetr() - SideC);
            return
                    Math.Sqrt(tmp);
        }

        /// <summary>
        /// Получение периметра треугольника.
        /// </summary>
        /// <returns>Периметр треугольника.</returns>
        public double GetPerimeter()
        {
            if (SideA == 0 || SideB == 0 || SideC == 0)
            {
                throw new ArgumentException("Треугольник не инициализирован значениями");
            }
            return (SideA + SideB + SideC);
        }

        /// <summary>
        /// Получение типа фигуры
        /// </summary>
        /// <returns>Тип фигуры</returns>
        public string GetType()
        {
            return "Треугольник";
        }

        #endregion

    }
}
