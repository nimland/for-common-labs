namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, "0,5");
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.button1 = new System.Windows.Forms.Button();
			this.textBoxA = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxM = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxR = new System.Windows.Forms.TextBox();
			this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.intervalA = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.intervalB = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.dispersion = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.expValue = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.uniformity = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.standardDeviation = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.aperiodicity = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.period = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
			this.SuspendLayout();
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "алогоритм Лемера",
            "равномерное распределение",
            "гауссовское распределение",
            "экспоненциальное распределение",
            "гамма-распределение",
            "треугольное распределение",
            "распределение Симпсона"});
			this.comboBox1.Location = new System.Drawing.Point(751, 12);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(167, 21);
			this.comboBox1.TabIndex = 1;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(799, 177);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "start";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBoxA
			// 
			this.textBoxA.ForeColor = System.Drawing.SystemColors.WindowText;
			this.textBoxA.Location = new System.Drawing.Point(751, 52);
			this.textBoxA.Name = "textBoxA";
			this.textBoxA.Size = new System.Drawing.Size(75, 20);
			this.textBoxA.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(751, 36);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(13, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "a";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(841, 36);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(15, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "m";
			// 
			// textBoxM
			// 
			this.textBoxM.ForeColor = System.Drawing.SystemColors.WindowText;
			this.textBoxM.Location = new System.Drawing.Point(841, 52);
			this.textBoxM.Name = "textBoxM";
			this.textBoxM.Size = new System.Drawing.Size(75, 20);
			this.textBoxM.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(751, 75);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(21, 13);
			this.label3.TabIndex = 8;
			this.label3.Text = "Ro";
			// 
			// textBoxR
			// 
			this.textBoxR.Location = new System.Drawing.Point(751, 91);
			this.textBoxR.Name = "textBoxR";
			this.textBoxR.Size = new System.Drawing.Size(75, 20);
			this.textBoxR.TabIndex = 7;
			// 
			// chart1
			// 
			chartArea1.AxisX.Maximum = 1D;
			chartArea1.AxisX.Minimum = 0D;
			chartArea1.Name = "ChartArea1";
			this.chart1.ChartAreas.Add(chartArea1);
			legend1.Name = "Legend1";
			this.chart1.Legends.Add(legend1);
			this.chart1.Location = new System.Drawing.Point(12, 12);
			this.chart1.Name = "chart1";
			series1.ChartArea = "ChartArea1";
			series1.Legend = "Legend1";
			series1.Name = "Series1";
			series2.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDot;
			series2.ChartArea = "ChartArea1";
			series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			series2.Color = System.Drawing.Color.Red;
			series2.Legend = "Legend1";
			series2.Name = "1/m";
			dataPoint1.IsEmpty = true;
			series2.Points.Add(dataPoint1);
			this.chart1.Series.Add(series1);
			this.chart1.Series.Add(series2);
			this.chart1.Size = new System.Drawing.Size(733, 435);
			this.chart1.TabIndex = 0;
			this.chart1.Text = "chart1";
			// 
			// intervalA
			// 
			this.intervalA.Location = new System.Drawing.Point(751, 151);
			this.intervalA.Name = "intervalA";
			this.intervalA.Size = new System.Drawing.Size(75, 20);
			this.intervalA.TabIndex = 9;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(751, 135);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(13, 13);
			this.label4.TabIndex = 10;
			this.label4.Text = "a";
			// 
			// intervalB
			// 
			this.intervalB.Location = new System.Drawing.Point(843, 151);
			this.intervalB.Name = "intervalB";
			this.intervalB.Size = new System.Drawing.Size(75, 20);
			this.intervalB.TabIndex = 11;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(840, 135);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(13, 13);
			this.label5.TabIndex = 12;
			this.label5.Text = "b";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(840, 282);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(64, 13);
			this.label6.TabIndex = 16;
			this.label6.Text = "Дисперсия";
			// 
			// dispersion
			// 
			this.dispersion.Location = new System.Drawing.Point(843, 298);
			this.dispersion.Name = "dispersion";
			this.dispersion.Size = new System.Drawing.Size(75, 20);
			this.dispersion.TabIndex = 15;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(751, 282);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(83, 13);
			this.label7.TabIndex = 14;
			this.label7.Text = "Мат. ожидание";
			// 
			// expValue
			// 
			this.expValue.Location = new System.Drawing.Point(751, 298);
			this.expValue.Name = "expValue";
			this.expValue.Size = new System.Drawing.Size(75, 20);
			this.expValue.TabIndex = 13;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(840, 321);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(22, 13);
			this.label8.TabIndex = 20;
			this.label8.Text = "ОР";
			// 
			// uniformity
			// 
			this.uniformity.Location = new System.Drawing.Point(843, 337);
			this.uniformity.Name = "uniformity";
			this.uniformity.Size = new System.Drawing.Size(75, 20);
			this.uniformity.TabIndex = 19;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(751, 321);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(14, 13);
			this.label9.TabIndex = 18;
			this.label9.Text = "σ";
			// 
			// standardDeviation
			// 
			this.standardDeviation.Location = new System.Drawing.Point(751, 337);
			this.standardDeviation.Name = "standardDeviation";
			this.standardDeviation.Size = new System.Drawing.Size(75, 20);
			this.standardDeviation.TabIndex = 17;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(840, 360);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(13, 13);
			this.label10.TabIndex = 24;
			this.label10.Text = "L";
			// 
			// aperiodicity
			// 
			this.aperiodicity.Location = new System.Drawing.Point(843, 376);
			this.aperiodicity.Name = "aperiodicity";
			this.aperiodicity.Size = new System.Drawing.Size(75, 20);
			this.aperiodicity.TabIndex = 23;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(751, 360);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(14, 13);
			this.label11.TabIndex = 22;
			this.label11.Text = "P";
			// 
			// period
			// 
			this.period.Location = new System.Drawing.Point(751, 376);
			this.period.Name = "period";
			this.period.Size = new System.Drawing.Size(75, 20);
			this.period.TabIndex = 21;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(930, 459);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.aperiodicity);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.period);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.uniformity);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.standardDeviation);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.dispersion);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.expValue);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.intervalB);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.intervalA);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBoxR);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBoxM);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBoxA);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.chart1);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxR;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox intervalA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox intervalB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox dispersion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox expValue;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox uniformity;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox standardDeviation;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox aperiodicity;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox period;
    }
}

