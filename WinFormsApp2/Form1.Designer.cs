namespace SoilTestApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvMeasurements;
        private System.Windows.Forms.Button btnAddAndCalculate;
        private System.Windows.Forms.TextBox txtDate, txtTime, txtInterval, txtLoad, txtS1, txtS2;
        private System.Windows.Forms.Label lblDate, lblTime, lblInterval, lblLoad, lblS1, lblS2;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvMeasurements = new System.Windows.Forms.DataGridView();
            this.btnAddAndCalculate = new System.Windows.Forms.Button();

            // Инициализация полей ввода
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.txtInterval = new System.Windows.Forms.TextBox();
            this.txtLoad = new System.Windows.Forms.TextBox();
            this.txtS1 = new System.Windows.Forms.TextBox();
            this.txtS2 = new System.Windows.Forms.TextBox();

            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblInterval = new System.Windows.Forms.Label();
            this.lblLoad = new System.Windows.Forms.Label();
            this.lblS1 = new System.Windows.Forms.Label();
            this.lblS2 = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.dgvMeasurements)).BeginInit();
            this.SuspendLayout();

            // Настройка меток и полей (Слева)
            int labelX = 15, textX = 15, y = 20, step = 50;

            string[] labels = { "Дата:", "Время:", "Интервал (мин):", "Нагрузка (кН):", "S1 (мм):", "S2 (мм):" };
            Control[] boxes = { txtDate, txtTime, txtInterval, txtLoad, txtS1, txtS2 };
            Label[] lbls = { lblDate, lblTime, lblInterval, lblLoad, lblS1, lblS2 };

            for (int i = 0; i < labels.Length; i++)
            {
                lbls[i].Text = labels[i];
                lbls[i].Location = new System.Drawing.Point(labelX, y);
                lbls[i].AutoSize = true;

                boxes[i].Location = new System.Drawing.Point(textX, y + 20);
                boxes[i].Size = new System.Drawing.Size(150, 23);

                this.Controls.Add(lbls[i]);
                this.Controls.Add(boxes[i]);
                y += step;
            }

            // Кнопка добавления
            this.btnAddAndCalculate.Location = new System.Drawing.Point(15, y + 10);
            this.btnAddAndCalculate.Size = new System.Drawing.Size(150, 45);
            this.btnAddAndCalculate.Text = "ДОБАВИТЬ В ТАБЛИЦУ";
            this.btnAddAndCalculate.Click += new System.EventHandler(this.btnAddAndCalculate_Click);

            // Таблица (Справа)
            this.dgvMeasurements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMeasurements.Location = new System.Drawing.Point(180, 12);
            this.dgvMeasurements.Size = new System.Drawing.Size(1000, 450);
            this.dgvMeasurements.AllowUserToAddRows = false; // Отключаем пустую строку внизу

            // Колонки
            this.dgvMeasurements.Columns.Add("Date", "Дата");
            this.dgvMeasurements.Columns.Add("Time", "Время");
            this.dgvMeasurements.Columns.Add("Interval", "Интервал");
            this.dgvMeasurements.Columns.Add("Load", "Нагрузка");
            this.dgvMeasurements.Columns.Add("S1", "S1");
            this.dgvMeasurements.Columns.Add("S2", "S2");
            this.dgvMeasurements.Columns.Add("Savg", "S сред.");
            this.dgvMeasurements.Columns.Add("DeltaS", "ΔS (прир.)");
            this.dgvMeasurements.Columns.Add("SumS", "ΣS (сумма)");
            this.dgvMeasurements.Columns.Add("TotalTime", "Сумм. время");

            // Форма
            this.ClientSize = new System.Drawing.Size(1200, 480);
            this.Controls.Add(this.dgvMeasurements);
            this.Controls.Add(this.btnAddAndCalculate);
            this.Text = "Ввод данных полевого журнала";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeasurements)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}