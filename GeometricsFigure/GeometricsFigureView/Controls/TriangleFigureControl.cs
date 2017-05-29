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
    public partial class TriangleFigureControl : UserControl
    {
        public TriangleFigureControl()
        {
            InitializeComponent();
        }

        public TriangleFigure Triangle
        {
            get
            {
                var triangle = new TriangleFigure();
                try
                {
                    triangle.SetSides(Convert.ToDouble(sideAtextBox.Text),
                                      Convert.ToDouble(sideBtextBox.Text),
                                      Convert.ToDouble(sideCtextBox.Text));
                }
                catch (FormatException)
                {
                    var exception = new FormatException(@"Ошибка ввода данных!");
                    throw exception;
                }
                return triangle;

            }
            set
            {
                sideAtextBox.Text = value.SideA.ToString();
                sideBtextBox.Text = value.SideB.ToString();
                sideCtextBox.Text = value.SideC.ToString();
                try
                {
                    double sideAtextBox = Convert.ToDouble(this.sideAtextBox.Text);
                    double sideBtextBox = Convert.ToDouble(this.sideBtextBox.Text);
                    double sideCtextBox = Convert.ToDouble(this.sideCtextBox.Text);
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
