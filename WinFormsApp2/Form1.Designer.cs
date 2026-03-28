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
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvMeasurements).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvMeasurements
            // 
            dgvMeasurements.AllowUserToAddRows = false;
            dgvMeasurements.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMeasurements.Dock = DockStyle.Fill;
            dgvMeasurements.Location = new Point(3, 19);
            dgvMeasurements.Name = "dgvMeasurements";
            dgvMeasurements.Size = new Size(737, 452);
            dgvMeasurements.TabIndex = 0;
            // 
            // btnAddAndCalculate
            // 
            btnAddAndCalculate.BackColor = Color.DeepSkyBlue;
            btnAddAndCalculate.Location = new Point(12, 372);
            btnAddAndCalculate.Name = "btnAddAndCalculate";
            btnAddAndCalculate.Size = new Size(150, 53);
            btnAddAndCalculate.TabIndex = 1;
            btnAddAndCalculate.Text = "ДОБАВИТЬ";
            btnAddAndCalculate.UseVisualStyleBackColor = false;
            btnAddAndCalculate.Click += btnAddAndCalculate_Click;
            // 
            // txtDate
            // 
            txtDate.Location = new Point(12, 47);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(150, 23);
            txtDate.TabIndex = 2;
            // 
            // txtTime
            // 
            txtTime.Location = new Point(12, 99);
            txtTime.Name = "txtTime";
            txtTime.Size = new Size(150, 23);
            txtTime.TabIndex = 3;
            // 
            // txtInterval
            // 
            txtInterval.Location = new Point(12, 151);
            txtInterval.Name = "txtInterval";
            txtInterval.Size = new Size(150, 23);
            txtInterval.TabIndex = 4;
            // 
            // txtLoad
            // 
            txtLoad.Location = new Point(12, 203);
            txtLoad.Name = "txtLoad";
            txtLoad.Size = new Size(150, 23);
            txtLoad.TabIndex = 5;
            // 
            // txtS1
            // 
            txtS1.Location = new Point(12, 255);
            txtS1.Name = "txtS1";
            txtS1.Size = new Size(150, 23);
            txtS1.TabIndex = 6;
            // 
            // txtS2
            // 
            txtS2.Location = new Point(12, 309);
            txtS2.Name = "txtS2";
            txtS2.Size = new Size(150, 23);
            txtS2.TabIndex = 7;
            // 
            // lblDate
            // 
            lblDate.Location = new Point(12, 25);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(100, 23);
            lblDate.TabIndex = 8;
            lblDate.Text = "Дата:";
            // 
            // lblTime
            // 
            lblTime.Location = new Point(12, 73);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(100, 23);
            lblTime.TabIndex = 9;
            lblTime.Text = "Время:";
            // 
            // lblInterval
            // 
            lblInterval.Location = new Point(12, 125);
            lblInterval.Name = "lblInterval";
            lblInterval.Size = new Size(100, 23);
            lblInterval.TabIndex = 10;
            lblInterval.Text = "Интервал (мин):";
            // 
            // lblLoad
            // 
            lblLoad.Location = new Point(12, 177);
            lblLoad.Name = "lblLoad";
            lblLoad.Size = new Size(100, 23);
            lblLoad.TabIndex = 11;
            lblLoad.Text = "Нагрузка (кН):";
            // 
            // lblS1
            // 
            lblS1.Location = new Point(12, 229);
            lblS1.Name = "lblS1";
            lblS1.Size = new Size(100, 23);
            lblS1.TabIndex = 12;
            lblS1.Text = "S1 (мм):";
            // 
            // lblS2
            // 
            lblS2.Location = new Point(12, 281);
            lblS2.Name = "lblS2";
            lblS2.Size = new Size(100, 25);
            lblS2.TabIndex = 13;
            lblS2.Text = "S2 (мм):";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LightSteelBlue;
            groupBox1.Controls.Add(txtDate);
            groupBox1.Controls.Add(lblDate);
            groupBox1.Controls.Add(btnAddAndCalculate);
            groupBox1.Controls.Add(txtTime);
            groupBox1.Controls.Add(lblS2);
            groupBox1.Controls.Add(txtInterval);
            groupBox1.Controls.Add(lblS1);
            groupBox1.Controls.Add(txtLoad);
            groupBox1.Controls.Add(lblLoad);
            groupBox1.Controls.Add(txtS1);
            groupBox1.Controls.Add(lblInterval);
            groupBox1.Controls.Add(txtS2);
            groupBox1.Controls.Add(lblTime);
            groupBox1.Dock = DockStyle.Left;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(175, 474);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.LightSteelBlue;
            groupBox2.Controls.Add(dgvMeasurements);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(175, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(743, 474);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(918, 474);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            MinimumSize = new Size(934, 513);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Инженерный калькулятор";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMeasurements).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}