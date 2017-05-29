namespace GeometricsFigureView.Controls
{
    partial class TrapezeFigureControl
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sideDtextBox = new System.Windows.Forms.TextBox();
            this.heighttextBox = new System.Windows.Forms.TextBox();
            this.sideAtextBox = new System.Windows.Forms.TextBox();
            this.sideBtextBox = new System.Windows.Forms.TextBox();
            this.sideCtextBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
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
            this.label2.Location = new System.Drawing.Point(2, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Сторона D";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Высота";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Сторона В";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Сторона С";
            // 
            // sideDtextBox
            // 
            this.sideDtextBox.Location = new System.Drawing.Point(3, 133);
            this.sideDtextBox.Name = "sideDtextBox";
            this.sideDtextBox.Size = new System.Drawing.Size(100, 20);
            this.sideDtextBox.TabIndex = 5;
            // 
            // heighttextBox
            // 
            this.heighttextBox.Location = new System.Drawing.Point(3, 172);
            this.heighttextBox.Name = "heighttextBox";
            this.heighttextBox.Size = new System.Drawing.Size(100, 20);
            this.heighttextBox.TabIndex = 6;
            // 
            // sideAtextBox
            // 
            this.sideAtextBox.Location = new System.Drawing.Point(3, 16);
            this.sideAtextBox.Name = "sideAtextBox";
            this.sideAtextBox.Size = new System.Drawing.Size(100, 20);
            this.sideAtextBox.TabIndex = 7;
            // 
            // sideBtextBox
            // 
            this.sideBtextBox.Location = new System.Drawing.Point(3, 55);
            this.sideBtextBox.Name = "sideBtextBox";
            this.sideBtextBox.Size = new System.Drawing.Size(100, 20);
            this.sideBtextBox.TabIndex = 8;
            // 
            // sideCtextBox
            // 
            this.sideCtextBox.Location = new System.Drawing.Point(3, 94);
            this.sideCtextBox.Name = "sideCtextBox";
            this.sideCtextBox.Size = new System.Drawing.Size(100, 20);
            this.sideCtextBox.TabIndex = 9;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // TrapezeFigureControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sideCtextBox);
            this.Controls.Add(this.sideBtextBox);
            this.Controls.Add(this.sideAtextBox);
            this.Controls.Add(this.heighttextBox);
            this.Controls.Add(this.sideDtextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TrapezeFigureControl";
            this.Size = new System.Drawing.Size(135, 218);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox sideDtextBox;
        private System.Windows.Forms.TextBox heighttextBox;
        private System.Windows.Forms.TextBox sideAtextBox;
        private System.Windows.Forms.TextBox sideBtextBox;
        private System.Windows.Forms.TextBox sideCtextBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}
