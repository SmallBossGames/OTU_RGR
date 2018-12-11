namespace OTU_RGR
{
    partial class Form1
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.divCountTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.calcButton = new System.Windows.Forms.Button();
            this.showX1Button = new System.Windows.Forms.Button();
            this.showX2Button = new System.Windows.Forms.Button();
            this.showX3Button = new System.Windows.Forms.Button();
            this.showX_CBButton = new System.Windows.Forms.Button();
            this.fromTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.toTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(12, 12);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(776, 400);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // divCountTextBox
            // 
            this.divCountTextBox.Location = new System.Drawing.Point(349, 420);
            this.divCountTextBox.Name = "divCountTextBox";
            this.divCountTextBox.Size = new System.Drawing.Size(100, 20);
            this.divCountTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(284, 422);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Разбиения:";
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(455, 417);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(75, 23);
            this.calcButton.TabIndex = 3;
            this.calcButton.Text = "Расчитать";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // showX1Button
            // 
            this.showX1Button.Location = new System.Drawing.Point(127, 456);
            this.showX1Button.Name = "showX1Button";
            this.showX1Button.Size = new System.Drawing.Size(75, 23);
            this.showX1Button.TabIndex = 3;
            this.showX1Button.Text = "x1";
            this.showX1Button.UseVisualStyleBackColor = true;
            this.showX1Button.Click += new System.EventHandler(this.showX1Button_Click);
            // 
            // showX2Button
            // 
            this.showX2Button.Location = new System.Drawing.Point(208, 456);
            this.showX2Button.Name = "showX2Button";
            this.showX2Button.Size = new System.Drawing.Size(75, 23);
            this.showX2Button.TabIndex = 3;
            this.showX2Button.Text = "x2";
            this.showX2Button.UseVisualStyleBackColor = true;
            this.showX2Button.Click += new System.EventHandler(this.showX2Button_Click);
            // 
            // showX3Button
            // 
            this.showX3Button.Location = new System.Drawing.Point(289, 456);
            this.showX3Button.Name = "showX3Button";
            this.showX3Button.Size = new System.Drawing.Size(75, 23);
            this.showX3Button.TabIndex = 3;
            this.showX3Button.Text = "x3";
            this.showX3Button.UseVisualStyleBackColor = true;
            this.showX3Button.Click += new System.EventHandler(this.showX3Button_Click);
            // 
            // showX_CBButton
            // 
            this.showX_CBButton.Location = new System.Drawing.Point(370, 455);
            this.showX_CBButton.Name = "showX_CBButton";
            this.showX_CBButton.Size = new System.Drawing.Size(75, 23);
            this.showX_CBButton.TabIndex = 3;
            this.showX_CBButton.Text = "x_РБ";
            this.showX_CBButton.UseVisualStyleBackColor = true;
            this.showX_CBButton.Click += new System.EventHandler(this.showX_CBButton_Click);
            // 
            // fromTextBox
            // 
            this.fromTextBox.Location = new System.Drawing.Point(38, 420);
            this.fromTextBox.Name = "fromTextBox";
            this.fromTextBox.Size = new System.Drawing.Size(100, 20);
            this.fromTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 423);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "От:";
            // 
            // toTextBox
            // 
            this.toTextBox.Location = new System.Drawing.Point(174, 419);
            this.toTextBox.Name = "toTextBox";
            this.toTextBox.Size = new System.Drawing.Size(100, 20);
            this.toTextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(144, 422);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "До:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 461);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Показать значение:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 490);
            this.Controls.Add(this.showX_CBButton);
            this.Controls.Add(this.showX3Button);
            this.Controls.Add(this.showX2Button);
            this.Controls.Add(this.showX1Button);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toTextBox);
            this.Controls.Add(this.fromTextBox);
            this.Controls.Add(this.divCountTextBox);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox divCountTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Button showX1Button;
        private System.Windows.Forms.Button showX2Button;
        private System.Windows.Forms.Button showX3Button;
        private System.Windows.Forms.Button showX_CBButton;
        private System.Windows.Forms.TextBox fromTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox toTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

