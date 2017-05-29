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
    public partial class TrapezeFigureControl : UserControl
    {
        public TrapezeFigureControl()
        {
            InitializeComponent();
        }

        public TrapezeFigure Trapeze
        {
            get
            {
                var trapeze = new TrapezeFigure();
                try
                {
                    trapeze.SideA = Convert.ToDouble(sideAtextBox.Text);
                    trapeze.SideB = Convert.ToDouble(sideBtextBox.Text);
                    trapeze.SideC = Convert.ToDouble(sideCtextBox.Text);
                    trapeze.SideD = Convert.ToDouble(sideDtextBox.Text);
                    trapeze.Height = Convert.ToDouble(heighttextBox.Text);
                }
                catch (FormatException)
                {
                    var exception = new FormatException(@"Ошибка ввода данных!");
                    throw exception;
                }
                return trapeze;

            }
            set
            {
                sideAtextBox.Text = value.SideA.ToString();
                sideBtextBox.Text = value.SideB.ToString();
                sideCtextBox.Text = value.SideC.ToString();
                sideDtextBox.Text = value.SideD.ToString();
                heighttextBox.Text = value.Height.ToString();
                try
                {
                    double sideAtextBox = Convert.ToDouble(this.sideAtextBox.Text);
                    double sideBtextBox = Convert.ToDouble(this.sideBtextBox.Text);
                    double sideCtextBox = Convert.ToDouble(this.sideCtextBox.Text);
                    double sideDtextBox = Convert.ToDouble(this.sideDtextBox.Text);
                    double heighttextBox = Convert.ToDouble(this.heighttextBox.Text);
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
