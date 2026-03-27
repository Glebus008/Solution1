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
            double? previousSavg = null;

            foreach (DataGridViewRow row in dgvMeasurements.Rows)
            {
                if (row.IsNewRow) continue;

                // Проверяем наличие данных в S1 и S2
                if (row.Cells["S1"].Value != null && row.Cells["S2"].Value != null)
                {
                    try
                    {
                        double s1 = ParseDouble(row.Cells["S1"].Value.ToString());
                        double s2 = ParseDouble(row.Cells["S2"].Value.ToString());

                        // 1. Среднее
                        double currentSavg = (s1 + s2) / 2.0;
                        row.Cells["Savg"].Value = currentSavg.ToString("F3");

                        // 2. Приращение (разница с предыдущей строкой)
                        double deltaS = 0;
                        if (previousSavg.HasValue)
                        {
                            deltaS = Math.Abs(previousSavg.Value - currentSavg);
                        }
                        row.Cells["DeltaS"].Value = deltaS.ToString("F3");

                        // 3. Сумма
                        totalSettlement += deltaS;
                        row.Cells["SumS"].Value = totalSettlement.ToString("F3");

                        previousSavg = currentSavg;
                    }
                    catch { /* Пропускаем строки с некорректным вводом */ }
                }
            }
        }

        private double ParseDouble(string input)
        {
            if (string.IsNullOrWhiteSpace(input)) return 0;
            input = input.Replace(',', '.');
            return double.Parse(input, CultureInfo.InvariantCulture);
        }
    }
}