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
        private double _radius;

        /// <summary>
        /// Пустой конструктор окружности.
        /// </summary>
        public CircleFigure()
        {
        }

        /// <summary>
        /// Конструктор окружности.
        /// </summary>
        /// <param name="radius">Радиус окружности.</param>
        public CircleFigure(double radius)
        {
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
        /// Получение площади окружности.
        /// </summary>
        /// <returns>Площадь окружности.</returns>
        public double Area
        {
            get
            {
                if (_radius == 0)
                {
                    throw new ArgumentException("Окружность не инициализирована значениями");
                }
                return Math.PI * Radius * Radius;
            }
        }

        /// <summary>
        /// Получение периметра окружности.
        /// </summary>
        /// <returns>Периметр окружности.</returns>
        public double Perimeter
        {
            get
            {
                if (_radius == 0)
                {
                    throw new ArgumentException("Окружность не инициализирована значениями");
                }
                return 2 * Math.PI * Radius;
            }
        }

        /// <summary>
        /// Получение типа фигуры
        /// </summary>
        /// <returns>Тип фигуры</returns>
        public string Type
        {
            get
            {
                return "Окружность";
            }
        }    

        #endregion
    }
}
