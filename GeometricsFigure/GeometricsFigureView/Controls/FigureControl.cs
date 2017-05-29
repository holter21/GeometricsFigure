using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GeometricsFigure;

namespace GeometricsFigureView.Controls
{
    public partial class FigureControl : UserControl
    {
        public FigureControl()
        {
            InitializeComponent();

            figurecomboBox.Items.Add("Прямоугольник");
            figurecomboBox.Items.Add("Треугольник");
            figurecomboBox.Items.Add("Трапеция");
            figurecomboBox.Items.Add("Окружность");

            rectangleFigureControl1.Visible = false;
            triangleFigureControl.Visible = false;
            trapezeFigureControl1.Visible = false;
            circleFigureControl1.Visible = false;
        }

        public IFigure Figure
        {
            get
            {
                IFigure figure = null;
                int ss = figurecomboBox.SelectedIndex;
                switch ( ss )
                {
                    case 0:
                    {
                        try
                        {
                            figure = rectangleFigureControl1.Rectangle;
                        }
                        catch ( FormatException exception )
                        {
                            throw exception;
                        }
                        break;
                    }
                    case 1:
                    {
                        try
                        {
                            figure = triangleFigureControl.Triangle;
                        }
                        catch ( FormatException exception )
                        {
                            throw exception;
                        }
                        break;
                    }
                    case 2:
                    {
                        try
                        {
                            figure = trapezeFigureControl1.Trapeze;
                        }
                        catch ( FormatException exception )
                        {
                            throw exception;
                        }
                        break;
                    }
                    case 3:
                    {
                        try
                        {
                            figure = circleFigureControl1.Circle;
                        }
                        catch ( FormatException exception )
                        {
                            throw exception;
                        }
                        break;
                    }
                }
                return figure;
            }
            set
            {
                if ( value is RectangleFigure )
                {
                    figurecomboBox.SelectedIndex = 0;
                    try
                    {
                        rectangleFigureControl1.Rectangle = (RectangleFigure)value;
                    }
                    catch ( FormatException exception )
                    {
                        throw exception;
                    }
                }
                else if ( value is TriangleFigure )
                {
                    figurecomboBox.SelectedIndex = 1;
                    try
                    {
                        triangleFigureControl.Triangle = (TriangleFigure)value;
                    }
                    catch ( FormatException exception )
                    {
                        throw exception;
                    }
                }
                else if ( value is TrapezeFigure )
                {
                    figurecomboBox.SelectedIndex = 2;
                    try
                    {
                        trapezeFigureControl1.Trapeze = (TrapezeFigure)value;
                    }
                    catch ( FormatException exception )
                    {
                        throw exception;
                    }
                }
                else if ( value is CircleFigure )
                {
                    figurecomboBox.SelectedIndex = 3;
                    try
                    {
                        circleFigureControl1.Circle = (CircleFigure)value;
                    }
                    catch ( FormatException exception )
                    {
                        throw exception;
                    }
                }
            }
        }

        private void figurecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            rectangleFigureControl1.Visible = (figurecomboBox.SelectedIndex == 0);
            triangleFigureControl.Visible = (figurecomboBox.SelectedIndex == 1);
            trapezeFigureControl1.Visible = (figurecomboBox.SelectedIndex == 2);
            circleFigureControl1.Visible = (figurecomboBox.SelectedIndex == 3);
        }
    }
}

