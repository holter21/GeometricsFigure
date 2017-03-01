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
    public class TrapezeFigure:IFigure
    {
        private Point _startPoint;
        private double _sideA;
        private double _sideB;
        private double _sideC;
        private double _sideD;
        private double _height;

        /// <summary>
        /// Конструктор трапеции.
        /// </summary>
        public TrapezeFigure()
        {
            _startPoint.X = 0;
            _startPoint.Y = 0;
            _sideA = 0;
            _sideB = 0;
            _sideC = 0;
            _sideD = 0;
            _height = 0;
        }

        /// <summary>
        /// Конструктор трапеции.
        /// </summary>
        /// <param name="startPoint">Начальные координаты трапеции.</param>
        /// <param name="a">Длина основания А трапеции.</param>
        /// <param name="b">Длина основания В трапеции.</param>
        /// <param name="c">Боковая сторона С трапеции.</param>
        /// <param name="d">Боковая сторона D трапеции.</param>
        /// <param name="h">Высота трапеции</param>
        public TrapezeFigure(Point startPoint, double a, double b, double c, double d, double h)
        {
            StartPoint = startPoint;
            SideA = a;
            SideB = b;
            SideC = c;
            SideD = d;
            Height = h;
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
                if ( value <= 0 )
                {
                    throw new ArgumentException("Некорректная длина основания трапеции");
                }
                _sideA = value;
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
                if (value <= 0)
                {
                    throw new ArgumentException("Некорректная длина основания трапеции");
                }
                _sideB = value;
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
                if (value <= 0)
                {
                    throw new ArgumentException("Некорректная длина боковой стороны трапеции");
                }
                _sideC = value;
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
                if (value <= 0)
                {
                    throw new ArgumentException("Некорректная длина боковой стороны трапеции");
                }
                _sideD = value;
            }
        }

        //TODO: Это поле можно вычислить 
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
                if (value <= 0)
                {
                    throw new ArgumentException("Некорректная высота трапеции");
                }
                _height = value;
            }
        }

        #region Implementation of IFigure

        /// <summary>
        /// Начальные координаты трапеции.
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
        /// Получение площади трапеции.
        /// </summary>
        /// <returns>Площадь трапеции.</returns>
        public double Area
        {
            get
            {
                if (SideA == 0 || SideB == 0 || SideC == 0 || SideD == 0 || Height == 0)
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
                if (SideA == 0 || SideB == 0 || SideC == 0 || SideD == 0 || Height == 0)
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
