namespace Lab7_1
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
            this.pct = new System.Windows.Forms.PictureBox();
            this.btn = new System.Windows.Forms.Button();
            this.file1 = new System.Windows.Forms.OpenFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn23 = new System.Windows.Forms.Button();
            this.save1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pct)).BeginInit();
            this.SuspendLayout();
            // 
            // pct
            // 
            this.pct.Location = new System.Drawing.Point(253, 39);
            this.pct.Name = "pct";
            this.pct.Size = new System.Drawing.Size(227, 205);
            this.pct.TabIndex = 0;
            this.pct.TabStop = false;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(151, 359);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(167, 21);
            this.btn.TabIndex = 1;
            this.btn.Text = "Загрузить рисунок";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // file1
            // 
            this.file1.FileName = "openFileDialog1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(317, 299);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(163, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Название рисунка";
            // 
            // btn23
            // 
            this.btn23.Location = new System.Drawing.Point(444, 357);
            this.btn23.Name = "btn23";
            this.btn23.Size = new System.Drawing.Size(132, 23);
            this.btn23.TabIndex = 4;
            this.btn23.Text = "Сохранить рисунок";
            this.btn23.UseVisualStyleBackColor = true;
            this.btn23.Click += new System.EventHandler(this.btn23_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn23);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.pct);
            this.Name = "Form1";
            this.Text = "Просмотр графического файла";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pct;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.OpenFileDialog file1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn23;
        private System.Windows.Forms.SaveFileDialog save1;
    }
}

