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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.menuStripCrypt = new System.Windows.Forms.MenuStrip();
            this.шифрованиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьКлючToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зашифроватьИнформациюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отобразитьШифрованнуюИнформациюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.дешифрованиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьКлючToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.расшифроватьФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.режимToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStripCrypt.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.EnableAutoDragDrop = true;
            this.richTextBox1.Font = new System.Drawing.Font("Metropolis", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(35, 144);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox1.Size = new System.Drawing.Size(200, 165);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.EnableAutoDragDrop = true;
            this.richTextBox2.Font = new System.Drawing.Font("Metropolis", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox2.Location = new System.Drawing.Point(319, 144);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox2.Size = new System.Drawing.Size(201, 165);
            this.richTextBox2.TabIndex = 1;
            this.richTextBox2.Text = "";
            // 
            // menuStripCrypt
            // 
            this.menuStripCrypt.Font = new System.Drawing.Font("Metropolis", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStripCrypt.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripCrypt.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.шифрованиеToolStripMenuItem,
            this.дешифрованиеToolStripMenuItem,
            this.toolStripComboBox1,
            this.режимToolStripMenuItem});
            this.menuStripCrypt.Location = new System.Drawing.Point(0, 0);
            this.menuStripCrypt.Name = "menuStripCrypt";
            this.menuStripCrypt.Size = new System.Drawing.Size(583, 35);
            this.menuStripCrypt.TabIndex = 2;
            this.menuStripCrypt.Text = "Шифрование";
            // 
            // шифрованиеToolStripMenuItem
            // 
            this.шифрованиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьКлючToolStripMenuItem,
            this.зашифроватьИнформациюToolStripMenuItem,
            this.отобразитьШифрованнуюИнформациюToolStripMenuItem});
            this.шифрованиеToolStripMenuItem.Name = "шифрованиеToolStripMenuItem";
            this.шифрованиеToolStripMenuItem.Size = new System.Drawing.Size(134, 31);
            this.шифрованиеToolStripMenuItem.Text = "Шифрование";
            // 
            // создатьКлючToolStripMenuItem
            // 
            this.создатьКлючToolStripMenuItem.Name = "создатьКлючToolStripMenuItem";
            this.создатьКлючToolStripMenuItem.Size = new System.Drawing.Size(442, 28);
            this.создатьКлючToolStripMenuItem.Text = "Создать ключ";
            this.создатьКлючToolStripMenuItem.Click += new System.EventHandler(this.создатьКлючToolStripMenuItem_Click);
            // 
            // зашифроватьИнформациюToolStripMenuItem
            // 
            this.зашифроватьИнформациюToolStripMenuItem.Name = "зашифроватьИнформациюToolStripMenuItem";
            this.зашифроватьИнформациюToolStripMenuItem.Size = new System.Drawing.Size(442, 28);
            this.зашифроватьИнформациюToolStripMenuItem.Text = "Зашифровать информацию";
            this.зашифроватьИнформациюToolStripMenuItem.Click += new System.EventHandler(this.зашифроватьИнформациюToolStripMenuItem_Click);
            // 
            // отобразитьШифрованнуюИнформациюToolStripMenuItem
            // 
            this.отобразитьШифрованнуюИнформациюToolStripMenuItem.Name = "отобразитьШифрованнуюИнформациюToolStripMenuItem";
            this.отобразитьШифрованнуюИнформациюToolStripMenuItem.Size = new System.Drawing.Size(442, 28);
            this.отобразитьШифрованнуюИнформациюToolStripMenuItem.Text = "Отобразить шифрованную информацию";
            this.отобразитьШифрованнуюИнформациюToolStripMenuItem.Click += new System.EventHandler(this.отобразитьШифрованнуюИнформациюToolStripMenuItem_Click);
            // 
            // дешифрованиеToolStripMenuItem
            // 
            this.дешифрованиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.загрузитьКлючToolStripMenuItem,
            this.расшифроватьФайлToolStripMenuItem});
            this.дешифрованиеToolStripMenuItem.Name = "дешифрованиеToolStripMenuItem";
            this.дешифрованиеToolStripMenuItem.Size = new System.Drawing.Size(157, 31);
            this.дешифрованиеToolStripMenuItem.Text = "Дешифрование";
            // 
            // загрузитьКлючToolStripMenuItem
            // 
            this.загрузитьКлючToolStripMenuItem.Name = "загрузитьКлючToolStripMenuItem";
            this.загрузитьКлючToolStripMenuItem.Size = new System.Drawing.Size(277, 28);
            this.загрузитьКлючToolStripMenuItem.Text = "Загрузить ключ";
            this.загрузитьКлючToolStripMenuItem.Click += new System.EventHandler(this.загрузитьКлючToolStripMenuItem_Click);
            // 
            // расшифроватьФайлToolStripMenuItem
            // 
            this.расшифроватьФайлToolStripMenuItem.Name = "расшифроватьФайлToolStripMenuItem";
            this.расшифроватьФайлToolStripMenuItem.Size = new System.Drawing.Size(277, 28);
            this.расшифроватьФайлToolStripMenuItem.Text = "Расшифровать файл";
            this.расшифроватьФайлToolStripMenuItem.Click += new System.EventHandler(this.расшифроватьФайлToolStripMenuItem_Click);
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripComboBox1.AutoToolTip = true;
            this.toolStripComboBox1.CausesValidation = false;
            this.toolStripComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox1.Font = new System.Drawing.Font("Metropolis", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "CBC",
            "CFB",
            "ECB",
            "OFB"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 31);
            this.toolStripComboBox1.ToolTipText = resources.GetString("toolStripComboBox1.ToolTipText");
            // 
            // режимToolStripMenuItem
            // 
            this.режимToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.режимToolStripMenuItem.Name = "режимToolStripMenuItem";
            this.режимToolStripMenuItem.Size = new System.Drawing.Size(85, 31);
            this.режимToolStripMenuItem.Text = "Режим:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Metropolis", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(499, 80);
            this.label1.TabIndex = 3;
            this.label1.Text = "DESCrypter";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 365);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStripCrypt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStripCrypt;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "DES Шифрование";
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
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripMenuItem режимToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem расшифроватьФайлToolStripMenuItem;
    }
}

