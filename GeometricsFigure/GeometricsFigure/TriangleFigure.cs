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
        //TODO: Добавить проверку условия Треугольник существует только тогда, когда сумма любых двух его сторон больше третьей.
        //Нельзя задать координаты по отдельности, из-за условия выше
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
        public double SideB
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
        public double SideC
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
    }
}
