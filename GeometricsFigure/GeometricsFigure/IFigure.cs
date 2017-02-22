using System.Drawing;

namespace GeometricsFigure
{
    /// <summary>
    /// Интерфейс геометрической фигуры.
    /// </summary>
    public interface IFigure
    {
        /// <summary>
        /// Начальные координаты фигуры.
        /// </summary>
        Point StartPoint { get; set; }

        /// <summary>
        /// Получение площади фигуры.
        /// </summary>
        /// <returns>Площадь фигуры.</returns>
        double GetArea();

        /// <summary>
        /// Получение периметра фигуры.
        /// </summary>
        /// <returns>Периметр фигуры.</returns>
        double GetPerimeter();
    }
}
