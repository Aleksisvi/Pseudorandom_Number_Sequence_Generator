
namespace Model3
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea11 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea12 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.differentFunct = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.integralFunct = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.selectBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.statisticBox = new System.Windows.Forms.RichTextBox();
            this.delButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.genLem = new System.Windows.Forms.RadioButton();
            this.genInn = new System.Windows.Forms.RadioButton();
            this.sequenceBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.differentFunct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.integralFunct)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.selectBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.statisticBox);
            this.panel1.Controls.Add(this.delButton);
            this.panel1.Controls.Add(this.startButton);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.sequenceBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1205, 703);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(917, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Статистика";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.differentFunct);
            this.groupBox2.Controls.Add(this.integralFunct);
            this.groupBox2.Location = new System.Drawing.Point(15, 77);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(882, 604);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Графики функций";
            // 
            // differentFunct
            // 
            chartArea11.Name = "ChartArea1";
            this.differentFunct.ChartAreas.Add(chartArea11);
            this.differentFunct.Location = new System.Drawing.Point(15, 30);
            this.differentFunct.Name = "differentFunct";
            this.differentFunct.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.differentFunct.Size = new System.Drawing.Size(850, 260);
            this.differentFunct.TabIndex = 6;
            // 
            // integralFunct
            // 
            chartArea12.Name = "ChartArea1";
            this.integralFunct.ChartAreas.Add(chartArea12);
            this.integralFunct.Location = new System.Drawing.Point(15, 311);
            this.integralFunct.Name = "integralFunct";
            this.integralFunct.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.integralFunct.Size = new System.Drawing.Size(850, 260);
            this.integralFunct.TabIndex = 7;
            // 
            // selectBox
            // 
            this.selectBox.BackColor = System.Drawing.SystemColors.Window;
            this.selectBox.Location = new System.Drawing.Point(229, 30);
            this.selectBox.Name = "selectBox";
            this.selectBox.Size = new System.Drawing.Size(190, 22);
            this.selectBox.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Объем выборки";
            // 
            // statisticBox
            // 
            this.statisticBox.BackColor = System.Drawing.SystemColors.Window;
            this.statisticBox.Location = new System.Drawing.Point(920, 107);
            this.statisticBox.Name = "statisticBox";
            this.statisticBox.ReadOnly = true;
            this.statisticBox.Size = new System.Drawing.Size(273, 541);
            this.statisticBox.TabIndex = 8;
            this.statisticBox.Text = "";
            // 
            // delButton
            // 
            this.delButton.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.delButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.delButton.Location = new System.Drawing.Point(855, 12);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(106, 40);
            this.delButton.TabIndex = 4;
            this.delButton.Text = "Очистить";
            this.delButton.UseVisualStyleBackColor = false;
            this.delButton.Click += new System.EventHandler(this.delButton_Click);
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.startButton.Location = new System.Drawing.Point(732, 12);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(106, 40);
            this.startButton.TabIndex = 3;
            this.startButton.Text = "Запуск";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.genLem);
            this.groupBox1.Controls.Add(this.genInn);
            this.groupBox1.Location = new System.Drawing.Point(435, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 47);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Генератор";
            // 
            // genLem
            // 
            this.genLem.AutoSize = true;
            this.genLem.Location = new System.Drawing.Point(123, 20);
            this.genLem.Name = "genLem";
            this.genLem.Size = new System.Drawing.Size(80, 21);
            this.genLem.TabIndex = 1;
            this.genLem.Tag = "2";
            this.genLem.Text = "Лемера";
            this.genLem.UseVisualStyleBackColor = true;
            // 
            // genInn
            // 
            this.genInn.AutoSize = true;
            this.genInn.Checked = true;
            this.genInn.Location = new System.Drawing.Point(7, 21);
            this.genInn.Name = "genInn";
            this.genInn.Size = new System.Drawing.Size(110, 21);
            this.genInn.TabIndex = 0;
            this.genInn.TabStop = true;
            this.genInn.Tag = "1";
            this.genInn.Text = "Встроенный";
            this.genInn.UseVisualStyleBackColor = true;
            // 
            // sequenceBox
            // 
            this.sequenceBox.BackColor = System.Drawing.SystemColors.Window;
            this.sequenceBox.Location = new System.Drawing.Point(15, 30);
            this.sequenceBox.Name = "sequenceBox";
            this.sequenceBox.Size = new System.Drawing.Size(190, 22);
            this.sequenceBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Длина последовательности";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1205, 703);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Генератор псевдослучайных числовых последовательностей";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.differentFunct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.integralFunct)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart differentFunct;
        private System.Windows.Forms.Button delButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton genLem;
        private System.Windows.Forms.RadioButton genInn;
        private System.Windows.Forms.TextBox sequenceBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart integralFunct;
        private System.Windows.Forms.RichTextBox statisticBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox selectBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

