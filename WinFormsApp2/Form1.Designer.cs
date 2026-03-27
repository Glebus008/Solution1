namespace SoilTestApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        // Поля управления
        private System.Windows.Forms.DataGridView dgvMeasurements;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblTitle;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            // КРИТИЧЕСКИ ВАЖНО: Сначала создаем объект, чтобы не было NullReference
            this.dgvMeasurements = new System.Windows.Forms.DataGridView();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.dgvMeasurements)).BeginInit();
            this.SuspendLayout();

            // Таблица
            this.dgvMeasurements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMeasurements.Location = new System.Drawing.Point(12, 50);
            this.dgvMeasurements.Name = "dgvMeasurements";
            this.dgvMeasurements.Size = new System.Drawing.Size(910, 350);

            // Добавляем колонки в новом порядке (как в журнале)
            this.dgvMeasurements.Columns.Add("Date", "Дата");
            this.dgvMeasurements.Columns.Add("Time", "Время");
            this.dgvMeasurements.Columns.Add("Interval", "Интервал (мин)");
            this.dgvMeasurements.Columns.Add("Load", "Нагрузка (кН)");
            this.dgvMeasurements.Columns.Add("S1", "S1 (мм)");
            this.dgvMeasurements.Columns.Add("S2", "S2 (мм)");
            this.dgvMeasurements.Columns.Add("Savg", "S сред. (мм)");
            this.dgvMeasurements.Columns.Add("DeltaS", "ΔS (прир.)");
            this.dgvMeasurements.Columns.Add("SumS", "ΣS (сумма)");

            // Только для чтения
            this.dgvMeasurements.Columns["Savg"].ReadOnly = true;
            this.dgvMeasurements.Columns["DeltaS"].ReadOnly = true;
            this.dgvMeasurements.Columns["SumS"].ReadOnly = true;

            // Кнопка
            this.btnCalculate.Location = new System.Drawing.Point(12, 410);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(150, 40);
            this.btnCalculate.Text = "Рассчитать";
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);

            // Форма
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 461);
            this.Controls.Add(this.dgvMeasurements);
            this.Controls.Add(this.btnCalculate);
            this.Name = "Form1";
            this.Text = "Расчет полевого журнала";

            ((System.ComponentModel.ISupportInitialize)(this.dgvMeasurements)).EndInit();
            this.ResumeLayout(false);
        }
    }
}