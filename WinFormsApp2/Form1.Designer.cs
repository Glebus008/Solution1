namespace SoilTestApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        // Объявляем все элементы здесь
        private System.Windows.Forms.DataGridView dgvMeasurements;
        private System.Windows.Forms.Button btnAddAndCalculate;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.TextBox txtInterval;
        private System.Windows.Forms.TextBox txtLoad;
        private System.Windows.Forms.TextBox txtS1;
        private System.Windows.Forms.TextBox txtS2;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblInterval;
        private System.Windows.Forms.Label lblLoad;
        private System.Windows.Forms.Label lblS1;
        private System.Windows.Forms.Label lblS2;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dgvMeasurements = new DataGridView();
            btnAddAndCalculate = new Button();
            txtDate = new TextBox();
            txtTime = new TextBox();
            txtInterval = new TextBox();
            txtLoad = new TextBox();
            txtS1 = new TextBox();
            txtS2 = new TextBox();
            lblDate = new Label();
            lblTime = new Label();
            lblInterval = new Label();
            lblLoad = new Label();
            lblS1 = new Label();
            lblS2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvMeasurements).BeginInit();
            SuspendLayout();
            // 
            // dgvMeasurements
            // 
            dgvMeasurements.AllowUserToAddRows = false;
            dgvMeasurements.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMeasurements.Location = new Point(185, 12);
            dgvMeasurements.Name = "dgvMeasurements";
            dgvMeasurements.Size = new Size(900, 430);
            dgvMeasurements.TabIndex = 0;
            // 
            // btnAddAndCalculate
            // 
            btnAddAndCalculate.Location = new Point(15, 340);
            btnAddAndCalculate.Name = "btnAddAndCalculate";
            btnAddAndCalculate.Size = new Size(150, 45);
            btnAddAndCalculate.TabIndex = 1;
            btnAddAndCalculate.Text = "ДОБАВИТЬ";
            btnAddAndCalculate.Click += btnAddAndCalculate_Click;
            // 
            // txtDate
            // 
            txtDate.Location = new Point(15, 40);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(150, 23);
            txtDate.TabIndex = 2;
            // 
            // txtTime
            // 
            txtTime.Location = new Point(15, 90);
            txtTime.Name = "txtTime";
            txtTime.Size = new Size(150, 23);
            txtTime.TabIndex = 3;
            // 
            // txtInterval
            // 
            txtInterval.Location = new Point(15, 140);
            txtInterval.Name = "txtInterval";
            txtInterval.Size = new Size(150, 23);
            txtInterval.TabIndex = 4;
            // 
            // txtLoad
            // 
            txtLoad.Location = new Point(15, 190);
            txtLoad.Name = "txtLoad";
            txtLoad.Size = new Size(150, 23);
            txtLoad.TabIndex = 5;
            // 
            // txtS1
            // 
            txtS1.Location = new Point(15, 240);
            txtS1.Name = "txtS1";
            txtS1.Size = new Size(150, 23);
            txtS1.TabIndex = 6;
            // 
            // txtS2
            // 
            txtS2.Location = new Point(15, 290);
            txtS2.Name = "txtS2";
            txtS2.Size = new Size(150, 23);
            txtS2.TabIndex = 7;
            // 
            // lblDate
            // 
            lblDate.Location = new Point(15, 20);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(100, 23);
            lblDate.TabIndex = 8;
            lblDate.Text = "Дата:";
            // 
            // lblTime
            // 
            lblTime.Location = new Point(15, 70);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(100, 23);
            lblTime.TabIndex = 9;
            lblTime.Text = "Время:";
            // 
            // lblInterval
            // 
            lblInterval.Location = new Point(15, 120);
            lblInterval.Name = "lblInterval";
            lblInterval.Size = new Size(100, 23);
            lblInterval.TabIndex = 10;
            lblInterval.Text = "Интервал (мин):";
            // 
            // lblLoad
            // 
            lblLoad.Location = new Point(15, 170);
            lblLoad.Name = "lblLoad";
            lblLoad.Size = new Size(100, 23);
            lblLoad.TabIndex = 11;
            lblLoad.Text = "Нагрузка (кН):";
            // 
            // lblS1
            // 
            lblS1.Location = new Point(15, 220);
            lblS1.Name = "lblS1";
            lblS1.Size = new Size(100, 23);
            lblS1.TabIndex = 12;
            lblS1.Text = "S1 (мм):";
            // 
            // lblS2
            // 
            lblS2.Location = new Point(15, 270);
            lblS2.Name = "lblS2";
            lblS2.Size = new Size(100, 23);
            lblS2.TabIndex = 13;
            lblS2.Text = "S2 (мм):";
            // 
            // Form1
            // 
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1100, 460);
            Controls.Add(dgvMeasurements);
            Controls.Add(btnAddAndCalculate);
            Controls.Add(txtDate);
            Controls.Add(txtTime);
            Controls.Add(txtInterval);
            Controls.Add(txtLoad);
            Controls.Add(txtS1);
            Controls.Add(txtS2);
            Controls.Add(lblDate);
            Controls.Add(lblTime);
            Controls.Add(lblInterval);
            Controls.Add(lblLoad);
            Controls.Add(lblS1);
            Controls.Add(lblS2);
            MaximumSize = new Size(1116, 499);
            MinimumSize = new Size(1116, 499);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Инженерный калькулятор";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMeasurements).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}