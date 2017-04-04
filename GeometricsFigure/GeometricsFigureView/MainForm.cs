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

        private void RandomFigureButton_Click(object sender, EventArgs e)
        {
            iFigureBindingSource.Add(new RectangleFigure(10, 10));
            iFigureBindingSource.Add(new TriangleFigure(15, 8, 8));
            iFigureBindingSource.Add(new TrapezeFigure(10, 8, 6, 6, 4));
            iFigureBindingSource.Add(new CircleFigure(5));
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            if ( !(ofd.FileName == null || ofd.ShowDialog() == DialogResult.Cancel) )
            {
                Figures = Serialization.Deserialize(ofd.FileName);
                iFigureBindingSource.DataSource = Figures;
            }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Figures.Count != 0)
            {
                var ofd = new SaveFileDialog
                {
                    Filter = @"dat files (*.dat)|*.dat",
                    RestoreDirectory = true
                };
                if (!(ofd.FileName == null || ofd.ShowDialog() == DialogResult.Cancel))
                {
                    Serialization.Serialize(ofd.FileName, Figures);
                }
            }
            else
            {
                MessageBox.Show(@"Ошибка. Файл не може быть пустым");
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (SearchTextBox.Text != "")
            {
                for (var i = 0; i < FigureDataGridView.RowCount; i++)
                {
                    FigureDataGridView.Rows[i].Selected = false;
                    for (var j = 0; j < FigureDataGridView.ColumnCount; j++)
                    {
                        if (FigureDataGridView.Rows[i].Cells[j].Value == null)
                        {
                            continue;
                        }
                        if (!FigureDataGridView.Rows[i].Cells[j].Value.ToString().Contains(SearchTextBox.Text))
                        {
                            continue;
                        }
                        FigureDataGridView.Rows[i].Selected = true;
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show(@"Введите значение поиска");
            }
        }
    }
}
