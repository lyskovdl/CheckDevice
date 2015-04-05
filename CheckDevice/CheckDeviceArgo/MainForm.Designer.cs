
namespace CheckDeviceArgo
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.labPort1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxPort1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxPort2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxBaudRate = new System.Windows.Forms.ComboBox();
            this.btnStartTest = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.numBuffSize = new System.Windows.Forms.NumericUpDown();
            this.pBLeftArrow = new System.Windows.Forms.PictureBox();
            this.pBRightArrow = new System.Windows.Forms.PictureBox();
            this.prgsBarTransfer = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.numBuffSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBLeftArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBRightArrow)).BeginInit();
            this.SuspendLayout();
            // 
            // labPort1
            // 
            this.labPort1.AutoSize = true;
            this.labPort1.Location = new System.Drawing.Point(19, 26);
            this.labPort1.Name = "labPort1";
            this.labPort1.Size = new System.Drawing.Size(41, 13);
            this.labPort1.TabIndex = 0;
            this.labPort1.Text = "Порт 1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Порт 1";
            // 
            // cbxPort1
            // 
            this.cbxPort1.FormattingEnabled = true;
            this.cbxPort1.Location = new System.Drawing.Point(66, 23);
            this.cbxPort1.Name = "cbxPort1";
            this.cbxPort1.Size = new System.Drawing.Size(121, 21);
            this.cbxPort1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Порт 2";
            // 
            // cbxPort2
            // 
            this.cbxPort2.FormattingEnabled = true;
            this.cbxPort2.Location = new System.Drawing.Point(336, 23);
            this.cbxPort2.Name = "cbxPort2";
            this.cbxPort2.Size = new System.Drawing.Size(121, 21);
            this.cbxPort2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Скорость передачи";
            // 
            // cbxBaudRate
            // 
            this.cbxBaudRate.FormattingEnabled = true;
            this.cbxBaudRate.Items.AddRange(new object[] {
            "115200",
            "57600",
            "38400",
            "28800",
            "19200",
            "9600",
            "4800",
            "2400",
            "1200"});
            this.cbxBaudRate.Location = new System.Drawing.Point(130, 65);
            this.cbxBaudRate.Name = "cbxBaudRate";
            this.cbxBaudRate.Size = new System.Drawing.Size(77, 21);
            this.cbxBaudRate.TabIndex = 3;
            this.cbxBaudRate.Text = "115200";
            // 
            // btnStartTest
            // 
            this.btnStartTest.Location = new System.Drawing.Point(22, 110);
            this.btnStartTest.Name = "btnStartTest";
            this.btnStartTest.Size = new System.Drawing.Size(435, 23);
            this.btnStartTest.TabIndex = 4;
            this.btnStartTest.Text = "button1";
            this.btnStartTest.UseVisualStyleBackColor = true;
            this.btnStartTest.Click += new System.EventHandler(this.btnStartTest_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(213, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Размер блока передачи";
            // 
            // numBuffSize
            // 
            this.numBuffSize.Location = new System.Drawing.Point(348, 65);
            this.numBuffSize.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numBuffSize.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numBuffSize.Name = "numBuffSize";
            this.numBuffSize.Size = new System.Drawing.Size(109, 20);
            this.numBuffSize.TabIndex = 6;
            this.numBuffSize.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // pBLeftArrow
            // 
            this.pBLeftArrow.Image = global::CheckDeviceArgo.Properties.Resources.ArrowLeft;
            this.pBLeftArrow.Location = new System.Drawing.Point(229, 23);
            this.pBLeftArrow.Name = "pBLeftArrow";
            this.pBLeftArrow.Size = new System.Drawing.Size(21, 21);
            this.pBLeftArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pBLeftArrow.TabIndex = 7;
            this.pBLeftArrow.TabStop = false;
            this.pBLeftArrow.Visible = false;
            // 
            // pBRightArrow
            // 
            this.pBRightArrow.Image = global::CheckDeviceArgo.Properties.Resources.ArrowRight;
            this.pBRightArrow.Location = new System.Drawing.Point(229, 23);
            this.pBRightArrow.Name = "pBRightArrow";
            this.pBRightArrow.Size = new System.Drawing.Size(21, 21);
            this.pBRightArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pBRightArrow.TabIndex = 7;
            this.pBRightArrow.TabStop = false;
            this.pBRightArrow.Visible = false;
            // 
            // prgsBarTransfer
            // 
            this.prgsBarTransfer.Location = new System.Drawing.Point(22, 158);
            this.prgsBarTransfer.MarqueeAnimationSpeed = 10;
            this.prgsBarTransfer.Maximum = 1000;
            this.prgsBarTransfer.Name = "prgsBarTransfer";
            this.prgsBarTransfer.Size = new System.Drawing.Size(435, 22);
            this.prgsBarTransfer.Step = 1000;
            this.prgsBarTransfer.TabIndex = 8;
            this.prgsBarTransfer.Value = 500;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(554, 314);
            this.Controls.Add(this.prgsBarTransfer);
            this.Controls.Add(this.pBRightArrow);
            this.Controls.Add(this.pBLeftArrow);
            this.Controls.Add(this.numBuffSize);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnStartTest);
            this.Controls.Add(this.cbxBaudRate);
            this.Controls.Add(this.cbxPort2);
            this.Controls.Add(this.cbxPort1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labPort1);
            this.Name = "MainForm";
            this.Text = "Тестирование передачи данных";
            ((System.ComponentModel.ISupportInitialize)(this.numBuffSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBLeftArrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBRightArrow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labPort1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxPort1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxPort2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxBaudRate;
        private System.Windows.Forms.Button btnStartTest;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numBuffSize;
        private System.Windows.Forms.PictureBox pBLeftArrow;
        private System.Windows.Forms.PictureBox pBRightArrow;
        private System.Windows.Forms.ProgressBar prgsBarTransfer;

    }
}

