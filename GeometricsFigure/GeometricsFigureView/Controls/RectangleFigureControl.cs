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
    public partial class RectangleFigureControl : UserControl
    {
        public RectangleFigureControl()
        {
            InitializeComponent();
        }

        public RectangleFigure Rectangle
        {
            get
            {
                var rectangle = new RectangleFigure();
                try
                {
                    rectangle.Height = Convert.ToDouble(sideAtextBox.Text);
                    rectangle.Width = Convert.ToDouble(sideBtextBox.Text);
                }
                catch (FormatException)
                {
                    var exception = new FormatException(@"Ошибка ввода данных!");
                    throw exception;
                }
                return rectangle;

            }
            set
            {
                sideAtextBox.Text = value.Height.ToString();
                sideBtextBox.Text = value.Width.ToString();
                try
                {
                    double sideAtextBox = Convert.ToDouble(this.sideAtextBox.Text);
                    double sideBtextBox = Convert.ToDouble(this.sideBtextBox.Text);
                }
                catch (FormatException)
                {
                    var exception = new FormatException(@"Ошибка ввода данных!");
                    throw exception;
                }
            }
        }

    }
}
