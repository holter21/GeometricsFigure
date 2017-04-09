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
using System.Windows.Forms.VisualStyles;

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

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            if ( FigureComboBox.SelectedIndex == 0 )
            {
                if ( SideATextBox.TextLength == 0 || SideBTextBox.TextLength == 0 )
                {
                    MessageBox.Show(@"Вы ввели не все стороны прямоугольника.", @"Ошибка!");
                    return;
                }
            }

            else if ( FigureComboBox.SelectedIndex == 1 )
            {
                if ( SideATextBox.TextLength == 0 || SideBTextBox.TextLength == 0 || SideCTextBox.TextLength == 0 )
                {
                    MessageBox.Show(@"Вы ввели не все стороны треугольника.", @"Ошибка!");
                    return;
                }
            }

            else if ( FigureComboBox.SelectedIndex == 2 )
            {
                if ( SideATextBox.TextLength == 0 || SideBTextBox.TextLength == 0 || SideCTextBox.TextLength == 0
                     || SideDTextBox.TextLength == 0 )
                {
                    MessageBox.Show(@"Вы ввели не все стороны трапеции.", @"Ошибка!");
                    return;
                }
            }

            else if ( FigureComboBox.SelectedIndex == 3 )
            {
                if ( RadiusTextBox.TextLength == 0 )
                {
                    MessageBox.Show(@"Вы не ввели радиус окружности.", @"Ошибка!");
                    return;
                }
            }
            else if ( FigureComboBox.SelectedIndex == -1 )
            {
                DialogResult = DialogResult.Cancel;
                Close();
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

            private void ButtonCancel_Click(object sender, EventArgs e)
                {
                    DialogResult = DialogResult.Cancel;
                    Close();
                }

                private void RadiusTextBox_KeyDown(object sender, KeyEventArgs e)
                {

                }

                private void RadiusTextBox_KeyPress(object sender, KeyPressEventArgs e)
                {
                    if ( e.KeyChar != 8 && (e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != ',' )
                    {
                        e.Handled = true;
                    }
                }

                private void SideATextBox_KeyPress(object sender, KeyPressEventArgs e)
                {
                    if ( e.KeyChar != 8 && (e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != ',' )
                    {
                        e.Handled = true;
                    }
                }

                private void SideBTextBox_KeyPress(object sender, KeyPressEventArgs e)
                {
                    if ( e.KeyChar != 8 && (e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != ',' )
                    {
                        e.Handled = true;
                    }
                }

                private void SideCTextBox_KeyPress(object sender, KeyPressEventArgs e)
                {
                    if ( e.KeyChar != 8 && (e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != ',' )
                    {
                        e.Handled = true;
                    }
                }

                private void SideDTextBox_KeyPress(object sender, KeyPressEventArgs e)
                {
                    if ( e.KeyChar != 8 && (e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != ',' )
                    {
                        e.Handled = true;
                    }
                }

                private void HeightTextBox_KeyPress(object sender, KeyPressEventArgs e)
                {
                    if ( e.KeyChar != 8 && (e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != ',' )
                    {
                        e.Handled = true;
                    }
                }
            }
        }
