namespace DESCrypterWindowsForms
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.menuStripCrypt = new System.Windows.Forms.MenuStrip();
            this.шифрованиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьКлючToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьКлючToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зашифроватьИнформациюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отобразитьШифрованнуюИнформациюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.дешифрованиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripCrypt.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(46, 305);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(100, 96);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(245, 305);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(100, 96);
            this.richTextBox2.TabIndex = 1;
            this.richTextBox2.Text = "";
            // 
            // menuStripCrypt
            // 
            this.menuStripCrypt.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripCrypt.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.шифрованиеToolStripMenuItem,
            this.дешифрованиеToolStripMenuItem});
            this.menuStripCrypt.Location = new System.Drawing.Point(0, 0);
            this.menuStripCrypt.Name = "menuStripCrypt";
            this.menuStripCrypt.Size = new System.Drawing.Size(800, 29);
            this.menuStripCrypt.TabIndex = 2;
            this.menuStripCrypt.Text = "Шифрование";
            // 
            // шифрованиеToolStripMenuItem
            // 
            this.шифрованиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьКлючToolStripMenuItem,
            this.загрузитьКлючToolStripMenuItem,
            this.зашифроватьИнформациюToolStripMenuItem,
            this.отобразитьШифрованнуюИнформациюToolStripMenuItem});
            this.шифрованиеToolStripMenuItem.Name = "шифрованиеToolStripMenuItem";
            this.шифрованиеToolStripMenuItem.Size = new System.Drawing.Size(119, 25);
            this.шифрованиеToolStripMenuItem.Text = "Шифрование";
            // 
            // создатьКлючToolStripMenuItem
            // 
            this.создатьКлючToolStripMenuItem.Name = "создатьКлючToolStripMenuItem";
            this.создатьКлючToolStripMenuItem.Size = new System.Drawing.Size(391, 26);
            this.создатьКлючToolStripMenuItem.Text = "Создать ключ";
            this.создатьКлючToolStripMenuItem.Click += new System.EventHandler(this.создатьКлючToolStripMenuItem_Click);
            // 
            // загрузитьКлючToolStripMenuItem
            // 
            this.загрузитьКлючToolStripMenuItem.Name = "загрузитьКлючToolStripMenuItem";
            this.загрузитьКлючToolStripMenuItem.Size = new System.Drawing.Size(391, 26);
            this.загрузитьКлючToolStripMenuItem.Text = "Загрузить ключ";
            this.загрузитьКлючToolStripMenuItem.Click += new System.EventHandler(this.загрузитьКлючToolStripMenuItem_Click);
            // 
            // зашифроватьИнформациюToolStripMenuItem
            // 
            this.зашифроватьИнформациюToolStripMenuItem.Name = "зашифроватьИнформациюToolStripMenuItem";
            this.зашифроватьИнформациюToolStripMenuItem.Size = new System.Drawing.Size(391, 26);
            this.зашифроватьИнформациюToolStripMenuItem.Text = "Зашифровать информацию";
            this.зашифроватьИнформациюToolStripMenuItem.Click += new System.EventHandler(this.зашифроватьИнформациюToolStripMenuItem_Click);
            // 
            // отобразитьШифрованнуюИнформациюToolStripMenuItem
            // 
            this.отобразитьШифрованнуюИнформациюToolStripMenuItem.Name = "отобразитьШифрованнуюИнформациюToolStripMenuItem";
            this.отобразитьШифрованнуюИнформациюToolStripMenuItem.Size = new System.Drawing.Size(391, 26);
            this.отобразитьШифрованнуюИнформациюToolStripMenuItem.Text = "Отобразить шифрованную информацию";
            // 
            // дешифрованиеToolStripMenuItem
            // 
            this.дешифрованиеToolStripMenuItem.Name = "дешифрованиеToolStripMenuItem";
            this.дешифрованиеToolStripMenuItem.Size = new System.Drawing.Size(136, 25);
            this.дешифрованиеToolStripMenuItem.Text = "Дешифрование";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStripCrypt);
            this.MainMenuStrip = this.menuStripCrypt;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStripCrypt.ResumeLayout(false);
            this.menuStripCrypt.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.MenuStrip menuStripCrypt;
        private System.Windows.Forms.ToolStripMenuItem шифрованиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьКлючToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зашифроватьИнформациюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отобразитьШифрованнуюИнформациюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem дешифрованиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьКлючToolStripMenuItem;
    }
}

