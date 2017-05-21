using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricsFigure
{
    /// <summary>
    /// Класс трапеция.
    /// </summary>
    [Serializable]
    public class TrapezeFigure:IFigure
    {
        private double _sideA;
        private double _sideB;
        private double _sideC;
        private double _sideD;
        private double _height;

        /// <summary>
        /// Пустой конструктор трапеции.
        /// </summary>
        public TrapezeFigure()
        {
        }

        /// <summary>
        /// Конструктор трапеции.
        /// </summary>
        /// <param name="a">Длина основания А трапеции.</param>
        /// <param name="b">Длина основания В трапеции.</param>
        /// <param name="c">Боковая сторона С трапеции.</param>
        /// <param name="d">Боковая сторона D трапеции.</param>
        /// <param name="h">Высота трапеции</param>
        public TrapezeFigure(double a, double b, double c, double d, double h)
        {
            SideA = CheckerValues.CheckValue(a); ;
            SideB = CheckerValues.CheckValue(b); ;
            SideC = CheckerValues.CheckValue(c); ;
            SideD = CheckerValues.CheckValue(d); ;
            Height = CheckerValues.CheckValue(h); ;
        }

        /// <summary>
        /// Длина основания А трапеции.
        /// </summary>
        public double SideA
        {
            get
            {
                return _sideA;
            }
            set
            {
                _sideA = CheckerValues.CheckValue(value);
            }
        }

        /// <summary>
        /// Длина основания В трапеции.
        /// </summary>
        public double SideB
        {
            get
            {
                return _sideB;
            }
            set
            {
                _sideB = CheckerValues.CheckValue(value);
            }
        }

        /// <summary>
        /// Длина боковой стороны С трапеции.
        /// </summary>
        public double SideC
        {
            get
            {
                return _sideC;
            }
            set
            {
                _sideC = CheckerValues.CheckValue(value);
            }
        }

        /// <summary>
        /// Длина боковой стороны D трапеции.
        /// </summary>
        public double SideD
        {
            get
            {
                return _sideD;
            }
            set
            {
                _sideD = CheckerValues.CheckValue(value);
            }
        }

        /// <summary>
        /// Высота трапеции.
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

        #region Implementation of IFigure

        /// <summary>
        /// Получение площади трапеции.
        /// </summary>
        /// <returns>Площадь трапеции.</returns>
        public double Area
        {
            get
            {
                if (SideA <= 0 || SideB <= 0 || SideC <= 0 || SideD <= 0 || Height <= 0)
                {
                    throw new ArgumentException("Трапеция не инициализирована значениями");
                }
                return ((SideA + SideB) / 2) * Height;
            }
        }  

        /// <summary>
        /// Получение периметра трапеции.
        /// </summary>
        /// <returns>Периметр трапеции.</returns>
        public double Perimeter
        {
            get
            {
                if (SideA <= 0 || SideB <= 0 || SideC <= 0 || SideD <= 0 || Height <= 0)
                {
                    throw new ArgumentException("Трапеция не инициализирована значениями");
                }
                return SideA + SideB + SideC + SideD;
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
                return "Трапеция";
            }
        }     

        #endregion
    }
}
