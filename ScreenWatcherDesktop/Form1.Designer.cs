namespace ScreenWatcherDesktop
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.ComputerIdTextBox4 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ComputerNameTextBox3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ServerAdressTextBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.VerticalTo = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.HorizontalTo = new System.Windows.Forms.NumericUpDown();
            this.HorizontalFrom = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.VerticalFrom = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VerticalTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HorizontalTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HorizontalFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VerticalFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.ComputerIdTextBox4);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.ComputerNameTextBox3);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.ServerAdressTextBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(967, 152);
            this.panel1.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(280, 98);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "ID этого компьютера";
            // 
            // ComputerIdTextBox4
            // 
            this.ComputerIdTextBox4.Location = new System.Drawing.Point(283, 114);
            this.ComputerIdTextBox4.Name = "ComputerIdTextBox4";
            this.ComputerIdTextBox4.ReadOnly = true;
            this.ComputerIdTextBox4.Size = new System.Drawing.Size(202, 20);
            this.ComputerIdTextBox4.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(280, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Имя этого компьютера";
            // 
            // ComputerNameTextBox3
            // 
            this.ComputerNameTextBox3.Location = new System.Drawing.Point(283, 72);
            this.ComputerNameTextBox3.Name = "ComputerNameTextBox3";
            this.ComputerNameTextBox3.Size = new System.Drawing.Size(202, 20);
            this.ComputerNameTextBox3.TabIndex = 14;
            this.ComputerNameTextBox3.TextChanged += new System.EventHandler(this.ComputerNameTextBox3_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(280, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Адрес сервера";
            // 
            // ServerAdressTextBox2
            // 
            this.ServerAdressTextBox2.Location = new System.Drawing.Point(283, 36);
            this.ServerAdressTextBox2.Name = "ServerAdressTextBox2";
            this.ServerAdressTextBox2.Size = new System.Drawing.Size(202, 20);
            this.ServerAdressTextBox2.TabIndex = 12;
            this.ServerAdressTextBox2.Text = "https://localhost:7187";
            this.ServerAdressTextBox2.Leave += new System.EventHandler(this.ServerAdressTextBox2_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.VerticalTo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.HorizontalTo);
            this.groupBox1.Controls.Add(this.HorizontalFrom);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.VerticalFrom);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(15, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 91);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Область слежения";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "до";
            // 
            // VerticalTo
            // 
            this.VerticalTo.Location = new System.Drawing.Point(62, 62);
            this.VerticalTo.Name = "VerticalTo";
            this.VerticalTo.Size = new System.Drawing.Size(61, 20);
            this.VerticalTo.TabIndex = 10;
            this.VerticalTo.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.VerticalTo.ValueChanged += new System.EventHandler(this.HorizontalTo_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "от";
            // 
            // HorizontalTo
            // 
            this.HorizontalTo.Location = new System.Drawing.Point(165, 62);
            this.HorizontalTo.Name = "HorizontalTo";
            this.HorizontalTo.Size = new System.Drawing.Size(61, 20);
            this.HorizontalTo.TabIndex = 9;
            this.HorizontalTo.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.HorizontalTo.ValueChanged += new System.EventHandler(this.HorizontalTo_ValueChanged);
            // 
            // HorizontalFrom
            // 
            this.HorizontalFrom.Location = new System.Drawing.Point(165, 36);
            this.HorizontalFrom.Name = "HorizontalFrom";
            this.HorizontalFrom.Size = new System.Drawing.Size(61, 20);
            this.HorizontalFrom.TabIndex = 8;
            this.HorizontalFrom.ValueChanged += new System.EventHandler(this.HorizontalTo_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(162, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Горизонталь";
            // 
            // VerticalFrom
            // 
            this.VerticalFrom.Location = new System.Drawing.Point(62, 36);
            this.VerticalFrom.Name = "VerticalFrom";
            this.VerticalFrom.Size = new System.Drawing.Size(61, 20);
            this.VerticalFrom.TabIndex = 7;
            this.VerticalFrom.ValueChanged += new System.EventHandler(this.HorizontalTo_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Вертикаль";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Location = new System.Drawing.Point(701, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "label3";
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.textBox1.Location = new System.Drawing.Point(736, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(231, 152);
            this.textBox1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "секунд";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(115, 23);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(54, 20);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Проверять раз в ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 152);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(967, 301);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(495, 36);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(235, 98);
            this.textBox2.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 453);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "VideoPlayerWatcher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VerticalTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HorizontalTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HorizontalFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VerticalFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown VerticalTo;
        private System.Windows.Forms.NumericUpDown HorizontalTo;
        private System.Windows.Forms.NumericUpDown HorizontalFrom;
        private System.Windows.Forms.NumericUpDown VerticalFrom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox ComputerIdTextBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ComputerNameTextBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ServerAdressTextBox2;
        private System.Windows.Forms.TextBox textBox2;
    }
}
