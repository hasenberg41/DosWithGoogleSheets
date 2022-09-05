namespace DdosWithGoogleSheets
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LabelRequestCount = new System.Windows.Forms.Label();
            this.UpdateCredentials = new System.Windows.Forms.Button();
            this.RequestCounterTimer = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(523, 23);
            this.textBox1.TabIndex = 0;
            // 
            // StartButton
            // 
            this.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartButton.Location = new System.Drawing.Point(215, 153);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(115, 48);
            this.StartButton.TabIndex = 1;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(33, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(478, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите ссылку на любой файл сайта (может быть изображение)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Location = new System.Drawing.Point(147, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "*Чем больше файл по размеру, тем лучше";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(12, 132);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(162, 23);
            this.numericUpDown1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Лимит запросов";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(394, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Запросов прошло:";
            // 
            // LabelRequestCount
            // 
            this.LabelRequestCount.AutoSize = true;
            this.LabelRequestCount.Font = new System.Drawing.Font("Fira Code Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelRequestCount.Location = new System.Drawing.Point(437, 166);
            this.LabelRequestCount.Name = "LabelRequestCount";
            this.LabelRequestCount.Size = new System.Drawing.Size(28, 29);
            this.LabelRequestCount.TabIndex = 7;
            this.LabelRequestCount.Text = "0";
            // 
            // UpdateCredentials
            // 
            this.UpdateCredentials.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateCredentials.Location = new System.Drawing.Point(12, 166);
            this.UpdateCredentials.Name = "UpdateCredentials";
            this.UpdateCredentials.Size = new System.Drawing.Size(162, 23);
            this.UpdateCredentials.TabIndex = 8;
            this.UpdateCredentials.Text = "Обновить ключ-файл";
            this.UpdateCredentials.UseVisualStyleBackColor = true;
            this.UpdateCredentials.Click += new System.EventHandler(this.UpdateCredentials_Click);
            // 
            // RequestCounterTimer
            // 
            this.RequestCounterTimer.Interval = 300;
            this.RequestCounterTimer.Tick += new System.EventHandler(this.RequestCounterTimer_Tick);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(12, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Установить Id листа";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 230);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.UpdateCredentials);
            this.Controls.Add(this.LabelRequestCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "DDOSER";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private Button StartButton;
        private Label label1;
        private Label label2;
        private NumericUpDown numericUpDown1;
        private Label label3;
        private Label label4;
        private Label LabelRequestCount;
        private Button UpdateCredentials;
        private System.Windows.Forms.Timer RequestCounterTimer;
        private Button button1;
    }
}