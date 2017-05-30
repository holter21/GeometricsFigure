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
        public AddFigureForm()
        {
            InitializeComponent();
        }

        public IFigure Figure
        {
            get
            {
                try
                {
                    var cathThrowFigure = figureControl1.Figure;
                }
                catch ( FormatException exception )
                {
                    MessageBox.Show(exception.Message);
                    return null;
                }
                return figureControl1.Figure;
            }
            set
            {
                try
                {
                    figureControl1.Figure = value;
                }
                catch ( Exception exception )
                {
                    MessageBox.Show(exception.Message);
                    throw;
                }
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            catch ( Exception A )
            {
                MessageBox.Show(A.Message, @"Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void AddFigureForm_Load(object sender, EventArgs e)
        {

        }
    }
}
