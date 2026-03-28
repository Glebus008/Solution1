using System;
using System.Windows.Forms;
using System.Globalization;

namespace SoilTestApp
{
    public partial class Form1 : Form
    {
        // Переменные для хранения накопленных итогов
        double totalSettlement = 0;
        double totalMinutes = 0;
        double? lastSavg = null;

        public Form1()
        {
            InitializeComponent();
            SetupTable(); // Выносим создание колонок в отдельный метод
            txtDate.Text = DateTime.Now.ToString("dd.MM.yyyy");
        }

        private void SetupTable()
        {
            dgvMeasurements.Columns.Clear();

            // Настройка автоматической ширины (чтобы всё влезло)
            dgvMeasurements.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Добавляем все 10 колонок
            dgvMeasurements.Columns.Add("Date", "Дата");
            dgvMeasurements.Columns.Add("Time", "Время");
            dgvMeasurements.Columns.Add("Interval", "Интервал");
            dgvMeasurements.Columns.Add("Load", "Нагрузка");
            dgvMeasurements.Columns.Add("S1", "S1");
            dgvMeasurements.Columns.Add("S2", "S2");
            dgvMeasurements.Columns.Add("Savg", "Перемещ. (S сред.)");
            dgvMeasurements.Columns.Add("DeltaS", "Приращ. перемещ. ΔS");
            dgvMeasurements.Columns.Add("SumS", "Сумм. перемещ. ΣS");
            dgvMeasurements.Columns.Add("TotalTime", "Сумм. время"); // Наша потеряшка
        }

        private void btnAddAndCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Читаем входные данные
                double interval = ParseDouble(txtInterval.Text);
                double load = ParseDouble(txtLoad.Text);
                double s1 = ParseDouble(txtS1.Text);
                double s2 = ParseDouble(txtS2.Text);

                // 1. Считаем суммарное время
                totalMinutes += interval;

                // 2. Считаем осадку
                double currentSavg = (s1 + s2) / 2.0;
                double deltaS = 0;

                if (lastSavg.HasValue)
                {
                    deltaS = Math.Abs(lastSavg.Value - currentSavg);
                }

                totalSettlement += deltaS;
                lastSavg = currentSavg;

                // 3. Добавляем строку (ВАЖНО: 10 аргументов)
                dgvMeasurements.Rows.Add(
                    txtDate.Text,                   // 1
                    txtTime.Text,                   // 2
                    interval.ToString(),            // 3
                    load.ToString(),                // 4
                    s1.ToString(),                  // 5
                    s2.ToString(),                  // 6
                    currentSavg.ToString("F3"),     // 7
                    deltaS.ToString("F3"),          // 8
                    totalSettlement.ToString("F3"),  // 9
                    totalMinutes.ToString()         // 10 (Суммарное время)
                );

                // Очистка полей для нового ввода
                txtS1.Clear();
                txtS2.Clear();
                txtS1.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private double ParseDouble(string input)
        {
            if (string.IsNullOrWhiteSpace(input)) return 0;
            input = input.Replace(',', '.');
            double.TryParse(input, NumberStyles.Any, CultureInfo.InvariantCulture, out double result);
            return result;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}