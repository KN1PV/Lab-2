using lab1;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing;

namespace Lab_1
{
    public partial class Form1 : Form
    {
        private ControlSystem _controlSystem1;
        private ControlSystem _controlSystem2;
        private HydraulicSystem _hydraulicSystem;
        private double[] _d;
        private bool _isSimulationRunning = false;
        private bool _isAutoMode = true;

        public Form1()
        {
            InitializeComponent();

            // Ініціалізація систем
            _hydraulicSystem = new HydraulicSystem();
            _controlSystem1 = new ControlSystem(15); // dt = 15 сек
            _controlSystem2 = new ControlSystem(15); // dt = 15 сек
            _d = new[] { 1.2 * _hydraulicSystem.DIn1, _hydraulicSystem.DIn2, _hydraulicSystem.DOut1 };

            // Налаштування графіка
            ConfigureChart();

            // Ініціалізація значень
            InitializeValues();

            // Підключення обробників подій
            SetupEventHandlers();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ConfigureChart()
        {
            chart1.Series.Clear();

            // Додаємо серії для рівнів рідини
            AddSeries("z1", Color.Blue, AxisType.Primary);
            AddSeries("z2", Color.Green, AxisType.Primary);
            AddSeries("SetPoint1", Color.Red, AxisType.Primary);
            AddSeries("SetPoint2", Color.Orange, AxisType.Primary);
            AddSeries("E1", Color.DarkRed, AxisType.Primary);
            AddSeries("x1", Color.LightPink, AxisType.Secondary);
            AddSeries("x2", Color.Black, AxisType.Secondary);

            // Налаштування осей
            chart1.ChartAreas[0].AxisX.Title = "Час t (сек)";
            chart1.ChartAreas[0].AxisY.Title = "Рівень рідини z (м)";
            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.ChartAreas[0].AxisY.Minimum = 0;
        }

        private void AddSeries(string name, Color color, AxisType yAxisType)
        {
            var series = chart1.Series.Add(name);
            series.ChartType = SeriesChartType.Line;
            series.Color = color;
            series.YAxisType = yAxisType;
            series.BorderWidth = 2;
        }

        private void InitializeValues()
        {
            Gin1Value.Text = _hydraulicSystem.Gin1.ToString("F0");
            Gin2Value.Text = _hydraulicSystem.Gin2.ToString("F0");
            Gout1Value.Text = _hydraulicSystem.Gout1.ToString("F0");

            tbKp1.Text = "1.0";
            tbKi1.Text = "0";
            tbKd1.Text = "0.01";
            tbSetPoint1.Text = "0,5";

            tbKp2.Text = "1.0";
            tbKi2.Text = "0.1";
            tbKd2.Text = "0.01";
            tbSetPoint2.Text = "0,3";

            UpdateControlParameters();
        }

        private void SetupEventHandlers()
        {
            btnStart.Click += btnStart_Click;
            btnStop.Click += btnStop_Click;
            btnAuto.Click += BtnAuto_Click;

            tbSetPoint1.TextChanged += TbSetPoint1_TextChanged;
            tbKp1.TextChanged += TbKp1_TextChanged;
            tbKi1.TextChanged += TbKi1_TextChanged;
            tbKd1.TextChanged += TbKd1_TextChanged;

            tbSetPoint2.TextChanged += TbSetPoint2_TextChanged;
            tbKp2.TextChanged += TbKp2_TextChanged;
            tbKi2.TextChanged += TbKi2_TextChanged;
            tbKd2.TextChanged += TbKd2_TextChanged;

            Gin1BtnUp.Click += Gin1BtnUp_Click;
            Gin1BtnDown.Click += Gin1BtnDown_Click;
            Gin2BtnUp.Click += Gin2BtnUp_Click;
            Gin2BtnDown.Click += Gin2BtnDown_Click;
            Gout1BtnUp.Click += Gout1BtnUp_Click;
            Gout1BtnDown.Click += Gout1BtnDown_Click;
        }

        private void UpdateControlParameters()
        {
            if (double.TryParse(tbKp1.Text, out double kp))
                _controlSystem1.Kp = kp;

            if (double.TryParse(tbKi1.Text, out double ki))
                _controlSystem1.Ki = ki;

            if (double.TryParse(tbKd1.Text, out double kd))
                _controlSystem1.Kd = kd;

            if (double.TryParse(tbSetPoint1.Text, out double setPoint))
                _controlSystem1.SetPoint = setPoint;

            if (double.TryParse(tbKp2.Text, out double kp2))
                _controlSystem2.Kp = kp2;

            if (double.TryParse(tbKi2.Text, out double ki2))
                _controlSystem2.Ki = ki2;

            if (double.TryParse(tbKd2.Text, out double kd2))
                _controlSystem2.Kd = kd2;

            if (double.TryParse(tbSetPoint2.Text, out double setPoint2))
                _controlSystem2.SetPoint = setPoint2;
        }

        private void TbSetPoint1_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(tbSetPoint1.Text, out double setPoint))
            {
                _controlSystem1.SetPoint = setPoint;
            }
        }

        private void TbKp1_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(tbKp1.Text, out double kp))
            {
                _controlSystem1.Kp = kp;
            }
        }

        private void TbKi1_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(tbKi1.Text, out double ki))
            {
                _controlSystem1.Ki = ki;
            }
        }

        private void TbKd1_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(tbKd1.Text, out double kd))
            {
                _controlSystem1.Kd = kd;
            }
        }

        private void TbSetPoint2_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(tbSetPoint2.Text, out double setPoint))
            {
                _controlSystem2.SetPoint = setPoint;
            }
        }

        private void TbKp2_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(tbKp2.Text, out double kp))
            {
                _controlSystem2.Kp = kp;
            }
        }

        private void TbKi2_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(tbKi2.Text, out double ki))
            {
                _controlSystem2.Ki = ki;
            }
        }

        private void TbKd2_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(tbKd2.Text, out double kd))
            {
                _controlSystem2.Kd = kd;
            }
        }

        private void BtnAuto_Click(object sender, EventArgs e)
        {
            _isAutoMode = !_isAutoMode;
            btnAuto.Text = _isAutoMode ? "Авто" : "Ручний";

            if (_isAutoMode)
            {
                _controlSystem1.SwitchToAutoMode();
                _controlSystem2.SwitchToAutoMode();
            }
            else
            {
                _controlSystem1.SwitchToManualMode(_hydraulicSystem.Gin1);
                _controlSystem2.SwitchToManualMode(_hydraulicSystem.Gout1);
            }
        }

        private void Gin1BtnUp_Click(object sender, EventArgs e)
        {
            if (!_isAutoMode)
            {
                _hydraulicSystem.Gin1 += 10;
                Gin1Value.Text = _hydraulicSystem.Gin1.ToString("F0");
                _controlSystem1.SwitchToManualMode(_hydraulicSystem.Gin1);
            }
        }

        private void Gin1BtnDown_Click(object sender, EventArgs e)
        {
            if (!_isAutoMode)
            {
                _hydraulicSystem.Gin1 -= 10;
                Gin1Value.Text = _hydraulicSystem.Gin1.ToString("F0");
                _controlSystem1.SwitchToManualMode(_hydraulicSystem.Gin1);
            }
        }

        private void Gin2BtnUp_Click(object sender, EventArgs e)
        {
            _hydraulicSystem.Gin2 += 10;
            Gin2Value.Text = _hydraulicSystem.Gin2.ToString("F0");
        }

        private void Gin2BtnDown_Click(object sender, EventArgs e)
        {
            _hydraulicSystem.Gin2 -= 10;
            Gin2Value.Text = _hydraulicSystem.Gin2.ToString("F0");
        }

        private void Gout1BtnUp_Click(object sender, EventArgs e)
        {
            _hydraulicSystem.Gout1 += 10;
            Gout1Value.Text = _hydraulicSystem.Gout1.ToString("F0");
        }

        private void Gout1BtnDown_Click(object sender, EventArgs e)
        {
            _hydraulicSystem.Gout1 -= 10;
            Gout1Value.Text = _hydraulicSystem.Gout1.ToString("F0");
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            if (_isSimulationRunning) return;

            _isSimulationRunning = true;
            btnStart.Enabled = false;
            btnStop.Enabled = true;

            try
            {
                double t0 = 0;
                double tEnd = 8000000;
                double h = 300;
                int steps = (int)((tEnd - t0) / h);
                double[] y = { _hydraulicSystem.Z1, _hydraulicSystem.Z2 };

                chart1.Invoke((MethodInvoker)delegate
                {
                    foreach (var series in chart1.Series)
                        series.Points.Clear();
                });

                await Task.Run(() =>
                {
                    for (int i = 0; i < steps && _isSimulationRunning; i++)
                    {
                        double controlOutput1 = _controlSystem1.ComputeControlOutput(_hydraulicSystem.Z1);
                        _hydraulicSystem.Gin1 = controlOutput1;
                        this.Invoke(() =>
                        {
                            Gin1Value.Text = _hydraulicSystem.Gin1.ToString("F0");
                        });

                        double controlOutput2 = _controlSystem2.ComputeControlOutput(_hydraulicSystem.Z2);
                        _hydraulicSystem.Gin2 = controlOutput2;
                        this.Invoke(() => {
                            Gin2Value.Text = _hydraulicSystem.Gin2.ToString("F0");
                        });

                        if (double.TryParse(Gout1Value.Text, out double gout1))
                        {
                            _hydraulicSystem.Gout1 = gout1;
                        }

                        _hydraulicSystem.UpdateCoefficients();
                        y = Integrator.RungeKutta4(_hydraulicSystem.CalculateDerivatives, y, t0 + i * h, t0 + (i + 1) * h, h, _d);

                        y[0] = Math.Min(1, Math.Max(0, y[0]));
                        y[1] = Math.Min(1, Math.Max(0, y[1]));

                        _hydraulicSystem.Z1 = y[0];
                        _hydraulicSystem.Z2 = y[1];

                        chart1.Invoke((MethodInvoker)delegate
                        {
                            double time = i * h;
                            chart1.Series["z1"].Points.AddXY(time, y[0]);
                            chart1.Series["z2"].Points.AddXY(time, y[1]);
                            chart1.Series["SetPoint1"].Points.AddXY(time, _controlSystem1.SetPoint);
                            chart1.Series["SetPoint2"].Points.AddXY(time, _controlSystem2.SetPoint);
                            chart1.Series["E1"].Points.AddXY(time, _controlSystem1.E);
                            chart1.Series["x1"].Points.AddXY(time, _hydraulicSystem.Gin1);
                            chart1.Series["x2"].Points.AddXY(time, _hydraulicSystem.Gin2);
                        });

                        System.Threading.Thread.Sleep(10);
                    }
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}");
            }
            finally
            {
                _isSimulationRunning = false;
                btnStart.Enabled = true;
                btnStop.Enabled = false;
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            _isSimulationRunning = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}