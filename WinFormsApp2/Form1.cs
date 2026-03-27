using System;
using System.Windows.Forms;
using System.Globalization;

namespace SoilTestApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double totalSettlement = 0;
            double totalMinutes = 0;
            double? previousSavg = null;

            foreach (DataGridViewRow row in dgvMeasurements.Rows)
            {
                if (row.IsNewRow) continue;

                // 1. Считаем суммарное время (из колонки Интервал)
                var intervalVal = row.Cells["Interval"].Value;
                if (intervalVal != null)
                {
                    totalMinutes += ParseDouble(intervalVal.ToString());
                    row.Cells["TotalTime"].Value = totalMinutes.ToString();
                }

                // 2. Считаем осадку (из колонок S1 и S2)
                var s1Val = row.Cells["S1"].Value;
                var s2Val = row.Cells["S2"].Value;

                if (s1Val != null && s2Val != null)
                {
                    double s1 = ParseDouble(s1Val.ToString());
                    double s2 = ParseDouble(s2Val.ToString());

                    // Среднее
                    double currentSavg = (s1 + s2) / 2.0;
                    row.Cells["Savg"].Value = currentSavg.ToString("F3");

                    // Приращение (разница с прошлой строкой)
                    double deltaS = 0;
                    if (previousSavg.HasValue)
                    {
                        deltaS = Math.Abs(previousSavg.Value - currentSavg);
                    }
                    row.Cells["DeltaS"].Value = deltaS.ToString("F3");

                    // Общая сумма осадки
                    totalSettlement += deltaS;
                    row.Cells["SumS"].Value = totalSettlement.ToString("F3");

                    previousSavg = currentSavg;
                }
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