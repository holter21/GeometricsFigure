using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricsFigure
{
    /// <summary>
    /// Класс прямоугольник.
    /// </summary>
    [Serializable]
    public class RectangleFigure:IFigure

    {
        private double _height;
        private double _width;

        /// <summary>
        /// Пустой конструктор треугольника.
        /// </summary>
        public RectangleFigure()
        {
        }

        /// <summary>
        /// Конструктор прямоугольника.
        /// </summary>
        /// <param name="height">Высота.</param>
        /// <param name="width">Ширина.</param>
        public RectangleFigure(double height, double width)
        {
            Height = CheckerValues.CheckValue(height); ;
            Width = CheckerValues.CheckValue(width); ;
        }

        /// <summary>
        /// Высота прямоугольника.
        /// </summary>
        public double Height
        {
            get
            {
                return _height;
            }
            set
            {
                _height = CheckerValues.CheckValue(value);

            }
        }

        /// <summary>
        /// Ширина прямоугольника.
        /// </summary>
        public double Width
        {
            get
            {
                return _width;
            }
            set
            {
                _width = CheckerValues.CheckValue(value);
            }
        }

        #region Implementation of IFigure

        /// <summary>
        /// Получение площади прямоугольника.
        /// </summary>
        /// <returns>Площадь прямоугольника.</returns>
        public double Area
        {
            get
            {
                if (Height <= 0 || Width <= 0)
                {
                    throw new ArgumentException("Прямоугольник не инициализирован значениями");
                }
                return Height * Width;
            }
        }

        /// <summary>
        /// Получение периметра прямоугльника.
        /// </summary>
        /// <returns>Периметр прямоугольника.</returns>
        public double Perimeter
        {
            get
            {
                if ( Height <= 0 || Width <= 0 )
                {
                    throw new ArgumentException("Прямоугольник не инициализирован значениями");
                }
                return (Height + Width) * 2;
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
                return "Прямоугольник";
           }
        }
        
        #endregion
    }
}
