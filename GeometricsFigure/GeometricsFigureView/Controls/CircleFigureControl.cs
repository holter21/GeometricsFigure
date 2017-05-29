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
    public partial class CircleFigureControl : UserControl
    {

        public CircleFigureControl()
        {
            InitializeComponent();
        }

        public CircleFigure Circle
        {
            get
            {
                var circle = new CircleFigure();
                try
                {
                    circle.Radius = Convert.ToDouble(radiustextBox.Text);
                }
                catch ( FormatException )
                {
                    var exception = new FormatException(@"Ошибка ввода данных!");
                    throw exception;
                }
                return circle;
                
            }
            set
            {
                radiustextBox.Text = value.Radius.ToString();
                try
                {
                    double radiusTextBox = Convert.ToDouble(this.radiustextBox.Text);
                }
                catch ( FormatException )
                {
                    var exception = new FormatException(@"Ошибка ввода данных!");
                    throw exception;
                }
            }
        }
    }
}
