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
            this.cryptedTextBox = new System.Windows.Forms.RichTextBox();
            this.decryptedTextBox = new System.Windows.Forms.RichTextBox();
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
            this.headerLabel1 = new System.Windows.Forms.Label();
            this.decryptButton = new System.Windows.Forms.Button();
            this.saveCryptedButton = new System.Windows.Forms.Button();
            this.saveDecryptButton = new System.Windows.Forms.Button();
            this.encryptButton = new System.Windows.Forms.Button();
            this.menuStripCrypt.SuspendLayout();
            this.SuspendLayout();
            // 
            // cryptedTextBox
            // 
            this.cryptedTextBox.EnableAutoDragDrop = true;
            this.cryptedTextBox.Font = new System.Drawing.Font("Metropolis", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cryptedTextBox.Location = new System.Drawing.Point(27, 117);
            this.cryptedTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.cryptedTextBox.Name = "cryptedTextBox";
            this.cryptedTextBox.ReadOnly = true;
            this.cryptedTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.cryptedTextBox.Size = new System.Drawing.Size(276, 147);
            this.cryptedTextBox.TabIndex = 0;
            this.cryptedTextBox.Text = "";
            // 
            // decryptedTextBox
            // 
            this.decryptedTextBox.EnableAutoDragDrop = true;
            this.decryptedTextBox.Font = new System.Drawing.Font("Metropolis", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decryptedTextBox.Location = new System.Drawing.Point(345, 117);
            this.decryptedTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.decryptedTextBox.Name = "decryptedTextBox";
            this.decryptedTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.decryptedTextBox.Size = new System.Drawing.Size(276, 147);
            this.decryptedTextBox.TabIndex = 1;
            this.decryptedTextBox.Text = "";
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
            this.menuStripCrypt.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStripCrypt.Size = new System.Drawing.Size(643, 31);
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
            this.шифрованиеToolStripMenuItem.Size = new System.Drawing.Size(106, 27);
            this.шифрованиеToolStripMenuItem.Text = "Шифрование";
            // 
            // создатьКлючToolStripMenuItem
            // 
            this.создатьКлючToolStripMenuItem.Name = "создатьКлючToolStripMenuItem";
            this.создатьКлючToolStripMenuItem.Size = new System.Drawing.Size(349, 24);
            this.создатьКлючToolStripMenuItem.Text = "Создать ключ";
            this.создатьКлючToolStripMenuItem.Click += new System.EventHandler(this.создатьКлючToolStripMenuItem_Click);
            // 
            // зашифроватьИнформациюToolStripMenuItem
            // 
            this.зашифроватьИнформациюToolStripMenuItem.Name = "зашифроватьИнформациюToolStripMenuItem";
            this.зашифроватьИнформациюToolStripMenuItem.Size = new System.Drawing.Size(349, 24);
            this.зашифроватьИнформациюToolStripMenuItem.Text = "Зашифровать информацию";
            this.зашифроватьИнформациюToolStripMenuItem.Click += new System.EventHandler(this.зашифроватьИнформациюToolStripMenuItem_Click);
            // 
            // отобразитьШифрованнуюИнформациюToolStripMenuItem
            // 
            this.отобразитьШифрованнуюИнформациюToolStripMenuItem.Name = "отобразитьШифрованнуюИнформациюToolStripMenuItem";
            this.отобразитьШифрованнуюИнформациюToolStripMenuItem.Size = new System.Drawing.Size(349, 24);
            this.отобразитьШифрованнуюИнформациюToolStripMenuItem.Text = "Отобразить шифрованную информацию";
            this.отобразитьШифрованнуюИнформациюToolStripMenuItem.Click += new System.EventHandler(this.отобразитьШифрованнуюИнформациюToolStripMenuItem_Click);
            // 
            // дешифрованиеToolStripMenuItem
            // 
            this.дешифрованиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.загрузитьКлючToolStripMenuItem,
            this.расшифроватьФайлToolStripMenuItem});
            this.дешифрованиеToolStripMenuItem.Name = "дешифрованиеToolStripMenuItem";
            this.дешифрованиеToolStripMenuItem.Size = new System.Drawing.Size(125, 27);
            this.дешифрованиеToolStripMenuItem.Text = "Дешифрование";
            // 
            // загрузитьКлючToolStripMenuItem
            // 
            this.загрузитьКлючToolStripMenuItem.Name = "загрузитьКлючToolStripMenuItem";
            this.загрузитьКлючToolStripMenuItem.Size = new System.Drawing.Size(218, 24);
            this.загрузитьКлючToolStripMenuItem.Text = "Загрузить ключ";
            this.загрузитьКлючToolStripMenuItem.Click += new System.EventHandler(this.загрузитьКлючToolStripMenuItem_Click);
            // 
            // расшифроватьФайлToolStripMenuItem
            // 
            this.расшифроватьФайлToolStripMenuItem.Name = "расшифроватьФайлToolStripMenuItem";
            this.расшифроватьФайлToolStripMenuItem.Size = new System.Drawing.Size(218, 24);
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
            this.toolStripComboBox1.Size = new System.Drawing.Size(92, 27);
            this.toolStripComboBox1.ToolTipText = resources.GetString("toolStripComboBox1.ToolTipText");
            // 
            // режимToolStripMenuItem
            // 
            this.режимToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.режимToolStripMenuItem.Name = "режимToolStripMenuItem";
            this.режимToolStripMenuItem.Size = new System.Drawing.Size(64, 27);
            this.режимToolStripMenuItem.Text = "Режим";
            // 
            // headerLabel1
            // 
            this.headerLabel1.AutoSize = true;
            this.headerLabel1.Font = new System.Drawing.Font("Metropolis", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel1.Location = new System.Drawing.Point(16, 37);
            this.headerLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.headerLabel1.Name = "headerLabel1";
            this.headerLabel1.Size = new System.Drawing.Size(398, 64);
            this.headerLabel1.TabIndex = 3;
            this.headerLabel1.Text = "DESCrypter";
            // 
            // decryptButton
            // 
            this.decryptButton.Font = new System.Drawing.Font("Metropolis", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decryptButton.Location = new System.Drawing.Point(27, 269);
            this.decryptButton.Name = "decryptButton";
            this.decryptButton.Size = new System.Drawing.Size(134, 38);
            this.decryptButton.TabIndex = 4;
            this.decryptButton.Text = "Расшифровать";
            this.decryptButton.UseVisualStyleBackColor = true;
            this.decryptButton.Click += new System.EventHandler(this.decryptButton_Click);
            // 
            // saveCryptedButton
            // 
            this.saveCryptedButton.Font = new System.Drawing.Font("Metropolis", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveCryptedButton.Location = new System.Drawing.Point(169, 269);
            this.saveCryptedButton.Name = "saveCryptedButton";
            this.saveCryptedButton.Size = new System.Drawing.Size(134, 38);
            this.saveCryptedButton.TabIndex = 5;
            this.saveCryptedButton.Text = "Сохранить";
            this.saveCryptedButton.UseVisualStyleBackColor = true;
            // 
            // saveDecryptButton
            // 
            this.saveDecryptButton.Font = new System.Drawing.Font("Metropolis", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveDecryptButton.Location = new System.Drawing.Point(487, 269);
            this.saveDecryptButton.Name = "saveDecryptButton";
            this.saveDecryptButton.Size = new System.Drawing.Size(134, 38);
            this.saveDecryptButton.TabIndex = 7;
            this.saveDecryptButton.Text = "Сохранить";
            this.saveDecryptButton.UseVisualStyleBackColor = true;
            // 
            // encryptButton
            // 
            this.encryptButton.Font = new System.Drawing.Font("Metropolis", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encryptButton.Location = new System.Drawing.Point(345, 269);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(134, 38);
            this.encryptButton.TabIndex = 6;
            this.encryptButton.Text = "Зашифровать";
            this.encryptButton.UseVisualStyleBackColor = true;
            this.encryptButton.Click += new System.EventHandler(this.encryptButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 333);
            this.Controls.Add(this.saveDecryptButton);
            this.Controls.Add(this.encryptButton);
            this.Controls.Add(this.saveCryptedButton);
            this.Controls.Add(this.decryptButton);
            this.Controls.Add(this.headerLabel1);
            this.Controls.Add(this.decryptedTextBox);
            this.Controls.Add(this.cryptedTextBox);
            this.Controls.Add(this.menuStripCrypt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStripCrypt;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "DES Шифрование";
            this.menuStripCrypt.ResumeLayout(false);
            this.menuStripCrypt.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox cryptedTextBox;
        private System.Windows.Forms.RichTextBox decryptedTextBox;
        private System.Windows.Forms.MenuStrip menuStripCrypt;
        private System.Windows.Forms.ToolStripMenuItem шифрованиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьКлючToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зашифроватьИнформациюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отобразитьШифрованнуюИнформациюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem дешифрованиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьКлючToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripMenuItem режимToolStripMenuItem;
        private System.Windows.Forms.Label headerLabel1;
        private System.Windows.Forms.ToolStripMenuItem расшифроватьФайлToolStripMenuItem;
        private System.Windows.Forms.Button decryptButton;
        private System.Windows.Forms.Button saveCryptedButton;
        private System.Windows.Forms.Button saveDecryptButton;
        private System.Windows.Forms.Button encryptButton;
    }
}

