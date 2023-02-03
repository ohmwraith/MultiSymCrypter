using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace DESCrypterWindowsForms
{   
    public partial class Form1 : Form
    {   
        public Form1()
        {
            InitializeComponent();
        }
        DESCryptoServiceProvider DES = new DESCryptoServiceProvider();
        String stored_text;

        private void создатьКлючToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.RestoreDirectory = true;
            sfd.DefaultExt = ".bin";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                KeyFileHandler.save(DES.Key, sfd.FileName);
                MessageBox.Show("Ключ успешно сохранен", "Создание ключа", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void загрузитьКлючToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "key files (*.bin)|*.bin|All files (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                DES.Key = KeyFileHandler.load(ofd.FileName);
                MessageBox.Show("Ключ успешно загружен", "Загрузка ключа", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void зашифроватьИнформациюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK) stored_text = TextFileHandler.load(ofd.FileName, 0);

            ICryptoTransform transform = DES.CreateEncryptor();
            String crypted_filename = Path.ChangeExtension(ofd.FileName, "crypt");
            using (FileStream fileStreamEncrypt = new FileStream(crypted_filename, FileMode.OpenOrCreate))
            {
                // Запись случайного вектора инициализации без его шифрования
                fileStreamEncrypt.Write(DES.IV, 0, DES.IV.Length);
                // Создание криптографического потока в режиме записи
                using (CryptoStream cryptoStream = new CryptoStream(fileStreamEncrypt, transform, CryptoStreamMode.Write))
                {
                    // Создание объекта записи текста, который будет преобразовывать текст в
                    // двоичные данные
                    using (StreamWriter streamWriter = new StreamWriter(cryptoStream))
                    {
                        // Запись зашифрованной информации и очистка буфера памяти
                        streamWriter.Write(stored_text);
                        streamWriter.Flush();
                        
                        // В конце операции шифрования необходимо дополнить заключительный частичный
                        // блок нулями и записать его в файл
                        cryptoStream.FlushFinalBlock();
                    }
                }
                richTextBox1.Text = TextFileHandler.load(crypted_filename, DES.IV.Length);
                MessageBox.Show("Шифртекст успешно сохранен!", "Шифрование", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void отобразитьШифрованнуюИнформациюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "crypt files (*.crypt)|*.crypt|All files (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Text = TextFileHandler.load(ofd.FileName, DES.IV.Length);
            }
        }
    }
    public class KeyFileHandler
    {
        public static byte[] load(string filename)
        {
            byte[] key = new byte[8];
            FileStream fs = new FileStream(filename, FileMode.Open);
            fs.Read(key, 0, key.Length);
            fs.Close();
            return key;
        }
        public static void save(byte[] key, string filename)
        {
            FileStream fs = new FileStream(filename, FileMode.OpenOrCreate);
            fs.Write(key, 0, key.Length);
            fs.Close();
        }
    }
    public class TextFileHandler
    {
        public static string load(string filename, int offset)
        {
            FileStream fs = new FileStream(filename, FileMode.Open);
            fs.Seek(offset, SeekOrigin.Begin);
            StreamReader sr = new StreamReader(fs);
            string text = sr.ReadToEnd();
            fs.Close();
            sr.Close();
            return text;
        }
        public static void save(string text, string filename)
        {
            FileStream fs = new FileStream(filename, FileMode.Open);
            StreamWriter sw = new StreamWriter(fs);
            sw.Write(text);
            fs.Close();
            sw.Close();
        }
    }
}
