using System;
using System.Windows.Forms;
using System.Globalization;

namespace SoilTestApp
{
    public partial class Form1 : Form
    {
        // Храним накопленные итоги в памяти класса
        double totalSettlement = 0;
        double totalMinutes = 0;
        double? lastSavg = null;

        public Form1()
        {
            InitializeComponent();
            txtDate.Text = DateTime.Now.ToString("dd.MM.yyyy"); // Предзаполнение даты
        }

        private void btnAddAndCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Читаем данные из текстбоксов
                double interval = ParseDouble(txtInterval.Text);
                double load = ParseDouble(txtLoad.Text);
                double s1 = ParseDouble(txtS1.Text);
                double s2 = ParseDouble(txtS2.Text);

                // 1. Считаем время
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

                // 3. Добавляем строку в таблицу
                dgvMeasurements.Rows.Add(
                    txtDate.Text,
                    txtTime.Text,
                    interval,
                    load,
                    s1,
                    s2,
                    currentSavg.ToString("F3"),
                    deltaS.ToString("F3"),
                    totalSettlement.ToString("F3"),
                    totalMinutes.ToString()
                );

                // Очищаем поля S1 и S2 для следующего замера, время и интервал оставляем для удобства
                txtS1.Clear();
                txtS2.Clear();
                txtS1.Focus(); // Ставим курсор обратно на S1
            }
            catch (Exception ex)
            {
                MessageBox.Show("Проверьте правильность ввода чисел!", "Ошибка");
            }
        }

        private double ParseDouble(string input)
        {
            if (string.IsNullOrWhiteSpace(input)) return 0;
            input = input.Replace(',', '.');
            double.TryParse(input, NumberStyles.Any, CultureInfo.InvariantCulture, out double result);
            return result;
        }
    }
}