namespace Lab_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            btnStart = new Button();
            btnStop = new Button();
            pictureBox1 = new PictureBox();
            Gin1BtnUp = new Button();
            Gin1BtnDown = new Button();
            Gin1Value = new TextBox();
            Gin2Value = new TextBox();
            Gin2BtnDown = new Button();
            Gin2BtnUp = new Button();
            Gout1Value = new TextBox();
            Gout1BtnUp = new Button();
            Gout1BtnDown = new Button();
            LbSetPoint = new Label();
            LbKp = new Label();
            LbTi = new Label();
            LbKd = new Label();
            tbSetPoint1 = new TextBox();
            tbKp1 = new TextBox();
            tbKi1 = new TextBox();
            tbKd1 = new TextBox();
            btnAuto = new Button();
            btnManual = new Button();
            tbKd2 = new TextBox();
            tbKi2 = new TextBox();
            tbKp2 = new TextBox();
            tbSetPoint2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // chart1
            // 
            chart1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(74, 289);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(1072, 490);
            chart1.TabIndex = 0;
            chart1.Text = "chart1";
            // 
            // btnStart
            // 
            btnStart.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnStart.BackColor = Color.FromArgb(128, 255, 128);
            btnStart.FlatStyle = FlatStyle.Popup;
            btnStart.Location = new Point(1039, 42);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(107, 43);
            btnStart.TabIndex = 1;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = false;
            // 
            // btnStop
            // 
            btnStop.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnStop.BackColor = Color.Red;
            btnStop.FlatStyle = FlatStyle.Popup;
            btnStop.Location = new Point(1039, 91);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(107, 43);
            btnStop.TabIndex = 2;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(464, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(528, 247);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Gin1BtnUp
            // 
            Gin1BtnUp.BackColor = Color.FromArgb(128, 255, 128);
            Gin1BtnUp.Location = new Point(503, 29);
            Gin1BtnUp.Name = "Gin1BtnUp";
            Gin1BtnUp.Size = new Size(26, 26);
            Gin1BtnUp.TabIndex = 4;
            Gin1BtnUp.Text = "↑";
            Gin1BtnUp.UseVisualStyleBackColor = false;
            // 
            // Gin1BtnDown
            // 
            Gin1BtnDown.BackColor = Color.FromArgb(255, 128, 128);
            Gin1BtnDown.Location = new Point(463, 29);
            Gin1BtnDown.Name = "Gin1BtnDown";
            Gin1BtnDown.Size = new Size(26, 26);
            Gin1BtnDown.TabIndex = 5;
            Gin1BtnDown.Text = "↓";
            Gin1BtnDown.UseVisualStyleBackColor = false;
            // 
            // Gin1Value
            // 
            Gin1Value.BackColor = Color.Silver;
            Gin1Value.Location = new Point(463, 53);
            Gin1Value.Name = "Gin1Value";
            Gin1Value.Size = new Size(66, 23);
            Gin1Value.TabIndex = 6;
            // 
            // Gin2Value
            // 
            Gin2Value.BackColor = Color.Silver;
            Gin2Value.Location = new Point(660, 53);
            Gin2Value.Name = "Gin2Value";
            Gin2Value.Size = new Size(66, 23);
            Gin2Value.TabIndex = 7;
            // 
            // Gin2BtnDown
            // 
            Gin2BtnDown.BackColor = Color.FromArgb(255, 128, 128);
            Gin2BtnDown.Location = new Point(660, 29);
            Gin2BtnDown.Name = "Gin2BtnDown";
            Gin2BtnDown.Size = new Size(26, 26);
            Gin2BtnDown.TabIndex = 8;
            Gin2BtnDown.Text = "↓";
            Gin2BtnDown.UseVisualStyleBackColor = false;
            // 
            // Gin2BtnUp
            // 
            Gin2BtnUp.BackColor = Color.FromArgb(128, 255, 128);
            Gin2BtnUp.Location = new Point(700, 29);
            Gin2BtnUp.Name = "Gin2BtnUp";
            Gin2BtnUp.Size = new Size(26, 26);
            Gin2BtnUp.TabIndex = 9;
            Gin2BtnUp.Text = "↑";
            Gin2BtnUp.UseVisualStyleBackColor = false;
            // 
            // Gout1Value
            // 
            Gout1Value.BackColor = Color.Silver;
            Gout1Value.Location = new Point(857, 251);
            Gout1Value.Name = "Gout1Value";
            Gout1Value.Size = new Size(66, 23);
            Gout1Value.TabIndex = 10;
            // 
            // Gout1BtnUp
            // 
            Gout1BtnUp.BackColor = Color.FromArgb(128, 255, 128);
            Gout1BtnUp.Location = new Point(929, 251);
            Gout1BtnUp.Name = "Gout1BtnUp";
            Gout1BtnUp.Size = new Size(26, 26);
            Gout1BtnUp.TabIndex = 11;
            Gout1BtnUp.Text = "↑";
            Gout1BtnUp.UseVisualStyleBackColor = false;
            // 
            // Gout1BtnDown
            // 
            Gout1BtnDown.BackColor = Color.FromArgb(255, 128, 128);
            Gout1BtnDown.Location = new Point(825, 251);
            Gout1BtnDown.Name = "Gout1BtnDown";
            Gout1BtnDown.Size = new Size(26, 26);
            Gout1BtnDown.TabIndex = 12;
            Gout1BtnDown.Text = "↓";
            Gout1BtnDown.UseVisualStyleBackColor = false;
            // 
            // LbSetPoint
            // 
            LbSetPoint.AutoSize = true;
            LbSetPoint.Location = new Point(40, 56);
            LbSetPoint.Name = "LbSetPoint";
            LbSetPoint.Size = new Size(57, 15);
            LbSetPoint.TabIndex = 13;
            LbSetPoint.Text = "SetPoint1";
            // 
            // LbKp
            // 
            LbKp.AutoSize = true;
            LbKp.Location = new Point(70, 91);
            LbKp.Name = "LbKp";
            LbKp.Size = new Size(21, 15);
            LbKp.TabIndex = 14;
            LbKp.Text = "Kp";
            // 
            // LbTi
            // 
            LbTi.AutoSize = true;
            LbTi.Location = new Point(75, 129);
            LbTi.Name = "LbTi";
            LbTi.Size = new Size(17, 15);
            LbTi.TabIndex = 15;
            LbTi.Text = "Ki";
            // 
            // LbKd
            // 
            LbKd.AutoSize = true;
            LbKd.Location = new Point(70, 166);
            LbKd.Name = "LbKd";
            LbKd.Size = new Size(21, 15);
            LbKd.TabIndex = 16;
            LbKd.Text = "Kd";
            // 
            // tbSetPoint1
            // 
            tbSetPoint1.Location = new Point(97, 53);
            tbSetPoint1.Name = "tbSetPoint1";
            tbSetPoint1.Size = new Size(100, 23);
            tbSetPoint1.TabIndex = 17;
            // 
            // tbKp1
            // 
            tbKp1.Location = new Point(97, 88);
            tbKp1.Name = "tbKp1";
            tbKp1.Size = new Size(100, 23);
            tbKp1.TabIndex = 18;
            // 
            // tbKi1
            // 
            tbKi1.Location = new Point(97, 126);
            tbKi1.Name = "tbKi1";
            tbKi1.Size = new Size(100, 23);
            tbKi1.TabIndex = 19;
            // 
            // tbKd1
            // 
            tbKd1.Location = new Point(97, 163);
            tbKd1.Name = "tbKd1";
            tbKd1.Size = new Size(100, 23);
            tbKd1.TabIndex = 20;
            // 
            // btnAuto
            // 
            btnAuto.Location = new Point(184, 209);
            btnAuto.Name = "btnAuto";
            btnAuto.Size = new Size(100, 37);
            btnAuto.TabIndex = 21;
            btnAuto.Text = "Auto";
            btnAuto.UseVisualStyleBackColor = true;
            // 
            // btnManual
            // 
            btnManual.Location = new Point(122, 273);
            btnManual.Name = "btnManual";
            btnManual.Size = new Size(18, 10);
            btnManual.TabIndex = 22;
            btnManual.Text = "Manual";
            btnManual.UseVisualStyleBackColor = true;
            // 
            // tbKd2
            // 
            tbKd2.Location = new Point(290, 163);
            tbKd2.Name = "tbKd2";
            tbKd2.Size = new Size(100, 23);
            tbKd2.TabIndex = 30;
            // 
            // tbKi2
            // 
            tbKi2.Location = new Point(290, 126);
            tbKi2.Name = "tbKi2";
            tbKi2.Size = new Size(100, 23);
            tbKi2.TabIndex = 29;
            // 
            // tbKp2
            // 
            tbKp2.Location = new Point(290, 88);
            tbKp2.Name = "tbKp2";
            tbKp2.Size = new Size(100, 23);
            tbKp2.TabIndex = 28;
            // 
            // tbSetPoint2
            // 
            tbSetPoint2.Location = new Point(290, 53);
            tbSetPoint2.Name = "tbSetPoint2";
            tbSetPoint2.Size = new Size(100, 23);
            tbSetPoint2.TabIndex = 27;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(263, 166);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 26;
            label1.Text = "Kd";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(268, 129);
            label2.Name = "label2";
            label2.Size = new Size(17, 15);
            label2.TabIndex = 25;
            label2.Text = "Ki";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(263, 91);
            label3.Name = "label3";
            label3.Size = new Size(21, 15);
            label3.TabIndex = 24;
            label3.Text = "Kp";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(233, 56);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 23;
            label4.Text = "SetPoint2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1173, 791);
            Controls.Add(tbKd2);
            Controls.Add(tbKi2);
            Controls.Add(tbKp2);
            Controls.Add(tbSetPoint2);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(btnManual);
            Controls.Add(btnAuto);
            Controls.Add(tbKd1);
            Controls.Add(tbKi1);
            Controls.Add(tbKp1);
            Controls.Add(tbSetPoint1);
            Controls.Add(LbKd);
            Controls.Add(LbTi);
            Controls.Add(LbKp);
            Controls.Add(LbSetPoint);
            Controls.Add(Gout1BtnDown);
            Controls.Add(Gout1BtnUp);
            Controls.Add(Gout1Value);
            Controls.Add(Gin2BtnUp);
            Controls.Add(Gin2BtnDown);
            Controls.Add(Gin2Value);
            Controls.Add(Gin1Value);
            Controls.Add(Gin1BtnDown);
            Controls.Add(Gin1BtnUp);
            Controls.Add(pictureBox1);
            Controls.Add(btnStop);
            Controls.Add(btnStart);
            Controls.Add(chart1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Button btnStart;
        private Button btnStop;
        private PictureBox pictureBox1;
        private Button Gin1BtnUp;
        private Button Gin1BtnDown;
        private TextBox Gin1Value;
        private TextBox Gin2Value;
        private Button Gin2BtnDown;
        private Button Gin2BtnUp;
        private TextBox Gout1Value;
        private Button Gout1BtnUp;
        private Button Gout1BtnDown;
        private Label LbSetPoint;
        private Label LbKp;
        private Label LbTi;
        private Label LbKd;
        private TextBox tbSetPoint1;
        private TextBox tbKp1;
        private TextBox tbKi1;
        private TextBox tbKd1;
        private Button btnAuto;
        private Button btnManual;
        private TextBox tbKd2;
        private TextBox tbKi2;
        private TextBox tbKp2;
        private TextBox tbSetPoint2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
