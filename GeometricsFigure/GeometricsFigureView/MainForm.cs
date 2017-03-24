using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using GeometricsFigure;

namespace GeometricsFigureView
{
    public partial class MainForm : Form
    {
        private List<IFigure> Figures;
        public MainForm()
        {
            InitializeComponent();
            Figures = new List<IFigure>();
            iFigureBindingSource.DataSource = Figures;
        }

        private void AddFigureButton_Click(object sender, EventArgs e)
        {
            var form = new AddFigureForm();
            if ( form.ShowDialog() == DialogResult.OK )
            {
                iFigureBindingSource.Add(form.Figure);
            }
        }

        private void RemoveFigureButton_Click(object sender, EventArgs e)
        {
            iFigureBindingSource.RemoveCurrent();
        }

        private void ModifyFigureButton_Click(object sender, EventArgs e)
        {
            int index = FigureDataGridView.SelectedCells[0].RowIndex;
            var form = new AddFigureForm
                       {
                           Figure = Figures[index]
                       };
            if ( form.ShowDialog() == DialogResult.OK )
            {
                iFigureBindingSource.RemoveAt(index);
                iFigureBindingSource.Insert(index, form.Figure);
            }
        }
    }
}
