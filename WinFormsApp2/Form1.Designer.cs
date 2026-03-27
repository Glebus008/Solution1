namespace SoilTestApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvMeasurements;
        private System.Windows.Forms.Button btnCalculate;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvMeasurements = new System.Windows.Forms.DataGridView();
            this.btnCalculate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeasurements)).BeginInit();
            this.SuspendLayout();

            this.dgvMeasurements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMeasurements.Location = new System.Drawing.Point(12, 12);
            this.dgvMeasurements.Name = "dgvMeasurements";
            this.dgvMeasurements.Size = new System.Drawing.Size(1100, 400);

            // ПОРЯДОК КОЛОНОК (Сумм. время теперь в конце)
            this.dgvMeasurements.Columns.Add("Date", "Дата");
            this.dgvMeasurements.Columns.Add("Time", "Время");
            this.dgvMeasurements.Columns.Add("Interval", "Интервал (мин)");
            this.dgvMeasurements.Columns.Add("Load", "Нагрузка (кН)");
            this.dgvMeasurements.Columns.Add("S1", "S1 (мм)");
            this.dgvMeasurements.Columns.Add("S2", "S2 (мм)");
            this.dgvMeasurements.Columns.Add("Savg", "S сред. (мм)");
            this.dgvMeasurements.Columns.Add("DeltaS", "ΔS (прир.)");
            this.dgvMeasurements.Columns.Add("SumS", "ΣS (сумма)");
            this.dgvMeasurements.Columns.Add("TotalTime", "Сумм. время (мин)"); // ТЕПЕРЬ ТУТ

            // Блокируем расчетные ячейки
            string[] readOnly = { "Savg", "DeltaS", "SumS", "TotalTime" };
            foreach (var name in readOnly) this.dgvMeasurements.Columns[name].ReadOnly = true;

            this.btnCalculate.Location = new System.Drawing.Point(12, 420);
            this.btnCalculate.Size = new System.Drawing.Size(200, 40);
            this.btnCalculate.Text = "РАССЧИТАТЬ";
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);

            this.ClientSize = new System.Drawing.Size(1130, 480);
            this.Controls.Add(this.dgvMeasurements);
            this.Controls.Add(this.btnCalculate);
            this.Name = "Form1";
            this.Text = "Калькулятор полевого журнала";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeasurements)).EndInit();
            this.ResumeLayout(false);
        }
    }
}