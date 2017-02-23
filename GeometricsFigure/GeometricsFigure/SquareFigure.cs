using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricsFigure
{
    /// <summary>
    /// Класс квадрат.
    /// </summary>
    public class SquareFigure:IFigure
    {
        private Point _startPoint;
        private double _sideA;

        /// <summary>
        /// Конструктор квадрата
        /// </summary>
        public SquareFigure()
        {
            _startPoint.X = 0;
            _startPoint.Y = 0;
            _sideA = 0;
        }

        /// <summary>
        /// Конструктор квадрата
        /// </summary>
        /// <param name="startPoint">Начальные координаты квадрата</param>
        /// <param name="a">Сторона квадрата</param>
        public SquareFigure(Point startPoint, double a)
        {
            StartPoint = startPoint;
            SideA = a;
        }

        /// <summary>
        /// Сторона квадрата
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
                    throw new ArgumentException("Некорректная сторона квадрата"); 
                }
                _sideA = value;
            }
        }

        #region Implementation of IFigure

        /// <summary>
        /// Начальные координаты квадрата.
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
        /// Получение площади квадрата.
        /// </summary>
        /// <returns>Площадь квадрата.</returns>
        public double GetArea()
        {
            if (SideA == 0)
            {
                throw new ArgumentException("Квадрат не инициализирован значениями");
            }
            return SideA * SideA;
        }

        /// <summary>
        /// Получение периметра квадрата.
        /// </summary>
        /// <returns>Периметр квадрата.</returns>
        public double GetPerimeter()
        {
            if (SideA == 0)
            {
                throw new ArgumentException("Квадрат не инициализирован значениями");
            }
            return 4 * SideA;
        }

        /// <summary>
        /// Получение типа фигуры
        /// </summary>
        /// <returns>Тип фигуры</returns>
        public string GetType()
        {
            return "Квадрат";
        }

        #endregion
    }
}
