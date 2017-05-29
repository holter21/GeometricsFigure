namespace GeometricsFigureView.Controls
{
    partial class FigureControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.figurecomboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.triangleFigureControl = new GeometricsFigureView.Controls.TriangleFigureControl();
            this.trapezeFigureControl1 = new GeometricsFigureView.Controls.TrapezeFigureControl();
            this.rectangleFigureControl1 = new GeometricsFigureView.Controls.RectangleFigureControl();
            this.circleFigureControl1 = new GeometricsFigureView.Controls.CircleFigureControl();
            this.triangleFigureControl1 = new GeometricsFigureView.Controls.TriangleFigureControl();
            this.SuspendLayout();
            // 
            // figurecomboBox
            // 
            this.figurecomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.figurecomboBox.FormattingEnabled = true;
            this.figurecomboBox.Location = new System.Drawing.Point(3, 32);
            this.figurecomboBox.Name = "figurecomboBox";
            this.figurecomboBox.Size = new System.Drawing.Size(121, 21);
            this.figurecomboBox.TabIndex = 0;
            this.figurecomboBox.SelectedIndexChanged += new System.EventHandler(this.figurecomboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберите фигуру";
            // 
            // triangleFigureControl
            // 
            this.triangleFigureControl.Location = new System.Drawing.Point(3, 59);
            this.triangleFigureControl.Name = "triangleFigureControl";
            this.triangleFigureControl.Size = new System.Drawing.Size(135, 218);
            this.triangleFigureControl.TabIndex = 5;
            // 
            // trapezeFigureControl1
            // 
            this.trapezeFigureControl1.Location = new System.Drawing.Point(6, 59);
            this.trapezeFigureControl1.Name = "trapezeFigureControl1";
            this.trapezeFigureControl1.Size = new System.Drawing.Size(135, 218);
            this.trapezeFigureControl1.TabIndex = 4;
            // 
            // rectangleFigureControl1
            // 
            this.rectangleFigureControl1.Location = new System.Drawing.Point(6, 59);
            this.rectangleFigureControl1.Name = "rectangleFigureControl1";
            this.rectangleFigureControl1.Size = new System.Drawing.Size(135, 218);
            this.rectangleFigureControl1.TabIndex = 3;
            // 
            // circleFigureControl1
            // 
            this.circleFigureControl1.Location = new System.Drawing.Point(6, 59);
            this.circleFigureControl1.Name = "circleFigureControl1";
            this.circleFigureControl1.Size = new System.Drawing.Size(135, 218);
            this.circleFigureControl1.TabIndex = 2;
            // 
            // triangleFigureControl1
            // 
            this.triangleFigureControl1.Location = new System.Drawing.Point(3, 59);
            this.triangleFigureControl1.Name = "triangleFigureControl1";
            this.triangleFigureControl1.Size = new System.Drawing.Size(135, 218);
            this.triangleFigureControl1.TabIndex = 5;
            // 
            // FigureControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.triangleFigureControl);
            this.Controls.Add(this.trapezeFigureControl1);
            this.Controls.Add(this.rectangleFigureControl1);
            this.Controls.Add(this.circleFigureControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.figurecomboBox);
            this.Name = "FigureControl";
            this.Size = new System.Drawing.Size(151, 298);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox figurecomboBox;
        private System.Windows.Forms.Label label1;
        private CircleFigureControl circleFigureControl1;
        private RectangleFigureControl rectangleFigureControl1;
        private TrapezeFigureControl trapezeFigureControl1;
        private TriangleFigureControl triangleFigureControl;
        private TriangleFigureControl triangleFigureControl1;
    }
}
