
namespace Муравей
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
            this.countAntInp = new System.Windows.Forms.TextBox();
            this.countIterInp = new System.Windows.Forms.TextBox();
            this.alphaInp = new System.Windows.Forms.TextBox();
            this.betaInp = new System.Windows.Forms.TextBox();
            this.vaporSpeedInp = new System.Windows.Forms.TextBox();
            this.pheromonInp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // countAntInp
            // 
            this.countAntInp.Location = new System.Drawing.Point(21, 76);
            this.countAntInp.Name = "countAntInp";
            this.countAntInp.Size = new System.Drawing.Size(115, 20);
            this.countAntInp.TabIndex = 0;
            // 
            // countIterInp
            // 
            this.countIterInp.Location = new System.Drawing.Point(173, 76);
            this.countIterInp.Name = "countIterInp";
            this.countIterInp.Size = new System.Drawing.Size(109, 20);
            this.countIterInp.TabIndex = 1;
            // 
            // alphaInp
            // 
            this.alphaInp.Location = new System.Drawing.Point(25, 139);
            this.alphaInp.Name = "alphaInp";
            this.alphaInp.Size = new System.Drawing.Size(111, 20);
            this.alphaInp.TabIndex = 2;
            // 
            // betaInp
            // 
            this.betaInp.Location = new System.Drawing.Point(173, 139);
            this.betaInp.Name = "betaInp";
            this.betaInp.Size = new System.Drawing.Size(109, 20);
            this.betaInp.TabIndex = 3;
            // 
            // vaporSpeedInp
            // 
            this.vaporSpeedInp.Location = new System.Drawing.Point(311, 139);
            this.vaporSpeedInp.Name = "vaporSpeedInp";
            this.vaporSpeedInp.Size = new System.Drawing.Size(162, 20);
            this.vaporSpeedInp.TabIndex = 4;
            // 
            // pheromonInp
            // 
            this.pheromonInp.Location = new System.Drawing.Point(311, 76);
            this.pheromonInp.Name = "pheromonInp";
            this.pheromonInp.Size = new System.Drawing.Size(162, 20);
            this.pheromonInp.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Количество муравьев";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Количество итераций";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(58, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Альфа";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(214, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Бета";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(334, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Скорость испарения";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(308, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Начальный уровень феромона";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(170, 296);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Кратчайший путь:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(272, 296);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(173, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Выбрать файл";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(188, 231);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Запустить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(260, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Введите параметры и выбирите файл с матрицей";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(173, 313);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 13);
            this.label10.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 384);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pheromonInp);
            this.Controls.Add(this.vaporSpeedInp);
            this.Controls.Add(this.betaInp);
            this.Controls.Add(this.alphaInp);
            this.Controls.Add(this.countIterInp);
            this.Controls.Add(this.countAntInp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox countAntInp;
        private System.Windows.Forms.TextBox countIterInp;
        private System.Windows.Forms.TextBox alphaInp;
        private System.Windows.Forms.TextBox betaInp;
        private System.Windows.Forms.TextBox vaporSpeedInp;
        private System.Windows.Forms.TextBox pheromonInp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

