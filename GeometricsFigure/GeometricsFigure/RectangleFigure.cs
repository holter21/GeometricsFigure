﻿using System;
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
    public class RectangleFigure:IFigure

    {
        private Point _startPoint;
        private double _height;
        private double _width;

        /// <summary>
        /// Конструктор прямоугольника
        /// </summary>
        public RectangleFigure()
        {
            _startPoint.X = 0;
            _startPoint.Y = 0;
            _height = 0;
            _width = 0;
        }
        /// <summary>
        /// Конструктор прямоугольника
        /// </summary>
        /// <param name="startPoint">Начальные координаты</param>
        /// <param name="height">Высота</param>
        /// <param name="width">Ширина</param>
        public RectangleFigure(Point startPoint, double height, double width)
        {
            StartPoint = startPoint;
            Height = height;
            Width = width;
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
                if ( _height <= 0 )
                {
                    throw new ArgumentException("Некорректная высота прямоугольника");
                }
                _height = value;
                
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
                if ( _width <= 0 )
                {
                    throw new ArgumentException("Неккоректная ширина прямоугольника");
                }
                _width = value;
            }
        }

        #region Implementation of IFigure

        /// <summary>
        /// Начальные координаты фигуры.
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
        /// Получение площади прямоугольника.
        /// </summary>
        /// <returns>Площадь прямоугольника.</returns>
        public double GetArea()
        {
            if ( _height == 0 || _width == 0 )
            {
                throw new ArgumentException("Прямоугольник не инициализирован значениями");
            }
            return _height * _width;
        }

        /// <summary>
        /// Получение периметра прямоугльника.
        /// </summary>
        /// <returns>Периметр прямоугольника.</returns>
        public double GetPerimeter()
        {
            if ( _height == 0 || _width == 0 )
            {
                throw new ArgumentException("Прямоугольник не инициализирован значениями");
            }
            return (_height + _width) * 2;
        }

        #endregion
    }
}
