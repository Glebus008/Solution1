namespace WinFormsApp1
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvMeasurements;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblTitle;

        // Колонки таблицы
        private System.Windows.Forms.DataGridViewTextBoxColumn colTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colS1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colS2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSavg;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDeltaS;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSumS;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvMeasurements = new System.Windows.Forms.DataGridView();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();

            // Инициализация колонок
            this.colTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colS1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colS2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSavg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDeltaS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSumS = new System.Windows.Forms.DataGridViewTextBoxColumn();

            ((System.ComponentModel.ISupportInitialize)(this.dgvMeasurements)).BeginInit();
            this.SuspendLayout();

            // 
            // lblTitle
            // 
            this.lblTitle.Text = "Журнал полевых испытаний (Статика)";
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Size = new System.Drawing.Size(300, 20);
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);

            // 
            // dgvMeasurements
            // 
            this.dgvMeasurements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMeasurements.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTime, this.colS1, this.colS2, this.colSavg, this.colDeltaS, this.colSumS});
            this.dgvMeasurements.Location = new System.Drawing.Point(12, 40);
            this.dgvMeasurements.Size = new System.Drawing.Size(760, 350);
            this.dgvMeasurements.Name = "dgvMeasurements";

            // Настройка заголовков (как в вашем бумажном журнале)
            this.colTime.HeaderText = "Время (мин)";
            this.colTime.Name = "Time";

            this.colS1.HeaderText = "S1 (мм)";
            this.colS1.Name = "S1";

            this.colS2.HeaderText = "S2 (мм)";
            this.colS2.Name = "S2";

            this.colSavg.HeaderText = "S сред. (мм)";
            this.colSavg.Name = "Savg";
            this.colSavg.ReadOnly = true; // Только для чтения (вычисляется)

            this.colDeltaS.HeaderText = "ΔS (приращ.)";
            this.colDeltaS.Name = "DeltaS";
            this.colDeltaS.ReadOnly = true;

            this.colSumS.HeaderText = "ΣS (сумма)";
            this.colSumS.Name = "SumS";
            this.colSumS.ReadOnly = true;

            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(12, 400);
            this.btnCalculate.Size = new System.Drawing.Size(150, 40);
            this.btnCalculate.Text = "Рассчитать итоги";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);

            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dgvMeasurements);
            this.Controls.Add(this.btnCalculate);
            this.Text = "Расчет осадки грунта";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeasurements)).EndInit();
            this.ResumeLayout(false);
        }
    }
}