namespace GeometricsFigureView.Controls
{
    partial class RectangleFigureControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sideAtextBox = new System.Windows.Forms.TextBox();
            this.sideBtextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Сторона А";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Сторона В";
            // 
            // sideAtextBox
            // 
            this.sideAtextBox.Location = new System.Drawing.Point(3, 16);
            this.sideAtextBox.Name = "sideAtextBox";
            this.sideAtextBox.Size = new System.Drawing.Size(100, 20);
            this.sideAtextBox.TabIndex = 2;
            // 
            // sideBtextBox
            // 
            this.sideBtextBox.Location = new System.Drawing.Point(3, 55);
            this.sideBtextBox.Name = "sideBtextBox";
            this.sideBtextBox.Size = new System.Drawing.Size(100, 20);
            this.sideBtextBox.TabIndex = 3;
            // 
            // RectangleFigureControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sideBtextBox);
            this.Controls.Add(this.sideAtextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RectangleFigureControl";
            this.Size = new System.Drawing.Size(135, 218);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sideAtextBox;
        private System.Windows.Forms.TextBox sideBtextBox;
    }
}
