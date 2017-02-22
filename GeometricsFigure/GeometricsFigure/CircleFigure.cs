using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricsFigure
{
    /// <summary>
    /// Класс окружность.
    /// </summary>
    public class CircleFigure:IFigure
    {
        private Point _startPoint;
        private double _radius;

        /// <summary>
        /// Конструктор окружности.
        /// </summary>
        public CircleFigure()
        {
            _startPoint.X = 0;
            _startPoint.Y = 0;
            _radius = 0;
        }

        /// <summary>
        /// Конструктор окружности.
        /// </summary>
        /// <param name="startPoint">Начальные координаты окружности.</param>
        /// <param name="radius">Радиус окружности.</param>
        public CircleFigure(Point startPoint, double radius)
        {
            StartPoint = startPoint;
            Radius = radius;
        }

        /// <summary>
        /// Радиус окружности
        /// </summary>
        public double Radius
        {
            get
            {
                return _radius;
            }
            set
            {
                if ( value <= 0 )
                {
                    throw new ArgumentException("Некорректный радиус окружности");
                }
                _radius = value;
            }
        }


        #region Implementation of IFigure

        /// <summary>
        /// Начальные координаты окружности.
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
        /// Получение площади окружности.
        /// </summary>
        /// <returns>Площадь окружности.</returns>
        public double GetArea()
        {
            if ( _radius == 0 )
            {
                throw new ArgumentException("Окружность не инициализирована значениями");
            }
            return Math.PI * Radius * Radius;
        }

        /// <summary>
        /// Получение периметра окружности.
        /// </summary>
        /// <returns>Периметр окружности.</returns>
        public double GetPerimeter()
        {
            if (_radius == 0)
            {
                throw new ArgumentException("Окружность не инициализирована значениями");
            }
            return 2 * Math.PI * Radius;
        }

        #endregion
    }
}
