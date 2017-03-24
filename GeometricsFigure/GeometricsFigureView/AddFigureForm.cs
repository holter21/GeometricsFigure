using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using GeometricsFigure;

namespace GeometricsFigureView
{
    public partial class AddFigureForm : Form
    {
        private IFigure _figure;

        public IFigure Figure
        {
            get
            {

                if ( FigureComboBox.SelectedIndex == 0 )
                {
                    var rectangle = new RectangleFigure
                                    {
                                        Height = Convert.ToDouble(SideATextBox.Text),
                                        Width = Convert.ToDouble(SideBTextBox.Text)
                                    };
                    _figure = rectangle;
                }
                else if (FigureComboBox.SelectedIndex == 1)
                {
                    var triangle = new TriangleFigure();
                    triangle.SetSides(Convert.ToDouble(SideATextBox.Text),
                                      Convert.ToDouble(SideBTextBox.Text),
                                      Convert.ToDouble(SideCTextBox.Text));
                     _figure = triangle;
                 }
                 else if ( FigureComboBox.SelectedIndex == 2 )
                {
                    var trapeze = new TrapezeFigure
                                  {
                                      Height = Convert.ToDouble(HeightTextBox.Text),
                                      SideA = Convert.ToDouble(SideATextBox.Text),
                                      SideB = Convert.ToDouble(SideBTextBox.Text),
                                      SideC = Convert.ToDouble(SideCTextBox.Text),
                                      SideD = Convert.ToDouble(SideDTextBox.Text)
                                  };
                    _figure = trapeze;
                }
                else if (FigureComboBox.SelectedIndex == 3)
                {
                    var circle = new CircleFigure()
                    {
                        Radius = Convert.ToDouble(RadiusTextBox.Text)
                    };
                    _figure = circle;
                }
                return _figure;
            }

            set
            {
                if ( value is RectangleFigure )
                {
                    var rec = (RectangleFigure)value;
                    FigureComboBox.SelectedIndex = 0;
                    FigureComboBox.Enabled = false;
                    SideATextBox.Text = rec.Height.ToString(CultureInfo.InvariantCulture);
                    SideBTextBox.Text = rec.Width.ToString(CultureInfo.InvariantCulture);
                }

                else if (value is TriangleFigure)
                {
                    var rec = (TriangleFigure)value;
                    FigureComboBox.SelectedIndex = 1;
                    FigureComboBox.Enabled = false;
                    SideATextBox.Text = rec.SideA.ToString(CultureInfo.InvariantCulture);
                    SideBTextBox.Text = rec.SideB.ToString(CultureInfo.InvariantCulture);
                    SideCTextBox.Text = rec.SideC.ToString(CultureInfo.InvariantCulture);
                }

                else if (value is TrapezeFigure)
                {
                    var tra = (TrapezeFigure)value;
                    FigureComboBox.SelectedIndex = 2;
                    FigureComboBox.Enabled = false;
                    SideATextBox.Text = tra.SideA.ToString(CultureInfo.InvariantCulture);
                    SideBTextBox.Text = tra.SideB.ToString(CultureInfo.InvariantCulture);
                    SideCTextBox.Text = tra.SideC.ToString(CultureInfo.InvariantCulture);
                    SideDTextBox.Text = tra.SideD.ToString(CultureInfo.InvariantCulture);
                    HeightTextBox.Text = tra.Height.ToString(CultureInfo.InvariantCulture);
                }

                else if (value is CircleFigure)
                {
                    var cir = (CircleFigure)value;
                    FigureComboBox.SelectedIndex = 3;
                    FigureComboBox.Enabled = false;
                    RadiusTextBox.Text = cir.Radius.ToString(CultureInfo.InvariantCulture);
                }
            }
        }


        public AddFigureForm()
        {
            InitializeComponent();
        }

        private void FigureComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ( FigureComboBox.SelectedIndex == 0 )
            {
                SideATextBox.Visible = true;
                SideBTextBox.Visible = true;
                SideCTextBox.Visible = false;
                SideDTextBox.Visible = false;
                HeightTextBox.Visible = false;
                RadiusTextBox.Visible = false;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
            }

            else if (FigureComboBox.SelectedIndex == 1)
            {
                SideATextBox.Visible = true;
                SideBTextBox.Visible = true;
                SideCTextBox.Visible = true;
                SideDTextBox.Visible = false;
                HeightTextBox.Visible = false;
                RadiusTextBox.Visible = false;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
            }

            else if (FigureComboBox.SelectedIndex == 2)
            {
                SideATextBox.Visible = true;
                SideBTextBox.Visible = true;
                SideCTextBox.Visible = true;
                SideDTextBox.Visible = true;
                HeightTextBox.Visible = true;
                RadiusTextBox.Visible = false;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = false;
            }

            else if (FigureComboBox.SelectedIndex == 3)
            {
                SideATextBox.Visible = false;
                SideBTextBox.Visible = false;
                SideCTextBox.Visible = false;
                SideDTextBox.Visible = false;
                HeightTextBox.Visible = false;
                RadiusTextBox.Visible = true;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = true;
            }
        }

        private void SideDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void SideBTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SideCTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void RadiusTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
